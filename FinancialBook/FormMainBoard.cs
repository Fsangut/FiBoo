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
    public partial class FormMainBoard : Form
    {
        
        int mov;
        int movX;
        int movY;
        public FormMainBoard()
        {
            InitializeComponent();
        }
        static string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|FBdb.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection Connection = new SqlConnection(conString);
        private void FormMainBoard_Load(object sender, EventArgs e)
        {
            comboBoxOdaberiOpciju.SelectedIndex = 0;
            txtBoxIznos.Text = "Unesi iznos";
            txtBoxOpis.Text = "Opis";
            lblIme.Text = FormLogIn.name;
            txtBoxIznos.Enabled = false;
            btnUnesi.Enabled = false;
            comboBoxOdaberiRacun.Enabled = false;
            txtBoxOpis.Enabled = false;
            ucitajSveRacune();
            popuniListu();
            popuniRacune();
        }     

        private void pozadina_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void pozadina_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pozadina_MouseUp(object sender, MouseEventArgs e)
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
        private void txtBoxIznos_Enter(object sender, EventArgs e)
        {
            if (txtBoxIznos.Text == "Unesi iznos")
            {
                txtBoxIznos.Text = null;
                txtBoxIznos.ForeColor = Color.Black;
            }
        }
        private void txtBoxIznos_Leave(object sender, EventArgs e)
        {
            if (txtBoxIznos.Text == "")
            {
                txtBoxIznos.Text = "Unesi iznos";
                txtBoxIznos.ForeColor = Color.Gray;
            }
        } 
        private void txtBoxOpis_Enter(object sender, EventArgs e)
        {
            if (txtBoxOpis.Text == "Opis")
            {
                txtBoxOpis.Text = null;
                txtBoxOpis.ForeColor = Color.Black;
            }
        }

        private void txtBoxOpis_Leave(object sender, EventArgs e)
        {
            if (txtBoxOpis.Text == "")
            {
                txtBoxOpis.Text = "Opis";
                txtBoxOpis.ForeColor = Color.Gray;
            }
        }
        private void comboBoxOdaberiOpciju_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxOdaberiOpciju.SelectedItem.ToString()== "Odaberi opciju")
            {
                txtBoxIznos.Enabled = false;
                btnUnesi.Enabled = false;
                comboBoxOdaberiRacun.Enabled = false;
                txtBoxOpis.Enabled = false;
            }
            else if(comboBoxOdaberiOpciju.SelectedItem.ToString() == "Prihod")
            {
                txtBoxIznos.Enabled = true;
                btnUnesi.Enabled = true;
                comboBoxOdaberiRacun.Enabled = false;
                txtBoxOpis.Enabled = true;
            }
            else if (comboBoxOdaberiOpciju.SelectedItem.ToString() == "Rashod")
            {
                txtBoxIznos.Enabled = true;
                btnUnesi.Enabled = true;
                comboBoxOdaberiRacun.Enabled = false;
                txtBoxOpis.Enabled = true;
            }
            else if(comboBoxOdaberiOpciju.SelectedItem.ToString() == "Prijenos")
            {
                txtBoxIznos.Enabled = true;
                btnUnesi.Enabled = true;
                comboBoxOdaberiRacun.Enabled = true;
                txtBoxOpis.Enabled = true;
            }
        }        
        private void checkBoxDodajNoviRacun_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDodajNoviRacun.Checked == true)
            {
                txtBoxDodajNoviRacun.Visible = true;
                btnDodajNoviRacun.Visible = true;
                btnObrisiOdabraniRacun.Visible = false;
            }
            else
            {
                txtBoxDodajNoviRacun.Visible = false;
                btnDodajNoviRacun.Visible = false;
                btnObrisiOdabraniRacun.Visible = true;
            }

        }       
        private void btnDodajNoviRacun_Click(object sender, EventArgs e)
        {
            string querryPocetna = "CREATE TABLE [dbo].[" + FormLogIn.name+"_" + txtBoxDodajNoviRacun.Text.Replace(" ","_")+"] ([Iznos] DECIMAL(10,2) NULL,[Datum] DATETIME NULL,[Opis] NCHAR(100) NULL)";
            Connection.Open();
            SqlCommand commandPocetna = new SqlCommand(querryPocetna, Connection);
            commandPocetna.ExecuteNonQuery();
            Connection.Close();
            string querryTekuciRacunPopuni = "INSERT INTO " + FormLogIn.name + "_" + txtBoxDodajNoviRacun.Text.Replace(" ", "_") + "(Iznos, Datum, Opis) values (@iznos, @datum, @opis)";
            Connection.Open();
            using (SqlCommand commandPopuni = new SqlCommand(querryTekuciRacunPopuni, Connection))
            {
                commandPopuni.Parameters.AddWithValue("@iznos", "0");
                commandPopuni.Parameters.AddWithValue("@datum", DateTime.Now);
                commandPopuni.Parameters.AddWithValue("@opis", " ");
                commandPopuni.ExecuteNonQuery();
                Connection.Close();
            }
            ucitajSveRacune();
            popuniListu();
            popuniRacune();
            txtBoxDodajNoviRacun.Text = "";
            MessageBox.Show("Uspješno dodan novi račun");
        }        
        private void comboBoxPrikazaniRacun_SelectedIndexChanged(object sender, EventArgs e)
        {
            popuniListu();
            popuniRacune();
        }       
        private void btnObrisiOdabraniRacun_Click(object sender, EventArgs e)
        {
            string querryObrisi = "DROP TABLE "+ this.comboBoxPrikazaniRacun.GetItemText(this.comboBoxPrikazaniRacun.SelectedItem).ToString().Replace("  ", FormLogIn.name + "_").Replace(" ", "_");
            SqlConnection Connection = new SqlConnection(conString);
            Connection.Open();
            using (SqlCommand commandObrisi = new SqlCommand(querryObrisi, Connection))
            {
                commandObrisi.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Račun je uspješno obrisan!");
                ucitajSveRacune();
                popuniListu();
                popuniRacune();
            }
                
            
        }
        

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (comboBoxOdaberiOpciju.SelectedItem.ToString() == "Prihod")
            {
                if (!int.TryParse(txtBoxIznos.Text, out parsedValue))
                {
                    MessageBox.Show("Polje za unos ne može sadržavati slova");
                    return;
                }
                else
                {
                    
                    string querryUnesi = "INSERT INTO "+ this.comboBoxPrikazaniRacun.GetItemText(this.comboBoxPrikazaniRacun.SelectedItem).ToString().Replace("  ", FormLogIn.name + "_").Replace(" ", "_") + "(Iznos, Datum, Opis) values (@iznos, @datum, @opis)";
                    SqlConnection Connection = new SqlConnection(conString);
                    Connection.Open();
                    using (SqlCommand commandUnesi = new SqlCommand(querryUnesi, Connection))
                    {
                        commandUnesi.Parameters.AddWithValue("@iznos", Convert.ToDecimal(txtBoxIznos.Text));
                        commandUnesi.Parameters.AddWithValue("@datum", DateTime.Now);
                        commandUnesi.Parameters.AddWithValue("@opis", txtBoxOpis.Text);
                        commandUnesi.ExecuteNonQuery();
                        Connection.Close();
                        txtBoxIznos.Text = "Unesi iznos";
                        txtBoxOpis.Text = "Opis";
                        popuniListu();
                        
                    }

                }
            }
            else if (comboBoxOdaberiOpciju.SelectedItem.ToString() == "Rashod")
            {
                if (!int.TryParse(txtBoxIznos.Text, out parsedValue))
                {
                    MessageBox.Show("Polje za unos ne može sadržavati slova");
                    return;
                }
                else
                {

                    string querryUnesi = "INSERT INTO " + this.comboBoxPrikazaniRacun.GetItemText(this.comboBoxPrikazaniRacun.SelectedItem).ToString().Replace("  ", FormLogIn.name + "_").Replace(" ", "_") + "(Iznos, Datum, Opis) values (@iznos, @datum, @opis)";
                    SqlConnection Connection = new SqlConnection(conString);
                    Connection.Open();
                    using (SqlCommand commandUnesi = new SqlCommand(querryUnesi, Connection))
                    {
                        commandUnesi.Parameters.AddWithValue("@iznos", -1*Convert.ToDecimal(txtBoxIznos.Text));
                        commandUnesi.Parameters.AddWithValue("@datum", DateTime.Now);
                        commandUnesi.Parameters.AddWithValue("@opis", txtBoxOpis.Text);
                        commandUnesi.ExecuteNonQuery();
                        Connection.Close();
                        txtBoxIznos.Text = "Unesi iznos";
                        txtBoxOpis.Text = "Opis";
                        popuniListu();

                    }

                }
            }
            else if (comboBoxOdaberiOpciju.SelectedItem.ToString() == "Prijenos")
            {
                if (!int.TryParse(txtBoxIznos.Text, out parsedValue))
                {
                    MessageBox.Show("Polje za unos ne može sadržavati slova");
                    return;
                }
                else
                {
                    if (comboBoxOdaberiRacun.SelectedItem.ToString() == "Odaberi racun")
                    {
                        MessageBox.Show("Odaberi jedan od računa ako je prijenos sa jednoga računa na drugi ili odaberi prihod-rashod");
                    }
                    else
                    {
                        string querryUnesiNeg = "INSERT INTO " + this.comboBoxPrikazaniRacun.GetItemText(this.comboBoxPrikazaniRacun.SelectedItem).ToString().Replace("  ", FormLogIn.name + "_").Replace(" ", "_") + "(Iznos, Datum, Opis) values (@iznos, @datum, @opis)";
                        SqlConnection Connection = new SqlConnection(conString);
                        Connection.Open();
                        using (SqlCommand commandUnesiNeg = new SqlCommand(querryUnesiNeg, Connection))
                        {
                            commandUnesiNeg.Parameters.AddWithValue("@iznos", -1 * Convert.ToDecimal(txtBoxIznos.Text));
                            commandUnesiNeg.Parameters.AddWithValue("@datum", DateTime.Now);
                            commandUnesiNeg.Parameters.AddWithValue("@opis", txtBoxOpis.Text);
                            commandUnesiNeg.ExecuteNonQuery();
                            Connection.Close();
                            
                            popuniListu();

                        }
                        string querryOduzmi = "INSERT INTO " + this.comboBoxOdaberiRacun.GetItemText(this.comboBoxOdaberiRacun.SelectedItem).ToString().Replace("  ", FormLogIn.name + "_").Replace(" ", "_") + "(Iznos, Datum, Opis) values (@iznos, @datum, @opis)"; ;
                        SqlConnection conn = new SqlConnection(conString);
                        conn.Open();
                        using (SqlCommand commandOduzmi = new SqlCommand(querryOduzmi, conn))
                        {
                            commandOduzmi.Parameters.AddWithValue("@iznos", Convert.ToDecimal(txtBoxIznos.Text));
                            commandOduzmi.Parameters.AddWithValue("@datum", DateTime.Now);
                            commandOduzmi.Parameters.AddWithValue("@opis", txtBoxOpis.Text);
                            commandOduzmi.ExecuteNonQuery();
                            conn.Close();
                            txtBoxIznos.Text = "Unesi iznos";
                            txtBoxOpis.Text = "Opis";
                            popuniListu();

                        }
                    }
                }
            }
        }
        public void ucitajSveRacune()
        {
            comboBoxPrikazaniRacun.Items.Clear();
            string querryUcitaj = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME LIKE '%" + FormLogIn.name + "%'";
            Connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(querryUcitaj, Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxPrikazaniRacun.Items.Add(dr["TABLE_NAME"].ToString().Replace(FormLogIn.name, " ").Replace("_", " "));
            }
            Connection.Close();
            comboBoxPrikazaniRacun.SelectedIndex = 0;
        }
        public void popuniListu()
        {
            listViewPopisTransakcija.Items.Clear();
            string querryOsvjeziListu = "SELECT * FROM " + this.comboBoxPrikazaniRacun.GetItemText(this.comboBoxPrikazaniRacun.SelectedItem).ToString().Replace("  ", FormLogIn.name + "_").Replace(" ", "_") + " ORDER BY Datum DESC";
            Connection.Open();
            SqlCommand comm = new SqlCommand(querryOsvjeziListu, Connection);
            SqlDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["Iznos"].ToString());
                item.SubItems.Add(dr["Datum"].ToString());
                item.SubItems.Add(dr["Opis"].ToString());

                listViewPopisTransakcija.Items.Add(item);
            }
            Connection.Close();
            string querryUkupanIznos = "SELECT SUM(Iznos) FROM " + this.comboBoxPrikazaniRacun.GetItemText(this.comboBoxPrikazaniRacun.SelectedItem).ToString().Replace("  ", FormLogIn.name + "_").Replace(" ", "_");
            Connection.Open();
            SqlCommand commSum = new SqlCommand(querryUkupanIznos, Connection);
            object result = commSum.ExecuteScalar();
            txtBoxIznosRacuna.Text = Convert.ToString(result);
            Connection.Close();
        }
        public void popuniRacune()
        {
            comboBoxOdaberiRacun.Items.Clear();
            string querryUcitaj = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME LIKE '%" + FormLogIn.name + "%'";

            Connection.Open();

            comboBoxOdaberiRacun.Items.Add("Odaberi racun");
            SqlDataAdapter da = new SqlDataAdapter(querryUcitaj, Connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["TABLE_NAME"].ToString().Replace(FormLogIn.name, " ").Replace("_", " ") == this.comboBoxPrikazaniRacun.GetItemText(this.comboBoxPrikazaniRacun.SelectedItem).ToString())
                {
                    continue;
                }
                else
                {
                    comboBoxOdaberiRacun.Items.Add(dr["TABLE_NAME"].ToString().Replace(FormLogIn.name, " ").Replace("_", " "));
                }
            }
            Connection.Close();
            comboBoxOdaberiRacun.SelectedIndex = 0;
        }

    }
}
