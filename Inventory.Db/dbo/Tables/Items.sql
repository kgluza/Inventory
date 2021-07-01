CREATE TABLE [dbo].[Items] (
    [Id]           INT  IDENTITY(1,1)         NOT NULL,
    [Name]         NVARCHAR (50) NOT NULL,
    [Category]     INT           NOT NULL,
    [SerialNumber] NVARCHAR (50) NULL,
    [Location]     INT           NOT NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Items_Locations] FOREIGN KEY ([Location]) REFERENCES [dbo].[Locations] ([Id])
);
GO
CREATE INDEX idx_Category
ON Items (Category);
GO
CREATE INDEX idx_Location
ON Items (Location);
