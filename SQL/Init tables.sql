CREATE TABLE [dbo].[Product] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
	[Name] VARCHAR(100) NOT NULL,
    PRIMARY KEY ([Id])
);

CREATE TABLE [dbo].[Category] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
	[Name] VARCHAR(100) NOT NULL,
    PRIMARY KEY ([Id])
);

CREATE TABLE [dbo].[ProductCategory] (
    [Id] INT IDENTITY(1,1) NOT NULL,
    [ProductId] INT NOT NULL,
    [CategoryId] INT NOT NULL,

    FOREIGN KEY([ProductId]) REFERENCES [Product]([Id]),
    FOREIGN KEY([CategoryId]) REFERENCES [Category]([Id]),
    PRIMARY KEY ([Id]),
    CONSTRAINT UC_ProductCategory UNIQUE ([ProductId],[CategoryId])
);