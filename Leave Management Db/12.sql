create table leave_balances (
emp_id int references employees(emp_id),
leave_id int references leave_types(leave_id),
remaining int
);