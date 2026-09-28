create procedure pending_leaves()
language plpgsql
as $$
declare
r record;
cur cursor for
select app_id from leave_applications
where status = 'Pending';
begin
open cur;
loop
fetch cur into r;
exit when not found;
update leave_applications
set status = 'Approved'
where app_id = r.app_id;
end loop;
close cur;
end;
$$;

call pending_leaves();

Select * from leave_applications;