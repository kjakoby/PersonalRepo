using CreatureArena.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Data.Interfaces
{
    public interface ICreatureAttacksRepo
    {
        List<CreatureAttacks> GetAll();
        IEnumerable<CreatureAttacks> GetByCreatureID(int creatureID);
        IEnumerable<CreatureAttacks> GetByAttackID(int attackID);
    }
}
