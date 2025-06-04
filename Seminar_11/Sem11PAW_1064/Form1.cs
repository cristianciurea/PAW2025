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

namespace Sem11PAW_1064
{
    public partial class Form1 : Form
    {
        string connString;
        public Form1()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = masini.accdb";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM masini", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "masini");
            DataTable tabela = ds.Tables["masini"];

            dataGridView1.DataSource = tabela;

            foreach (DataColumn coloana in tabela.Columns)
                textBox1.Text += coloana.ColumnName + "   ";
            textBox1.Text += Environment.NewLine;

            foreach(DataRow linie in tabela.Rows)
            {
                foreach (object camp in linie.ItemArray)
                    textBox1.Text += camp + "   ";
                textBox1.Text += Environment.NewLine;
            }

            comboBox1.DataSource = tabela;
            comboBox1.DisplayMember = "motorizare";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM masini", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "masini");
            DataTable tabela = ds.Tables["masini"];

            DataRow[] rows = tabela.Select("motorizare='" + comboBox1.Text + "'", "pret");
            foreach (DataRow linie in rows)
                textBox1.Text += linie["motorizare"] + "   " + linie["marca"] + "   " + linie["pret"] + Environment.NewLine;

            DataView dv = new DataView(tabela);
            dv.Sort = "pret";
            dv.RowFilter = "motorizare='" + comboBox1.Text + "'";
            foreach(DataRowView linie in dv)
                textBox1.Text += linie["motorizare"] + "   " + linie["marca"] + "   " + linie["pret"] + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM masini", conexiune);
            DataSet ds = new DataSet();
            adaptor.Fill(ds, "masini");
            DataTable tabela = ds.Tables["masini"];

            adaptor.UpdateCommand = new OleDbCommand("UPDATE masini SET motorizare='ELECTRIC'", conexiune);

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
                comanda.CommandText = "CREATE PROCEDURE MasiniMarca AS SELECT * FROM masini WHERE marca=@marca";
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
                comanda.CommandText = "MasiniMarca";
                comanda.CommandType = CommandType.StoredProcedure;
                comanda.Parameters.Add("@marca", OleDbType.Char, 20).Value = "Toyota";
                OleDbDataReader reader = comanda.ExecuteReader();
                while(reader.Read())
                {
                    textBox1.Text += reader["marca"] + "  " + reader["pret"] + Environment.NewLine;
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
