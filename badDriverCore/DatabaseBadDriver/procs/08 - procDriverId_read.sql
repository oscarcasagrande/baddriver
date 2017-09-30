CREATE PROCEDURE [dbo].[procDriverId_Read]
	@id			int
AS
begin	
			SELECT
				[id]
			,	[color]
			,	[supplier]
			,	[label]
			,	[model]
			from
				[dbo].[Driver]
			where
				[id]	=	@id
end