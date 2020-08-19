using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassinClass
{
    public class Heroes : Type
    {
       
        public string SuperPower { get; set; }


        public Heroes(string naam, string leeftijd, string tyype,string superpower) :base(naam , leeftijd,tyype)
        {
            SuperPower = superpower;

        }
        public override string Beschrijft()
        {
            return base.Beschrijft()+ $"\nDiens een Hero.\n" +
                $" Diens super power is {SuperPower} ";
        }
    }
}
