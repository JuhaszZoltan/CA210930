using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA210930
{
    class Felhasznalo
    {
        public string Nev { get; set; }
        public DateTime SzuletesiDatum { get; set; }
        public List<int> AlkalmazasfejlesztesJegyek { get; set; }
        public int Eletkor => DateTime.Now.Year - SzuletesiDatum.Year;

        private string _jelszo = null;
        public string Jelszo
        {
            set
            {
                _jelszo = value;
            }
        }

        public Felhasznalo(string nev, DateTime szuletesiDatum)
        {
            Nev = nev;
            SzuletesiDatum = szuletesiDatum;
            AlkalmazasfejlesztesJegyek = new List<int>();
        }
    }

    class Program
    {
        static void Main()
        {
            var f = new Felhasznalo(
                nev: "Füty Imre",
                szuletesiDatum: new DateTime(2000, 07, 11));

            f.AlkalmazasfejlesztesJegyek.Add(5);

            Console.WriteLine(f.Eletkor);
            //nem engedi:
            //f.Eletkor = 40;

            Console.Write("írd be a jelszót: ");
            f.Jelszo = Console.ReadLine();

            Console.Write("a jelszavad: ");
            //nem engedi:
            //Console.WriteLine(f.Jelszo);

            Console.ReadKey();
        }
    }
}
