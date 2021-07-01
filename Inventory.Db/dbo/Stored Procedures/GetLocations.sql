CREATE PROCEDURE GetLocations
    @Id nvarchar (6) = '',
    @Name nvarchar(50) = ''
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

SELECT * FROM [dbo].[Locations]
       WHERE CAST(Id as CHAR) LIKE '%'+@Id+'%'
    AND Location LIKE '%'+@Name+'%'    

END
