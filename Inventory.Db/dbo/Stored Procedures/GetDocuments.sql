CREATE PROCEDURE GetDocuments
    @ItemId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

SELECT * FROM [dbo].[Documents]
       WHERE ItemId = @ItemId
	   ORDER BY Id DESC
END
