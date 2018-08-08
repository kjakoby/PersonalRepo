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
        private static List<CreatureAttacks> _creatureAttacks = new List<CreatureAttacks>
        {
            new CreatureAttacks {CreatureID=1, AttackID=1 }, new CreatureAttacks {CreatureID=1, AttackID=2 }, new CreatureAttacks {CreatureID=1, AttackID=3 }, new CreatureAttacks {CreatureID=1, AttackID=5 },
            new CreatureAttacks {CreatureID=2, AttackID=3 }, new CreatureAttacks {CreatureID=2, AttackID=4 }, new CreatureAttacks {CreatureID=2, AttackID=1 }, new CreatureAttacks {CreatureID=2, AttackID=5 },
            new CreatureAttacks {CreatureID=3, AttackID=5 }, new CreatureAttacks {CreatureID=3, AttackID=6 }, new CreatureAttacks {CreatureID=3, AttackID=1 }, new CreatureAttacks {CreatureID=3, AttackID=3 },
        };

        public List<CreatureAttacks> GetAll()
        {
            return _creatureAttacks;
        }

        public IEnumerable<CreatureAttacks> GetByAttackID(int attackID)
        {
            if (_creatureAttacks.Where(ca => ca.AttackID == attackID).Count() == 0)
            {
                return null;
            }
            else
            {
                return _creatureAttacks.Where(ca => ca.AttackID == attackID).ToList();
            }
        }

        public IEnumerable<CreatureAttacks> GetByCreatureID(int creatureID)
        {
            if (_creatureAttacks.Where(ca => ca.CreatureID == creatureID).Count() == 0)
            {
                return null;
            }
            else
            {
                return _creatureAttacks.Where(ca => ca.CreatureID == creatureID).ToList();
            }
        }
    }
}
