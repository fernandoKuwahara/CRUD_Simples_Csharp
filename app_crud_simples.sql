#create database App_CRUD_Simples;
#use App_CRUD_Simples;

#create table contaDoUsuario (nome varchar(128) not null, email varchar(128) primary key, senha char(40) not null, saldo double not null, comprasRealizadas int not null);

#select * from contaDoUsuario;