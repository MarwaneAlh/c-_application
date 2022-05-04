using System;
using System.IO.Ports;
using System.Data;
using System.Windows.Forms;
using Meteo_Interface.WinForms;
using Meteo_Interface.Resources;
using System.Drawing;

namespace Meteo_Interface
{
    public partial class MainForm : Form
    {


        public MainForm()
        {

            
            InitializeComponent();
            loadform(new dataForm());

            SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataHandler.Reception.ReceptionHandler);

            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.ID);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.BinaryData);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.NbrBytes);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Type);
          
       
        }
        
        public void loadform(object Form)
        {

            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();

        }

        private void databutton_Click(object sender, EventArgs e)
        {
            loadform(new dataForm());
            whereIam.Height = databutton.Height;
            whereIam.Top = databutton.Top;
        }

        private void alertbutton_Click(object sender, EventArgs e)
        {
            loadform(new alertForm());
            whereIam.Height = alertbutton.Height;
            whereIam.Top = alertbutton.Top;
        }

        private void chartbutton_Click(object sender, EventArgs e)
        {
            loadform(new chartForm());
            whereIam.Height = chartbutton.Height;
            whereIam.Top = chartbutton.Top;
        }

        private void accountbutton_Click(object sender, EventArgs e)
        {
            loadform(new accountForm());
            whereIam.Height = accountbutton.Height;
            whereIam.Top = accountbutton.Top;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            loadform(new saveForm());
            whereIam.Height = savebutton.Height;
            whereIam.Top = savebutton.Top;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
