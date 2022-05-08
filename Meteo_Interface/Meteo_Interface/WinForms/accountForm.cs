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
    public partial class accountForm : Form
    {

        public Panel panelmain;
        public accountForm()
        {
            InitializeComponent();


            loadform(new ConnectingForm());
            setConnected();
        }


        public void loadform(object Form)
        {

            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            this.panel1.Tag = f;
            f.Show();


        }
        public void setConnected()
        {
            if (this.panel1.Controls.Count == 0)
            {
                myAccount m = new myAccount();
                m.TopLevel = false;
                m.Dock = DockStyle.Fill;
                this.panel1.Controls.Add(m);
                this.panel1.Tag = m;
                m.Show();
            }
        }




        private void connectBtn_Click(object sender, EventArgs e)
        {
            loadform(new ConnectingForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new registerForm());
        }


      
    }
}
