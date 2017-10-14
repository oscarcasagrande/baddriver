Use BadDriver
Go

If exists(select 1 from sys.objects where type = 'U' and object_id = OBJECT_ID (N'[dbo].[Photo]'))
DROP TABLE [dbo].[Photo]
GO


CREATE TABLE [dbo].[Photo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [creationTime] DATETIME NOT NULL DEFAULT getdate(), 
    [name] VARCHAR(50) NOT NULL, 
    [url] VARCHAR(250) NOT NULL, 
    [IncidentId] INT NOT NULL
);
GO