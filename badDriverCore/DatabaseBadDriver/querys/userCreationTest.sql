--declare @userId int;

--set @userId = 0;

--select * from [User];

--select @userId;

--exec [dbo].[procUser_create] "teste3@teste.com.br", "123456", "nickname3", @id = @userId output;

--select @userId;

--select * from [User];

--exec [dbo].[procUser_read] 0, 'rafael.redoval@gmail.com', '123456', '';

select  * from Incident;

declare @IncidentId int;

select @IncidentId ;

set @IncidentId  = 0;

exec [dbo].[procIncident_create] '-20.345678', '12.7678687', 1, @id = @IncidentId output;

select @IncidentId;

select  * from Incident;



select  * from Photo;

declare @PhotoId int;

select @PhotoId ;

set @PhotoId = 0;

exec [dbo].[procPhoto_create] 'PhotoName.jpg', 'DIR\PhotoName.jpg', @IncidentId, @id = @PhotoId output;
exec [dbo].[procPhoto_create] 'PhotoName2.jpg', 'DIR\PhotoName2.jpg', @IncidentId, @id = @PhotoId output;

select @PhotoId;

select  * from Photo;