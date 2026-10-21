using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_WoVM.Domein
{
    public class AnderstaligeNaam
    {
        public AnderstaligeNaam(string naam, string taalcode)
        {
            Naam = naam;
            Taalcode = taalcode;
        }

        public string Naam {  get; set; }
        public string Taalcode { get; set; }
        public override string ToString()
        {
            return $"De naam is {Naam}, taal code is {Taalcode}";
        }
    }
}
