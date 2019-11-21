namespace Forme
{
    partial class FrmUnosMasine
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtOcekivaniRadniVek = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipMasine = new System.Windows.Forms.ComboBox();
            this.cmbLokacija = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbAlati = new System.Windows.Forms.ComboBox();
            this.btnDodajAlat = new System.Windows.Forms.Button();
            this.dgvAlati = new System.Windows.Forms.DataGridView();
            this.btnSacuvajMasinu = new System.Windows.Forms.Button();
            this.btnObrisiAlat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proizvodjac";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ocekivani radni vek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Godina proizvodnje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pocetak eksploatacije";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(147, 28);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(200, 20);
            this.txtNaziv.TabIndex = 6;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(147, 63);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(200, 20);
            this.txtProizvodjac.TabIndex = 7;
            // 
            // txtOcekivaniRadniVek
            // 
            this.txtOcekivaniRadniVek.Location = new System.Drawing.Point(147, 95);
            this.txtOcekivaniRadniVek.Name = "txtOcekivaniRadniVek";
            this.txtOcekivaniRadniVek.Size = new System.Drawing.Size(200, 20);
            this.txtOcekivaniRadniVek.TabIndex = 8;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(147, 134);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(200, 20);
            this.txtGodinaProizvodnje.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tip masine";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 243);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Lokacija";
            // 
            // cmbTipMasine
            // 
            this.cmbTipMasine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipMasine.FormattingEnabled = true;
            this.cmbTipMasine.Location = new System.Drawing.Point(147, 205);
            this.cmbTipMasine.Name = "cmbTipMasine";
            this.cmbTipMasine.Size = new System.Drawing.Size(200, 21);
            this.cmbTipMasine.TabIndex = 12;
            // 
            // cmbLokacija
            // 
            this.cmbLokacija.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLokacija.FormattingEnabled = true;
            this.cmbLokacija.Location = new System.Drawing.Point(147, 240);
            this.cmbLokacija.Name = "cmbLokacija";
            this.cmbLokacija.Size = new System.Drawing.Size(200, 21);
            this.cmbLokacija.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alati";
            // 
            // cmbAlati
            // 
            this.cmbAlati.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlati.FormattingEnabled = true;
            this.cmbAlati.Location = new System.Drawing.Point(431, 28);
            this.cmbAlati.Name = "cmbAlati";
            this.cmbAlati.Size = new System.Drawing.Size(200, 21);
            this.cmbAlati.TabIndex = 15;
            // 
            // btnDodajAlat
            // 
            this.btnDodajAlat.Location = new System.Drawing.Point(431, 66);
            this.btnDodajAlat.Name = "btnDodajAlat";
            this.btnDodajAlat.Size = new System.Drawing.Size(88, 28);
            this.btnDodajAlat.TabIndex = 16;
            this.btnDodajAlat.Text = "Dodaj alat";
            this.btnDodajAlat.UseVisualStyleBackColor = true;
            this.btnDodajAlat.Click += new System.EventHandler(this.btnDodajAlat_Click);
            // 
            // dgvAlati
            // 
            this.dgvAlati.AllowUserToAddRows = false;
            this.dgvAlati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlati.Location = new System.Drawing.Point(380, 119);
            this.dgvAlati.Name = "dgvAlati";
            this.dgvAlati.Size = new System.Drawing.Size(251, 142);
            this.dgvAlati.TabIndex = 17;
            // 
            // btnSacuvajMasinu
            // 
            this.btnSacuvajMasinu.Location = new System.Drawing.Point(303, 277);
            this.btnSacuvajMasinu.Name = "btnSacuvajMasinu";
            this.btnSacuvajMasinu.Size = new System.Drawing.Size(122, 35);
            this.btnSacuvajMasinu.TabIndex = 18;
            this.btnSacuvajMasinu.Text = "Sacuvaj masinu";
            this.btnSacuvajMasinu.UseVisualStyleBackColor = true;
            this.btnSacuvajMasinu.Click += new System.EventHandler(this.btnSacuvajMasinu_Click);
            // 
            // btnObrisiAlat
            // 
            this.btnObrisiAlat.Location = new System.Drawing.Point(543, 66);
            this.btnObrisiAlat.Name = "btnObrisiAlat";
            this.btnObrisiAlat.Size = new System.Drawing.Size(88, 28);
            this.btnObrisiAlat.TabIndex = 19;
            this.btnObrisiAlat.Text = "Obrisi alat";
            this.btnObrisiAlat.UseVisualStyleBackColor = true;
            this.btnObrisiAlat.Click += new System.EventHandler(this.btnObrisiAlat_Click);
            // 
            // FrmUnosMasine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 326);
            this.Controls.Add(this.btnObrisiAlat);
            this.Controls.Add(this.btnSacuvajMasinu);
            this.Controls.Add(this.dgvAlati);
            this.Controls.Add(this.btnDodajAlat);
            this.Controls.Add(this.cmbAlati);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbLokacija);
            this.Controls.Add(this.cmbTipMasine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtOcekivaniRadniVek);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUnosMasine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unos masine";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtOcekivaniRadniVek;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipMasine;
        private System.Windows.Forms.ComboBox cmbLokacija;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbAlati;
        private System.Windows.Forms.Button btnDodajAlat;
        private System.Windows.Forms.DataGridView dgvAlati;
        private System.Windows.Forms.Button btnSacuvajMasinu;
        private System.Windows.Forms.Button btnObrisiAlat;
    }
}