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
                    measure.IsConfiguratedStatus ? "Done" : "None",
                    measure.Type.ToString(),
                    measure.Data.ToString(),
                    measure.LastUpdate.ToString(),
                    measure.AlarmType.ToString()
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

            Console.WriteLine(selectedIndex);
            Console.WriteLine(min);
            Console.WriteLine(max);
            measures[selectedIndex].Alarm = new Alarm(min, max);

            MessageBox.Show("Alarm has been added");
         
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (measures.Count >= 8)
            {
                timer1.Stop();
            }
            else
            {
                FillMeasureList();
                LoadDataGridValues();
            }
        }
    }
}
