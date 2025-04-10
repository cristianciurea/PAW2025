
namespace Sem7PAW_1064
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNrAngajati = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCifraAfaceri = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(276, 62);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(100, 20);
            this.tbCod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Denumire";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(276, 114);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(100, 20);
            this.tbDenumire.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adresa";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(276, 167);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(100, 20);
            this.tbAdresa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numar angajati";
            // 
            // tbNrAngajati
            // 
            this.tbNrAngajati.Location = new System.Drawing.Point(276, 227);
            this.tbNrAngajati.Name = "tbNrAngajati";
            this.tbNrAngajati.Size = new System.Drawing.Size(100, 20);
            this.tbNrAngajati.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cifra de afaceri";
            // 
            // tbCifraAfaceri
            // 
            this.tbCifraAfaceri.Location = new System.Drawing.Point(276, 289);
            this.tbCifraAfaceri.Name = "tbCifraAfaceri";
            this.tbCifraAfaceri.Size = new System.Drawing.Size(100, 20);
            this.tbCifraAfaceri.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Adaugare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCifraAfaceri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNrAngajati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCod);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNrAngajati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCifraAfaceri;
        private System.Windows.Forms.Button button1;
    }
}