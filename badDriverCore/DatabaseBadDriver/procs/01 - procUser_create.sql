﻿Use BadDriver
Go
If exists(select 1 from sys.objects where type = 'P' and object_id = OBJECT_ID (N'[dbo].[procUser_create]'))
DROP PROC [dbo].[procUser_create]
GO

CREATE PROCEDURE [dbo].[procUser_create]
	@email		varchar(350)	,
	@password	varchar(150)	,
	@nickname	varchar(150)	,
	@id			int		output
AS
begin 
	declare @countRows int;
	set @countRows  = 0;
	set @countRows  = (select count(1) from [dbo].[User] where (@nickname = nickname) or (@email = email));
	print '@countRows' 
	print @countRows
	if (@countRows > 0 )
		begin
			set @id = 0;
		end
	else
		begin
			insert into [dbo].[User]
				(Email, Password, Nickname, Active)
			values
				(@Email, @Password, @Nickname, 1);
			
			select @id =  SCOPE_IDENTITY()
		end
end
GO