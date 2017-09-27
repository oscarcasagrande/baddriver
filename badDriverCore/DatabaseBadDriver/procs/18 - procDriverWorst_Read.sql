use baddriver;
go

if exists (select name from sysobjects where name = 'procDriverWorst_Read' and type = 'P')
	drop proc procDriverWorst_Read
go

create proc procDriverWorst_Read
as
select top 10
	count(Incident.driverId)	quantity
,	Driver.Id
,	Driver.Color
,	Driver.Label
,	Driver.Model
,	Driver.Supplier
from
		Driver
	Join
		Incident
			on	Incident.driverId	=	Driver.Id
group by
	Driver.Id
,	Driver.Color
,	Driver.Label
,	Driver.Model
,	Driver.Supplier
order by
	Driver.Id	desc;
go