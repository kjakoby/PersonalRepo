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
        private static List<Models.Tables.Type> _types = new List<Models.Tables.Type>
        {
            new Models.Tables.Type
            {TypeID=1, TypeName="MockTName1", TypeIcon="MockTIcon1", TypeStrength=2, TypeWeakness=3},
            new Models.Tables.Type
            {TypeID=2, TypeName="MockTName2", TypeIcon="MockTIcon2", TypeStrength=3, TypeWeakness=1},
            new Models.Tables.Type
            {TypeID=3, TypeName="MockTName3", TypeIcon="MockTIcon3", TypeStrength=1, TypeWeakness=2}
        };

        public List<Models.Tables.Type> GetAll()
        {
            return _types;
        }

        public Models.Tables.Type GetByID(int typeID)
        {
            if (_types.Where(t => t.TypeID == typeID).Count() == 0)
            {
                return null;
            }
            else
            {
                return _types.FirstOrDefault(t => t.TypeID == typeID);
            }
        }
    }
}
