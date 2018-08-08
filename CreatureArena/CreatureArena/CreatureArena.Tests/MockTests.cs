using CreatureArena.Data.Mock;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Tests
{
    [TestFixture]
    public class MockTests
    {
        //creature tests------------------------------------------------------------------------------------

        [Test]
        public void MockCanGetAllCreatures()
        {
            var repo = new CreatureRepoMock();
            var creatureList = repo.GetCreatureDirectory().ToList();

            Assert.AreEqual(3, creatureList.Count());
            Assert.AreEqual(2, creatureList[1].CreatureID);
            Assert.AreEqual("MockCName3", creatureList[2].CreatureName);
            Assert.AreEqual(1, creatureList[0].TypeID);
            Assert.AreEqual("MockTName2", creatureList[1].TypeName);
            Assert.AreEqual(100, creatureList[2].CreatureHP);
            Assert.AreEqual(true, creatureList[0].Boss);
            Assert.AreEqual(3, creatureList[1].StrengthID);
            Assert.AreEqual(3, creatureList[0].WeaknessID);
            Assert.AreEqual("MockStrength3", creatureList[2].StrengthName);
            Assert.AreEqual("MockWeakness1", creatureList[0].WeaknessName);
        }

        [Test]
        public void MockCanGetSingleCreatureByID()
        {
            var repo = new CreatureRepoMock();
            var foundCreature = repo.GetSingleCreatureByID(3);

            Assert.AreEqual(3, foundCreature.CreatureID);
            Assert.AreEqual("MockCName3", foundCreature.CreatureName);
            Assert.AreEqual(3, foundCreature.TypeID);
            Assert.AreEqual("MockTName3", foundCreature.TypeName);
            Assert.AreEqual(100, foundCreature.CreatureHP);
            Assert.AreEqual(true, foundCreature.Boss);
            Assert.AreEqual(1, foundCreature.StrengthID);
            Assert.AreEqual(2, foundCreature.WeaknessID);
            Assert.AreEqual("MockStrength3", foundCreature.StrengthName);
            Assert.AreEqual("MockWeakness3", foundCreature.WeaknessName);
        }

        [Test]
        public void MockCanGetCreaturesByTypeID()
        {
            var repo = new CreatureRepoMock();
            var creatureList = repo.GetCreaturesByTypeID(2).ToList();

            Assert.AreEqual(1, creatureList.Count());
            Assert.AreEqual(2, creatureList[0].CreatureID);
            Assert.AreEqual("MockCName2", creatureList[0].CreatureName);
            Assert.AreEqual(2, creatureList[0].TypeID);
            Assert.AreEqual("MockTName2", creatureList[0].TypeName);
            Assert.AreEqual(100, creatureList[0].CreatureHP);
            Assert.AreEqual(true, creatureList[0].Boss);
            Assert.AreEqual(3, creatureList[0].StrengthID);
            Assert.AreEqual(1, creatureList[0].WeaknessID);
            Assert.AreEqual("MockStrength2", creatureList[0].StrengthName);
            Assert.AreEqual("MockWeakness2", creatureList[0].WeaknessName);
        }

        [Test]
        public void MockCanGetDetailedCreature()
        {
            var repo = new CreatureRepoMock();
            var foundCreature = repo.GetDetailedCreatureByID(1);

            Assert.AreEqual(1, foundCreature.CreatureID);
            Assert.AreEqual("MockCName1", foundCreature.CreatureName);
            Assert.AreEqual(1, foundCreature.TypeID);
            Assert.AreEqual("MockTName1", foundCreature.TypeName);
            Assert.AreEqual(100, foundCreature.CreatureHP);
            Assert.AreEqual(true, foundCreature.Boss);
            Assert.AreEqual(2, foundCreature.StrengthID);
            Assert.AreEqual(3, foundCreature.WeaknessID);
            Assert.AreEqual("MockStrength1", foundCreature.StrengthName);
            Assert.AreEqual("MockWeakness1", foundCreature.WeaknessName);
            Assert.AreEqual("MockCreature.jpg", foundCreature.CreaturePic);
            Assert.AreEqual("MockInfo1MockInfo1MockInfo1MockInfo1MockInfo1", foundCreature.CreatureInfo);
        }

        [Test]
        public void MockCanGetAllBosses()
        {
            var repo = new CreatureRepoMock();
            var bossList = repo.GetBosses().ToList();

            Assert.AreEqual(3, bossList.Count());
            Assert.AreEqual(1, bossList[0].CreatureID);
            Assert.AreEqual("MockCName4", bossList[2].CreatureName);
            Assert.AreEqual("MockCreature.jpg", bossList[1].CreaturePic);
            Assert.AreEqual("MockInfo1MockInfo1MockInfo1MockInfo1MockInfo1", bossList[0].CreatureInfo);
            Assert.AreEqual(true, bossList[1].Boss);
        }

        //attack tests--------------------------------------------------------------------------------------

        [Test]
        public void MockCanGetAllAttacks()
        {
            var repo = new AttackRepoMock();
            var attackList = repo.GetAll();

            Assert.AreEqual(6, attackList.Count());
            Assert.AreEqual(1, attackList[0].AttackID);
            Assert.AreEqual("MockAName4", attackList[3].AttackName);
            Assert.AreEqual(20, attackList[5].AttackDamage);
            Assert.AreEqual(2, attackList[2].TypeID);
        }

        [Test]
        public void MockCanGetSingleAttackByID()
        {
            var repo = new AttackRepoMock();
            var foundAttack = repo.GetByID(3);

            Assert.AreEqual(3, foundAttack.AttackID);
            Assert.AreEqual("MockAName3", foundAttack.AttackName);
            Assert.AreEqual(10, foundAttack.AttackDamage);
            Assert.AreEqual(2, foundAttack.TypeID);
        }

        [Test]
        public void MockCanGetAttacksByTypeID()
        {
            var repo = new AttackRepoMock();
            var attackList = repo.GetByTypeID(2).ToList();

            Assert.AreEqual(2, attackList.Count());
            Assert.AreEqual(3, attackList[0].AttackID);
            Assert.AreEqual("MockAName4", attackList[1].AttackName);
            Assert.AreEqual(20, attackList[1].AttackDamage);
            Assert.AreEqual(2, attackList[0].TypeID);
        }

        //type tests----------------------------------------------------------------------------------------

        [Test]
        public void MockCanGetAllTypes()
        {
            var repo = new TypeRepoMock();
            var typeList = repo.GetAll().ToList();

            Assert.AreEqual(3, typeList.Count());
            Assert.AreEqual(2, typeList[1].TypeID);
            Assert.AreEqual("MockTName3", typeList[2].TypeName);
            Assert.AreEqual("MockType.jpg", typeList[0].TypeIcon);
            Assert.AreEqual(3, typeList[1].TypeStrength);
            Assert.AreEqual(3, typeList[0].TypeWeakness);
        }

        [Test]
        public void MockCanGetSingleTypeByID()
        {
            var repo = new TypeRepoMock();
            var foundType = repo.GetByID(2);

            Assert.AreEqual(2, foundType.TypeID);
            Assert.AreEqual("MockTName2", foundType.TypeName);
            Assert.AreEqual("MockType.jpg", foundType.TypeIcon);
            Assert.AreEqual(3, foundType.TypeStrength);
            Assert.AreEqual(1, foundType.TypeWeakness);
        }

        //enviro tests--------------------------------------------------------------------------------------

        [Test]
        public void MockCanGetAllEnviros()
        {
            var repo = new EnviroRepoMock();
            var enviroList = repo.GetAll();

            Assert.AreEqual(3, enviroList.Count());
            Assert.AreEqual(2, enviroList[1].EnviroID);
            Assert.AreEqual("MockEName1", enviroList[0].EnviroName);
            Assert.AreEqual("MockEnviro.jpg", enviroList[2].EnviroPic);
            Assert.AreEqual(1, enviroList[0].TypeID);
        }

        [Test]
        public void MockCanGetSingleEnviroByID()
        {
            var repo = new EnviroRepoMock();
            var foundEnviro = repo.GetByID(2);
            
            Assert.AreEqual(2, foundEnviro.EnviroID);
            Assert.AreEqual("MockEName2", foundEnviro.EnviroName);
            Assert.AreEqual("MockEnviro.jpg", foundEnviro.EnviroPic);
            Assert.AreEqual(2, foundEnviro.TypeID);
        }

        [Test]
        public void MockCanGetSingleEnviroByTypeID()
        {
            var repo = new EnviroRepoMock();
            var foundEnviro = repo.GetByTypeID(2);

            Assert.AreEqual(2, foundEnviro.EnviroID);
            Assert.AreEqual("MockEName2", foundEnviro.EnviroName);
            Assert.AreEqual("MockEnviro.jpg", foundEnviro.EnviroPic);
            Assert.AreEqual(2, foundEnviro.TypeID);
        }

        //creature attack tests-----------------------------------------------------------------------------

        [Test]
        public void MockCanGetAllCreatureAttacks()
        {
            var repo = new CreatureAttacksRepoMock();
            var creatureAttacksList = repo.GetAll();

            Assert.AreEqual(12, creatureAttacksList.Count());
            Assert.AreEqual(2, creatureAttacksList[5].CreatureID);
            Assert.AreEqual(3, creatureAttacksList[2].AttackID);
            Assert.AreEqual(2, creatureAttacksList[6].CreatureID);
            Assert.AreEqual(6, creatureAttacksList[9].AttackID);
        }

        [Test]
        public void MockCanGetCreatureAttacksByCreatureID()
        {
            var repo = new CreatureAttacksRepoMock();
            var creatureAttacksList = repo.GetByCreatureID(3).ToList();

            Assert.AreEqual(4, creatureAttacksList.Count());
            Assert.AreEqual(3, creatureAttacksList[1].CreatureID);
            Assert.AreEqual(1, creatureAttacksList[2].AttackID);
            Assert.AreEqual(3, creatureAttacksList[0].CreatureID);
            Assert.AreEqual(3, creatureAttacksList[3].AttackID);
        }

        [Test]
        public void MockCanGetCreatureAttacksByAttackID()
        {
            var repo = new CreatureAttacksRepoMock();
            var creatureAttacksList = repo.GetByAttackID(5).ToList();

            Assert.AreEqual(3, creatureAttacksList.Count());
            Assert.AreEqual(1, creatureAttacksList[0].CreatureID);
            Assert.AreEqual(5, creatureAttacksList[2].AttackID);
            Assert.AreEqual(2, creatureAttacksList[1].CreatureID);
            Assert.AreEqual(5, creatureAttacksList[1].AttackID);
        }

        //null tests----------------------------------------------------------------------------------------

        [Test]
        public void MockNoCreatureByInvalidID()
        {
            var repo = new CreatureRepoMock();
            var foundCreature = repo.GetSingleCreatureByID(999999);

            Assert.IsNull(foundCreature);
        }

        [Test]
        public void MockNoCreaturesByInvalidTypeID()
        {
            var repo = new CreatureRepoMock();
            var creatureList = repo.GetCreaturesByTypeID(999999);

            Assert.IsNull(creatureList);
        }

        [Test]
        public void MockNoAttackByInvalidID()
        {
            var repo = new AttackRepoMock();
            var foundAttack = repo.GetByID(999999);

            Assert.IsNull(foundAttack);
        }

        [Test]
        public void MockNoAttacksByInvalidTypeID()
        {
            var repo = new AttackRepoMock();
            var attackList = repo.GetByTypeID(999999);

            Assert.IsNull(attackList);
        }

        [Test]
        public void MockNoCreatureAttacksByInvalidCreatureID()
        {
            var repo = new CreatureAttacksRepoMock();
            var creatureAttacksList = repo.GetByCreatureID(999999);

            Assert.IsNull(creatureAttacksList);
        }

        [Test]
        public void MockNoCreatureAttacksByInvalidAttackID()
        {
            var repo = new CreatureAttacksRepoMock();
            var creatureAttacksList = repo.GetByAttackID(999999);

            Assert.IsNull(creatureAttacksList);
        }

        [Test]
        public void MockNoTypeByInvalidID()
        {
            var repo = new TypeRepoMock();
            var foundType = repo.GetByID(999999);

            Assert.IsNull(foundType);
        }

        [Test]
        public void MockNoEnviroByInvalidID()
        {
            var repo = new EnviroRepoMock();
            var foundEnviro = repo.GetByID(999999);

            Assert.IsNull(foundEnviro);
        }

        [Test]
        public void MockNoEnviroByInvalidTypeID()
        {
            var repo = new EnviroRepoMock();
            var foundEnviro = repo.GetByTypeID(999999);

            Assert.IsNull(foundEnviro);
        }
    }
}
