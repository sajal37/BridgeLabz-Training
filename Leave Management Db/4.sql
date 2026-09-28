create table employees (
emp_id serial primary key, 
emp_name varchar(50),
dept_id int references
departments(dept_id)
);