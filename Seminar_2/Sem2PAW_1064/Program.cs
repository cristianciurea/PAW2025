using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1064
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicul v1 = new Vehicul();
            Vehicul v2 = new Vehicul(2023, "Dacia", 14999.9f);
            Vehicul v3 = new Vehicul(v2);
            Vehicul v4 = (Vehicul)v2.Clone();
            v3.AnFabricatie = 2024;
            v4.Marca = "Mercedes";

            Automobil a1 = new Automobil(2021, "Opel", 22500, "benzina", true);
            Motocicleta m1 = new Motocicleta(2022, "Honda", 8000, 500, false);

            List<Vehicul> listaVehicule = new List<Vehicul>();
            listaVehicule.Add(v1);
            listaVehicule.Add(v2);
            listaVehicule.Add(v3);
            listaVehicule.Add(v4);
            listaVehicule.Add(a1);
            listaVehicule.Add(m1);
            listaVehicule.Sort();
            foreach (Vehicul v in listaVehicule)
                Console.WriteLine(v);

            ParcAuto p1 = new ParcAuto();
            p1.Lista = listaVehicule;
            Console.WriteLine(p1);

            ParcAuto p2 = (ParcAuto)p1.Clone();
            p2.Adresa = "Timisoara";
            foreach (Vehicul v in p1.Lista)
                v.Marca += " copie";

            Motocicleta m2 = new Motocicleta(2020, "Yamaha", 7500, 600, false);
            p1 = p1 + m2;
            p2 += m2;

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine("Pretul mediu al vehiculelor din p2 este {0}", (float)p2);
        }
    }
}
