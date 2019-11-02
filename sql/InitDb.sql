create database clima
go
use clima
go

create table persona(
idpersona int primary key identity(1,1),
correo nvarchar(100) not null,
contras nvarchar(50) not null);
go

insert into persona
values
('pablo@gmail.com','hola')
go


create procedure getidpersona
(@correo nvarchar(100))
as
select idpersona from persona where correo = @correo
go


create procedure registro
(
	@correo nvarchar(100),
	@contras nvarchar(50),
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	if exists(select top 1 1 from persona where correo = @correo)
	begin
		set @haserror = 1
	end
	else
	begin
		insert into persona
		values
		(@correo,@contras)
	end
end try
begin catch
	set @haserror = 1;
end catch
go

create procedure logi
(
	@correo nvarchar(100),
	@contras nvarchar(50),
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	if exists(select top 1 1 from persona where correo = @correo and contras = @contras)
	begin
		set @haserror = 0;
	end
	else
	begin
		set @haserror = 1;
	end
end try
begin catch
	set @haserror = 1;
end catch
go

/**********Cuidades*******************/

create table ciudades(
idpersonaciudad int,
nombreciudad nvarchar(100) not null);
go

create procedure getciudad
(@idpersonaciudad int)
as
select * from ciudades where idpersonaciudad = @idpersonaciudad
go

create procedure agregarciudad
(
	@idpersonaciudad int,
	@nombreciudad nvarchar(100),
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	if exists(select top 1 1 from ciudades where idpersonaciudad = @idpersonaciudad and nombreciudad = @nombreciudad)
	begin
		set @haserror = 1
	end
	else
	begin
		insert into ciudades
		values
		(@idpersonaciudad,@nombreciudad)
	end
end try
begin catch
	set @haserror = 1;
end catch
go

create procedure borrarciudad
(
	@idpersonaciudad int,
	@nombreciudad nvarchar(100),
	@haserror bit out
)
as
set @haserror = 1
begin try
if exists(select top 1 1 from ciudades where idpersonaciudad = @idpersonaciudad and nombreciudad = @nombreciudad)
begin
	set @haserror = 0
	delete ciudades where idpersonaciudad = @idpersonaciudad and nombreciudad = @nombreciudad
end
end try
begin catch
	set @haserror = 1;
end catch
go