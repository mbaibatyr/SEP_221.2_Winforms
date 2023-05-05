alter proc pStudentsIns --N'Сидоров', N'Сергей', '2001-05-01', 'm'
@lastName nvarchar(200),
@firstName nvarchar(200),
@dateBirth datetime,
@gender char(1)
as
if exists
(
	select 1 from Students s 
	where s.lastName = @lastName 
	and s.firstName = @firstName 
)
	select 0 status
else
	begin
		insert into Students
		(
			lastName,
			firstName,
			dateBirth,
			gender
		)
		values
		(
			@lastName,
			@firstName,
			@dateBirth,
			@gender
		)
		select 1 status
	end

