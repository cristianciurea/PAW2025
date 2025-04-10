using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sem7PAW_1063
{
    public partial class Form1 : Form
    {
        List<Masina> listaMasini = new List<Masina>();
        public Form1()
        {
            InitializeComponent();
            listaMasini.Add(new Masina(1234, "Dacia", 1600, 14999));
            listaMasini.Add(new Masina(4567, "Mercedes", 2000, 34999));
            listView1.Columns.Add("Observatii");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Masina m in listaMasini)
            {
                ListViewItem itm = new ListViewItem(m.codVIN.ToString());
                itm.SubItems.Add(m.marca);
                itm.SubItems.Add(m.capacitateCilindrica.ToString());
                itm.SubItems.Add(m.pret.ToString());
                if (m.pret >= 15000)
                    itm.SubItems.Add("program rabla plus");
                else
                    itm.SubItems.Add("program rabla");
                listView1.Items.Add(itm);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while((linie = sr.ReadLine())!=null)
            {
                int cod = Convert.ToInt32(linie.Split('|')[0]);
                string marca = linie.Split('|')[1];
                int cc = Convert.ToInt32(linie.Split('|')[2]);
                float pret = (float)Convert.ToDouble(linie.Split('|')[3]);
                Masina m = new Masina(cod, marca, cc, pret);
                listaMasini.Add(m);
            }
            sr.Close();
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Checked)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaMasini.Count; i++)
                        if (cod == listaMasini[i].codVIN)
                            listaMasini.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaMasini.Count; i++)
                        if (cod == listaMasini[i].codVIN)
                            listaMasini.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            foreach(Masina m in listaMasini)
            {
                sw.Write(m.codVIN);
                sw.Write("|");
                sw.Write(m.marca);
                sw.Write("|");
                sw.Write(m.capacitateCilindrica);
                sw.Write("|");
                sw.Write(m.pret);
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Date exportate!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaMasini);
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(listaMasini);
            frm.ShowDialog();
        }
    }
}
