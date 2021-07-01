CREATE TABLE [dbo].[Documents] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [ItemId] INT NOT NULL,
    [File] IMAGE NOT NULL, 
    [FileName] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Items_Documents] FOREIGN KEY ([ItemId]) REFERENCES [dbo].[Items] ([Id])
);
GO
CREATE INDEX idx_ItemId
ON Documents (ItemId);