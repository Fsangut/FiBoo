namespace FinancialBook
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.Pozadina = new System.Windows.Forms.Panel();
            this.lblRegistrirajSe = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnPrijaviSe = new System.Windows.Forms.Button();
            this.txtBoxKorZap = new System.Windows.Forms.TextBox();
            this.txtBoxKorIme = new System.Windows.Forms.TextBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxX = new System.Windows.Forms.PictureBox();
            this.Pozadina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxX)).BeginInit();
            this.SuspendLayout();
            // 
            // Pozadina
            // 
            this.Pozadina.BackColor = System.Drawing.Color.White;
            this.Pozadina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pozadina.Controls.Add(this.lblRegistrirajSe);
            this.Pozadina.Controls.Add(this.lblText);
            this.Pozadina.Controls.Add(this.btnPrijaviSe);
            this.Pozadina.Controls.Add(this.txtBoxKorZap);
            this.Pozadina.Controls.Add(this.txtBoxKorIme);
            this.Pozadina.Controls.Add(this.picBoxLogo);
            this.Pozadina.Controls.Add(this.picBoxX);
            this.Pozadina.Location = new System.Drawing.Point(0, 0);
            this.Pozadina.Name = "Pozadina";
            this.Pozadina.Size = new System.Drawing.Size(468, 315);
            this.Pozadina.TabIndex = 0;
            this.Pozadina.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pozadina_MouseDown);
            this.Pozadina.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pozadina_MouseMove);
            this.Pozadina.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pozadina_MouseUp);
            // 
            // lblRegistrirajSe
            // 
            this.lblRegistrirajSe.AutoSize = true;
            this.lblRegistrirajSe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistrirajSe.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblRegistrirajSe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(220)))));
            this.lblRegistrirajSe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRegistrirajSe.Location = new System.Drawing.Point(262, 290);
            this.lblRegistrirajSe.Name = "lblRegistrirajSe";
            this.lblRegistrirajSe.Size = new System.Drawing.Size(71, 16);
            this.lblRegistrirajSe.TabIndex = 6;
            this.lblRegistrirajSe.Text = "Registriraj se";
            this.lblRegistrirajSe.Click += new System.EventHandler(this.lblRegistrirajSe_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lblText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblText.Location = new System.Drawing.Point(134, 290);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(134, 16);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "Nemaš korisnički račun?";
            // 
            // btnPrijaviSe
            // 
            this.btnPrijaviSe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(220)))));
            this.btnPrijaviSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrijaviSe.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnPrijaviSe.ForeColor = System.Drawing.Color.White;
            this.btnPrijaviSe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrijaviSe.Location = new System.Drawing.Point(196, 253);
            this.btnPrijaviSe.Name = "btnPrijaviSe";
            this.btnPrijaviSe.Size = new System.Drawing.Size(77, 26);
            this.btnPrijaviSe.TabIndex = 4;
            this.btnPrijaviSe.Text = "Prijavi se";
            this.btnPrijaviSe.UseVisualStyleBackColor = false;
            this.btnPrijaviSe.Click += new System.EventHandler(this.btnPrijaviSe_Click);
            // 
            // txtBoxKorZap
            // 
            this.txtBoxKorZap.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtBoxKorZap.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxKorZap.Location = new System.Drawing.Point(155, 202);
            this.txtBoxKorZap.Name = "txtBoxKorZap";
            this.txtBoxKorZap.Size = new System.Drawing.Size(158, 30);
            this.txtBoxKorZap.TabIndex = 3;
            this.txtBoxKorZap.Text = "Zaporka";
            this.txtBoxKorZap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxKorZap.Enter += new System.EventHandler(this.txtBoxKorZap_Enter);
            this.txtBoxKorZap.Leave += new System.EventHandler(this.txtBoxKorZap_Leave);
            // 
            // txtBoxKorIme
            // 
            this.txtBoxKorIme.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxKorIme.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.txtBoxKorIme.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxKorIme.Location = new System.Drawing.Point(155, 145);
            this.txtBoxKorIme.Name = "txtBoxKorIme";
            this.txtBoxKorIme.Size = new System.Drawing.Size(158, 30);
            this.txtBoxKorIme.TabIndex = 2;
            this.txtBoxKorIme.Text = "Korisničko ime";
            this.txtBoxKorIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxKorIme.Enter += new System.EventHandler(this.txtBoxKorIme_Enter);
            this.txtBoxKorIme.Leave += new System.EventHandler(this.txtBoxKorIme_Leave);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::FinancialBook.Properties.Resources.FBlogo;
            this.picBoxLogo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picBoxLogo.Location = new System.Drawing.Point(140, 23);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(188, 85);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            // 
            // picBoxX
            // 
            this.picBoxX.Image = global::FinancialBook.Properties.Resources.close20;
            this.picBoxX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picBoxX.Location = new System.Drawing.Point(439, 5);
            this.picBoxX.Name = "picBoxX";
            this.picBoxX.Size = new System.Drawing.Size(24, 24);
            this.picBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxX.TabIndex = 0;
            this.picBoxX.TabStop = false;
            this.picBoxX.Click += new System.EventHandler(this.picBoxX_Click);
            this.picBoxX.MouseLeave += new System.EventHandler(this.picBoxX_MouseLeave);
            this.picBoxX.MouseHover += new System.EventHandler(this.picBoxX_MouseHover);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 315);
            this.Controls.Add(this.Pozadina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Pozadina.ResumeLayout(false);
            this.Pozadina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pozadina;
        private System.Windows.Forms.PictureBox picBoxX;
        private System.Windows.Forms.Button btnPrijaviSe;
        private System.Windows.Forms.TextBox txtBoxKorZap;
        private System.Windows.Forms.TextBox txtBoxKorIme;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblRegistrirajSe;
    }
}

