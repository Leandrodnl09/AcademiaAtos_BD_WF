create database Academia_Atos_Adonet_Exercicio

create login exercicio_adonet with password='senha123';
create user usuario from login exercicio_adonet;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

CREATE TABLE Fornecedor (
    Id INT PRIMARY KEY,
    Nome VARCHAR(100),
    Endereco VARCHAR(100),
    Telefone VARCHAR(20)
);

CREATE TABLE Produto (
    Id INT PRIMARY KEY,
    Nome VARCHAR(100),
    Preco DECIMAL(10,2),
    FornecedorId INT FOREIGN KEY REFERENCES Fornecedor(Id)
);

CREATE TABLE Cliente (
    Id INT PRIMARY KEY,
    Nome VARCHAR(100),
    Endereco VARCHAR(100),
    Telefone VARCHAR(20)
);

CREATE TABLE Nota (
    Id INT PRIMARY KEY,
    ClienteId INT FOREIGN KEY REFERENCES Cliente(Id),
    Data DATETIME
);

CREATE TABLE NotaProduto (
    NotaId INT,
    ProdutoId INT,
    Quantidade INT,
    PrecoUnitario DECIMAL(10,2),
    PRIMARY KEY (NotaId, ProdutoId),
    FOREIGN KEY (NotaId) REFERENCES Nota(Id),
    FOREIGN KEY (ProdutoId) REFERENCES Produto(Id)
);
