CREATE PROCEDURE GetItemById
@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

SELECT 
  i.Id,
  i.Name,
  c.Id AS CategoryId,
  c.Category AS CategoryName,
  l.Id AS LocationId,
  l.Location AS LocationName,
  i.SerialNumber
  FROM [Inventory].[dbo].[Items] AS i
  INNER JOIN [Inventory].[dbo].Categories AS c
  ON c.Id = i.Category
  INNER JOIN [Inventory].[dbo].[Locations] AS l
  on l.Id = i.Location
  WHERE i.Id = @Id
           

END
