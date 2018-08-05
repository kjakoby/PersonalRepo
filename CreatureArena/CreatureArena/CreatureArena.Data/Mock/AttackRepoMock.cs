using CreatureArena.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatureArena.Models.Tables;

namespace CreatureArena.Data.Mock
{
    public class AttackRepoMock : IAttackRepo
    {
        private static List<Attack> _attacks = new List<Attack>
        {
            new Attack
            {AttackID=1, AttackName="MockAName1", AttackDamage=10, TypeID=1},
            new Attack
            {AttackID=2, AttackName="MockAName2", AttackDamage=20, TypeID=1},
            new Attack
            {AttackID=3, AttackName="MockAName3", AttackDamage=10, TypeID=2},
            new Attack
            {AttackID=4, AttackName="MockAName4", AttackDamage=20, TypeID=2},
            new Attack
            {AttackID=5, AttackName="MockAName5", AttackDamage=10, TypeID=3},
            new Attack
            {AttackID=6, AttackName="MockAName6", AttackDamage=20, TypeID=3}
        };

        public List<Attack> GetAll()
        {
            return _attacks;
        }

        public Attack GetByID(int attackID)
        {
            if (_attacks.Where(a => a.AttackID == attackID).Count() == 0)
            {
                return null;
            }
            else
            {
                return _attacks.FirstOrDefault(a => a.AttackID == attackID);
            }
        }

        public IEnumerable<Attack> GetByTypeID(int typeID)
        {
            if (_attacks.Where(a => a.TypeID == typeID).Count() == 0)
            {
                return null;
            }
            else
            {
                return _attacks.Where(a => a.TypeID == typeID).ToList();
            }
        }
    }
}
