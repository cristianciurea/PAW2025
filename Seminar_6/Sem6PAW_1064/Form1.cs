using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem6PAW_1064
{
    public partial class Form1 : Form
    {
        ArrayList listaTb = new ArrayList();
        ArrayList listaProd = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            listaTb.Add(tbDenumire);
            listaTb.Add(tbPret);
            listaTb.Add(tbCantitate);
            listaTb.Add(tbValoare);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = ((TextBox)listaTb[0]).Location.X;
            int y = ((TextBox)listaTb[listaTb.Count - 1]).Location.Y;
            int dist = ((TextBox)listaTb[1]).Location.X-
                ((TextBox)listaTb[0]).Location.X;
            int latime = ((TextBox)listaTb[0]).Width;

            for(int i=0;i<4;i++)
            {
                TextBox tbNou = new TextBox();
                tbNou.Location = new Point(x, y + 30);
                tbNou.Width = latime;
                x += dist;
                if (i == 3)
                    tbNou.ReadOnly = true;
                if (i == 1 || i == 2)
                    tbNou.KeyPress += new KeyPressEventHandler(tbPret_KeyPress);
                listaTb.Add(tbNou);
                this.Controls.Add(tbNou);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float total = 0;
            for(int i=0;i<listaTb.Count;i+=4)
            {
                if (((TextBox)listaTb[i]).Text == "")
                    errorProvider1.SetError((TextBox)listaTb[i],
                        "Introduceti denumirile!");
                else
                    if (((TextBox)listaTb[i+1]).Text == "")
                    errorProvider1.SetError((TextBox)listaTb[i+1],
                        "Introduceti preturile!");
                else
                    if (((TextBox)listaTb[i+2]).Text == "")
                    errorProvider1.SetError((TextBox)listaTb[i+2],
                        "Introduceti cantitatile!");
                else
                {
                    try
                    {
                        string denumire = ((TextBox)listaTb[i]).Text;
                        float pret = (float)Convert.ToDouble(((TextBox)listaTb[i+1]).Text);
                        float cantitate = (float)Convert.ToDouble(((TextBox)listaTb[i + 2]).Text);
                        float valoare = pret * cantitate;
                        ((TextBox)listaTb[i + 3]).Text = valoare.ToString();
                        total += valoare;
                        tbTotal.Text = total.ToString();

                        Produs p = new Produs(denumire, pret, cantitate);
                        listaProd.Add(p);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        errorProvider1.Clear();
                    }
                }
            }
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' ||
                e.KeyChar == (char)8 || e.KeyChar == ',')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaProd);
            frm.ShowDialog();
        }
    }
}
