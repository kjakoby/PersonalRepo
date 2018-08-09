USE CreatureArena
GO

----------------------------------------------------------------------
----------------------------------------------------------------------

--Attack--

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
	WHERE ROUTINE_NAME = 'AttackByID')
		DROP PROCEDURE AttackByID
GO

CREATE PROCEDURE AttackByID(
	@AttackID INT
		) AS
BEGIN
	SELECT AttackID, AttackName, AttackDamage, TypeID 
	FROM Attack
	WHERE AttackID = @AttackID
END
GO

--EXEC AttackByID

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'AttackByTypeID')
		DROP PROCEDURE AttackByTypeID
GO

CREATE PROCEDURE AttackByTypeID(
	@TypeID INT
		) AS
BEGIN
	SELECT AttackID, AttackName, AttackDamage, TypeID 
	FROM Attack
	WHERE TypeID = @TypeID
END
GO

--EXEC AttackByTypeID

----------------------------------------------------------------------
----------------------------------------------------------------------

--Creature--

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
	WHERE ROUTINE_NAME = 'CreatureByID')
		DROP PROCEDURE CreatureByID
GO

CREATE PROCEDURE CreatureByID(
	@CreatureID INT
		) AS
BEGIN
	SELECT CreatureID, CreatureHP, CreatureName, TypeID, Boss, CreaturePic, CreatureInfo
	FROM Creature
	WHERE CreatureID = @CreatureID
END
GO

--EXEC CreatureByID

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'CreatureDirectory')
		DROP PROCEDURE CreatureDirectory
GO

CREATE PROCEDURE CreatureDirectory AS
BEGIN
	SELECT CreatureID, CreatureHP, CreatureName, T.TypeName, Boss, T2.TypeName AS Strength, T3.TypeName AS Weakness, C.TypeID, T.TypeStrength, T.TypeWeakness
	FROM Creature AS C
		INNER JOIN [Type] AS T ON 
			 T.TypeID = C.TypeID
		INNER JOIN [Type] AS T2 ON
			T2.TypeID = T.TypeStrength
		INNER JOIN [Type] AS T3 ON
			T3.TypeID = T.TypeWeakness
END
GO

--EXEC CreatureDirectory

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'SingleCreatureByID')
		DROP PROCEDURE SingleCreatureByID
GO

CREATE PROCEDURE SingleCreatureByID(
	@CreatureID INT
		) AS
BEGIN
	SELECT CreatureID, CreatureHP, CreatureName, T.TypeName, Boss, T2.TypeName AS Strength, T3.TypeName AS Weakness, C.TypeID, T.TypeStrength, T.TypeWeakness
	FROM Creature AS C
		INNER JOIN [Type] AS T ON 
			 T.TypeID = C.TypeID
		INNER JOIN [Type] AS T2 ON
			T2.TypeID = T.TypeStrength
		INNER JOIN [Type] AS T3 ON
			T3.TypeID = T.TypeWeakness
	WHERE CreatureID = @CreatureID
END
GO

--EXEC SingleCreatureByID

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'CreaturesByTypeID')
		DROP PROCEDURE CreaturesByTypeID
GO

CREATE PROCEDURE CreaturesByTypeID(
	@TypeID INT
		) AS
BEGIN
	SELECT CreatureID, CreatureHP, CreatureName, T.TypeName, Boss, T2.TypeName AS Strength, T3.TypeName AS Weakness, C.TypeID, T.TypeStrength, T.TypeWeakness
	FROM Creature AS C
		INNER JOIN [Type] AS T ON 
			 T.TypeID = C.TypeID
		INNER JOIN [Type] AS T2 ON
			T2.TypeID = T.TypeStrength
		INNER JOIN [Type] AS T3 ON
			T3.TypeID = T.TypeWeakness
	WHERE C.TypeID = @TypeID
END
GO

--EXEC CreaturesByTypeID

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'CreatureDetails')
		DROP PROCEDURE CreatureDetails
GO

CREATE PROCEDURE CreatureDetails(
	@CreatureID INT
		) AS
BEGIN
	SELECT CreatureID, CreatureName, T.TypeName, CreatureHP, Boss, CreaturePic, CreatureInfo, T2.TypeName AS Strength, T3.TypeName AS Weakness, C.TypeID, T.TypeStrength, T.TypeWeakness
	FROM Creature AS C
		INNER JOIN [Type] AS T ON 
			 T.TypeID = C.TypeID
		INNER JOIN [Type] AS T2 ON
			T2.TypeID = T.TypeStrength
		INNER JOIN [Type] AS T3 ON
			T3.TypeID = T.TypeWeakness
	WHERE CreatureID = @CreatureID
END
GO

--EXEC CreatureDetails

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'CreatureBosses')
		DROP PROCEDURE CreatureBosses
GO

CREATE PROCEDURE CreatureBosses AS
BEGIN
	SELECT CreatureID, CreatureName, Boss, CreaturePic, CreatureInfo
	FROM Creature
	WHERE Boss = 1
END
GO

--EXEC CreatureBosses

----------------------------------------------------------------------
----------------------------------------------------------------------

--CreatureAttacks--

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
	WHERE ROUTINE_NAME = 'CreatureAttacksByAttackID')
		DROP PROCEDURE CreatureAttacksByAttackID
GO

CREATE PROCEDURE CreatureAttacksByAttackID(
	@AttackID INT
		) AS
BEGIN
	SELECT CreatureID, AttackID
	FROM CreatureAttacks
	WHERE AttackID = @AttackID
END
GO

--EXEC CreatureAttacksByAttackID

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'CreatureAttacksByCreatureID')
		DROP PROCEDURE CreatureAttacksByCreatureID
GO

CREATE PROCEDURE CreatureAttacksByCreatureID(
	@CreatureID INT
		) AS
BEGIN
	SELECT CreatureID, AttackID
	FROM CreatureAttacks
	WHERE CreatureID = @CreatureID
END
GO

--EXEC CreatureAttacksByCreatureID

----------------------------------------------------------------------
----------------------------------------------------------------------

--Enviro--

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'EnviroSelectAll')
		DROP PROCEDURE EnviroSelectAll
GO

CREATE PROCEDURE EnviroSelectAll AS
BEGIN
	SELECT EnviroID, EnviroName, EnviroPic, TypeID
	FROM Environment
END
GO

--EXEC EnviroSelectAll

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'EnviroByID')
		DROP PROCEDURE EnviroByID
GO

CREATE PROCEDURE EnviroByID(
	@EnviroID INT
		) AS
BEGIN
	SELECT EnviroID, EnviroName, EnviroPic, TypeID
	FROM Environment
	WHERE EnviroID = @EnviroID
END
GO

--EXEC EnviroByID

----------------------------------------------------------------------

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'EnviroByTypeID')
		DROP PROCEDURE EnviroByTypeID
GO

CREATE PROCEDURE EnviroByTypeID(
	@TypeID INT
		) AS
BEGIN
	SELECT EnviroID, EnviroName, EnviroPic, TypeID
	FROM Environment
	WHERE TypeID = @TypeID
END
GO

--EXEC EnviroByTypeID

----------------------------------------------------------------------
----------------------------------------------------------------------

--Type--

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

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'TypeByID')
		DROP PROCEDURE TypeByID
GO

CREATE PROCEDURE TypeByID(
	@TypeID INT
		) AS
BEGIN
	SELECT TypeID, TypeName, TypeIcon, TypeStrength, TypeWeakness
	FROM [Type]
	WHERE TypeID = @TypeID
END
GO

--EXEC TypeByID

----------------------------------------------------------------------
----------------------------------------------------------------------


