using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1063
{
    class Conferinta: ICloneable
    {
        private string denumire;
        private List<Persoana> listaPersoane;

        public Conferinta()
        {
            denumire = "IE 2025";
            listaPersoane = new List<Persoana>();
        }

        public override string ToString()
        {
            string rezultat = "Conferinta " + denumire +
                " are urmatorii participanti: " + Environment.NewLine;
            foreach (Persoana p in listaPersoane)
                rezultat += p.ToString() + Environment.NewLine;
            return rezultat;
        }

        public object Clone()
        {
            Conferinta clona = (Conferinta) this.MemberwiseClone();
            List<Persoana> listaClona = new List<Persoana>();
            foreach (Persoana p in listaPersoane)
                listaClona.Add((Persoana)p.Clone());
            clona.listaPersoane = listaClona;
            return clona;
        }

        public static Conferinta operator+(Conferinta c, Persoana p)
        {
            c.listaPersoane.Add(p);
            return c;
        }

        public static Conferinta operator+(Persoana p, Conferinta c)
        {
            return c + p;
        }

        public static explicit operator float(Conferinta c)
        {
            float total = 0.0f;
            foreach (Persoana p in c.listaPersoane)
                total += p.Varsta;
            return total / c.listaPersoane.Count;
        }

        public string Denumire { get => denumire; set => denumire = value; }
        internal List<Persoana> ListaPersoane { get => listaPersoane; set => listaPersoane = value; }
    }
}
