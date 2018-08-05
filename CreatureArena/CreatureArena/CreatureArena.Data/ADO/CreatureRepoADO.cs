using CreatureArena.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatureArena.Models.Tables;
using CreatureArena.Models.Queries;

namespace CreatureArena.Data.ADO
{
    public class CreatureRepoADO : ICreatureRepo
    {
        public List<Creature> GetAll()
        {
            throw new NotImplementedException();
        }

        public Creature GetByID(int creatureID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AllCreaturesItem> GetCreatureDirectory()
        {
            throw new NotImplementedException();

        }

        public AllCreaturesItem GetSingleCreature(int creatureID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BossCreatures> GetBosses()
        {
            throw new NotImplementedException();
        }

        public AllCreaturesItem GetSingleCreatureByID(int creatureID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AllCreaturesItem> GetCreaturesByTypeID(int typeID)
        {
            throw new NotImplementedException();
        }

        public DetailedCreatureItem GetDetailedCreatureByID(int creatureID)
        {
            throw new NotImplementedException();
        }
    }
}
