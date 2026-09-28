create user hr_user
with password 'hr123';

grant all on schema hr to hr_user;

grant select, insert, update
on employees, departments, leave_types, leave_applications
to hr_user;

grant select, update
on leave_balances
to hr_user;

revoke delete
on leave_applications
from hr_user;