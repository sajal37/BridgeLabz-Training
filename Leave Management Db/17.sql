create temp table pending_leave as
select *
from leave_applications
where status = 'Pending';

select * from pending_leave;