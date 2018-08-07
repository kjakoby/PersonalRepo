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

IF EXISTS(SELECT * FROM INFORMATION_SCHEMA.ROUTINES
	WHERE ROUTINE_NAME = 'CreatureDetails')
		DROP PROCEDURE CreatureDetails
GO

CREATE PROCEDURE CreatureDetails(
	@CreatureID INT
		) AS
BEGIN
	SELECT CreatureID, CreatureName, C.TypeID, T.TypeName, CreatureHP, Boss, CreaturePic, CreatureInfo, T.TypeStrength, T.TypeWeakness, T2.TypeName AS Strength, T3.TypeName AS Weakness
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

