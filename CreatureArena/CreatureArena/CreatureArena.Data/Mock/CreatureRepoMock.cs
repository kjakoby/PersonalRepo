using CreatureArena.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreatureArena.Models.Tables;
using CreatureArena.Models.Queries;

namespace CreatureArena.Data.Mock
{
    public class CreatureRepoMock : ICreatureRepo
    {
        public static List<AllCreaturesItem> _allCreatures = new List<AllCreaturesItem>
        {
            new AllCreaturesItem
            {CreatureID=1, CreatureName="MockCName1", TypeID=1, TypeName="MockTName1", CreatureHP=100, Boss=true, StrengthID=2, WeaknessID=3, StrengthName="MockStrength1", WeaknessName="MockWeakness1" },
            new AllCreaturesItem
            {CreatureID=2, CreatureName="MockCName2", TypeID=2, TypeName="MockTName2", CreatureHP=100, Boss=true, StrengthID=3, WeaknessID=1, StrengthName="MockStrength2", WeaknessName="MockWeakness2" },
            new AllCreaturesItem
            {CreatureID=3, CreatureName="MockCName3", TypeID=3, TypeName="MockTName3", CreatureHP=100, Boss=true, StrengthID=1, WeaknessID=2, StrengthName="MockStrength3", WeaknessName="MockWeakness3" }
        };

        public static List<BossCreatures> _CreaturesToSearch = new List<BossCreatures>
        {
            new BossCreatures
            {CreatureID=1, CreatureName="MockCName1", CreaturePic="placeholder.jpg", CreatureInfo="MockInfo1MockInfo1MockInfo1MockInfo1MockInfo1", Boss=true },
            new BossCreatures
            {CreatureID=2, CreatureName="MockCName2", CreaturePic="placeholder.jpg", CreatureInfo="MockInfo2MockInfo2MockInfo2MockInfo2MockInfo2" , Boss=false},
            new BossCreatures
            {CreatureID=3, CreatureName="MockCName3", CreaturePic="placeholder.jpg", CreatureInfo="MockInfo3MockInfo3MockInfo3MockInfo3MockInfo3", Boss=true},
            new BossCreatures
            {CreatureID=4, CreatureName="MockCName4", CreaturePic="placeholder.jpg", CreatureInfo="MockInfo4MockInfo4MockInfo4MockInfo4MockInfo4", Boss=true},
        };

        public List<Creature> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BossCreatures> GetBosses()
        {
            var foundBosses = _CreaturesToSearch.Where(c => c.Boss == true);
            if (foundBosses.Count() == 0)
            {
                return null;
            }
            else
            {
                return foundBosses;
            }
        }

        public Creature GetByID(int creatureID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AllCreaturesItem> GetCreatureDirectory()
        {
            return _allCreatures;

            //return MockCreatureRepo.GetCreatureDirectory();
        }

        public AllCreaturesItem GetSingleCreature(int creatureID)
        {
            if (_allCreatures.Where(c=>c.CreatureID==creatureID).Count()==0)
            {
                return null;
            }
            else
            {
                return _allCreatures.FirstOrDefault(c => c.CreatureID == creatureID);
            }
        }
    }
}
