CREATE PROCEDURE [dbo].[Modify]
	@Id int = 0,
	@Name varchar(100),
	@Phone varchar(50)
AS
	update Table1 set 
	Id = @Id,
	Name = @Name,
	Phone = @Phone 
	where Id = @Id
RETURN 0
