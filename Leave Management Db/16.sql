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