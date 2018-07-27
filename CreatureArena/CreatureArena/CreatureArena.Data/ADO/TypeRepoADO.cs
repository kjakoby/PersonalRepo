using CreatureArena.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatureArena.Models.Tables;

namespace CreatureArena.Data.ADO
{
    public class TypeRepoADO : ITypeRepo
    {
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
