using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialBook
{
    public partial class FormLogIn : Form
    {
        int mov;
        int movX;
        int movY;
        public static string name;
        public FormLogIn()
        {
            InitializeComponent();
            
        }
        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|FBdb.mdf;Integrated Security=True;Connect Timeout=30";
        private void Pozadina_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void Pozadina_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }


        private void Pozadina_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void picBoxX_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void picBoxX_MouseHover(object sender, EventArgs e)
        {
            picBoxX.BackColor = Color.FromArgb(255, 196, 196);
        }

        private void picBoxX_MouseLeave(object sender, EventArgs e)
        {
            picBoxX.BackColor = Color.White;
            
        }

        private void txtBoxKorIme_Leave(object sender, EventArgs e)
        {
            if (txtBoxKorIme.Text == "")
            {
                txtBoxKorIme.Text = "Korisničko ime";
                txtBoxKorIme.ForeColor = Color.Gray;
            }
        }

        private void txtBoxKorIme_Enter(object sender, EventArgs e)
        {
            if(txtBoxKorIme.Text == "Korisničko ime")
            {
                txtBoxKorIme.Text = null;
                txtBoxKorIme.ForeColor = Color.Black;
            }
        }

        private void txtBoxKorZap_Leave(object sender, EventArgs e)
        {
            if (txtBoxKorZap.Text == "")
            {
                txtBoxKorZap.UseSystemPasswordChar = false;
                txtBoxKorZap.Text = "Zaporka";
                txtBoxKorZap.ForeColor = Color.Gray;
            }
        }

        private void txtBoxKorZap_Enter(object sender, EventArgs e)
        {
            if (txtBoxKorZap.Text == "Zaporka")
            {
                txtBoxKorZap.UseSystemPasswordChar = true;
                txtBoxKorZap.Text = null;
                txtBoxKorZap.ForeColor = Color.Black;
            }
        }

        private void lblRegistrirajSe_Click(object sender, EventArgs e)
        {
            
            FormRegister register = new FormRegister();
            register.Owner = this;
            register.Show();
        }
        string querry = "";
        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            querry = "SELECT * FROM tbl_glavna WHERE KorisnickoIme = '" + txtBoxKorIme.Text + "' and Zaporka = '"+txtBoxKorZap.Text+"'";
            SqlConnection Connection = new SqlConnection(conString);
            Connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(querry,Connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                
                name = txtBoxKorIme.Text;
                txtBoxKorIme.Text = "";
                txtBoxKorZap.Text = "";
                Connection.Close();
                this.Hide();
                FormMainBoard board = new FormMainBoard();
                board.ShowDialog();
                //this.Close();                
            }
            else{
                MessageBox.Show("Molim provjeri korisničko ime i zaporku!!");
                txtBoxKorIme.Text = "";
                txtBoxKorZap.Text = "";
                Connection.Close();
            }
        }
    }
}
