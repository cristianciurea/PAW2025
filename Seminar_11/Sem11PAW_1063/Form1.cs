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

namespace Sem11PAW_1063
{
    public partial class Form1 : Form
    {
        string connString;
        public Form1()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = carti.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM carti", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "carti");
            DataTable tabela = ds.Tables["carti"];

            dataGridView1.DataSource = tabela;

            foreach (DataColumn coloana in tabela.Columns)
                textBox1.Text += coloana.ColumnName + "    ";
            textBox1.Text += Environment.NewLine;

            foreach(DataRow linie in tabela.Rows)
            {
                foreach (object camp in linie.ItemArray)
                    textBox1.Text += camp + "    ";
                textBox1.Text += Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM carti", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "carti");
            DataTable tabela = ds.Tables["carti"];

            /*DataRow[] rows = tabela.Select("editura='" + comboBox1.Text + "'", "pret");
             foreach (DataRow linie in rows)
                 textBox1.Text += linie["editura"] + "    " + linie["titlu"] + "   " + linie["pret"] + Environment.NewLine;*/

            textBox1.Clear();
            DataView dv = new DataView(tabela);
            dv.Sort = "pret";
            dv.RowFilter = "editura='" + comboBox1.Text + "'";
            foreach(DataRowView linie in dv)
                textBox1.Text += linie["editura"] + "    " + linie["titlu"] + "   " + linie["pret"] + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM carti", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "carti");
            DataTable tabela = ds.Tables["carti"];

            adaptor.UpdateCommand = new OleDbCommand("UPDATE carti SET editura='ASE'", conexiune);

            tabela.Rows[0].BeginEdit();
            tabela.Rows[0].EndEdit();

            adaptor.Update(tabela);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "CREATE PROCEDURE CartiEditura AS SELECT * FROM carti WHERE editura=@editura";
                comanda.ExecuteNonQuery();
                MessageBox.Show("Procedura creata!");
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

        private void button5_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "CartiEditura";
                comanda.CommandType = CommandType.StoredProcedure;
                comanda.Parameters.Add("@editura", OleDbType.Char, 20).Value = "ASE";
                OleDbDataReader reader = comanda.ExecuteReader();
                while(reader.Read())
                {
                    textBox1.Text += reader["titlu"] + "   " + reader["editura"] + Environment.NewLine;
                }
                reader.Close();
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
    }
}
