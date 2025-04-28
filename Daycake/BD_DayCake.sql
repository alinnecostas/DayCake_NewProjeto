drop database if exists daycake;
CREATE DATABASE Daycake;

USE Daycake;

CREATE TABLE Usuario(
idUsuario int auto_increment primary key,
nome varchar(150) not null,
login varchar(50) not null,
senha varchar(100) not null,
cargo varchar(50) not null,
ativo boolean default true
);

CREATE TABLE Cliente(
idCliente int auto_increment primary key,
data_cadastro varchar (60), -- DATA CADASTRO
nome varchar(150) not null,
email varchar(100),
endereco varchar(100),
numero varchar(10),
bairro varchar(50),
telefone varchar(20) not null
);

CREATE TABLE Produto(
idProduto int(50) auto_increment primary key,
preco decimal(10,2) not null,
nome varchar(150) not null,
descricao varchar(255) not null,
ativo boolean default true,
tempo_preparo varchar(20)
);

CREATE TABLE Pedido(
idPedido int auto_increment primary key, -- IDPEDIDO
clienteid int(50) not null,
data_pedido varchar(60) not null,
data_entrega varchar(60) not null,
tipo_de_doce varchar(255) not null,
descricao varchar(255) not null,
forma_pagamento varchar(60) not null,
status varchar(30) not null,

FOREIGN KEY (clienteid)
REFERENCES Cliente(idCliente)
);

CREATE TABLE Tarefa_Producao(
idTarefa int auto_increment PRIMARY KEY,
pedidoId int not null,
produtoid int not null,
prioridade varchar(50),
status varchar(50),
data_inicio varchar(60),
data_conclusao varchar(60),
responsavelID int,

FOREIGN KEY(pedidoId)
REFERENCES pedido(idpedido),

FOREIGN KEY (produtoid)
REFERENCES Produto(idproduto),

FOREIGN KEY (responsavelId)
REFERENCES Usuario(idUsuario)
);

INSERT INTO Usuario(nome, login, senha, cargo, ativo) VALUES
('Juliana Ferreira', 'juliana.f', 'julia123', 'Confeiteira', 1),
('Carlos Andrade', 'carlos.a', 'carlos321', 'Caixa', 1),
('Mariana Costa', 'mari.costa', 'mari2025', 'Atendente', 1);

Select * from Usuario;

INSERT INTO Cliente(nome, telefone, email, endereco, bairro, data_cadastro) VALUES
('Ana Beatriz Lima', '(11) 98877-1234', 'ana.lima@gmail.com', 'Rua das Flores, 123', 'Centro', '2025-02-15'),
('Bruno Oliveira', '(11) 97766-2345', 'bruno_oliveira@yahoo.com', 'Av. Brasil, 456', 'Jardim América', '2025-03-10'),
('Camila Santos', '(11) 96655-3456', 'cami_santos@outlook.com', 'Rua Azul, 98', 'Bela Vista', '2025-01-20'),
('Daniel Rocha', '(11) 95544-4567', 'dan.rocha@gmail.com', 'Rua Verde, 567', 'Liberdade', '2025-02-01'),
('Elisa Martins', '(11) 94433-5678', 'elisa.martins@uol.com.br', 'Av. das Palmeiras, 89', 'Centro', '2025-04-02'),
('Felipe Silva','(11) 93322-6789','felipe_silva@ig.com.br','Rua Amarela, 301','Moema','	2025-03-15'),
('Gabriela Nogueira','(11) 92211-7890','gabi.nogueira@gmail.com','	Rua das Acácias, 142','Tatuapé','2025-02-25'),
('Henrique Almeida','(11) 91100-8901','henrique.a@hotmail.com','Av. Paulista, 300','Consolação','2025-01-10'),
('Isabela Fonseca','(11) 90099-9012','isabela.fonseca@gmail.com','Rua da Esperança, 17','Pinheiros','2025-03-20'),
('João Pedro Vasconcelos','(11) 98888-1122','joaopedro_v@gmail.com','Rua João XXIII, 800','Vila Mariana','2025-04-10');

Select * from Cliente;

INSERT INTO Produto(nome, descricao, preco, tempo_preparo, ativo) VALUES
('Bolo', 'Com massa branca ou massa de chocolate e um recheio da escolha do cliente', '65.00', '03:00', 1),
('Torta de Limão', 'Torta com recheio de limão e merengue', '45.00', '01:30', 1),
('Cupcakes', '	Caixa com 6 unidades', '48.00', '01:00', 1),
('Palha Italiana Gourmet', 'Feita com chocolate belga', '25.00', '01:00', 1),
('Bolo no Pote', 'Sabores variados (ninho com morango morango, nutella, brigadeiro)', '12.00', '00:40', 1),
('Bolo Red Velvet', 'Massa de cacau com cream cheese', '70.00', '02:30', 1),
('Brigadeiro', 'Feito com leite condensado, chocolate e coberto com granulado.', '2.00', '01:20', 1),
('Brigadeiro Gourmet', 'Chocolate belga, granulado belga, recheios, etc.) e decoração diferenciada.', '4.00', '01:40', 1),
('Cheesecake de Frutas Vermelhas', 'Cheesecake com calda natural', '55.00', '02:00', 0);

Select * from Produto; 

INSERT INTO Pedido(clienteid, data_pedido, data_entrega, tipo_de_doce, descricao, forma_pagamento, status) VALUES
(1, '2025-04-01', '2025-04-03', 'Bolo e Brigadeiro', '2kg de Bolo e 100 brigadeiros. Entregar após as 14h', 'PIX', 'Em andamento'),
(3, '2025-04-10', '2025-04-19', 'Cupcakes', 'Caixa com 6 sabores sortidos. Tema “Unicórnio” para decoração', 'Débito', 'Entregue'),
(5, '2025-04-13', '2025-04-15', 'Torta de Limão', 'Entregar até as 12h', 'Dinheiro', 'Finalizado'),
(2, '2025-04-14', '2025-04-16', 'Bolo Red Velvet e Bolo no Pote','1 kg de bolo red velver e 2 bolos de pote de ninho com morango', 'Cartão de Crédito', 'Cancelado'),
(8, '2025-04-12', '2025-04-13', 'Bolo e Brigadeiro Gourmet', '3kg Bolo com massa branca, recheio de ninho e 30und de Brigadeiro Gourmet. Tema: casamento civil. Usar fitas brancas nas embalagens.', 'PIX', 'Cancelado');

SELECT cliente. idcliente, cliente.nome, pedido.idpedido, pedido.tipo_de_doce, pedido.data_pedido, pedido.status
FROM Cliente
INNER JOIN pedido ON cliente.idcliente = pedido.clienteid;

Select * from Pedido;


-- id pedido, id cliente, data cadastro pedido, status














