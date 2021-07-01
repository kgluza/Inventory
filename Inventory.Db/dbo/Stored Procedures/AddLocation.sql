CREATE PROCEDURE AddLocation
	@Location nvarchar(25)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

INSERT INTO [dbo].[Locations]
           (Location)
     VALUES
           (@Location)


END
