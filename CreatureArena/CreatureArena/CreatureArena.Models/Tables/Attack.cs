using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatureArena.Models.Tables
{
    public class Attack
    {
        public int AttackID { get; set; }
        public string AttackName { get; set; }
        public int AttackDamage { get; set; }
        public int? TypeID { get; set; }
    }
}
