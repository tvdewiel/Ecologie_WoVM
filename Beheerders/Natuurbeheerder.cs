using Ecologie_WoVM.Domein;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_WoVM.Beheerders
{
    public class Natuurbeheerder
    {
        private Dictionary<string,Natuurgebied> natuurgebieden = new(); //databank later

        public Natuurbeheerder()
        {
            natuurgebieden.Add("A1", new Natuurgebied("A1", "Het Zwin", "Brugge", 20));
            natuurgebieden.Add("A7", new Natuurgebied("A7", "Bourgoyen", "Gent", 12));
        }

        public Natuurgebied RegistreerNatuurgebied(string id,string nedNaam,string locatie,double oppervlakte)
        {
            Natuurgebied natuurgebied=new Natuurgebied(id,nedNaam,locatie,oppervlakte);
            natuurgebieden.Add(id,natuurgebied);
            return natuurgebied;
        }
        public Natuurgebied SelecteerNatuurgebied(string id)
        {
            return natuurgebieden[id];
        }
    }
}
