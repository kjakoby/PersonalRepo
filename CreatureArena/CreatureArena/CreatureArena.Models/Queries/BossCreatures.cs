using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Models.Queries
{
    public class BossCreatures
    {
        public int CreatureID { get; set; }
        public string CreaturePic { get; set; }
        public string CreatureName { get; set; }
        public string CreatureInfo { get; set; }
        public bool Boss { get; set; }
    }
}
