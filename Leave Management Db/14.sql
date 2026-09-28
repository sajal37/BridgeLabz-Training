select e.emp_name, d.dept_name, l.days, l.status
from employees e
join departments d on e.dept_id = d.dept_id
join leave_applications l on e.emp_id = l.emp_id;