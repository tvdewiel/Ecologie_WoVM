using Ecologie_WoVM.Beheerders;
using Ecologie_WoVM.Domein;

namespace Ecologie_WoVM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //AnderstaligeNaam naamEngels;
            //naamEngels = new AnderstaligeNaam("Fox","Eng");

            //Diersoort vos=new Diersoort("Vos",false);
            //vos.VoegNaamToe(naamEngels);

            //Console.WriteLine($"{vos}");

            ////UC : registreernatuurgebied
            //Console.WriteLine("geef id :");
            //string id=Console.ReadLine();
            //Console.WriteLine("geef naam :");
            //string naam=Console.ReadLine();
            //Console.WriteLine("geef locatie :");
            //string locatie=Console.ReadLine();
            //Console.WriteLine("geef oppervlakte :");
            //double oppervlakte=Double.Parse(Console.ReadLine());

            //Natuurbeheerder natuurbeheerder=new Natuurbeheerder(); 
            //natuurbeheerder.RegistreerNatuurgebied(id,naam, locatie, oppervlakte);
            Natuurbeheerder natuurbeheerder=new Natuurbeheerder();
            Natuurgebied x = natuurbeheerder.SelecteerNatuurgebied("A7");

            Console.WriteLine("einde");
        }
    }
}
