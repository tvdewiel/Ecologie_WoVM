using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_WoVM.Domein
{
    public class Natuurgebied
    {
        public Natuurgebied(string id, string nederlandseNaam, string locatie, double oppervlakte)
        {
            Id = id;
            NederlandseNaam = nederlandseNaam;
            Locatie = locatie;
            Oppervlakte = oppervlakte;
        }

        public string Id { get; set; }
        public string NederlandseNaam { get; set; }
        public string Locatie {  get; set; }
        public double Oppervlakte { get; set; } //hectare
        private List<AnderstaligeNaam> _namen = new();
        public IReadOnlyList<AnderstaligeNaam> Namen { get { return _namen; } }
        public void VoegNaamToe(AnderstaligeNaam naam)
        {
            _namen.Add(naam);
        }
    }
}
