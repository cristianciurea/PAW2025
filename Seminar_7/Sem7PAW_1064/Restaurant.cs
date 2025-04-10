using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem7PAW_1064
{
    public class Restaurant
    {
        public int cod;
        public string denumire;
        public string adresa;
        public int nrAngajati;
        public float cifraAfaceri;

        public Restaurant(int c, string d, string a, int nr, float ca)
        {
            cod = c;
            denumire = d;
            adresa = a;
            nrAngajati = nr;
            cifraAfaceri = ca;
        }
    }
}
