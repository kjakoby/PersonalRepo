using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Tests
{
    [TestFixture]
    public class ADOTests
    {
        [SetUp]
        public void Init()
        {
            using (var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                var cmd = new SqlCommand();
                cmd.CommandText = "DBReset";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Connection = cn;
                cn.Open();

                cmd.ExecuteNonQuery();
            }
        }

        [Test]
        public void ADOCanLoadCreatureTable()
        {

        }

        [Test]
        public void ADOCanLoadCreatureAttacksTable()
        {

        }

        [Test]
        public void ADOCanLoadAttackTable()
        {

        }

        [Test]
        public void ADOCanLoadEnviroTable()
        {

        }

        [Test]
        public void ADOCanLoadTypeTable()
        {

        }

        [Test]
        public void ADOCanGetAllCreatures()
        {

        }

        [Test]
        public void ADOCanGetSingleCreatureByID(int creatureID)
        {

        }

        [Test]
        public void ADOCanGetCreaturesByTypeID(int typeID)
        {

        }

        [Test]
        public void ADOCanGetAllBosses()
        {

        }

        [Test]
        public void ADOCanGetAllAttacks()
        {

        }

        [Test]
        public void ADOCanGetSingleAttackByID(int attackID)
        {

        }

        [Test]
        public void ADOCanGetAttacksByTypeID(int typeID)
        {

        }

        [Test]
        public void ADOCanGetAllTypes()
        {

        }

        [Test]
        public void ADOCanGetSingleTypeByID(int typeID)
        {

        }

        [Test]
        public void ADOCanGetAllEnviros()
        {

        }

        [Test]
        public void ADOCanGetSingleEnviroByID(int enviroID)
        {

        }

        [Test]
        public void ADOCanGetSingleEnviroByTypeID(int typeID)
        {

        }

        [Test]
        public void ADOCanGetAllCreatureAttacks()
        {

        }

        [Test]
        public void ADOCanGetCreatureAttacksByCreatureID(int creatureID)
        {

        }

        [Test]
        public void ADOCanGetCreatureAttacksByAttackID(int attackID)
        {

        }
    }
}
