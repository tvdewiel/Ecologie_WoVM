using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_WoVM.Domein
{
    public class Diersoort
    {
        public Diersoort(string nederlandseNaam, bool bedreigd)
        {
            NederlandseNaam = nederlandseNaam;
            Bedreigd = bedreigd;
        }

        public string NederlandseNaam {  get; set; }
        public string WetenschappelijkeNaam { get; set; }
        public bool Bedreigd {  get; set; }
        private List<AnderstaligeNaam> _namen = new();
        public IReadOnlyList<AnderstaligeNaam> Namen { get { return _namen; } }
        public override string ToString()
        {
            return $"Naam is {NederlandseNaam}, wetenschappelijke naam is {WetenschappelijkeNaam}, bedreigd is {Bedreigd} en heeft {_namen.Count} anderstalige namen";
        }
        public void VoegNaamToe(AnderstaligeNaam naam)
        {
            _namen.Add(naam);
        }
    }
}
