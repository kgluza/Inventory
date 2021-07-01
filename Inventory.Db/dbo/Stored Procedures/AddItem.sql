CREATE PROCEDURE AddItem
	@Name nvarchar(50),
    @SerialNumber nvarchar(50) = NULL,
    @CategoryId int,
    @LocationId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here


INSERT INTO [dbo].[Items]
           ([Name]
           ,[Category]
           ,[SerialNumber]
           ,[Location])
     VALUES
           (@Name
           ,@CategoryId
           ,@SerialNumber
           ,@LocationId)


END
