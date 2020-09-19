namespace FinancialBook
{
    partial class FormMainBoard
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
            this.picBoxX = new System.Windows.Forms.PictureBox();
            this.pozadina = new System.Windows.Forms.Panel();
            this.btnDodajNoviRacun = new System.Windows.Forms.Button();
            this.txtBoxDodajNoviRacun = new System.Windows.Forms.TextBox();
            this.checkBoxDodajNoviRacun = new System.Windows.Forms.CheckBox();
            this.txtBoxOpis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtBoxIznos = new System.Windows.Forms.TextBox();
            this.comboBoxOdaberiOpciju = new System.Windows.Forms.ComboBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.comboBoxOdaberiRacun = new System.Windows.Forms.ComboBox();
            this.txtBoxIznosRacuna = new System.Windows.Forms.TextBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.listViewPopisTransakcija = new System.Windows.Forms.ListView();
            this.colIznos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOpis = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxPrikazaniRacun = new System.Windows.Forms.ComboBox();
            this.btnObrisiOdabraniRacun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxX)).BeginInit();
            this.pozadina.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxX
            // 
            this.picBoxX.BackColor = System.Drawing.Color.White;
            this.picBoxX.Image = global::FinancialBook.Properties.Resources.close20;
            this.picBoxX.Location = new System.Drawing.Point(638, 5);
            this.picBoxX.Name = "picBoxX";
            this.picBoxX.Size = new System.Drawing.Size(24, 24);
            this.picBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxX.TabIndex = 1;
            this.picBoxX.TabStop = false;
            this.picBoxX.Click += new System.EventHandler(this.picBoxX_Click);
            this.picBoxX.MouseLeave += new System.EventHandler(this.picBoxX_MouseLeave);
            this.picBoxX.MouseHover += new System.EventHandler(this.picBoxX_MouseHover);
            // 
            // pozadina
            // 
            this.pozadina.BackColor = System.Drawing.Color.White;
            this.pozadina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pozadina.Controls.Add(this.btnObrisiOdabraniRacun);
            this.pozadina.Controls.Add(this.btnDodajNoviRacun);
            this.pozadina.Controls.Add(this.txtBoxDodajNoviRacun);
            this.pozadina.Controls.Add(this.checkBoxDodajNoviRacun);
            this.pozadina.Controls.Add(this.txtBoxOpis);
            this.pozadina.Controls.Add(this.label1);
            this.pozadina.Controls.Add(this.picBoxX);
            this.pozadina.Controls.Add(this.lblIme);
            this.pozadina.Controls.Add(this.txtBoxIznos);
            this.pozadina.Controls.Add(this.comboBoxOdaberiOpciju);
            this.pozadina.Controls.Add(this.btnUnesi);
            this.pozadina.Controls.Add(this.comboBoxOdaberiRacun);
            this.pozadina.Controls.Add(this.txtBoxIznosRacuna);
            this.pozadina.Controls.Add(this.lblIznos);
            this.pozadina.Controls.Add(this.listViewPopisTransakcija);
            this.pozadina.Controls.Add(this.comboBoxPrikazaniRacun);
            this.pozadina.Location = new System.Drawing.Point(0, 0);
            this.pozadina.Name = "pozadina";
            this.pozadina.Size = new System.Drawing.Size(667, 350);
            this.pozadina.TabIndex = 2;
            this.pozadina.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pozadina_MouseDown);
            this.pozadina.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pozadina_MouseMove);
            this.pozadina.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pozadina_MouseUp);
            // 
            // btnDodajNoviRacun
            // 
            this.btnDodajNoviRacun.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnDodajNoviRacun.Location = new System.Drawing.Point(531, 65);
            this.btnDodajNoviRacun.Name = "btnDodajNoviRacun";
            this.btnDodajNoviRacun.Size = new System.Drawing.Size(75, 23);
            this.btnDodajNoviRacun.TabIndex = 13;
            this.btnDodajNoviRacun.Text = "Dodaj";
            this.btnDodajNoviRacun.UseVisualStyleBackColor = true;
            this.btnDodajNoviRacun.Visible = false;
            this.btnDodajNoviRacun.Click += new System.EventHandler(this.btnDodajNoviRacun_Click);
            // 
            // txtBoxDodajNoviRacun
            // 
            this.txtBoxDodajNoviRacun.Location = new System.Drawing.Point(494, 39);
            this.txtBoxDodajNoviRacun.Name = "txtBoxDodajNoviRacun";
            this.txtBoxDodajNoviRacun.Size = new System.Drawing.Size(149, 20);
            this.txtBoxDodajNoviRacun.TabIndex = 12;
            this.txtBoxDodajNoviRacun.Visible = false;
            // 
            // checkBoxDodajNoviRacun
            // 
            this.checkBoxDodajNoviRacun.AutoSize = true;
            this.checkBoxDodajNoviRacun.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxDodajNoviRacun.Location = new System.Drawing.Point(370, 38);
            this.checkBoxDodajNoviRacun.Name = "checkBoxDodajNoviRacun";
            this.checkBoxDodajNoviRacun.Size = new System.Drawing.Size(122, 20);
            this.checkBoxDodajNoviRacun.TabIndex = 11;
            this.checkBoxDodajNoviRacun.Text = "Dodaj novi račun";
            this.checkBoxDodajNoviRacun.UseVisualStyleBackColor = true;
            this.checkBoxDodajNoviRacun.CheckedChanged += new System.EventHandler(this.checkBoxDodajNoviRacun_CheckedChanged);
            // 
            // txtBoxOpis
            // 
            this.txtBoxOpis.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxOpis.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxOpis.Location = new System.Drawing.Point(25, 229);
            this.txtBoxOpis.Multiline = true;
            this.txtBoxOpis.Name = "txtBoxOpis";
            this.txtBoxOpis.Size = new System.Drawing.Size(158, 71);
            this.txtBoxOpis.TabIndex = 10;
            this.txtBoxOpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxOpis.Enter += new System.EventHandler(this.txtBoxOpis_Enter);
            this.txtBoxOpis.Leave += new System.EventHandler(this.txtBoxOpis_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(618, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "kn";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblIme.Location = new System.Drawing.Point(91, 38);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(26, 21);
            this.lblIme.TabIndex = 8;
            this.lblIme.Text = "__";
            this.lblIme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxIznos
            // 
            this.txtBoxIznos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxIznos.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxIznos.Location = new System.Drawing.Point(44, 165);
            this.txtBoxIznos.Name = "txtBoxIznos";
            this.txtBoxIznos.Size = new System.Drawing.Size(121, 23);
            this.txtBoxIznos.TabIndex = 7;
            this.txtBoxIznos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxIznos.Enter += new System.EventHandler(this.txtBoxIznos_Enter);
            this.txtBoxIznos.Leave += new System.EventHandler(this.txtBoxIznos_Leave);
            // 
            // comboBoxOdaberiOpciju
            // 
            this.comboBoxOdaberiOpciju.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOdaberiOpciju.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBoxOdaberiOpciju.FormattingEnabled = true;
            this.comboBoxOdaberiOpciju.Items.AddRange(new object[] {
            "Odaberi opciju",
            "Prihod",
            "Rashod",
            "Prijenos"});
            this.comboBoxOdaberiOpciju.Location = new System.Drawing.Point(44, 132);
            this.comboBoxOdaberiOpciju.Name = "comboBoxOdaberiOpciju";
            this.comboBoxOdaberiOpciju.Size = new System.Drawing.Size(121, 25);
            this.comboBoxOdaberiOpciju.TabIndex = 6;
            this.comboBoxOdaberiOpciju.SelectedIndexChanged += new System.EventHandler(this.comboBoxOdaberiOpciju_SelectedIndexChanged);
            // 
            // btnUnesi
            // 
            this.btnUnesi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnUnesi.Location = new System.Drawing.Point(67, 308);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 5;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // comboBoxOdaberiRacun
            // 
            this.comboBoxOdaberiRacun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOdaberiRacun.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBoxOdaberiRacun.FormattingEnabled = true;
            this.comboBoxOdaberiRacun.Location = new System.Drawing.Point(44, 196);
            this.comboBoxOdaberiRacun.Name = "comboBoxOdaberiRacun";
            this.comboBoxOdaberiRacun.Size = new System.Drawing.Size(121, 25);
            this.comboBoxOdaberiRacun.TabIndex = 4;
            // 
            // txtBoxIznosRacuna
            // 
            this.txtBoxIznosRacuna.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxIznosRacuna.Location = new System.Drawing.Point(517, 314);
            this.txtBoxIznosRacuna.Name = "txtBoxIznosRacuna";
            this.txtBoxIznosRacuna.Size = new System.Drawing.Size(100, 23);
            this.txtBoxIznosRacuna.TabIndex = 3;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblIznos.Location = new System.Drawing.Point(421, 317);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(93, 17);
            this.lblIznos.TabIndex = 2;
            this.lblIznos.Text = "Iznos računa:";
            // 
            // listViewPopisTransakcija
            // 
            this.listViewPopisTransakcija.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIznos,
            this.colDatum,
            this.colOpis});
            this.listViewPopisTransakcija.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.listViewPopisTransakcija.HideSelection = false;
            this.listViewPopisTransakcija.Location = new System.Drawing.Point(228, 93);
            this.listViewPopisTransakcija.Name = "listViewPopisTransakcija";
            this.listViewPopisTransakcija.Size = new System.Drawing.Size(415, 205);
            this.listViewPopisTransakcija.TabIndex = 1;
            this.listViewPopisTransakcija.UseCompatibleStateImageBehavior = false;
            this.listViewPopisTransakcija.View = System.Windows.Forms.View.Details;
            // 
            // colIznos
            // 
            this.colIznos.Text = "Iznos";
            this.colIznos.Width = 85;
            // 
            // colDatum
            // 
            this.colDatum.Text = "Datum";
            this.colDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDatum.Width = 130;
            // 
            // colOpis
            // 
            this.colOpis.Text = "Opis";
            this.colOpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colOpis.Width = 196;
            // 
            // comboBoxPrikazaniRacun
            // 
            this.comboBoxPrikazaniRacun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrikazaniRacun.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.comboBoxPrikazaniRacun.FormattingEnabled = true;
            this.comboBoxPrikazaniRacun.Location = new System.Drawing.Point(228, 36);
            this.comboBoxPrikazaniRacun.Name = "comboBoxPrikazaniRacun";
            this.comboBoxPrikazaniRacun.Size = new System.Drawing.Size(121, 25);
            this.comboBoxPrikazaniRacun.TabIndex = 0;
            this.comboBoxPrikazaniRacun.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrikazaniRacun_SelectedIndexChanged);
            // 
            // btnObrisiOdabraniRacun
            // 
            this.btnObrisiOdabraniRacun.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiOdabraniRacun.Location = new System.Drawing.Point(519, 28);
            this.btnObrisiOdabraniRacun.Name = "btnObrisiOdabraniRacun";
            this.btnObrisiOdabraniRacun.Size = new System.Drawing.Size(99, 41);
            this.btnObrisiOdabraniRacun.TabIndex = 14;
            this.btnObrisiOdabraniRacun.Text = "Obriši odabrani račun";
            this.btnObrisiOdabraniRacun.UseVisualStyleBackColor = true;
            this.btnObrisiOdabraniRacun.Click += new System.EventHandler(this.btnObrisiOdabraniRacun_Click);
            // 
            // FormMainBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 350);
            this.Controls.Add(this.pozadina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainBoard";
            this.Load += new System.EventHandler(this.FormMainBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxX)).EndInit();
            this.pozadina.ResumeLayout(false);
            this.pozadina.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxX;
        private System.Windows.Forms.Panel pozadina;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.ListView listViewPopisTransakcija;
        private System.Windows.Forms.ColumnHeader colIznos;
        private System.Windows.Forms.ColumnHeader colDatum;
        private System.Windows.Forms.ColumnHeader colOpis;
        private System.Windows.Forms.ComboBox comboBoxPrikazaniRacun;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtBoxIznos;
        private System.Windows.Forms.ComboBox comboBoxOdaberiOpciju;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.ComboBox comboBoxOdaberiRacun;
        private System.Windows.Forms.TextBox txtBoxIznosRacuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxOpis;
        private System.Windows.Forms.Button btnDodajNoviRacun;
        private System.Windows.Forms.TextBox txtBoxDodajNoviRacun;
        private System.Windows.Forms.CheckBox checkBoxDodajNoviRacun;
        private System.Windows.Forms.Button btnObrisiOdabraniRacun;
    }
}