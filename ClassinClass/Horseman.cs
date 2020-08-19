using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassinClass
{
    public class Horseman : Type
    {
        public string Horse { get; set; }
        public Horseman(string naam, string level, string tyype,string horse) : base(naam, level, tyype)
        {
            Horse = horse;
        }
        public override string Beschrijft()
        {
            return base.Beschrijft() + $"\nDiens is horsmen en uw horse {Horse} is.";
        }
    }
}
