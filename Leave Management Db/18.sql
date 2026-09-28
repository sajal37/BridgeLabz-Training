create view employee_balance as
select e.emp_name, l.leave_name, b.remaining
from employees e
join leave_balances b on e.emp_id = b.emp_id
join leave_types l on b.leave_id = l.leave_id;

Select * from employee_balance;