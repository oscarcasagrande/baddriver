use baddriver;
go

CREATE PROCEDURE [dbo].[procUser_Read]
	@id			int
,	@email		varchar(350)
,	@password	varchar(150)
,	@nickname	varchar(150)
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
				([id]	=	@id)
			or
				((
					[email]		=	@email
					or
					[nickname]	=	@nickname
				)
					and
					[Password]	=	@password
				)
end