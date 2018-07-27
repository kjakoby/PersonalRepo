using CreatureArena.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatureArena.Models.Tables;

namespace CreatureArena.Data.Mock
{
    public class EnviroRepoMock : IEnviroRepo
    {
        public List<Enviro> GetAll()
        {
            throw new NotImplementedException();
        }

        public Enviro GetByID(int creatureID)
        {
            throw new NotImplementedException();
        }
    }
}
