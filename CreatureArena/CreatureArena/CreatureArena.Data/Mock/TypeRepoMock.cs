using CreatureArena.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatureArena.Models.Tables;

namespace CreatureArena.Data.Mock
{
    public class TypeRepoMock : ITypeRepo
    {
        private static List<Models.Tables.Type> _type = new List<Models.Tables.Type>
        {
            //new Models.Tables.Type
            //{TypeID=1, TypeName="MockTName1", TypeIcon="MockTIcon1", TypeStrength=}
        };

        public List<Models.Tables.Type> GetAll()
        {
            throw new NotImplementedException();
        }

        public Models.Tables.Type GetByID(int typeID)
        {
            throw new NotImplementedException();
        }
    }
}
