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
    public class CreatureAttacksRepoFactory
    {
        public static ICreatureAttacksRepo GetRepo()
        {
            switch (Settings.GetRepoType())
            {
                case "MockData":
                    return new CreatureAttacksRepoMock();
                case "ADO":
                    return new CreatureAttacksRepoADO();
                default:
                    throw new Exception("Not a valid Repo type!");
            }
        }
    }
}
