Use BadDriver
Go
If exists(select 1 from sys.objects where type = 'P' and object_id = OBJECT_ID (N'[dbo].[procDriver_Create]'))
DROP PROC [dbo].[procDriver_Create]
GO

CREATE PROCEDURE [dbo].[procDriver_Create]
	@Label		char(7)	,
	@Model		varchar(50)	,
	@Supplier	varchar(50)	,
	@Color		varchar(50)	,
	@id			int		output
AS
begin 
	declare @countRows int;
	set @countRows  = 0;
	set @countRows  = (select count(1) from [dbo].[Driver] where (@Model = Model) and (@Label = Label) and (@Supplier = Supplier));
	print '@countRows' 
	print @countRows
	if (@countRows > 0 )
		begin
			set @id = 0;
		end
	else
		begin
			insert into [dbo].[Driver]
				(Label, Model, Supplier, Color)
			values
				(@Label, @Model, @Supplier, @Color);
			set @id = @@IDENTITY;
			select @id =  Id From [dbo].[Driver] where (@Model = Model) and (@Label = Label) and (@Supplier = Supplier)
		end
end
GO