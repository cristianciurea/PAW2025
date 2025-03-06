using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1064
{
    class Vehicul: ICloneable, IComparable
    {
        private int anFabricatie;
        private string marca;
        private float pret;

        public Vehicul()
        {
            anFabricatie = 0;
            marca = "nespecificat";
            pret = 0.0f;
        }

        public Vehicul(int an, string m, float p)
        {
            this.anFabricatie = an;
            this.marca = m;
            this.pret = p;
        }

        public Vehicul(Vehicul v)
        {
            anFabricatie = v.anFabricatie;
            marca = v.marca;
            pret = v.pret;
        }

        public int AnFabricatie
        {
            get { return anFabricatie; }
            set { if (value > 0) anFabricatie = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { if (value != null) marca = value; }
        }

        public float Pret
        {
            get { return pret; }
            set { pret = value; }
        }

        public override string ToString()
        {
            return "Vehiculul " + marca + " are anul fabricatiei " + anFabricatie +
                " si pretul " + pret;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Vehicul v = (Vehicul)obj;
            if (this.anFabricatie < v.anFabricatie)
                return -1;
            else
                if (this.anFabricatie > v.anFabricatie)
                return 1;
            else
                return string.Compare(this.marca, v.marca);
        }
    }
}
