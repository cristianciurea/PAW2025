using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1PAW_1064
{
    class Student
    {
        public int varsta;
        private string nume;
        protected float medie;

        public Student()
        {
            varsta = 0;
            nume = "Anonim";
            medie = 0.0f;
        }

        public Student(int v, string n, float m)
        {
            varsta = v;
            nume = n;
            medie = m;
        }

        public Student(Student s)
        {
            varsta = s.varsta;
            nume = s.nume;
            medie = s.medie;
        }

        public void afisare()
        {
            Console.WriteLine("Studentul {0} are varsta {1} si media {2}",
                nume, varsta, medie);
        }

        public override string ToString()
        {
            return "Studentul "+nume+" are varsta "+varsta+" si media "+medie;
        }
    }
}
