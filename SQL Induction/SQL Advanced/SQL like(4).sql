--displays records of employees whose names does not starts with 'H','A' or 'R'
select * from employee where fname not like '[HAR]%'