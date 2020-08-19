using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassinClass
{
    public class Type : Warcraft
    {
        public string Tyype { get; set; }
        public Type(string naam, string leeftijd,string tyype) : base(naam, leeftijd)
        {
            Tyype = tyype;
        }
        public override string Beschrijft()
        {
            return base.Beschrijft() + $"\nDiens is een {Tyype}.";
        }

    }
}
