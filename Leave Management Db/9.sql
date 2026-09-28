create table leave_applications (
app_id serial primary key,
emp_id int references employees(emp_id),
leave_id int references leave_types(leave_id),
days int,
reason varchar(100),
status varchar(20)
);