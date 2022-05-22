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
        private List<Measure> measures = new List<Measure>();
        public static List<Alarm> Alarms = new List<Alarm>();

        public dataForm()
        {
            InitializeComponent();
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
                    measure.ConfigStatus ? "Done" : "None",
                    measure.Type.ToString(),
                    measure.Data.ToString(),
                    measure.LastUpdate.ToString(),
                    measure.Alarm.ToString()
                );
            }

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Config Status";
            dataGridView1.Columns[2].HeaderText = "Type";
            dataGridView1.Columns[3].HeaderText = "Data";
            dataGridView1.Columns[4].HeaderText = "Last Update";
            dataGridView1.Columns[5].HeaderText = "Alarm";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FillMeasureList();
            LoadDataGridValues();

            if (_lastId == 8)
            {
                timer1.Stop();
            }
        }

        private void FillMeasureList()
        {
            cmbIds.Items.Add(_lastId);
            measures.Add(new Measure(
                _lastId++,
                (DataType)new Random().Next(4),
                new Random().Next(65535),
                (AlarmType)new Random().Next(5)
            ));
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            //Faire les vérifications
            int selectedIndex = (int)cmbIds.SelectedItem;
            int min = (int)nudMin.Value;
            int max = (int)nudMax.Value;

            Console.WriteLine(selectedIndex);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Alarms.Add(new Alarm(
                measures[selectedIndex - 1],
                min,
                max
            ));

            //Envoyer la liste vers AlertForm
        }
    }
}
