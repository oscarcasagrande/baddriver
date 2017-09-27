CREATE PROCEDURE [dbo].[procUser_update]
	@id			int
,	@email		varchar(350)
,	@password	varchar(150)
,	@nickname	varchar(150)
,	@active		bit
AS
	update
		[dbo].[User]
	set
		[Email]		=	@email
,		[password]	=	@password
,		[nickname]	=	@nickname
,		[Active]	=	@active
	where
		id	=	@id;

go