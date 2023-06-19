CREATE TABLE produto (
  codigo INTEGER  NOT NULL   IDENTITY ,
  nome VARCHAR(70)  NOT NULL  ,
  estoque INT    ,
  preco DECIMAL  NOT NULL  ,
  descricao VARCHAR(200)    ,
  autor VARCHAR(20)  NOT NULL  ,
  categoria VARCHAR(20)  NOT NULL    ,
PRIMARY KEY(codigo));
GO




CREATE TABLE endereco (
  codigo INTEGER  NOT NULL   IDENTITY ,
  cidade VARCHAR(20)  NOT NULL  ,
  bairro VARCHAR(30)  NOT NULL  ,
  rua VARCHAR(30)  NOT NULL  ,
  numero INT  NOT NULL  ,
  cep VARCHAR(9)  NOT NULL  ,
  uf VARCHAR(2)  NOT NULL    ,
PRIMARY KEY(codigo));
GO




CREATE TABLE fornecedor (
  codigo INTEGER  NOT NULL   IDENTITY ,
  nome VARCHAR(50)  NOT NULL  ,
  telefone VARCHAR(14)  NOT NULL  ,
  cpf VARCHAR(11)  NOT NULL  ,
  dtnascimento DATETIME  NOT NULL  ,
  senha VARCHAR(20)  NOT NULL    ,
PRIMARY KEY(codigo));
GO




CREATE TABLE uf (
  codigo INTEGER  NOT NULL   IDENTITY ,
  sigla VARCHAR(2)      ,
PRIMARY KEY(codigo));
GO




CREATE TABLE categorias (
  codigo INTEGER  NOT NULL   IDENTITY ,
  nome VARCHAR(20)  NOT NULL    ,
PRIMARY KEY(codigo));
GO




CREATE TABLE cliente (
  codigo INTEGER  NOT NULL   IDENTITY ,
  nome VARCHAR(50)  NOT NULL  ,
  telefone VARCHAR(14)  NOT NULL  ,
  cpf VARCHAR(11)  NOT NULL  ,
  dtnascimento DATETIME  NOT NULL  ,
  senha VARCHAR(20)  NOT NULL    ,
PRIMARY KEY(codigo));
GO




CREATE TABLE carrinho (
  codigo INTEGER  NOT NULL   IDENTITY ,
  cliente_codigo INTEGER  NOT NULL  ,
  produto_codigo INTEGER  NOT NULL  ,
  quantidade INT      ,
PRIMARY KEY(codigo)    ,
  FOREIGN KEY(cliente_codigo)
    REFERENCES cliente(codigo),
  FOREIGN KEY(produto_codigo)
    REFERENCES produto(codigo));
GO


CREATE INDEX carrinho_FKIndex1 ON carrinho (cliente_codigo);
GO
CREATE INDEX carrinho_FKIndex2 ON carrinho (produto_codigo);
GO


CREATE INDEX IFK_Rel_01 ON carrinho (cliente_codigo);
GO
CREATE INDEX IFK_Rel_03 ON carrinho (produto_codigo);
GO


CREATE TABLE compra (
  codigo INTEGER  NOT NULL   IDENTITY ,
  carrinho_codigo INTEGER  NOT NULL  ,
  endereco_codigo INTEGER  NOT NULL  ,
  precoTotal DECIMAL  NOT NULL    ,
PRIMARY KEY(codigo)    ,
  FOREIGN KEY(carrinho_codigo)
    REFERENCES carrinho(codigo),
  FOREIGN KEY(endereco_codigo)
    REFERENCES endereco(codigo));
GO


CREATE INDEX compra_FKIndex1 ON compra (carrinho_codigo);
GO
CREATE INDEX compra_FKIndex2 ON compra (endereco_codigo);
GO


CREATE INDEX IFK_Rel_05 ON compra (carrinho_codigo);
GO
CREATE INDEX IFK_Rel_07 ON compra (endereco_codigo);
GO



