﻿using CreatureArena.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatureArena.Models.Tables;

namespace CreatureArena.Data.ADO
{
    public class CreatureAttacksRepoADO : ICreatureAttacksRepo
    {
        public List<CreatureAttacks> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CreatureAttacks> GetByAttackID(int attackID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CreatureAttacks> GetByCreatureID(int creatureID)
        {
            throw new NotImplementedException();
        }
    }
}
