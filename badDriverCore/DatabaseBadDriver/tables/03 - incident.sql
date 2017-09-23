CREATE TABLE [dbo].[Incident] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [latitude]     VARCHAR(50) NOT NULL,
    [longitude]    VARCHAR(50) NOT NULL,
    [userId]       INT            NOT NULL,
    [creationTime] DATETIME       DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);