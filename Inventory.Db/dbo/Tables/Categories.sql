CREATE TABLE [dbo].[Categories] (
    [Id]       INT           IDENTITY (1, 1) NOT NULL,
    [Category] NVARCHAR (20) NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([Id] ASC)
);

