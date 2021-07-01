CREATE PROCEDURE UpdateLocation
	@Id int,
	@Location nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

UPDATE [dbo].[Locations]
   SET [Location] = @Location
 WHERE Id = @Id


END
