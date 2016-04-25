DELIMITER //
create procedure setTeam(IN teamid varchar(20), id integer)
begin
update playerinfo set playerinfo.teamid = teamid where playerid = id;
end //
DELIMITER ;