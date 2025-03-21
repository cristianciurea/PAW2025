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
using System.Runtime.Serialization.Formatters.Binary;

namespace Sem3PAW_1063_WF
{
    public partial class Form2 : Form
    {
        List<Student> lista2;
        public Form2(List<Student> lista)
        {
            InitializeComponent();
            lista2 = lista;
            foreach (Student s in lista)
                textBox1.Text += s.ToString() + Environment.NewLine;
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, textBox1.Text);
            bf.Serialize(fs, lista2);
            textBox1.Clear();
            fs.Close();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("fisier.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            //textBox1.Text = (string)bf.Deserialize(fs);
            List<Student> listaDeserializata = (List<Student>)bf.Deserialize(fs);
            foreach (Student s in listaDeserializata)
                textBox1.Text += s.ToString() + Environment.NewLine;
            fs.Close();
        }
    }
}
