using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecologie_WoVM.Domein
{
    public class Onderzoeker
    {
        public Onderzoeker(int id, string naam, string email)
        {
            Id = id;
            Naam = naam;
            Email = email;
        }

        public int Id { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }
    }
}
