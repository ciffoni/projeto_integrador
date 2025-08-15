create database projeto;
use projeto;
create table cargo(
codigocargo int primary key auto_increment,
cargo varchar(100)
);
create table usuario(
codigo int primary key auto_increment ,
nome varchar(100),
email varchar(100),
senha varchar(255),
cargo int,
ativo tinyint,
constraint fk_cargo foreign key (cargo) references cargo(codigocargo)
);

create table tipo(
codigotipo int primary key auto_increment,
descricao varchar(100)
);
insert into tipo(descricao) values ("administração");
insert into tipo(descricao) values ("Vendedor");
create table produto(

codigoProduto int primary key auto_increment,
descricao varchar(100),
valor decimal(5,2),
quantidade int,
foto varchar(100),
nome varchar(100),
tipo int,
constraint fk_tipo foreign key (tipo) references tipo(codigotipo)
);

create table cliente(
codigocliente int primary key auto_increment,
nome varchar(60),
fone varchar(15),
email varchar(100),
cnpj_cpf varchar(30),
cep varchar(20),
num_casa varchar(4),
complemento varchar(100)
);
create table pedido(
codigopedido int primary key auto_increment,
data_pedido datetime,
data_entrega datetime,
codigousuario int,
codigocliente int,
formapagamento varchar(60),
constraint fk_usuario foreign key (codigousuario) references usuario(codigo),
constraint fk_cliente foreign key (codigocliente) references cliente(codigocliente)
);

create table pedido_itens(
codigoitens int primary key auto_increment,
codigopedido int,
codigoproduto int,
quantidade int,
valor decimal(5,2),
total decimal(5,2),
constraint fk_pedido foreign key (codigopedido) references pedido(codigopedido),
constraint fk_produto foreign key(codigoproduto) references produto(codigoproduto)
);

create table fluxocaixa(
codigofluxo int primary key auto_increment,
descricao varchar(100),
tipo varchar(50),
valor decimal(5,2)
)