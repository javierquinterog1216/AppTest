CREATE PROCEDURE [dbo].[Add]
	@Name varchar(100),
	@Phone varchar(50)
AS
	insert into Table1 values(
	@Name,
	@Phone
	)
RETURN 0
