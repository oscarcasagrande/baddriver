Use BadDriver
Go

If exists(select 1 from sys.objects where type = 'U' and object_id = OBJECT_ID (N'[dbo].[Incident]'))
DROP TABLE [dbo].[Incident]
GO

CREATE TABLE [dbo].[Incident] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [latitude]     VARCHAR(50) NOT NULL,
    [longitude]    VARCHAR(50) NOT NULL,
    [userId]       INT            NOT NULL,
	[driverId]     INT            NOT NULL,
    [creationTime] DATETIME       DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO