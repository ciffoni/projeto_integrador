create database projeto;
use projeto;
create table usuario(
codigo int primary key auto_increment,
nome varchar(100),
email varchar(100),
senha varchar(255),
cargo varchar(60)

);