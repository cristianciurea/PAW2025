using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem7PAW_1063
{
    public class Masina
    {
        public int codVIN;
        public string marca;
        public int capacitateCilindrica;
        public float pret;

        public Masina(int cod, string m, int cc, float p)
        {
            codVIN = cod;
            marca = m;
            capacitateCilindrica = cc;
            pret = p;
        }

        public override string ToString()
        {
            return "Masina " + marca + " cu codul " + codVIN + " si capacitatea cilindrica " +
                capacitateCilindrica + " are pretul " + pret;
        }
    }
}
