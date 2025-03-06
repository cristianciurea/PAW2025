using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1064
{
    class Automobil: Vehicul
    {
        private string tipMotorizare;
        private bool areITP;

        public Automobil():base()
        {
            tipMotorizare = "electric";
            areITP = true;
        }

        public Automobil(int an, string m, float p, string tip, bool are):
            base(an, m, p)
        {
            tipMotorizare = tip;
            areITP = are;
        }

        public string TipMotorizare { get => tipMotorizare; set => tipMotorizare = value; }
        public bool AreITP { get => areITP; set => areITP = value; }

        public override string ToString()
        {
            return base.ToString() + " si tip motorizare "+tipMotorizare+
                " si are ITP "+areITP;
        }


    }
}
