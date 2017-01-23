namespace AplikacjaDotNet
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.deleteProdukty = new System.Windows.Forms.Button();
            this.numericUpDownIlosc = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerRok = new System.Windows.Forms.DateTimePicker();
            this.buttonAddProdukt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProducent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNazwa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProdukty = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.deleteKlienci = new System.Windows.Forms.Button();
            this.buttonAddKlient = new System.Windows.Forms.Button();
            this.textBoxMiasto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewKlienci = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleteZamowienia = new System.Windows.Forms.Button();
            this.buttonAddZamowienia = new System.Windows.Forms.Button();
            this.dataGridViewZamowienia = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIlosc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdukty)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlienci)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZamowienia)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.deleteProdukty);
            this.tabPage1.Controls.Add(this.numericUpDownIlosc);
            this.tabPage1.Controls.Add(this.dateTimePickerRok);
            this.tabPage1.Controls.Add(this.buttonAddProdukt);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxProducent);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxNazwa);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridViewProdukty);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produkty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteProdukty
            // 
            this.deleteProdukty.Location = new System.Drawing.Point(336, 193);
            this.deleteProdukty.Name = "deleteProdukty";
            this.deleteProdukty.Size = new System.Drawing.Size(75, 23);
            this.deleteProdukty.TabIndex = 12;
            this.deleteProdukty.Text = "Usuń";
            this.deleteProdukty.UseVisualStyleBackColor = true;
            this.deleteProdukty.Click += new System.EventHandler(this.deleteProdukty_Click);
            // 
            // numericUpDownIlosc
            // 
            this.numericUpDownIlosc.Location = new System.Drawing.Point(142, 219);
            this.numericUpDownIlosc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownIlosc.Name = "numericUpDownIlosc";
            this.numericUpDownIlosc.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownIlosc.TabIndex = 11;
            // 
            // dateTimePickerRok
            // 
            this.dateTimePickerRok.Location = new System.Drawing.Point(142, 180);
            this.dateTimePickerRok.Name = "dateTimePickerRok";
            this.dateTimePickerRok.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerRok.TabIndex = 10;
            // 
            // buttonAddProdukt
            // 
            this.buttonAddProdukt.Location = new System.Drawing.Point(83, 259);
            this.buttonAddProdukt.Name = "buttonAddProdukt";
            this.buttonAddProdukt.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProdukt.TabIndex = 9;
            this.buttonAddProdukt.Text = "Dodaj";
            this.buttonAddProdukt.UseVisualStyleBackColor = true;
            this.buttonAddProdukt.Click += new System.EventHandler(this.buttonAddProdukt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rok produkcji";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ilość";
            // 
            // textBoxProducent
            // 
            this.textBoxProducent.Location = new System.Drawing.Point(10, 219);
            this.textBoxProducent.Name = "textBoxProducent";
            this.textBoxProducent.Size = new System.Drawing.Size(100, 20);
            this.textBoxProducent.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Producent";
            // 
            // textBoxNazwa
            // 
            this.textBoxNazwa.Location = new System.Drawing.Point(10, 180);
            this.textBoxNazwa.Name = "textBoxNazwa";
            this.textBoxNazwa.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa";
            // 
            // dataGridViewProdukty
            // 
            this.dataGridViewProdukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdukty.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewProdukty.Name = "dataGridViewProdukty";
            this.dataGridViewProdukty.Size = new System.Drawing.Size(473, 150);
            this.dataGridViewProdukty.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.deleteKlienci);
            this.tabPage2.Controls.Add(this.buttonAddKlient);
            this.tabPage2.Controls.Add(this.textBoxMiasto);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxNazwisko);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxImie);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridViewKlienci);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Klienci";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // deleteKlienci
            // 
            this.deleteKlienci.Location = new System.Drawing.Point(288, 193);
            this.deleteKlienci.Name = "deleteKlienci";
            this.deleteKlienci.Size = new System.Drawing.Size(75, 23);
            this.deleteKlienci.TabIndex = 13;
            this.deleteKlienci.Text = "Usuń";
            this.deleteKlienci.UseVisualStyleBackColor = true;
            this.deleteKlienci.Click += new System.EventHandler(this.deleteKlienci_Click);
            // 
            // buttonAddKlient
            // 
            this.buttonAddKlient.Location = new System.Drawing.Point(9, 279);
            this.buttonAddKlient.Name = "buttonAddKlient";
            this.buttonAddKlient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddKlient.TabIndex = 8;
            this.buttonAddKlient.Text = "Dodaj";
            this.buttonAddKlient.UseVisualStyleBackColor = true;
            this.buttonAddKlient.Click += new System.EventHandler(this.buttonAddKlient_Click_1);
            // 
            // textBoxMiasto
            // 
            this.textBoxMiasto.Location = new System.Drawing.Point(6, 253);
            this.textBoxMiasto.Name = "textBoxMiasto";
            this.textBoxMiasto.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiasto.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Miasto";
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(9, 214);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nazwisko";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(9, 175);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Imię";
            // 
            // dataGridViewKlienci
            // 
            this.dataGridViewKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKlienci.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewKlienci.Name = "dataGridViewKlienci";
            this.dataGridViewKlienci.Size = new System.Drawing.Size(473, 150);
            this.dataGridViewKlienci.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleteZamowienia);
            this.tabPage3.Controls.Add(this.buttonAddZamowienia);
            this.tabPage3.Controls.Add(this.dataGridViewZamowienia);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(482, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Zamówienia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // deleteZamowienia
            // 
            this.deleteZamowienia.Location = new System.Drawing.Point(195, 255);
            this.deleteZamowienia.Name = "deleteZamowienia";
            this.deleteZamowienia.Size = new System.Drawing.Size(75, 23);
            this.deleteZamowienia.TabIndex = 13;
            this.deleteZamowienia.Text = "Usuń";
            this.deleteZamowienia.UseVisualStyleBackColor = true;
            this.deleteZamowienia.Click += new System.EventHandler(this.deleteZamowienia_Click);
            // 
            // buttonAddZamowienia
            // 
            this.buttonAddZamowienia.Location = new System.Drawing.Point(147, 306);
            this.buttonAddZamowienia.Name = "buttonAddZamowienia";
            this.buttonAddZamowienia.Size = new System.Drawing.Size(168, 23);
            this.buttonAddZamowienia.TabIndex = 3;
            this.buttonAddZamowienia.Text = "Dodaj zamówienie";
            this.buttonAddZamowienia.UseVisualStyleBackColor = true;
            this.buttonAddZamowienia.Click += new System.EventHandler(this.buttonAddZamowienia_Click);
            // 
            // dataGridViewZamowienia
            // 
            this.dataGridViewZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZamowienia.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewZamowienia.Name = "dataGridViewZamowienia";
            this.dataGridViewZamowienia.Size = new System.Drawing.Size(473, 150);
            this.dataGridViewZamowienia.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 385);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIlosc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdukty)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKlienci)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZamowienia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewProdukty;
        private System.Windows.Forms.DataGridView dataGridViewKlienci;
        private System.Windows.Forms.DataGridView dataGridViewZamowienia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxProducent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNazwa;
        private System.Windows.Forms.Button buttonAddProdukt;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMiasto;
        private System.Windows.Forms.Button buttonAddKlient;
        private System.Windows.Forms.Button buttonAddZamowienia;
        private System.Windows.Forms.DateTimePicker dateTimePickerRok;
        private System.Windows.Forms.NumericUpDown numericUpDownIlosc;
        private System.Windows.Forms.Button deleteProdukty;
        private System.Windows.Forms.Button deleteKlienci;
        private System.Windows.Forms.Button deleteZamowienia;
    }
}

