CREATE PROCEDURE [dbo].[procUserNickname_Read]
	@nickname	varchar(150)
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
				[nickname]	=	@nickname
end