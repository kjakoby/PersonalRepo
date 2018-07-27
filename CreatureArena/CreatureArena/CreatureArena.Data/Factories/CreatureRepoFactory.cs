using CreatureArena.Data.ADO;
using CreatureArena.Data.Interfaces;
using CreatureArena.Data.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Data.Factories
{
    public class CreatureRepoFactory
    {
        public static ICreatureRepo GetRepo()
        {
            switch (Settings.GetRepoType())
            {
                case "MockData":
                    return new CreatureRepoMock();
                case "ADO":
                    return new CreatureRepoADO();
                default:
                    throw new Exception("Not a valid Repo type!");
            }
        }
    }
}
