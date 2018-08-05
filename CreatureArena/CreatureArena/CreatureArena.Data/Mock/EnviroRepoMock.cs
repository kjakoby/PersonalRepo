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
            {EnviroID=1, EnviroName="MockEName1", EnviroPic="MockEnviro.jpg", TypeID=1},
            new Enviro
            {EnviroID=2, EnviroName="MockEName2", EnviroPic="MockEnviro.jpg", TypeID=2},
            new Enviro
            {EnviroID=3, EnviroName="MockEName3", EnviroPic="MockEnviro.jpg", TypeID=3}
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

        public Enviro GetByTypeID(int typeID)
        {
            if (_enviros.Where(e => e.TypeID == typeID).Count() == 0)
            {
                return null;
            }
            else
            {
                return _enviros.FirstOrDefault(e => e.TypeID == typeID);
            }
        }
    }
}
