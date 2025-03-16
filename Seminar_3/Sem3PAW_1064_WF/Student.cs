﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1064_WF
{
    class Student: Persoana, IMedia, ICloneable, IComparable
    {
        private int varsta;
        private string nume;
        private int[] note;

        public Student():base()
        {
            varsta = 0;
            nume = "Anonim";
            note = null;
        }

        public Student(int c, char s, int v, string n, int[] nt):
            base(c, s)
        {
            varsta = v;
            nume = n;
            //var 1
            /*note = new int[nt.Length];
            for (int i = 0; i < nt.Length; i++)
                note[i] = nt[i];*/
            //var 2
            note = (int[])nt.Clone();
        }

        public int Varsta { get => varsta; set => varsta = value; }
        public string Nume { get => nume; set => nume = value; }
        public int[] Note { get => note; set => note = value; }

        public float calculeazaMedie()
        {
            float total = 0.0f;
            if (note != null)
            {
                for (int i = 0; i < note.Length; i++)
                    total += note[i];
                return total / note.Length;
            }
            else
                return -1;
        }

        public object Clone()
        {
            Student clona = (Student)this.MemberwiseClone();
            int[] noteClona = (int[])note.Clone();
            clona.note = noteClona;
            return clona;
        }

        public int CompareTo(object obj)
        {
            Student s = (Student)obj;
            if (this.calculeazaMedie() < s.calculeazaMedie())
                return -1;
            else
                if (this.calculeazaMedie() > s.calculeazaMedie())
                return 1;
            else
                return string.Compare(this.nume, s.nume);
        }

        public override string spuneAnNastere()
        {
            return (System.DateTime.Now.Year - varsta).ToString();
        }

        public override string ToString()
        {
            string rezultat = base.ToString()+" si are varsta "+varsta+
                " si numele "+nume;
            if (note == null)
                rezultat += " si nu are note";
            else
            {
                rezultat += " si are urmatoarele note: " + Environment.NewLine;
                for (int i = 0; i < note.Length; i++)
                    rezultat += note[i] + ", ";
            }
            return rezultat;
        }

        public static Student operator+(Student s, int notaNoua)
        {
            int[] noteNoi = new int[s.Note.Length + 1];
            for (int i = 0; i < s.note.Length; i++)
                noteNoi[i] = s.note[i];
            noteNoi[noteNoi.Length - 1] = notaNoua;
            s.note = noteNoi;
            return s;
        }

        public static Student operator+(int notaNoua, Student s)
        {
            return s + notaNoua;
        }

        public static explicit operator float(Student s)
        {
            return s.calculeazaMedie();
        }

        public int this[int index]
        {
            get
            {
                if (note != null && index >= 0 && index < note.Length)
                    return note[index];
                else
                    return -1;
            }
            set
            {
                if (note != null && index >= 0 && index < note.Length
                    && value >= 1 && value <= 10)
                    note[index] = value;
            }
        }
    }
}
