﻿CREATE PROCEDURE DeleteCategory
	@Id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

DELETE FROM [dbo].[Categories]
   
 WHERE Id = @Id


END
