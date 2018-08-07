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
--DBCC CHECKIDENT ('CreatureAttacks', RESEED, 1)
DBCC CHECKIDENT ('Environment', RESEED, 1)

SET IDENTITY_INSERT [Type] ON;
INSERT INTO [Type](TypeID, TypeName, TypeIcon, TypeWeakness, TypeStrength)
VALUES (1, 'Water', 'MockType.jpg', 2, 3),
(2, 'Earth', 'MockType.jpg', 3, 1),
(3, 'Fire', 'MockType.jpg', 1, 2)
SET IDENTITY_INSERT [Type] OFF;

SET IDENTITY_INSERT Creature ON;
INSERT INTO Creature(CreatureID, CreatureHP, CreatureName, TypeID, Boss, CreaturePic, CreatureInfo)
VALUES (1, 100, 'Igneous', 3, 1, 'MockCreature.jpg', 'amaret amarissimam amatoriis ambigua amentur amet amice amici amicis amicitia amicitiae amicitiam amicitias amicorum amicos amicum amorem amori amoris amotio amplificarique amputata an ancillae angere'),
(2, 100, 'Glacis', 1, 1, 'MockCreature.jpg', 'capti captiosa careat carere careret caret caritatem carum causa causae causam causas cedentem celeritas censes censet centurionum cepisse ceramico cernantur cernimus certa certae certamen certe choro'),
(3, 100, 'Bouldros', 2, 1, 'MockCreature.jpg', 'brevis breviter brute brutus cadere caecilii caeco caelo calere campum canes captet capti captiosa careat carere careret caret caritatem carum causa causae causam causas cedentem celeritas censes cibo'),
(4, 50, 'Pyre', 3, 0, 'MockCreature.jpg', 'cogitemus cognita cognitio cognitione cognitionem cognitionis cognitioque cognomen cognoscerem cognosci cohaerescant cohaerescent collaudata collegi collegisti comit commemorandis commenticiam commodi'),
(5, 50, 'Hydran', 1, 0, 'MockCreature.jpg', 'appetendum appetere approbantibus apte aptent aptior aptissimum aptius apud arare arbitramur arbitrantur arbitrarer arbitraretur arbitratu arbitrer arbitrium arbitror architecto arcu ardore arguerenti'), 
(6, 50, 'Roc', 2, 0, 'MockCreature.jpg', 'attico attingere attulit auctor auctori audaces audeam audiam audiebam audiebamus audire audita audivi augendas augeri augue aut aute autem avocent beata beatae beatam beate beateque beatus bella bene')
SET IDENTITY_INSERT Creature OFF;

SET IDENTITY_INSERT Attack ON;
INSERT INTO Attack(AttackID, AttackName, AttackDamage, TypeID)
VALUES (1, 'Mud Slide', 10, 2),
(2, 'Lava Spin', 20, 3),
(3, 'Whirlpool', 10, 1),
(4, 'Fire Stomp', 20, 3),
(5, 'Magma', 10, 3),
(6, 'Earthquake', 20, 2),
(7, 'Ice punch', 20, 1),
(8, 'Gravel Throw', 10, 2),
(9, 'Liquify', 20, 1),
(10, 'Granite Smash', 20, 2),
(11, 'Sizzle', 10, 3),
(12, 'Water Gun', 10, 1)
SET IDENTITY_INSERT Attack OFF;

--SET IDENTITY_INSERT CreatureAttacks ON;
INSERT INTO CreatureAttacks(CreatureID, AttackID)
VALUES (1, 2), (1, 4), (1, 5), (1, 11),
(2, 3), (2, 7), (2, 9), (2, 12),
(3, 1), (3, 6), (3, 8), (3, 10),
(4, 2), (4, 4), (4, 5), (4, 11),
(5, 3), (5, 7), (5, 9), (5, 12),
(6, 1), (6, 6), (6, 8), (6, 10)
--SET IDENTITY_INSERT CreatureAttacks OFF;

SET IDENTITY_INSERT Environment ON;
INSERT INTO Environment(EnviroID, EnviroName, EnviroPic, TypeID)
VALUES (1, 'an Ocean', 'MockEnviro.jpg', 1),
(2, 'a Forest', 'MockEnviro.jpg', 2),
(3, 'a Volcano', 'MockEnviro.jpg', 3)
SET IDENTITY_INSERT Environment OFF;

END

--exec DbReset