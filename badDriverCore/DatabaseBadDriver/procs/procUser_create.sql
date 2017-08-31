CREATE PROCEDURE [dbo].[procUser_create]
	@email		varchar(350)	,
	@password	varchar(150)	,
	@nickname	varchar(150)	,
	@id			int		output
AS
begin 
	insert into [dbo].[User]
		(Email, Password, Nickname, Active)
	values
		(@Email, @Password, @Nickname, 1)
	set @id = @@IDENTITY;
end
RETURN @id;
GO