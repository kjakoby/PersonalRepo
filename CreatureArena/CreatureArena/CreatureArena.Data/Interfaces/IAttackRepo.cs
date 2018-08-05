using CreatureArena.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Data.Interfaces
{
    public interface IAttackRepo
    {
        List<Attack> GetAll();
        Attack GetByID(int attackID);
        IEnumerable<Attack> GetByTypeID(int typeID);
    }
}
