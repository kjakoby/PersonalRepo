using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Models.Tables
{
    public class Creature
    {
        public int CreatureID { get; set; }
        public int CreatureHP { get; set; }
        public string CreatureName { get; set; }
        public int? TypeID { get; set; }
        public bool Boss { get; set; }
        public string CreaturePic { get; set; }
        public string CreatureInfo { get; set; }
    }
}
