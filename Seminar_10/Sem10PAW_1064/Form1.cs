using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sem10PAW_1064
{
    public partial class Form1 : Form
    {
        string connString;
        public Form1()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = studenti.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                //MessageBox.Show("Conexiune deschisa!");
                OleDbCommand comanda = new OleDbCommand();
                comanda.CommandText = "SELECT * FROM studenti";
                comanda.Connection = conexiune;
                OleDbDataReader reader = comanda.ExecuteReader();
                while(reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["cod"].ToString());
                    itm.SubItems.Add(reader["nume"].ToString());
                    itm.SubItems.Add(reader["facultate"].ToString());
                    itm.SubItems.Add(reader["anStudiu"].ToString());
                    itm.SubItems.Add(reader["formaInv"].ToString());
                    itm.SubItems.Add(reader["medie"].ToString());
                    listView1.Items.Add(itm);
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                int cod = 0;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Selected)
                        cod = Convert.ToInt32(itm.SubItems[0].Text);
                //comanda.CommandText = "UPDATE studenti SET medie=10 WHERE cod=" + cod;
               /* comanda.CommandText = "UPDATE studenti SET anStudiu=" + 
                    comboBox1.Text + " WHERE cod=" + cod;*/
                comanda.CommandText = "UPDATE studenti SET facultate='" +
                    comboBox2.Text + "' WHERE cod=" + cod;
                comanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                int cod = 0;
                foreach (ListViewItem itm in listView1.Items)
                    if (itm.Checked)
                        cod = Convert.ToInt32(itm.SubItems[0].Text);
                comanda.CommandText = "DELETE FROM studenti WHERE cod="+cod;
                comanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
