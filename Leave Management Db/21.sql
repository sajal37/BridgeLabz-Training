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