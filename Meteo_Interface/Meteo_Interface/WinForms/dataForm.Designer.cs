
using System;

namespace Meteo_Interface.Resources
{
    partial class dataForm
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
            this.components = new System.ComponentModel.Container();
            this.lData = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.lMax = new System.Windows.Forms.Label();
            this.lMin = new System.Windows.Forms.Label();
            this.lType = new System.Windows.Forms.Label();
            this.lID = new System.Windows.Forms.Label();
            this.cmbIds = new System.Windows.Forms.ComboBox();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.bApply = new System.Windows.Forms.Button();
            this.lConfig = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            this.SuspendLayout();
            // 
            // lData
            // 
            this.lData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lData.AutoSize = true;
            this.lData.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lData.ForeColor = System.Drawing.Color.White;
            this.lData.Location = new System.Drawing.Point(513, 0);
            this.lData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(171, 61);
            this.lData.TabIndex = 3;
            this.lData.Text = "DATA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(790, 398);
            this.dataGridView1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lStatus);
            this.groupBox1.Controls.Add(this.lMax);
            this.groupBox1.Controls.Add(this.lMin);
            this.groupBox1.Controls.Add(this.lType);
            this.groupBox1.Controls.Add(this.lID);
            this.groupBox1.Controls.Add(this.cmbIds);
            this.groupBox1.Controls.Add(this.nudMax);
            this.groupBox1.Controls.Add(this.nudMin);
            this.groupBox1.Controls.Add(this.bApply);
            this.groupBox1.Controls.Add(this.lConfig);
            this.groupBox1.Location = new System.Drawing.Point(937, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 398);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.lStatus.Location = new System.Drawing.Point(71, 269);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(68, 20);
            this.lStatus.TabIndex = 9;
            this.lStatus.Text = "Status : ";
            // 
            // lMax
            // 
            this.lMax.AutoSize = true;
            this.lMax.ForeColor = System.Drawing.SystemColors.Control;
            this.lMax.Location = new System.Drawing.Point(15, 227);
            this.lMax.Name = "lMax";
            this.lMax.Size = new System.Drawing.Size(50, 20);
            this.lMax.TabIndex = 8;
            this.lMax.Text = "Max : ";
            // 
            // lMin
            // 
            this.lMin.AutoSize = true;
            this.lMin.ForeColor = System.Drawing.SystemColors.Control;
            this.lMin.Location = new System.Drawing.Point(11, 183);
            this.lMin.Name = "lMin";
            this.lMin.Size = new System.Drawing.Size(46, 20);
            this.lMin.TabIndex = 7;
            this.lMin.Text = "Min : ";
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.ForeColor = System.Drawing.SystemColors.Control;
            this.lType.Location = new System.Drawing.Point(67, 152);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(51, 20);
            this.lType.TabIndex = 6;
            this.lType.Text = "Type :";
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
            this.cmbIds.Size = new System.Drawing.Size(121, 28);
            this.cmbIds.TabIndex = 4;
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(68, 227);
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(120, 26);
            this.nudMax.TabIndex = 3;
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(67, 183);
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(120, 26);
            this.nudMin.TabIndex = 2;
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(44, 326);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(143, 44);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // lConfig
            // 
            this.lConfig.AutoSize = true;
            this.lConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.lConfig.Location = new System.Drawing.Point(61, 32);
            this.lConfig.Name = "lConfig";
            this.lConfig.Size = new System.Drawing.Size(104, 20);
            this.lConfig.TabIndex = 0;
            this.lConfig.Text = "Configuration";
            // 
            // dataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "dataForm";
            this.Text = "dataForm";
            this.Load += new System.EventHandler(this.dataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataForm_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lID;
        private System.Windows.Forms.ComboBox cmbIds;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Label lConfig;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lMax;
        private System.Windows.Forms.Label lMin;
    }
}