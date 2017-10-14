Use BadDriver
Go

If exists(select 1 from sys.objects where type = 'U' and object_id = OBJECT_ID (N'[dbo].[User]'))
DROP TABLE [dbo].[User]
GO


CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY identity (1, 1), 
    [Email] VARCHAR(350) NOT NULL, 
    [Password] VARCHAR(150) NOT NULL, 
    [Nickname] VARCHAR(150) NOT NULL, 
    [Active] BIT NOT NULL, 
    [CreationTime] DATETIME NOT NULL DEFAULT getdate()
)
GO