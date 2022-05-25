
namespace Meteo_Interface.WinForms
{
    partial class alertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudMaxPeriod = new System.Windows.Forms.NumericUpDown();
            this.nudCriticalMin = new System.Windows.Forms.NumericUpDown();
            this.nudWarningMin = new System.Windows.Forms.NumericUpDown();
            this.lMaxPeriod = new System.Windows.Forms.Label();
            this.lCritcialMin = new System.Windows.Forms.Label();
            this.lWarningMin = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.lWarningMax = new System.Windows.Forms.Label();
            this.lCriticalMax = new System.Windows.Forms.Label();
            this.lID = new System.Windows.Forms.Label();
            this.cmbIds = new System.Windows.Forms.ComboBox();
            this.nudWarningMax = new System.Windows.Forms.NumericUpDown();
            this.nudCriticalMax = new System.Windows.Forms.NumericUpDown();
            this.bApply = new System.Windows.Forms.Button();
            this.lAlarm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriticalMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarningMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarningMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriticalMax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(468, -85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALERT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(659, 262);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMaxPeriod);
            this.groupBox1.Controls.Add(this.nudCriticalMin);
            this.groupBox1.Controls.Add(this.nudWarningMin);
            this.groupBox1.Controls.Add(this.lMaxPeriod);
            this.groupBox1.Controls.Add(this.lCritcialMin);
            this.groupBox1.Controls.Add(this.lWarningMin);
            this.groupBox1.Controls.Add(this.lType);
            this.groupBox1.Controls.Add(this.lWarningMax);
            this.groupBox1.Controls.Add(this.lCriticalMax);
            this.groupBox1.Controls.Add(this.lID);
            this.groupBox1.Controls.Add(this.cmbIds);
            this.groupBox1.Controls.Add(this.nudWarningMax);
            this.groupBox1.Controls.Add(this.nudCriticalMax);
            this.groupBox1.Controls.Add(this.bApply);
            this.groupBox1.Controls.Add(this.lAlarm);
            this.groupBox1.Location = new System.Drawing.Point(724, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 498);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // nudMaxPeriod
            // 
            this.nudMaxPeriod.Location = new System.Drawing.Point(134, 394);
            this.nudMaxPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxPeriod.Name = "nudMaxPeriod";
            this.nudMaxPeriod.Size = new System.Drawing.Size(201, 26);
            this.nudMaxPeriod.TabIndex = 15;
            this.nudMaxPeriod.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudCriticalMin
            // 
            this.nudCriticalMin.Location = new System.Drawing.Point(134, 357);
            this.nudCriticalMin.Name = "nudCriticalMin";
            this.nudCriticalMin.Size = new System.Drawing.Size(201, 26);
            this.nudCriticalMin.TabIndex = 14;
            // 
            // nudWarningMin
            // 
            this.nudWarningMin.Location = new System.Drawing.Point(134, 310);
            this.nudWarningMin.Name = "nudWarningMin";
            this.nudWarningMin.Size = new System.Drawing.Size(201, 26);
            this.nudWarningMin.TabIndex = 13;
            // 
            // lMaxPeriod
            // 
            this.lMaxPeriod.AutoSize = true;
            this.lMaxPeriod.ForeColor = System.Drawing.SystemColors.Control;
            this.lMaxPeriod.Location = new System.Drawing.Point(15, 394);
            this.lMaxPeriod.Name = "lMaxPeriod";
            this.lMaxPeriod.Size = new System.Drawing.Size(99, 20);
            this.lMaxPeriod.TabIndex = 12;
            this.lMaxPeriod.Text = "Max Period : ";
            // 
            // lCritcialMin
            // 
            this.lCritcialMin.AutoSize = true;
            this.lCritcialMin.ForeColor = System.Drawing.SystemColors.Control;
            this.lCritcialMin.Location = new System.Drawing.Point(19, 357);
            this.lCritcialMin.Name = "lCritcialMin";
            this.lCritcialMin.Size = new System.Drawing.Size(97, 20);
            this.lCritcialMin.TabIndex = 11;
            this.lCritcialMin.Text = "Critical Min : ";
            // 
            // lWarningMin
            // 
            this.lWarningMin.AutoSize = true;
            this.lWarningMin.ForeColor = System.Drawing.SystemColors.Control;
            this.lWarningMin.Location = new System.Drawing.Point(17, 310);
            this.lWarningMin.Name = "lWarningMin";
            this.lWarningMin.Size = new System.Drawing.Size(109, 20);
            this.lWarningMin.TabIndex = 10;
            this.lWarningMin.Text = "Warning Min : ";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.ForeColor = System.Drawing.SystemColors.Control;
            this.lType.Location = new System.Drawing.Point(73, 273);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(55, 20);
            this.lType.TabIndex = 9;
            this.lType.Text = "Type : ";
            // 
            // lWarningMax
            // 
            this.lWarningMax.AutoSize = true;
            this.lWarningMax.ForeColor = System.Drawing.SystemColors.Control;
            this.lWarningMax.Location = new System.Drawing.Point(15, 227);
            this.lWarningMax.Name = "lWarningMax";
            this.lWarningMax.Size = new System.Drawing.Size(113, 20);
            this.lWarningMax.TabIndex = 8;
            this.lWarningMax.Text = "Warning Max : ";
            // 
            // lCriticalMax
            // 
            this.lCriticalMax.AutoSize = true;
            this.lCriticalMax.ForeColor = System.Drawing.SystemColors.Control;
            this.lCriticalMax.Location = new System.Drawing.Point(15, 183);
            this.lCriticalMax.Name = "lCriticalMax";
            this.lCriticalMax.Size = new System.Drawing.Size(101, 20);
            this.lCriticalMax.TabIndex = 7;
            this.lCriticalMax.Text = "Critical Max : ";
            // 
            // lID
            // 
            this.lID.AutoSize = true;
            this.lID.ForeColor = System.Drawing.SystemColors.Control;
            this.lID.Location = new System.Drawing.Point(7, 117);
            this.lID.Name = "lID";
            this.lID.Size = new System.Drawing.Size(34, 20);
            this.lID.TabIndex = 5;
            this.lID.Text = "ID :";
            // 
            // cmbIds
            // 
            this.cmbIds.FormattingEnabled = true;
            this.cmbIds.Location = new System.Drawing.Point(67, 117);
            this.cmbIds.Name = "cmbIds";
            this.cmbIds.Size = new System.Drawing.Size(268, 28);
            this.cmbIds.TabIndex = 4;
            this.cmbIds.SelectedIndexChanged += new System.EventHandler(this.cmbIds_SelectedIndexChanged);
            // 
            // nudWarningMax
            // 
            this.nudWarningMax.Location = new System.Drawing.Point(134, 227);
            this.nudWarningMax.Name = "nudWarningMax";
            this.nudWarningMax.Size = new System.Drawing.Size(201, 26);
            this.nudWarningMax.TabIndex = 3;
            // 
            // nudCriticalMax
            // 
            this.nudCriticalMax.Location = new System.Drawing.Point(134, 183);
            this.nudCriticalMax.Name = "nudCriticalMax";
            this.nudCriticalMax.Size = new System.Drawing.Size(201, 26);
            this.nudCriticalMax.TabIndex = 2;
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(134, 444);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(143, 44);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // lAlarm
            // 
            this.lAlarm.AutoSize = true;
            this.lAlarm.ForeColor = System.Drawing.SystemColors.Control;
            this.lAlarm.Location = new System.Drawing.Point(61, 32);
            this.lAlarm.Name = "lAlarm";
            this.lAlarm.Size = new System.Drawing.Size(50, 20);
            this.lAlarm.TabIndex = 0;
            this.lAlarm.Text = "Alarm";
            // 
            // alertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1109, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "alertForm";
            this.Text = "alertForm";
            this.Load += new System.EventHandler(this.alertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriticalMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarningMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarningMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriticalMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lWarningMax;
        private System.Windows.Forms.Label lCriticalMax;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.ComboBox cmbIds;
        private System.Windows.Forms.NumericUpDown nudWarningMax;
        private System.Windows.Forms.NumericUpDown nudCriticalMax;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Label lAlarm;
        private System.Windows.Forms.Label lWarningMin;
        private System.Windows.Forms.Label lCritcialMin;
        private System.Windows.Forms.Label lMaxPeriod;
        private System.Windows.Forms.NumericUpDown nudCriticalMin;
        private System.Windows.Forms.NumericUpDown nudWarningMin;
        private System.Windows.Forms.NumericUpDown nudMaxPeriod;
    }
}