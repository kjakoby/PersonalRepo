using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Data.Interfaces
{
    public interface ITypeRepo
    {
        List<Models.Tables.Type> GetAll();
        Models.Tables.Type GetByID(int typeID);
    }
}
