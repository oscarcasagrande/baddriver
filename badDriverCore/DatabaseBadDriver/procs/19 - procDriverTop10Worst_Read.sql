Use baddriver
go

If exists(select 1 from sys.objects where type = 'P' and object_id = OBJECT_ID (N'[dbo].[procDriverTop10Worst_Read]'))
DROP PROC [dbo].[procDriverTop10Worst_Read]
go

create proc [dbo].[procDriverTop10Worst_Read]
as
select top 10
	count(incident.id)		as 	quantity
,	driver.label			
,	driver.color
,	driver.supplier
,	driver.model
,	driver.ID
from
	driver
join
	incident
		on	driver.id	=	incident.DriverId
group by
	driver.label
Order by
	quantidade desc
go
