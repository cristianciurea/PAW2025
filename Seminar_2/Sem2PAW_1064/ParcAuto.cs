using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1064
{
    class ParcAuto: ICloneable
    {
        private string adresa;
        private List<Vehicul> lista;

        public ParcAuto()
        {
            adresa = "Bucuresti";
            lista = new List<Vehicul>();
        }

        public string Adresa { get => adresa; set => adresa = value; }
        internal List<Vehicul> Lista { get => lista; set => lista = value; }

        public object Clone()
        {
            ParcAuto clona = (ParcAuto) this.MemberwiseClone();
            List<Vehicul> listaClona = new List<Vehicul>();
            foreach (Vehicul v in lista)
                listaClona.Add((Vehicul)v.Clone());
            clona.lista = listaClona;
            return clona;
        }

        public static ParcAuto operator+(ParcAuto p, Vehicul v)
        {
            p.lista.Add(v);
            return p;
        }

        public static ParcAuto operator+(Vehicul v, ParcAuto p)
        {
            return p + v;
        }

        public static explicit operator float(ParcAuto p)
        {
            float total = 0.0f;
            foreach (Vehicul v in p.lista)
                total += v.Pret;
            return total / p.lista.Count;
        }

        public override string ToString()
        {
            string rezultat = "Parcul auto de la adresa " + adresa +
                " are urmatoarele vehicule: " + Environment.NewLine;
            foreach (Vehicul v in lista)
                rezultat += v.ToString() + Environment.NewLine;
            return rezultat;
        }
    }
}
