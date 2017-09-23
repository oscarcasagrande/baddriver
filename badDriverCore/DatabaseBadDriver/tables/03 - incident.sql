CREATE TABLE [dbo].[Incident]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [latitude] NUMERIC(9, 9) NOT NULL, 
    [longitude] NUMERIC(9, 9) NOT NULL, 
    [userId] INT NOT NULL, 
    [creationTime] DATETIME NOT NULL DEFAULT getdate()
)
