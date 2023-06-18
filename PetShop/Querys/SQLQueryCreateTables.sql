CREATE TABLE [dbo].[tbl_animal] (
    [idAnimal]    INT          IDENTITY (1, 1) NOT NULL,
    [nomeAnimal]  VARCHAR (30) NOT NULL,
    [idadeAnimal] VARCHAR (20) NOT NULL,
    [porteAnimal] VARCHAR (20) NOT NULL,
    [racaAnimal]  VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([Idanimal] ASC)
);

CREATE TABLE [dbo].[tbl_baia] (
    [idBaia]    INT          IDENTITY (1, 1) NOT NULL,
    [localBaia] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([IdBaia] ASC)
);


CREATE TABLE [dbo].[tbl_donoAnimal] (
    [idDono]   INT           IDENTITY (1, 1) NOT NULL,
    [nomeDono] VARCHAR (50)  NULL,
    [endereco] VARCHAR (100) NULL,
    [telefone] VARCHAR (30)  NULL,
    PRIMARY KEY CLUSTERED ([IdDono] ASC)
);

CREATE TABLE [dbo].[tbl_servico] (
    [idServico]        INT           IDENTITY (1, 1) NOT NULL,
    [descricaoServico] VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([IdServico] ASC)
);




CREATE TABLE [dbo].[tbl_atendimento] (
    [idAtendimento]   INT          IDENTITY (1, 1) NOT NULL,
    [idDono]          INT          NOT NULL,
    [idBaia]          INT          NOT NULL,
    [idanimal]        INT          NOT NULL,
    [idServico]       INT          NOT NULL,
    [dataAtendimento] VARCHAR (30) NULL,
    [horaAtendimento] VARCHAR (30) NULL,
    [profResponsavel] VARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([idAtendimento] ASC),
    FOREIGN KEY ([idanimal]) REFERENCES [dbo].[tbl_animal] ([idanimal]),
    FOREIGN KEY ([idBaia]) REFERENCES [dbo].[tbl_baia] ([idBaia]),
    FOREIGN KEY ([idDono]) REFERENCES [dbo].[tbl_donoAnimal] ([idDono]),
    FOREIGN KEY ([idServico]) REFERENCES [dbo].[tbl_servico] ([idServico])
);





CREATE TABLE `tbl_animal` (
  `idAnimal` int NOT NULL AUTO_INCREMENT,
  `nomeAnimal` varchar(25) NOT NULL,
  `idadeAnimal` varchar(25) not null,
  `porteAnimal` varchar(25) NOT NULL,
  `racaAnimal` varchar(25) NOT NULL,
  PRIMARY KEY (`idAnimal`)
);
create table `tbl_baia`(
`idBaia` int not null auto_increment,
`localBaia` varchar (25) not null,
primary key (`idBaia`)
);
create table `tbl_donoAnimal` (
`idDono` int not null auto_increment,
`nomeDono` varchar(50) not null,
`endereco` varchar (150) not null,
`telefone` varchar (20) not null,
primary key (`idDono`)
);

create table `tbl_servico`(
`idServico` int not null auto_increment,
`descricaoServico` varchar (150) not null,
primary key (`idServico`)
);

create table `tbl_atendimento`(
`idAtendimento` int not null auto_increment,
`dataAtendimento` timestamp null default current_timestamp,
primary key (`idAtendimento`)
);