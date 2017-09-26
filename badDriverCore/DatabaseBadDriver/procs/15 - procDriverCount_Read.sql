create proc procDriverCount_Read
as
select count(1) as 'count' from [dbo].[Driver]  with (nolock)
go