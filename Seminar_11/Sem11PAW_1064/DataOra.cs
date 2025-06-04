using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem11PAW_1064
{
    public partial class DataOra : UserControl
    {
        public DataOra()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = System.DateTime.Now.ToString();
        }
    }
}
