CREATE PROCEDURE UpdateItem
    @Id int,
	@Name nvarchar(50),
    @SerialNumber nvarchar(50),
    @CategoryId int,
    @LocationId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

UPDATE [dbo].[Items]
   SET [Name] = @Name,
       [Category] = @CategoryId,
       [Location] = @LocationId,
       [SerialNumber] = @SerialNumber
 WHERE Id = @Id


END
