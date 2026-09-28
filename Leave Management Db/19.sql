create function get_balance(eid int, lid int)
returns int
language plpgsql as $$
declare
x int;
begin
select remaining into x
from leave_balances
where emp_id = eid and leave_id = lid;
return x;
end;
$$;

Select get_balance(1,1);