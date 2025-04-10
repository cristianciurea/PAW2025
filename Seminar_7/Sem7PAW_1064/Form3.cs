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
    public partial class Form3 : Form
    {
        List<Restaurant> lista2;
        public Form3(List<Restaurant> lista)
        {
            InitializeComponent();
            lista2 = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode parinte = new TreeNode("Restaurante");
            treeView1.Nodes.Add(parinte);

            foreach(Restaurant r in lista2)
            {
                TreeNode copil = new TreeNode(r.cod + "-" + r.denumire + "-" + r.adresa);
                parinte.Nodes.Add(copil);

                TreeNode nepot = new TreeNode();
                if (r.cifraAfaceri > 10000)
                    nepot.Text = "cifra mare";
                else
                    nepot.Text = "cifra mica";
                copil.Nodes.Add(nepot);
            }
            treeView1.ExpandAll();
        }
    }
}
