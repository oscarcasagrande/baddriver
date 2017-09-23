Use BadDriver
Go
If exists(select 1 from sys.objects where type = 'P' and object_id = OBJECT_ID (N'[dbo].[procIncident_Create]'))
DROP PROC [dbo].[procIncident_Create]
GO

create proc procIncident_Create
	@Latitude	numeric(9,9)	,
	@Longitude	numeric(9,9)	,
	@UserId		int				,
	@id			int	output
as
begin
	insert into
		[dbo].[Incident]
		(Latitude, Longitude, UserId)
	values
		(@Latitude, @Longitude, @UserId)

	set @id = @@IDENTITY;

	if (@id  = 0)
		begin
			select @id =  Id From Inserted
		end
go