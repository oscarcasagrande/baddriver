CREATE PROCEDURE [dbo].[procUser_Read]
	@id			int				=	0
,	@email		varchar(350)
,	@password	varchar(150)
,	@nickname	varchar(150)
AS
begin
	if (len(rtrim((ltrim(@password)))) > 0)	and (@id > 0)
		begin
			SELECT
				id			
			,	email		
			,	password	
			,	nickname	
			,	active
			from
				[dbo].[User]
			where
				([id]	=	@id)
			or
				(
					[email]		=	@email
				or
				[nickname]	=	@nickname
				)
		end
	else
		begin
			SELECT
				id			
			,	email		
			,	password	
			,	nickname	
			,	active
			from
				[dbo].[User]
			where
				(
					[email]		=	@email
				or
					[nickname]	=	@nickname
				)
				and
					[Password]	=	@password

		end
end