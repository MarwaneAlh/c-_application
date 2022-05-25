using Meteo_Interface.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Meteo_Interface.Resources
{
    public partial class dataForm : Form
    {
        private readonly int _nbCol = 6;
        private int _lastId = 1;
        private List<Measure> measures = MainForm.Measures;

        public dataForm()
        {
            InitializeComponent();
            LoadDataGridValues();

            lType.Visible = false;
            lStatus.Visible = false;
        }

        private void LoadDataGridValues()
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            for (int i = 0; i < _nbCol; i++)
            {
                dt.Columns.Add();
            }

            foreach (Measure measure in measures)
            {
                dt.Rows.Add(
                    measure.Id.ToString(),
                    IsConfigLabel(measure.IsConfiguratedStatus),
                    measure.Type.ToString(),
                    ConvertedData(measure),
                    measure.LastUpdate.ToString()+" sec",
                    ConvertedAlarm(measure)
                );
                AddCmbItems(measure);
            }
            
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Config Status";
            dataGridView1.Columns[2].HeaderText = "Type";
            dataGridView1.Columns[3].HeaderText = "Data";
            dataGridView1.Columns[4].HeaderText = "Last Update";
            dataGridView1.Columns[5].HeaderText = "Alarm";
        }

        private string ConvertedAlarm(Measure measure)
        {
            AlarmType alarmType = AlarmType.Ok;
            Alarm alarm = measure.Alarm;
            if(alarm != null)
            {
                if(alarm.ConvertedData <= alarm.WarningMin && alarm.ConvertedData >= alarm.CriticalMin)
                {
                    alarmType = AlarmType.Low;
                }
                else if (alarm.ConvertedData <= alarm.CriticalMin)
                {
                    alarmType = AlarmType.Too_Low;
                }

                else if (alarm.ConvertedData >= alarm.WarningMax && alarm.ConvertedData <= alarm.CriticalMax)
                {
                    alarmType = AlarmType.High;
                }
                else if (alarm.ConvertedData >= alarm.CriticalMax)
                {
                    alarmType = AlarmType.Too_High;
                }
            }

            measure.AlarmType = alarmType;
            return alarmType.ToString();
        }

        private string ConvertedData(Measure measure)
        {
            string value = measure.Data.ToString();
            if (measure.IsConfiguratedStatus)
            {
                value = measure.Alarm.ConvertedData.ToString();
                switch (measure.Type)
                {
                    case DataType.Co2:
                        value += " ppm";
                        break;
                    case DataType.Temperature:
                        value += " C°";
                        break;

                        //PAS OUBLIER LES AUTRES
                }
            }
            return value;
        }

        private void FillMeasureList()
        {
            measures.Add(new Measure(
                _lastId++,
                (DataType)new Random().Next(4),
                new Random().Next(65535),
                (AlarmType)new Random().Next(5)
            ));
        }

        private void AddCmbItems(Measure measure)
        {
            if (!measure.IsConfiguratedStatus && !cmbIds.Items.Contains(measure.Id))
            cmbIds.Items.Add(measure.Id);
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            //Faire les vérifications

            int selectedIndex = (int)cmbIds.SelectedItem - 1;
            int min = (int)nudMin.Value;
            int max = (int)nudMax.Value;

            if(min > max)
            {
                MessageBox.Show("Min can not be higher than max");
            }
            else
            {
                Console.WriteLine(selectedIndex);
                Console.WriteLine(min);
                Console.WriteLine(max);
                measures[selectedIndex].Alarm = new Alarm(min, max);

                MessageBox.Show("Alarm has been added");
            }
        }

        private void cmbIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            lType.Visible = true;
            lStatus.Visible = true;

            int index = (int)cmbIds.SelectedItem;
            Measure measure = measures[index - 1];
            lType.Text += measure.Type;
            lStatus.Text += IsConfigLabel(measure.IsConfiguratedStatus);
        }

        private string IsConfigLabel(bool isConfig)
        {
            return isConfig ? "Done" : "None";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (measures.Count >= 8)
            {
                timer1.Stop();
                timer2.Enabled = true;
                timer2.Start();
            }
            else
            {
                FillMeasureList();
                LoadDataGridValues();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            measures.ForEach(measure => measure.LastUpdate++);
            int indexMeasure = new Random().Next(measures.Count);

            measures[indexMeasure].Data = new Random().Next(65535);
            measures[indexMeasure].LastUpdate = 0;
            LoadDataGridValues();
        }
    }
}
