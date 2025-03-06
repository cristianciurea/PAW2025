using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1064
{
    class Motocicleta: Vehicul
    {
        private int capacitateCilindrica;
        private bool areAtas;

        public Motocicleta():base()
        {
            capacitateCilindrica = 0;
            areAtas = false;
        }

        public Motocicleta(int an, string m, float p, int cc, bool are)
            :base(an, m, p)
        {
            capacitateCilindrica = cc;
            areAtas = are;
        }

        public int CapacitateCilindrica { get => capacitateCilindrica; set => capacitateCilindrica = value; }
        public bool AreAtas { get => areAtas; set => areAtas = value; }

        public override string ToString()
        {
            return base.ToString()+" si capacitate cilindrica "+capacitateCilindrica+
                " si are atas "+areAtas;
        }
    }
}
