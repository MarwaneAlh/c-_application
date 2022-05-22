using Meteo_Interface.Model;
using Meteo_Interface.Resources;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Meteo_Interface.WinForms
{
    public partial class alertForm : Form
    {
        private List<Alarm> alarms = dataForm.Alarms;

        public alertForm()
        {
            InitializeComponent();
        }

        private void alertForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(alarms[0].Id);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
