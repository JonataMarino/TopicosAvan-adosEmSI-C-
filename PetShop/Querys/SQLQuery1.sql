create table tbl_atendimento ([Id] INT NOT NULL identity PRIMARY KEY,
[dataAtendimento] varchar(20),
[horaAtendimento] varchar(20),
[profResponsável] varchar(50),
[horaSaida] varchar(10));

create table tbl_donoAnimal ([IdDono] INT NOT NULL identity PRIMARY KEY,
[nomeDono] varchar(50),
[endereco] varchar (100),
[telefone] varchar(30));

create table tbl_baia ([IdDono] INT NOT NULL identity PRIMARY KEY,
[localBaia] varchar(50));

create table tbl_servico ([IdServico] INT NOT NULL identity PRIMARY KEY,
[descricaoServico] varchar(100));
	