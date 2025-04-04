using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem6PAW_1063
{
    public partial class Form2 : Form
    {
        public Form2(ArrayList lista)
        {
            InitializeComponent();
            foreach(Produs p in lista)
            {
                ListViewItem itm = new ListViewItem(p.Denumire);
                itm.SubItems.Add(p.Pret.ToString());
                itm.SubItems.Add(p.Cantitate.ToString());
                listView1.Items.Add(itm);
            }
        }
    }
}
