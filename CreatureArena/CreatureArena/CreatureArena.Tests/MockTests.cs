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
            var creaturesList = repo.GetCreatureDirectory().ToList();

            Assert.AreEqual(3, creaturesList.Count());
            Assert.AreEqual(2, creaturesList[1].CreatureID);
            Assert.AreEqual("MockCName3", creaturesList[2].CreatureName);
            Assert.AreEqual(1, creaturesList[0].TypeID);
            Assert.AreEqual("MockTName2", creaturesList[1].TypeName);
            Assert.AreEqual(100, creaturesList[2].CreatureHP);
            Assert.AreEqual(true, creaturesList[0].Boss);
            Assert.AreEqual(3, creaturesList[1].StrengthID);
            Assert.AreEqual(3, creaturesList[0].WeaknessID);
            Assert.AreEqual("MockStrength3", creaturesList[2].StrengthName);
            Assert.AreEqual("MockWeakness1", creaturesList[0].WeaknessName);
        }

        [Test]
        public void MockCanGetSingleCreatureByID()
        {
            var repo = new CreatureRepoMock();
            var creatureToTest = repo.GetSingleCreatureByID(3);

            Assert.AreEqual(3, creatureToTest.CreatureID);
            Assert.AreEqual("MockCName3", creatureToTest.CreatureName);
            Assert.AreEqual(3, creatureToTest.TypeID);
            Assert.AreEqual("MockTName3", creatureToTest.TypeName);
            Assert.AreEqual(100, creatureToTest.CreatureHP);
            Assert.AreEqual(true, creatureToTest.Boss);
            Assert.AreEqual(1, creatureToTest.StrengthID);
            Assert.AreEqual(2, creatureToTest.WeaknessID);
            Assert.AreEqual("MockStrength3", creatureToTest.StrengthName);
            Assert.AreEqual("MockWeakness3", creatureToTest.WeaknessName);
        }

        [Test]
        public void MockCanGetCreaturesByTypeID()
        {
            //need to add .ToList() to method after chaning method to allow for multiples

            var repo = new CreatureRepoMock();
            var creaturesList = repo.GetCreaturesByTypeID(2);

            //Assert.AreEqual(3, creaturesList.Count());
            //Assert.AreEqual(3, creatureToTest.CreatureID);
            //Assert.AreEqual("MockCName3", creatureToTest.CreatureName);
            //Assert.AreEqual(3, creatureToTest.TypeID);
            //Assert.AreEqual("MockTName3", creatureToTest.TypeName);
            //Assert.AreEqual(100, creatureToTest.CreatureHP);
            //Assert.AreEqual(true, creatureToTest.Boss);
            //Assert.AreEqual(1, creatureToTest.StrengthID);
            //Assert.AreEqual(2, creatureToTest.WeaknessID);
            //Assert.AreEqual("MockStrength3", creatureToTest.StrengthName);
            //Assert.AreEqual("MockWeakness3", creatureToTest.WeaknessName);
        }

        [Test]
        public void MockCanGetDetailedCreature()
        {
            //need to complete

            var repo = new CreatureRepoMock();
            var creatureToTest = repo.GetDetailedCreatureByID(1);

            //Assert.AreEqual(3, creatureToTest.CreatureID);
            //Assert.AreEqual("MockCName3", creatureToTest.CreatureName);
            //Assert.AreEqual(3, creatureToTest.TypeID);
            //Assert.AreEqual("MockTName3", creatureToTest.TypeName);
            //Assert.AreEqual(100, creatureToTest.CreatureHP);
            //Assert.AreEqual(true, creatureToTest.Boss);
            //Assert.AreEqual(1, creatureToTest.StrengthID);
            //Assert.AreEqual(2, creatureToTest.WeaknessID);
            //Assert.AreEqual("MockStrength3", creatureToTest.StrengthName);
            //Assert.AreEqual("MockWeakness3", creatureToTest.WeaknessName);
        }

        [Test]
        public void MockCanGetAllBosses()
        {
            throw new NotImplementedException();
        }

        //attack tests--------------------------------------------------------------------------------------

        [Test]
        public void MockCanGetAllAttacks()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockCanGetSingleAttackByID()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockCanGetAttacksByTypeID()
        {
            throw new NotImplementedException();
        }

        //type tests----------------------------------------------------------------------------------------

        [Test]
        public void MockCanGetAllTypes()
        {
            var repo = new TypeRepoMock();
            var typesList = repo.GetAll().ToList();

            Assert.AreEqual(3, typesList.Count());
            Assert.AreEqual(2, typesList[1].TypeID);
            Assert.AreEqual("MockTName3", typesList[2].TypeName);
            Assert.AreEqual("MockTIcon1", typesList[0].TypeIcon);
            Assert.AreEqual(3, typesList[1].TypeStrength);
            Assert.AreEqual(3, typesList[0].TypeWeakness);
        }

        [Test]
        public void MockCanGetSingleTypeByID()
        {
            var repo = new TypeRepoMock();
            var typeToTest = repo.GetByID(2);

            Assert.AreEqual(2, typeToTest.TypeID);
            Assert.AreEqual("MockTName2", typeToTest.TypeName);
            Assert.AreEqual("MockTIcon2", typeToTest.TypeIcon);
            Assert.AreEqual(3, typeToTest.TypeStrength);
            Assert.AreEqual(1, typeToTest.TypeWeakness);
        }

        //enviro tests--------------------------------------------------------------------------------------

        [Test]
        public void MockCanGetAllEnviros()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockCanGetSingleEnviroByID()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockCanGetSingleEnviroByTypeID()
        {
            throw new NotImplementedException();
        }

        //creature attack tests-----------------------------------------------------------------------------

        [Test]
        public void MockCanGetAllCreatureAttacks()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockCanGetCreatureAttacksByCreatureID()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockCanGetCreatureAttacksByAttackID()
        {
            throw new NotImplementedException();
        }

        //null tests----------------------------------------------------------------------------------------

        [Test]
        public void MockNoCreatureByID()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockNoCreaturesByTypeID()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockNoAttackByID()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockNoAttacksByTypeID()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockNoCreatureAttacksByCreatureID()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockNoCreatureAttacksByAttackID()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockNoTypeByID()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockNoEnviroByID()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void MockNoEnvirosByTypeID()
        {
            throw new NotImplementedException();
        }
    }
}
