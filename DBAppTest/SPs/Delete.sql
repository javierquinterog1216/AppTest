CREATE PROCEDURE [dbo].[Delete]
	@Id int
	
AS
	delete from Table1
	where Id = @Id
RETURN 0
