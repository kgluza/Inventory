CREATE TABLE [dbo].[History_Items] (
    [Timestamp]    DateTime NOT NULL,
    [User]         NVARCHAR(50) NOT NULL,
    [Action]       NVARCHAR(20) NOT NULL,
    [Id]           INT           NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [Category]     INT           NOT NULL,
    [SerialNumber] NVARCHAR (50) NULL,
    [Location]     INT           NOT NULL,
);
GO
