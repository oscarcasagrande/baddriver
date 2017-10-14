use baddriver;
go

CREATE PROCEDURE [dbo].[procDriverFull_Read]
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
end
go