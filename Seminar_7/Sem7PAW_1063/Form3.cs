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
    public partial class Form3 : Form
    {
        List<Masina> lista2;
        public Form3(List<Masina> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Masini");
            treeView1.Nodes.Add(parinte);

            foreach(Masina m in lista2)
            {
                TreeNode copil = new TreeNode(m.codVIN + "-" + m.marca + "-" + m.capacitateCilindrica + "-" + m.pret);
                parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode();
                if (m.pret >= 15000)
                    nepot.Text = "program rabla plus";
                else
                    nepot.Text = "program rabla";
                copil.Nodes.Add(nepot);
            }
            treeView1.ExpandAll();
        }
    }
}
