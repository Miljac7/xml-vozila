namespace Xml_vozila
{
    partial class Form1
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
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.textBoxGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.textBoxKilometraza = new System.Windows.Forms.TextBox();
            this.Marka = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(170, 62);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(100, 26);
            this.textBoxMarka.TabIndex = 0;
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(170, 136);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(100, 26);
            this.textBoxModel.TabIndex = 1;
            // 
            // textBoxGodinaProizvodnje
            // 
            this.textBoxGodinaProizvodnje.Location = new System.Drawing.Point(170, 203);
            this.textBoxGodinaProizvodnje.Name = "textBoxGodinaProizvodnje";
            this.textBoxGodinaProizvodnje.Size = new System.Drawing.Size(100, 26);
            this.textBoxGodinaProizvodnje.TabIndex = 2;
            // 
            // textBoxKilometraza
            // 
            this.textBoxKilometraza.Location = new System.Drawing.Point(170, 259);
            this.textBoxKilometraza.Name = "textBoxKilometraza";
            this.textBoxKilometraza.Size = new System.Drawing.Size(100, 26);
            this.textBoxKilometraza.TabIndex = 3;
            // 
            // Marka
            // 
            this.Marka.AutoSize = true;
            this.Marka.Location = new System.Drawing.Point(24, 62);
            this.Marka.Name = "Marka";
            this.Marka.Size = new System.Drawing.Size(53, 20);
            this.Marka.TabIndex = 4;
            this.Marka.Text = "marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "G.Proizvodnje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kilometraza";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(28, 355);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(77, 33);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(353, 373);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(77, 33);
            this.btnSortiraj.TabIndex = 9;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(180, 355);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 28);
            this.ComboBox.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(384, 73);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(369, 184);
            this.listBox1.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(447, 284);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(306, 122);
            this.textBox5.TabIndex = 12;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(322, 13);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 43);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Marka);
            this.Controls.Add(this.textBoxKilometraza);
            this.Controls.Add(this.textBoxGodinaProizvodnje);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxMarka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.TextBox textBoxGodinaProizvodnje;
        private System.Windows.Forms.TextBox textBoxKilometraza;
        private System.Windows.Forms.Label Marka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnObrisi;
    }
}

