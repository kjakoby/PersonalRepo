USE CreatureArena

IF EXISTS(SELECT * FROM sys.tables WHERE name='Environment')
	DROP TABLE Environment;
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='CreatureAttacks')
	DROP TABLE CreatureAttacks;
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='Attack')
	DROP TABLE Attack;
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='Creature')
	DROP TABLE Creature;
GO

IF EXISTS(SELECT * FROM sys.tables WHERE name='Type')
	DROP TABLE [Type];
GO

----------------------------------------------------------------------------------

CREATE TABLE [Type] (
	TypeID INT NOT NULL primary key identity(1,1),
	TypeName varchar(50) NOT NULL,
	TypeIcon varchar(50) NOT NULL,
	TypeWeakness int NOT NULL foreign key references [Type](TypeID),
	TypeStrength int NOT NULL foreign key references [Type](TypeID)
);

CREATE TABLE Creature (
	CreatureID INT NOT NULL primary key identity(1,1),
	CreatureHP INT NOT NULL,
	CreatureName varchar(50) NOT NULL,
	TypeID INT NULL foreign key references [Type](TypeID),
	Boss BIT NOT NULL,
	CreaturePic varchar(50) NOT NULL,
	CreatureInfo varchar(200) NULL
);

CREATE TABLE Attack (
	AttackID INT NOT NULL primary key identity(1,1),
	AttackName varchar(50) NOT NULL,
	AttackDamage INT NOT NULL,
	TypeID INT NULL foreign key references [Type](TypeID)
);

CREATE TABLE CreatureAttacks (
	CreatureID INT NOT NULL foreign key references Creature(CreatureID),
	AttackID INT NOT NULL foreign key references Attack(AttackID)
);

CREATE TABLE Environment (
	EnviroID INT NOT NULL primary key identity(1,1),
	EnviroName varchar(50) NOT NULL,
	EnviroPic varchar(50) NOT NULL
);

