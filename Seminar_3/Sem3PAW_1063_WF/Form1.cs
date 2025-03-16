using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem3PAW_1063_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = Convert.ToInt32(tbCod.Text);
                char sex = Convert.ToChar(cbSex.Text);
                int varsta = Convert.ToInt32(tbVarsta.Text);
                string nume = tbNume.Text;
                string noteS = tbNote.Text;
                string[] vectNoteS = noteS.Split(',');
                int[] vectNote = new int[vectNoteS.Length];
                for (int i = 0; i < vectNoteS.Length; i++)
                    vectNote[i] = Convert.ToInt32(vectNoteS[i]);
                Student s = new Student(cod, sex, varsta, nume, vectNote);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
