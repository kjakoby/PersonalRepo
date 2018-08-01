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
        private static List<Enviro> _enviros = new List<Enviro>()
        {
            new Enviro
            { },
            new Enviro
            { },
            new Enviro
            { }
        };

        public List<Enviro> GetAll()
        {
            return _enviros;
        }

        public Enviro GetByID(int enviroID)
        {
            if (_enviros.Where(e => e.EnviroID == enviroID).Count() == 0)
            {
                return null;
            }
            else
            {
                return _enviros.FirstOrDefault(e => e.EnviroID == enviroID);
            }
        }
    }
}
