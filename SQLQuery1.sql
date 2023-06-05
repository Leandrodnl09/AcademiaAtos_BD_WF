create database Academia_Atos_Adonet

create table pessoas
(
id integer primary key identity,
nome varchar(50) not null,
profissao varchar(30)
)

create login atos with password='senha123';
create user usuario from login atos;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

INSERT INTO pessoas (nome)
VALUES ('Pessoa1'), ('Pessoa2');
	