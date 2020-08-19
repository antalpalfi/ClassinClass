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
        public string Leeftijd { get; set; }
       
        public Warcraft(string naam, string leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
           
        }
        public virtual string Beschrijft()
        {
            return $"Wiens naam is {Naam}. Diens leeftijd is {Leeftijd}.";
        }
        public override string ToString()
        {
            return Naam;
        }
    }
}
