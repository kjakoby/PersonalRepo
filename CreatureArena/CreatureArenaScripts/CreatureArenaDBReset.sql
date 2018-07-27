USE CreatureArena
GO

IF EXISTS (
    SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
    WHERE ROUTINE_NAME = 'DbReset'
)
BEGIN
    DROP PROCEDURE DbReset
END
GO

CREATE PROCEDURE DbReset AS
BEGIN

	DELETE FROM Environment;
	DELETE FROM CreatureAttacks;
	DELETE FROM Attack;
	DELETE FROM Creature;
	DELETE FROM [Type];

DBCC CHECKIDENT ('Type', RESEED, 1)
DBCC CHECKIDENT ('Creature', RESEED, 1)
DBCC CHECKIDENT ('Attack', RESEED, 1)
DBCC CHECKIDENT ('CreatureAttacks', RESEED, 1)
DBCC CHECKIDENT ('Environment', RESEED, 1)

SET IDENTITY_INSERT [Type] ON;
INSERT INTO [Type](TypeID, TypeName, TypeIcon, TypeWeakness, TypeStrength)
VALUES (1, 'Water', 'placeholder.png', 2, 3),
(2, 'Earth', 'placeholder.png', 3, 1),
(3, 'Fire', 'placeholder.png', 1, 2)
SET IDENTITY_INSERT [Type] OFF;

SET IDENTITY_INSERT Creature ON;
INSERT INTO Creature(CreatureID, CreatureHP, CreatureName, TypeID, Boss, CreaturePic, CreatureInfo)
VALUES (1, 100, 'Igneous', 3, 1, 'placeholder.png', ),
(2, 'Earth', 'placeholder.png', 3, 1),
(3, 'Fire', 'placeholder.png', 1, 2)
SET IDENTITY_INSERT Creature OFF;

SET IDENTITY_INSERT Attack ON;
INSERT INTO Attack(TypeID, TypeName, TypeIcon, TypeWeakness, TypeStrength)
VALUES (1, 'Water', 'placeholder.png', 2, 3),
(2, 'Earth', 'placeholder.png', 3, 1),
(3, 'Fire', 'placeholder.png', 1, 2)
SET IDENTITY_INSERT Attack OFF;

SET IDENTITY_INSERT CreatureAttacks ON;
INSERT INTO CreatureAttacks(TypeID, TypeName, TypeIcon, TypeWeakness, TypeStrength)
VALUES (1, 'Water', 'placeholder.png', 2, 3),
(2, 'Earth', 'placeholder.png', 3, 1),
(3, 'Fire', 'placeholder.png', 1, 2)
SET IDENTITY_INSERT CreatureAttacks OFF;

SET IDENTITY_INSERT Environment ON;
INSERT INTO Environment(TypeID, TypeName, TypeIcon, TypeWeakness, TypeStrength)
VALUES (1, 'Water', 'placeholder.png', 2, 3),
(2, 'Earth', 'placeholder.png', 3, 1),
(3, 'Fire', 'placeholder.png', 1, 2)
SET IDENTITY_INSERT Environment OFF;

END

--exec DbReset