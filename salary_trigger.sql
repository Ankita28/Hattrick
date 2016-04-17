create trigger salary_trigger
	after insert on playerinfo
	for each row
	begin 
		playerinfo.salary := 1.5*playerinfo.salary;
	end;
/