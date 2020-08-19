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
        public Horseman(string naam, string leeftijd, string tyype,string horse) : base(naam, leeftijd,tyype)
        {
            Horse = horse;
        }
        public override string Beschrijft()
        {
            return base.Beschrijft() + $"\nDiens is horsmen en uw horse {Horse} is.";
        }
    }
}
