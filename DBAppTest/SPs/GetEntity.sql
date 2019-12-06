CREATE PROCEDURE [dbo].[GetEntity]
	@Id int = 0
	
AS
	SELECT 
	Id, 
	Name, 
	Phone from Table1
	where Id = @Id or @Id = -1
RETURN 0
