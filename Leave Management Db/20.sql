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