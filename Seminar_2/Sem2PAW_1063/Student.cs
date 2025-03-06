using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1063
{
    class Student: Persoana
    {
        private bool areBursa;
        private float medie;

        public Student():base()
        {
            areBursa = true;
            medie = 0.0f;
        }

        public Student(int v, string n, char s, bool are, float m):base(v,n,s)
        {
            areBursa = are;
            medie = m;
        }

        public bool AreBursa { get => areBursa; set => areBursa = value; }
        public float Medie { get => medie; set => medie = value; }

        public override string ToString()
        {
            return base.ToString() + " si media " +
                medie + " si are bursa " + areBursa;
        }
    }
}
