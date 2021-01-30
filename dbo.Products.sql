CREATE TABLE [dbo].[Products] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [ProductName] NVARCHAR (MAX) NOT NULL,
    [Info]        NVARCHAR (MAX) NULL,
    [Price]       FLOAT (53)     NOT NULL,
    [CategoryId]  INT            NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Products_CategoryId]
    ON [dbo].[Products]([CategoryId] ASC);

