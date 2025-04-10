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

namespace Sem7PAW_1064
{
    public partial class Form1 : Form
    {
        List<Restaurant> listaRestaurante = new List<Restaurant>();
        public Form1()
        {
            InitializeComponent();
            listView1.Columns.Add("Observatii");
            listaRestaurante.Add(new Restaurant(100, "Benvenutto", "Calea Bucuresti 123", 17, 195000));
            listaRestaurante.Add(new Restaurant(200, "BellaVitta", "Calea Constantei 112", 9, 154000));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Restaurant r in listaRestaurante)
            {
                ListViewItem itm = new ListViewItem(r.cod.ToString());
                itm.SubItems.Add(r.denumire);
                itm.SubItems.Add(r.adresa);
                itm.SubItems.Add(r.nrAngajati.ToString());
                itm.SubItems.Add(r.cifraAfaceri.ToString());
                if (r.cifraAfaceri >= 100000)
                    itm.SubItems.Add("cifra afaceri mare");
                else
                    itm.SubItems.Add("cifra afaceri mica");
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
                string denumire = linie.Split('|')[1];
                string adresa = linie.Split('|')[2];
                int nrAng = Convert.ToInt32(linie.Split('|')[3]);
                float cifraAfaceri = (float)Convert.ToDouble(linie.Split('|')[4]);
                Restaurant r = new Restaurant(cod, denumire, adresa, nrAng, cifraAfaceri);
                listaRestaurante.Add(r);
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
                    for (int i = 0; i < listaRestaurante.Count; i++)
                        if (cod == listaRestaurante[i].cod)
                            listaRestaurante.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
                if (itm.Selected)
                {
                    int cod = Convert.ToInt32(itm.SubItems[0].Text);
                    for (int i = 0; i < listaRestaurante.Count; i++)
                        if (cod == listaRestaurante[i].cod)
                            listaRestaurante.RemoveAt(i);
                    itm.Remove();
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("fisier.txt");
            foreach(Restaurant r in listaRestaurante)
            {
                sw.Write(r.cod);
                sw.Write("|");
                sw.Write(r.denumire);
                sw.Write("|");
                sw.Write(r.adresa);
                sw.Write("|");
                sw.Write(r.nrAngajati);
                sw.Write("|");
                sw.Write(r.cifraAfaceri);
                sw.WriteLine();
            }
            sw.Close();
            MessageBox.Show("Date exportate!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaRestaurante);
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3(listaRestaurante);
            frm.ShowDialog();
        }
    }
}
