CREATE PROCEDURE AddDocument
    @ItemId int,
	@File image,
    @FileName nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here


INSERT INTO [dbo].[Documents]
           ([ItemId]
           ,[File]
           ,[FileName])
     VALUES
           (@ItemId
           ,@File
           ,@FileName)


END
