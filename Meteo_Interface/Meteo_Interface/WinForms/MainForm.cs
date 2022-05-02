using System;
using System.IO.Ports;
using System.Data;
using System.Windows.Forms;

namespace Meteo_Interface
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();

            SerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialDataHandler.Reception.ReceptionHandler);

            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.ID);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.BinaryData);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.NbrBytes);
            Data.Tables.DataFromSensor.Columns.Add(Data.Tables.Columns.Type);
        }            
   
    }
}
