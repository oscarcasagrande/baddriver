Use BadDriver
Go

If exists(select 1 from sys.objects where type = 'P' and object_id = OBJECT_ID (N'[dbo].[procPhoto_Create]'))
DROP PROC [dbo].[procPhoto_Create]
GO

create proc procPhoto_Create
	@name		varchar(50)	,
	@url		varchar(50)	,
	@IncidentId	int			,
	@id			int	output
as
begin
	insert into
		[dbo].[Photo]
		(Name, Url, IncidentId)
	values
		(@Name, @Url, @IncidentId)

	select @id =  SCOPE_IDENTITY()
end
go