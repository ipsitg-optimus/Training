--function leap_year which takes input as a int and returns whether it is leap year or not.
create function leap_year(@year int) returns varchar(13)
as
begin
	declare @var varchar(13)
	if(@year%400=0)
		set @var='Leap year'
	else
		if(@year%100=0)
			set @var='Non Leap year'
		else if(@year%4=0)
			set @var='Leap year'
		else
			set @var='Non Leap year'
	return (@var)
end

--prints whether a year is leap or not.
print dbo.leap_year(2100)