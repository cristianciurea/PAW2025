using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(100, 'M', 21, "Gigel",
                new int[3] { 7, 8, 9 });
            Student s3 = (Student)s2.Clone();
            s3.Nume = "Ionel";
            s3 += 1;
            s3 = 9 + s3;
            s3[2] = 5;

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
