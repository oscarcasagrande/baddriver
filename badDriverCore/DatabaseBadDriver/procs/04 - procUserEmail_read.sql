use baddriver;
go
CREATE PROCEDURE [dbo].[procUserEmail_Read]
	@email		varchar(350)
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
				[email]		=	@email
end;
go