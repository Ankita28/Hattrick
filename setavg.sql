DELIMITER //
create procedure setavg()
begin
declare count INT unsigned DEFAULT 1;
label1: LOOP
update playerperformance_bowler set avrg = (runs)/wickets where playerid=count;
	set count = count + 1;
	if count < 129 then
	iterate label1;
	end if;
	leave label1;
	end LOOP label1;
end; //
DELIMITER ;