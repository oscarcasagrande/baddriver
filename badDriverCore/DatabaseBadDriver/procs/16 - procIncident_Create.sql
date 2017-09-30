Use BadDriver
Go

If exists(select 1 from sys.objects where type = 'P' and object_id = OBJECT_ID (N'[dbo].[procIncident_Create]'))
DROP PROC [dbo].[procIncident_Create]
GO

create proc procIncident_Create
	@Latitude	varchar(50)	,
	@Longitude	varchar(50)	,
	@UserId		int			,
	@id			int	output
as
begin
	insert into
		[dbo].[Incident]
		(Latitude, Longitude, UserId)
	values
		(@Latitude, @Longitude, @UserId)

	select @id =  SCOPE_IDENTITY()
end
go