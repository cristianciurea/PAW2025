using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1063
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(100, 'M', 21, "Gigel",
                new int[3] { 7, 8, 9 });
            Student s3 = (Student)s2.Clone();
            s3.Nume = "Dorel";
            s3 += 10;
            s3 = 5 + s3;
            Console.WriteLine("Media notelor lui s2: {0}", (float)s2);
            Console.WriteLine("Media notelor lui s3: {0}", s3.calculeazaMedie());
            s3[2] = 3;
            Console.WriteLine("A 3-a nota a lui s3 este: {0}", s3[2]);
            s1.Note = new int[3] { 5, 6, 7 };

            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Sort();
            foreach (Student s in listaStud)
                Console.WriteLine(s);
        }
    }
}
