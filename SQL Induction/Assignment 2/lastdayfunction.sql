--creates function for checking as last day of the month
create function check_last_day(@date date) returns bit
as 
begin
declare @stat bit
declare @month int
declare @day int
set @month=DATEPART(m,@date)
set @day=DATEPART(d,@date)
if((@month=1 or @month=3 or @month=5 or @month=7 or @month=8 or @month=10 or @month=1)and @day=31)
	set @stat='True'
else
begin
	if(@month=2 and @day=28)
		set @stat='True'
	else
	begin
		if((@month=4 or @month=6 or @month=9 or @month=11)and @day=30)
			set @stat='True'
		else
			set @stat='False'
	end
end
return @stat
end
