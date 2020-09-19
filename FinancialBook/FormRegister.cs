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
    public partial class FormRegister : Form
    {
        int mov;
        int movX;
        int movY;
        

        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|FBdb.mdf;Integrated Security=True;Connect Timeout=30";

        public FormRegister()
        {
            InitializeComponent();
        }        
        
        private void panelRegister_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }
        private void panelRegister_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void panelRegister_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void picBoxX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picBoxX_MouseHover(object sender, EventArgs e)
        {
            picBoxX.BackColor = Color.FromArgb(255, 196, 196);
        }

        private void picBoxX_MouseLeave(object sender, EventArgs e)
        {
            picBoxX.BackColor = Color.White;
        }

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            Owner.Enabled = false;
        } 
        private void checkBoxPrikaziZaporku_CheckedChanged(object sender, EventArgs e)
        {
            if( checkBoxPrikaziZaporku.Checked == true)
            {
                txtBoxKorZapRegister.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxKorZapRegister.UseSystemPasswordChar = true;
            }
        }        
        private void checkBoxPrikaziPonovi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrikaziPonovi.Checked == true)
            {
                txtBoxKorZapPonovi.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxKorZapPonovi.UseSystemPasswordChar = true;
            }
        }
        string querry = "";

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if(txtBoxKorImeRegister.Text == string.Empty || txtBoxKorZapPonovi.Text == string.Empty || txtBoxKorZapRegister.Text == string.Empty)
                {
                    MessageBox.Show("Molim popunite sva polja");
                    return;
                }
            else if (txtBoxKorZapRegister.Text == txtBoxKorZapPonovi.Text)
            { 
                querry = "SELECT * FROM tbl_glavna WHERE KorisnickoIme = '" + txtBoxKorImeRegister.Text + "'";
                SqlConnection Connection = new SqlConnection(conString);
                Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(querry, Connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Korisničko ime već postoji!!");
                    txtBoxKorImeRegister.Text = "";
                    txtBoxKorZapPonovi.Text = "";
                    txtBoxKorZapRegister.Text = "";
                    Connection.Close();
                }
                
                else
                {
                    Connection.Close();
                    string querryTekuciRacun = "INSERT INTO tbl_glavna(KorisnickoIme, Zaporka) values (@korIme, @zap)";
                    Connection.Open();
                    using(SqlCommand command = new SqlCommand(querryTekuciRacun, Connection))
                    {
                        command.Parameters.AddWithValue("@korIme", txtBoxKorImeRegister.Text);
                        command.Parameters.AddWithValue("@zap", txtBoxKorZapRegister.Text);
                        command.ExecuteNonQuery();
                        Connection.Close();
                        MessageBox.Show("Uspješna registracija!!");

                    }
                    string querryPocetna = "CREATE TABLE [dbo].["+txtBoxKorImeRegister.Text+ "_Tekuci_Racun] ([Iznos] DECIMAL(10,2) NULL,[Datum] DATETIME NULL,[Opis] NCHAR(100) NULL)";
                    Connection.Open();
                    SqlCommand commandPocetna = new SqlCommand(querryPocetna, Connection);
                    commandPocetna.ExecuteNonQuery();
                    Connection.Close();
                    string querryTekuciRacunPopuni = "INSERT INTO " + txtBoxKorImeRegister.Text + "_Tekuci_Racun(Iznos, Datum, Opis) values (@iznos, @datum, @opis)";
                    Connection.Open();
                    using(SqlCommand commandPopuni = new SqlCommand(querryTekuciRacunPopuni, Connection))
                    {
                        commandPopuni.Parameters.AddWithValue("@iznos","0");
                        commandPopuni.Parameters.AddWithValue("@datum", DateTime.Now);
                        commandPopuni.Parameters.AddWithValue("@opis"," ");
                        commandPopuni.ExecuteNonQuery();
                        Connection.Close();
                    }
                    
                    txtBoxKorImeRegister.Text = "";
                    txtBoxKorZapPonovi.Text = "";
                    txtBoxKorZapRegister.Text = "";
                    Close();
                }
            }
            else {
                MessageBox.Show("Zaporka nije identična!!");

            }
        }


    }
}
