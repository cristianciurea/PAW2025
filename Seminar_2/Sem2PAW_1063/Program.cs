using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1063
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoana p1 = new Persoana();
            Persoana p2 = new Persoana(21, "Gigel", 'M');
            Persoana p3 = new Persoana(p2); //constructor copiere
            Persoana p4 = (Persoana)p2.Clone(); //apel metoda Clone()
            p3.Nume = "Dorel";
            p4.Sex = 'F';
            p2.Varsta = 25;

            Student s1 = new Student(23, "Vasile", 'M', true, 9.5f);
            Invitat i1 = new Invitat(27, "Maricica", 'F', "doctorand", true);

            List<Persoana> listaPers = new List<Persoana>();
            listaPers.Add(p1);
            listaPers.Add(p2);
            listaPers.Add(p3);
            listaPers.Add(p4);
            listaPers.Add(s1);
            listaPers.Add(i1);
            listaPers.Sort();
            foreach (Persoana p in listaPers)
                Console.WriteLine(p);

            Conferinta conf1 = new Conferinta();
            conf1.ListaPersoane = listaPers;
            Console.WriteLine(conf1);

            Conferinta conf2 = (Conferinta)conf1.Clone();
            foreach (Persoana p in conf1.ListaPersoane)
                p.Nume += " copie";
            conf2.Denumire = "ICBE 2024";

            Invitat i2 = new Invitat(24, "Ion", 'M', "masterand", false);
            conf2 = conf2 + i2;
            conf1 += i2;

            Console.WriteLine(conf1);
            Console.WriteLine(conf2);

            Console.WriteLine("Varsta medie a participantilor este {0}", (float)conf2);

        }
    }
}
