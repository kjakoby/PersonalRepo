USE master
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name='CreatureArena')
	DROP DATABASE CreatureArena;
GO

CREATE DATABASE CreatureArena;
GO