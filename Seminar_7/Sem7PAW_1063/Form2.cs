using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem7PAW_1063
{
    public partial class Form2 : Form
    {
        List<Masina> lista2;
        public Form2(List<Masina> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                string marca = tbMarca.Text;
                int cc = Convert.ToInt32(tbCapacitate.Text);
                float pret = (float)Convert.ToDouble(tbPret.Text);
                Masina m = new Masina(cod, marca, cc, pret);
                lista2.Add(m);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbCod.Clear();
                tbMarca.Clear();
                tbCapacitate.Clear();
                tbPret.Clear();
            }
        }
    }
}
