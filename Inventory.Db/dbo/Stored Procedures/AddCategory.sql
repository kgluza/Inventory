CREATE PROCEDURE AddCategory
	@Category nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

INSERT INTO [dbo].[Categories]
           ([Category])
     VALUES
           (@Category)


END
