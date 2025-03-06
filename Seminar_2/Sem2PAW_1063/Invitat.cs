using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1063
{
    class Invitat: Persoana
    {
        private string categorie;
        private bool areGratuitate;

        public Invitat():base()
        {
            this.categorie = "nespecificat";
            this.areGratuitate = false;
        }

        public Invitat(int v, string n, char s, string c, bool are):base(v,n,s)
        {
            this.categorie = c;
            this.areGratuitate = are;
        }

        public string Categorie { get => categorie; set => categorie = value; }
        public bool AreGratuitate { get => areGratuitate; set => areGratuitate = value; }

        public override string ToString()
        {
            return base.ToString() + " si este din categoria "+categorie+
                " si are gratuitate "+areGratuitate;
        }
    }
}
