using CreatureArena.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatureArena.Models.Tables;

namespace CreatureArena.Data.Mock
{
    public class CreatureAttacksRepoMock : ICreatureAttacksRepo
    {
        public List<CreatureAttacks> GetAll()
        {
            throw new NotImplementedException();
        }

        public CreatureAttacks GetByCreatureID(int creatureID)
        {
            throw new NotImplementedException();
        }
    }
}
