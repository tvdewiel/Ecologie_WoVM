using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_WoVM.Domein
{
    public class Waarneming
    {
        public Waarneming(DateTime datum, int aantal, Diersoort diersoort, Natuurgebied natuurgebied, Onderzoeker onderzoeker)
        {
            Datum = datum;
            Aantal = aantal;
            Diersoort = diersoort;
            Natuurgebied = natuurgebied;
            Onderzoeker = onderzoeker;
        }

        public DateTime Datum { get; set; }
        public int Aantal { get; set; }
        public Diersoort Diersoort { get; set; }
        public Natuurgebied Natuurgebied { get; set; }
        public Onderzoeker Onderzoeker { get; set; }
    }
}
