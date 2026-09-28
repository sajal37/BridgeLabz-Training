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