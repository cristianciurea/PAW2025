using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem6PAW_1063
{
    class Produs
    {
        private string denumire;
        private float pret;
        private float cantitate;

        public Produs(string den, float p, float cant)
        {
            denumire = den;
            pret = p;
            cantitate = cant;
        }

        public override string ToString()
        {
            return "Produsul " + denumire + " are pretul " + pret +
                " si cantitatea " + cantitate;
        }

        public string Denumire { get => denumire; set => denumire = value; }
        public float Pret { get => pret; set => pret = value; }
        public float Cantitate { get => cantitate; set => cantitate = value; }
    }
}
