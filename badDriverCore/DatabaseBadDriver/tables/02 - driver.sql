USE DatabaseBadDriver
GO

CREATE TABLE [dbo].[Driver] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [Label]        CHAR (7)     NOT NULL,
    [Model]        VARCHAR (50) NOT NULL,
    [Supplier]     VARCHAR (50) NOT NULL,
    [Color] VARCHAR(50) NOT NULL, 
	[CreationTime] DATETIME     DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO