using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Models.Queries
{
    public class AllCreaturesItem
    {
        public int CreatureID { get; set; }
        public string CreatureName { get; set; }
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public int CreatureHP { get; set; }
        public bool Boss { get; set; }
        public int StrengthID { get; set; }
        public int WeaknessID { get; set; }
        public string StrengthName { get; set; }
        public string WeaknessName { get; set; }
    }
}
