CREATE PROCEDURE [dbo].[procDriver_Read]
	@Label		char(7)	,
	@Model		varchar(50)	,
	@Supplier	varchar(50)	,
	@Color		varchar(50)
AS
begin	
	SELECT
		[id]
	,	[Label]
	,	[Model]
	,	[Supplier]
	,	[Color]
	,	[CreationTime]
	from
		[dbo].[Driver]
	where
		[Label]		=	@Label
	and	[Model]		=	@Model
	and	[Supplier]	=	@Supplier
	and	[Color]		=	@Color
end