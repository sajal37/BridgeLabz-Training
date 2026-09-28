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