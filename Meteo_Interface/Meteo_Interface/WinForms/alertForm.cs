using Meteo_Interface.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Meteo_Interface.WinForms
{
    public partial class alertForm : Form
    {
        private List<Measure> measures = MainForm.Measures;
        private readonly int _nbCol = 6;

        public alertForm()
        {
            InitializeComponent();
            LoadDataGridValues();
        }

        private void alertForm_Load(object sender, EventArgs e)
        {
            foreach (Measure measure in measures)
                if (measure.Alarm != null && !measure.IsConfiguratedStatus)
                    cmbIds.Items.Add(measure.Id);
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
                if (measure.IsConfiguratedStatus)
                {
                    dt.Rows.Add(
                       measure.Id.ToString(),
                       measure.Alarm.CriticalMin.ToString(),
                       measure.Alarm.WarningMin.ToString(),
                       measure.AlarmType.ToString(),
                       measure.Alarm.WarningMax.ToString(),
                       measure.Alarm.CriticalMax.ToString()
                   );
                }
            }

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Critical Min";
            dataGridView1.Columns[2].HeaderText = "Warning Min";
            dataGridView1.Columns[3].HeaderText = "Status";
            dataGridView1.Columns[4].HeaderText = "Warning Max";
            dataGridView1.Columns[5].HeaderText = "Critical Max";
        }

        private void bApply_Click(object sender, EventArgs e)
        {

            // Verifications
            int selectedId = (int)cmbIds.SelectedItem - 1;

            if (nudWarningMin.Value > nudWarningMax.Value || nudCriticalMin.Value > nudCriticalMax.Value)
            {
                MessageBox.Show("WarningMin can not be higher than WarningMax");
            }
            else
            {
                measures[selectedId].IsConfiguratedStatus = true;
                measures[selectedId].Alarm.CriticalMin = (int)nudCriticalMin.Value;
                measures[selectedId].Alarm.WarningMin = (int)nudWarningMin.Value;
                measures[selectedId].Alarm.CriticalMax = (int)nudCriticalMax.Value;
                measures[selectedId].Alarm.WarningMax = (int)nudWarningMax.Value;
                measures[selectedId].Alarm.AlarmPeriod = (int)nudMaxPeriod.Value;
                measures[selectedId].Data = ConvertData(measures[selectedId]);

                MessageBox.Show("Configuration has been added");
                LoadDataGridValues();
            }
        }

        private int ConvertData(Measure measure)
        {
            int converted = (measure.Data / 65535) * (measure.Alarm.Max + measure.Alarm.Min) - measure.Alarm.Min;
            measure.Alarm.ConvertedData = converted;
            return converted;
        }

        private void cmbIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (int)cmbIds.SelectedItem;
            Measure measure = measures[index - 1];

            lType.Text += measure.Type;
            lType.Text += " / Limits : ";
            lType.Text += measure.Alarm.Min.ToString() + " - " + measure.Alarm.Max.ToString();
            nudCriticalMax.Value = measure.Alarm.Max;
            nudWarningMax.Value = measure.Alarm.Max;
            nudWarningMin.Value = measure.Alarm.Min;
            nudCriticalMin.Value = measure.Alarm.Min;
        }
    }
}
