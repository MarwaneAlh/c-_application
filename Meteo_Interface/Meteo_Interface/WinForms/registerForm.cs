using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
              

            }
            else
            {
            MessageBox.Show("Les mots de passe sont differents", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
