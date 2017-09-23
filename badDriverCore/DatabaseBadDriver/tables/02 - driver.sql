Use BadDriver
Go

If exists(select 1 from sys.objects where type = 'U' and object_id = OBJECT_ID (N'[dbo].[Driver]'))
DROP TABLE [dbo].[Driver]
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