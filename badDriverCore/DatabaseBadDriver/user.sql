USE DatabaseBadDriver
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