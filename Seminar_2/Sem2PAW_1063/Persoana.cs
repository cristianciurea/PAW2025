using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2PAW_1063
{
    class Persoana: ICloneable, IComparable
    {
        private int varsta;
        private string nume;
        private char sex;

        public Persoana()
        {
            varsta = 0;
            nume = "Anonim";
            sex = 'F';
        }

        public Persoana(int v, string n, char s)
        {
            varsta = v;
            nume = n;
            sex = s;
        }

        public Persoana(Persoana p)
        {
            varsta = p.varsta;
            nume = p.nume;
            sex = p.sex;
        }

        public override string ToString()
        {
            return "Persoana " + nume + " are varsta " 
                + varsta + " si sexul " + sex;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Persoana p = (Persoana)obj;
            if (this.varsta < p.varsta)
                return -1;
            else
                if (this.varsta > p.varsta)
                return 1;
            else
                return string.Compare(this.nume, p.nume);
        }

        public int Varsta
        {
            get { return varsta; }
            set { if (value >= 0) varsta = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

        public char Sex
        {
            get { return sex; }
            set { if (value != null) sex = value; }
        }
    }
}
