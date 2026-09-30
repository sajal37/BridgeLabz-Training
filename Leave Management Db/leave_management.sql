-- 1. departments table
create table departments (
dept_id serial primary key,
dept_name varchar(50)
);

insert into departments
(dept_name)
values ('IT'), ('HR'), ('Finance'), ('Sales');

Select * from departments;

-- 2. employees table
create table employees (
emp_id serial primary key, 
emp_name varchar(50),
dept_id int references
departments(dept_id)
);

insert into employees
(emp_name, dept_id)
values
('Rahul', 1),
('Aman', 1),
('Priya', 2),
('Neha', 2),
('Rohit', 3),
('Karan', 3),
('Simran', 4);

Select * from employees;

-- 3. leave types
create table leave_types (
leave_id serial primary key,
leave_name varchar(50),
total_days int
);

insert into leave_types (leave_name, total_days)
values
('Casual', 12),
('Sick', 10),
('Earned', 15);

-- 4. leave applications
create table leave_applications (
app_id serial primary key,
emp_id int references employees(emp_id),
leave_id int references leave_types(leave_id),
days int,
reason varchar(100),
status varchar(20)
);

insert into leave_applications
(emp_id, leave_id, days, reason, status)
values
(1, 1, 2, 'Personal work', 'Approved'),
(2, 1, 4, 'Function', 'Approved'),
(3, 2, 3, 'Fever', 'Approved'),
(4, 1, 2, 'Personal', 'Pending'),
(5, 3, 5, 'Trip', 'Approved'),
(6, 1, 3, 'Travel', 'Pending'),
(7, 2, 2, 'Not well', 'Pending');

Select * from leave_applications;

-- 5. leave balances
create table leave_balances (
emp_id int references employees(emp_id),
leave_id int references leave_types(leave_id),
remaining int
);

insert into leave_balances
values
(1,1,10),
(1,2,10),
(2,1,8),
(2,2,7),
(3,1,10),
(3,2,7),
(4,1,8),
(4,2,10),
(5,1,9),
(5,3,10),
(6,1,5),
(6,2,8),
(7,1,10),
(7,2,8);

-- employee leave report using joins
select e.emp_name, d.dept_name, l.days, l.status
from employees e
join departments d on e.dept_id = d.dept_id
join leave_applications l on e.emp_id = l.emp_id;

-- department leave utilization using cte
with leave_data as
(
    select e.dept_id, sum(l.days) as total_leave
    from employees e
    join leave_applications l on e.emp_id = l.emp_id
    where l.status = 'Approved'
    group by e.dept_id
)
select d.dept_name, leave_data.total_leave
from leave_data
join departments d on leave_data.dept_id = d.dept_id;

-- employees taking more leave than department average (subquery)
select e.emp_name, sum(l.days) as total_leave
from employees e
join leave_applications l on e.emp_id = l.emp_id
where l.status = 'Approved'
group by e.emp_name, e.dept_id
having sum(l.days) >
(
    select avg(l2.days)
    from employees e2
    join leave_applications l2 on e2.emp_id = l2.emp_id
    where l2.status = 'Approved' and e2.dept_id = e.dept_id
);

-- temp table for pending leaves
create temp table pending_leave as
select *
from leave_applications
where status = 'Pending';

select * from pending_leave;

-- view for employee leave balances
create view employee_balance as
select e.emp_name, l.leave_name, b.remaining
from employees e
join leave_balances b on e.emp_id = b.emp_id
join leave_types l on b.leave_id = l.leave_id;

Select * from employee_balance;

-- udf to calculate remaining balance
create function get_balance(eid int, lid int)
returns int
language plpgsql as $$
declare
x int;
begin
select remaining into x
from leave_balances
where emp_id = eid and leave_id = lid;
return x;
end;
$$;

Select get_balance(1,1);

-- stored procedure to approve leave and deduct balance
create procedure approve_leave(aid int)
language plpgsql as $$
declare
eid int;
lid int;
d int;
begin
select emp_id, leave_id, days into eid, lid, d
from leave_applications where app_id = aid;
update leave_applications
set status = 'Approved'
where app_id = aid;
update leave_balances
set remaining = remaining - d
where emp_id = eid and leave_id = lid;
end;
$$;

call approve_leave(4);

Select * from leave_applications;

-- trigger to check leave balance before approval
create function check_balance()
returns trigger
language plpgsql as $$
declare
x int;
begin
select remaining into x
from leave_balances
where emp_id = new.emp_id and leave_id = new.leave_id;
if new.status = 'Approved' and x < new.days then
    raise exception 'Not enough leave balance';
end if;
return new;
end;
$$;

create trigger check_leave
before update on leave_applications
for each row
execute function check_balance();

update leave_applications
set days = 10, status = 'Approved'
where app_id = 6;

-- cursor to process pending applications
create procedure pending_leaves()
language plpgsql
as $$
declare
r record;
cur cursor for
select app_id from leave_applications
where status = 'Pending';
begin
open cur;
loop
fetch cur into r;
exit when not found;
update leave_applications
set status = 'Approved'
where app_id = r.app_id;
end loop;
close cur;
end;
$$;

call pending_leaves();

Select * from leave_applications;

-- indexes
create index emp_index on leave_applications(emp_id);
create index leave_index on leave_applications(leave_id);
create index status_index on leave_applications(status);

-- transaction with row locking
begin;

select *
from leave_balances
where emp_id = 1
and leave_id = 1
for update;

update leave_balances
set remaining = remaining - 2
where emp_id = 1
and leave_id = 1;

commit;

-- hr schema and dcl permissions
create schema hr;

create user hr_user
with password 'hr123';

grant all on schema hr to hr_user;

grant select, insert, update
on employees, departments, leave_types, leave_applications
to hr_user;

grant select, update
on leave_balances
to hr_user;

revoke delete
on leave_applications
from hr_user;
