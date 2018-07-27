using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Models.Tables
{
    public class Type
    {
        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public string TypeIcon { get; set; }
        public int TypeWeakness { get; set; }
        public int TypeStrength { get; set; }
    }
}
