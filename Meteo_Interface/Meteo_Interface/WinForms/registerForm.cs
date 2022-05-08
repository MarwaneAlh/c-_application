using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meteo_Interface.WinForms
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            
            if (userName.Text == "" || password.Text == "" || password2.Text == "")
            {
                //Debug.WriteLine("Test");
                MessageBox.Show("Veuillez remplire tout les champs", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (password.Text == password2.Text)
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Marwa\OneDrive\Bureau\projetHelb\Capplicationdebug\c-_application\Meteo_Interface\Meteo_Interface\db.accdb");
                //con.ConnectionString = ConfigurationManager.ConnectionStrings["Meteo_Interface.Properties.Settings.dbConnectionString"].ToString();
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "insert into UserTable(UserName,UserPassword)values(@user,@password)";
                cmd.Parameters.AddWithValue("@user", userName.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Connection = con;
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                { 
                    con.Close();
                    MessageBox.Show("Compte créer avec succés !");
                    Form actual = this.FindForm();
                    actual.Close();
                    //myAccount m = new myAccount();
                    

                    

                    //this.Hide();
                   

                   
                }

            }
            else
            {
            MessageBox.Show("Les mots de passe sont differents", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

      
    }
}
