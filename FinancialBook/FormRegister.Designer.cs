namespace FinancialBook
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxX = new System.Windows.Forms.PictureBox();
            this.txtBoxKorImeRegister = new System.Windows.Forms.TextBox();
            this.txtBoxKorZapRegister = new System.Windows.Forms.TextBox();
            this.lblKorImeRegister = new System.Windows.Forms.Label();
            this.lblKorZapRegister = new System.Windows.Forms.Label();
            this.lblKorZapPonovi = new System.Windows.Forms.Label();
            this.txtBoxKorZapPonovi = new System.Windows.Forms.TextBox();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.checkBoxPrikaziPonovi = new System.Windows.Forms.CheckBox();
            this.checkBoxPrikaziZaporku = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxX)).BeginInit();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::FinancialBook.Properties.Resources.FBlogo;
            this.picBoxLogo.Location = new System.Drawing.Point(53, 25);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(188, 85);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 2;
            this.picBoxLogo.TabStop = false;
            // 
            // picBoxX
            // 
            this.picBoxX.Image = global::FinancialBook.Properties.Resources.close20;
            this.picBoxX.Location = new System.Drawing.Point(275, 5);
            this.picBoxX.Name = "picBoxX";
            this.picBoxX.Size = new System.Drawing.Size(24, 24);
            this.picBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxX.TabIndex = 3;
            this.picBoxX.TabStop = false;
            this.picBoxX.Click += new System.EventHandler(this.picBoxX_Click);
            this.picBoxX.MouseLeave += new System.EventHandler(this.picBoxX_MouseLeave);
            this.picBoxX.MouseHover += new System.EventHandler(this.picBoxX_MouseHover);
            // 
            // txtBoxKorImeRegister
            // 
            this.txtBoxKorImeRegister.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxKorImeRegister.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtBoxKorImeRegister.ForeColor = System.Drawing.Color.Black;
            this.txtBoxKorImeRegister.Location = new System.Drawing.Point(73, 166);
            this.txtBoxKorImeRegister.Name = "txtBoxKorImeRegister";
            this.txtBoxKorImeRegister.Size = new System.Drawing.Size(158, 30);
            this.txtBoxKorImeRegister.TabIndex = 4;
            this.txtBoxKorImeRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxKorZapRegister
            // 
            this.txtBoxKorZapRegister.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxKorZapRegister.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtBoxKorZapRegister.ForeColor = System.Drawing.Color.Black;
            this.txtBoxKorZapRegister.Location = new System.Drawing.Point(73, 238);
            this.txtBoxKorZapRegister.Name = "txtBoxKorZapRegister";
            this.txtBoxKorZapRegister.Size = new System.Drawing.Size(158, 30);
            this.txtBoxKorZapRegister.TabIndex = 5;
            this.txtBoxKorZapRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxKorZapRegister.UseSystemPasswordChar = true;
            // 
            // lblKorImeRegister
            // 
            this.lblKorImeRegister.AutoSize = true;
            this.lblKorImeRegister.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblKorImeRegister.Location = new System.Drawing.Point(82, 134);
            this.lblKorImeRegister.Name = "lblKorImeRegister";
            this.lblKorImeRegister.Size = new System.Drawing.Size(140, 22);
            this.lblKorImeRegister.TabIndex = 6;
            this.lblKorImeRegister.Text = "Korisničko ime:";
            // 
            // lblKorZapRegister
            // 
            this.lblKorZapRegister.AutoSize = true;
            this.lblKorZapRegister.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblKorZapRegister.Location = new System.Drawing.Point(107, 206);
            this.lblKorZapRegister.Name = "lblKorZapRegister";
            this.lblKorZapRegister.Size = new System.Drawing.Size(91, 22);
            this.lblKorZapRegister.TabIndex = 7;
            this.lblKorZapRegister.Text = "Zaporka:";
            // 
            // lblKorZapPonovi
            // 
            this.lblKorZapPonovi.AutoSize = true;
            this.lblKorZapPonovi.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.lblKorZapPonovi.Location = new System.Drawing.Point(74, 278);
            this.lblKorZapPonovi.Name = "lblKorZapPonovi";
            this.lblKorZapPonovi.Size = new System.Drawing.Size(157, 22);
            this.lblKorZapPonovi.TabIndex = 9;
            this.lblKorZapPonovi.Text = "Ponovi zaporku:";
            // 
            // txtBoxKorZapPonovi
            // 
            this.txtBoxKorZapPonovi.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxKorZapPonovi.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtBoxKorZapPonovi.ForeColor = System.Drawing.Color.Black;
            this.txtBoxKorZapPonovi.Location = new System.Drawing.Point(73, 310);
            this.txtBoxKorZapPonovi.Name = "txtBoxKorZapPonovi";
            this.txtBoxKorZapPonovi.Size = new System.Drawing.Size(158, 30);
            this.txtBoxKorZapPonovi.TabIndex = 8;
            this.txtBoxKorZapPonovi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxKorZapPonovi.UseSystemPasswordChar = true;
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(220)))));
            this.btnPrijaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijaviSe.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrijaviSe.ForeColor = System.Drawing.Color.White;
            this.btnPrijaviSe.Location = new System.Drawing.Point(111, 352);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(98, 26);
            this.btnPrijaviSe.TabIndex = 10;
            this.btnPrijaviSe.Text = "Registriraj se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // panelRegister
            // 
            this.panelRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRegister.Controls.Add(this.checkBoxPrikaziPonovi);
            this.panelRegister.Controls.Add(this.checkBoxPrikaziZaporku);
            this.panelRegister.Location = new System.Drawing.Point(0, 0);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(305, 395);
            this.panelRegister.TabIndex = 11;
            this.panelRegister.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRegister_MouseDown);
            this.panelRegister.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelRegister_MouseMove);
            this.panelRegister.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelRegister_MouseUp);
            // 
            // checkBoxPrikaziPonovi
            // 
            this.checkBoxPrikaziPonovi.AutoSize = true;
            this.checkBoxPrikaziPonovi.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPrikaziPonovi.Location = new System.Drawing.Point(236, 307);
            this.checkBoxPrikaziPonovi.Name = "checkBoxPrikaziPonovi";
            this.checkBoxPrikaziPonovi.Size = new System.Drawing.Size(71, 36);
            this.checkBoxPrikaziPonovi.TabIndex = 1;
            this.checkBoxPrikaziPonovi.Text = "Prikaži\r\nZaporku";
            this.checkBoxPrikaziPonovi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPrikaziPonovi.UseVisualStyleBackColor = true;
            this.checkBoxPrikaziPonovi.CheckedChanged += new System.EventHandler(this.checkBoxPrikaziPonovi_CheckedChanged);
            // 
            // checkBoxPrikaziZaporku
            // 
            this.checkBoxPrikaziZaporku.AutoSize = true;
            this.checkBoxPrikaziZaporku.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxPrikaziZaporku.Location = new System.Drawing.Point(234, 235);
            this.checkBoxPrikaziZaporku.Name = "checkBoxPrikaziZaporku";
            this.checkBoxPrikaziZaporku.Size = new System.Drawing.Size(71, 36);
            this.checkBoxPrikaziZaporku.TabIndex = 0;
            this.checkBoxPrikaziZaporku.Text = "Prikaži\r\nZaporku";
            this.checkBoxPrikaziZaporku.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxPrikaziZaporku.UseVisualStyleBackColor = true;
            this.checkBoxPrikaziZaporku.CheckedChanged += new System.EventHandler(this.checkBoxPrikaziZaporku_CheckedChanged);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(305, 395);
            this.Controls.Add(this.btnPrijaviSe);
            this.Controls.Add(this.lblKorZapPonovi);
            this.Controls.Add(this.txtBoxKorZapPonovi);
            this.Controls.Add(this.lblKorZapRegister);
            this.Controls.Add(this.lblKorImeRegister);
            this.Controls.Add(this.txtBoxKorZapRegister);
            this.Controls.Add(this.txtBoxKorImeRegister);
            this.Controls.Add(this.picBoxX);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.panelRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegister_FormClosing);
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxX)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox picBoxX;
        private System.Windows.Forms.TextBox txtBoxKorImeRegister;
        private System.Windows.Forms.TextBox txtBoxKorZapRegister;
        private System.Windows.Forms.Label lblKorImeRegister;
        private System.Windows.Forms.Label lblKorZapRegister;
        private System.Windows.Forms.Label lblKorZapPonovi;
        private System.Windows.Forms.TextBox txtBoxKorZapPonovi;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.CheckBox checkBoxPrikaziPonovi;
        private System.Windows.Forms.CheckBox checkBoxPrikaziZaporku;
    }
}