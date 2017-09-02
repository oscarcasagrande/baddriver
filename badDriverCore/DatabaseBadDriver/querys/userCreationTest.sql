declare @userId int;

set @userId = 0;

select * from [User];

select @userId;

exec [dbo].[procUser_create] "teste3@teste.com.br", "123456", "nickname3", @id = @userId output;

select @userId;

select * from [User];