USE CreatureArena
GO

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'AttackSelectAll')
		DROP PROCEDURE AttackSelectAll
GO

CREATE PROCEDURE AttackSelectAll AS
BEGIN
	SELECT AttackID, AttackName, AttackDamage, TypeID 
	FROM Attack
END
GO

--EXEC AttackSelectAll

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'CreatureSelectAll')
		DROP PROCEDURE CreatureSelectAll
GO

CREATE PROCEDURE CreatureSelectAll AS
BEGIN
	SELECT CreatureID, CreatureHP, CreatureName, TypeID, Boss, CreaturePic, CreatureInfo
	FROM Creature
END
GO

--EXEC CreatureSelectAll

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'CreatureAttacksSelectAll')
		DROP PROCEDURE CreatureAttacksSelectAll
GO

CREATE PROCEDURE CreatureAttacksSelectAll AS
BEGIN
	SELECT CreatureID, AttackID
	FROM CreatureAttacks
END
GO

--EXEC CreatureAttacksSelectAll

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'EnvironmentSelectAll')
		DROP PROCEDURE EnvironmentSelectAll
GO

CREATE PROCEDURE EnvironmentSelectAll AS
BEGIN
	SELECT EnviroID, EnviroName, EnviroPic
	FROM Environment
END
GO

--EXEC EnvironmentSelectAll

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'TypeSelectAll')
		DROP PROCEDURE TypeSelectAll
GO

CREATE PROCEDURE TypeSelectAll AS
BEGIN
	SELECT TypeID, TypeName, TypeIcon, TypeStrength, TypeWeakness
	FROM [Type]
END
GO

--EXEC TypeSelectAll

----------------------------------------------------------------------