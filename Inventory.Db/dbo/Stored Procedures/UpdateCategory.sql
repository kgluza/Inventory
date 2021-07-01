CREATE PROCEDURE UpdateCategory
	@Id int,
	@Category nvarchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

UPDATE [dbo].[Categories]
   SET [Category] = @Category
 WHERE Id = @Id


END
