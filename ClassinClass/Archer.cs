using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassinClass
{
    public class Archer: Type
    {
        public string Bow { get; set; }
        //public List<string> bows = new List<string> { "ice crosbow", "fire crosbow", "icebow longbow","fire };
        public Archer(string naam, string level, string tyype,string bow) : base(naam, level, tyype)
        {
            Bow = bow;
        }
        public override string Beschrijft()
        {
            return base.Beschrijft() + $"\nDiens is een archer, en diens heeft {Bow}.";
        }
    }
}
