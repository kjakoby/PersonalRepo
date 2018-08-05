using CreatureArena.Models.Tables;
using CreatureArena.Models.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Data.Interfaces
{
    public interface ICreatureRepo
    {
        List<Creature> GetAll();
        Creature GetByID(int creatureID);
        IEnumerable<AllCreaturesItem> GetCreatureDirectory();
        AllCreaturesItem GetSingleCreatureByID(int creatureID);
        IEnumerable<AllCreaturesItem> GetCreaturesByTypeID(int typeID);
        DetailedCreatureItem GetDetailedCreatureByID(int creatureID);
        IEnumerable<BossCreatures> GetBosses();
    }
}
