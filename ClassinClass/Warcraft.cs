using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassinClass
{
    public class Warcraft
    {
        public string Naam { get; set; }
        public string Level{ get; set; }
       
        public Warcraft(string naam, string level)
        {
            Naam = naam;
            Level = level;
           
        }
        public virtual string Beschrijft()
        {
            return $"Wiens naam is {Naam}. Diens level is {Level}.";
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
