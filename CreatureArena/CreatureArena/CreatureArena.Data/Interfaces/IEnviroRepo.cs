using CreatureArena.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Data.Interfaces
{
    public interface IEnviroRepo
    {
        List<Enviro> GetAll();
        Enviro GetByID(int creatureID);
        Enviro GetByTypeID(int typeID);
    }
}
