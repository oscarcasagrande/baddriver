use baddriver;
go

CREATE PROCEDURE [dbo].[procUserId_Read]
	@id			int
AS
begin	
			SELECT
				[id]
			,	[email]
			,	[password]
			,	[nickname]
			,	[active]
			from
				[dbo].[User]
			where
				[id]	=	@id
end;
go