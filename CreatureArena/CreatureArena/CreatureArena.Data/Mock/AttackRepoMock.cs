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
            //new Attack
            //{AttackID=1, AttackName="MockAName1", AttackDamage=1, TypeID= }
        };

        public List<Attack> GetAll()
        {
            return _attacks;
        }

        public Attack GetByID(int attackID)
        {
            throw new NotImplementedException();
        }
    }
}
