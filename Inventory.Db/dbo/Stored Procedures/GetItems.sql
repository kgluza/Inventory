CREATE PROCEDURE GetItems
    @Id nvarchar (6) = '',
    @Name nvarchar(50) = '',
    @SerialNumber nvarchar(50) = '',
    @CategoryName nvarchar(20) = '',
    @LocationName nvarchar(20) = ''
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
  WHERE CAST(i.Id as CHAR) LIKE '%'+@Id+'%'
    AND i.Name LIKE '%'+@Name+'%'
    AND i.SerialNumber LIKE '%'+@SerialNumber+'%'
    AND c.Category LIKE '%'+@CategoryName+'%'
    AND l.Location LIKE '%'+@LocationName+'%'

END
