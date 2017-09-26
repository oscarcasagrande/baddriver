use baddriver;
go
CREATE PROCEDURE [dbo].[procDriver_Update]
	@Id			int			,
	@Label		char(7)		,
	@Model		varchar(50)	,
	@Supplier	varchar(50)	,
	@Color		varchar(50)
AS
begin	
	update
		[dbo].[Driver]
	set
		[Label]		=	@Label
	,	[Model]		=	@Model
	,	[Supplier]	=	@Supplier
	,	[Color]		=	@Color
	where
		[id]		=	@Id
end