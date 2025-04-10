using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem7PAW_1064
{
    public partial class Form2 : Form
    {
        List<Restaurant> lista2;
        public Form2(List<Restaurant> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                string denumire = tbDenumire.Text;
                string adresa = tbAdresa.Text;
                int nrAng = Convert.ToInt32(tbNrAngajati.Text);
                float cifraAfaceri = (float)Convert.ToDouble(tbCifraAfaceri.Text);
                Restaurant r = new Restaurant(cod, denumire, adresa, nrAng, cifraAfaceri);
                lista2.Add(r);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                tbDenumire.Clear();
                tbAdresa.Clear();
                tbNrAngajati.Clear();
                tbCifraAfaceri.Clear();
            }
        }
    }
}
