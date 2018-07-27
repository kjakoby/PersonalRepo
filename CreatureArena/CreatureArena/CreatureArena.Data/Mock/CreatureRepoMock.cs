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
    //public class MockCreatureRepo
    //{
    //    private static List<AllCreaturesItem> _allCreatures = new List<AllCreaturesItem>
    //    {
    //        new AllCreaturesItem
    //        {CreatureID=1, CreatureName="MockCName1", TypeID=1, TypeName="MockTName1", CreatureHP=100, Boss=true, StrengthID=2, WeaknessID=3, StrengthName="MockStrength1", WeaknessName="MockWeakness1" },
    //        new AllCreaturesItem
    //        {CreatureID=2, CreatureName="MockCName2", TypeID=2, TypeName="MockTName2", CreatureHP=100, Boss=true, StrengthID=3, WeaknessID=1, StrengthName="MockStrength2", WeaknessName="MockWeakness2" },
    //        new AllCreaturesItem
    //        {CreatureID=3, CreatureName="MockCName3", TypeID=3, TypeName="MockTName3", CreatureHP=100, Boss=true, StrengthID=1, WeaknessID=2, StrengthName="MockStrength3", WeaknessName="MockWeakness3" }
    //    };

    //    public static List<AllCreaturesItem> GetCreatureDirectory()
    //    {
    //        return _allCreatures;
    //    }
    //}


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

        public List<Creature> GetAll()
        {
            throw new NotImplementedException();
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
