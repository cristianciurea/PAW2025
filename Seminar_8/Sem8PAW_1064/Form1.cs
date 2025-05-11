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
using System.Drawing.Printing;

namespace Sem8PAW_1064
{
    public partial class Form1 : Form
    {
        double[] vect = new double[30];
        int nrElem = 0;

        bool vb = false;

        const int marg = 10;

        Graphics gr;

        Color culoare = Color.Blue;

        Font font = new Font(FontFamily.GenericSansSerif, 12);
        public Form1()
        {
            InitializeComponent();
        }

        private void incarcaDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("fisier.txt");
            string linie = null;
            while((linie = sr.ReadLine())!=null)
            {
                vect[nrElem] = Convert.ToDouble(linie);
                nrElem++;
                vb = true;
            }
            sr.Close();
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            gr = e.Graphics;
            if (vb == true)
            {
                Rectangle dreptRosu = new Rectangle(panel1.ClientRectangle.X + marg,
                    panel1.ClientRectangle.Y + 2 * marg,
                    panel1.ClientRectangle.Width - 2 * marg,
                    panel1.ClientRectangle.Height - 3 * marg);
                Pen pen = new Pen(Color.Red, 3);
                gr.DrawRectangle(pen, dreptRosu);

                double latime = dreptRosu.Width / nrElem / 2;
                double distanta = (dreptRosu.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for(int i=0;i<nrElem;i++)
                {
                    recs[i] = new Rectangle((int)(dreptRosu.Location.X+(i+1)*distanta+i*latime),
                       (int)(dreptRosu.Location.Y+dreptRosu.Height-vect[i]/vMax*dreptRosu.Height),
                       (int)latime,
                       (int)(vect[i]/vMax*dreptRosu.Height));
                    //gr.FillRectangle(br, recs[i]);
                    //gr.DrawRectangle(pen, recs[i]);
                    //gr.DrawEllipse(pen, recs[i]);
                    gr.DrawString(vect[i].ToString(), font,
                        br, new Point((int)(recs[i].Location.X+latime/2),
                        (int)(recs[i].Location.Y-font.Height)));
                }
                //gr.FillRectangles(br, recs);
                for (int i = 0; i < nrElem - 1; i++)
                    gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), (int)(recs[i + 1].Location.Y)));
            }
        }

        private void schimbaCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                culoare = dlg.Color;
            panel1.Invalidate();
        }

        private void schimbaFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
                font = dlg.Font;
            panel1.Invalidate();
        }

        private void pd_print(object sender, PrintPageEventArgs e)
        {
            gr = e.Graphics;
            if (vb == true)
            {
                Rectangle dreptRosu = new Rectangle(e.PageBounds.X + marg,
                    e.PageBounds.Y + 2 * marg,
                    e.PageBounds.Width - 2 * marg,
                    e.PageBounds.Height - 3 * marg);
                Pen pen = new Pen(Color.Red, 3);
                gr.DrawRectangle(pen, dreptRosu);

                double latime = dreptRosu.Width / nrElem / 2;
                double distanta = (dreptRosu.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(dreptRosu.Location.X + (i + 1) * distanta + i * latime),
                       (int)(dreptRosu.Location.Y + dreptRosu.Height - vect[i] / vMax * dreptRosu.Height),
                       (int)latime,
                       (int)(vect[i] / vMax * dreptRosu.Height));
                    //gr.FillRectangle(br, recs[i]);
                    //gr.DrawRectangle(pen, recs[i]);
                    //gr.DrawEllipse(pen, recs[i]);
                    gr.DrawString(vect[i].ToString(), font,
                        br, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y - font.Height)));
                }
                //gr.FillRectangles(br, recs);
                for (int i = 0; i < nrElem - 1; i++)
                    gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2), (int)(recs[i + 1].Location.Y)));
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}
