using System.Drawing;

namespace Meteo_Interface
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.panelSide = new System.Windows.Forms.Panel();
            this.whereIam = new System.Windows.Forms.Panel();
            this.accountbutton = new System.Windows.Forms.Button();
            this.chartbutton = new System.Windows.Forms.Button();
            this.databutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.alertbutton = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelSide.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.PortName = "COM2";
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panelSide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSide.Controls.Add(this.whereIam);
            this.panelSide.Controls.Add(this.accountbutton);
            this.panelSide.Controls.Add(this.chartbutton);
            this.panelSide.Controls.Add(this.databutton);
            this.panelSide.Controls.Add(this.savebutton);
            this.panelSide.Controls.Add(this.alertbutton);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelSide.Location = new System.Drawing.Point(0, 142);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(298, 323);
            this.panelSide.TabIndex = 5;
            // 
            // whereIam
            // 
            this.whereIam.BackColor = System.Drawing.Color.DodgerBlue;
            this.whereIam.Location = new System.Drawing.Point(280, 48);
            this.whereIam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.whereIam.Name = "whereIam";
            this.whereIam.Size = new System.Drawing.Size(300, 77);
            this.whereIam.TabIndex = 5;
            // 
            // accountbutton
            // 
            this.accountbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.accountbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accountbutton.FlatAppearance.BorderSize = 0;
            this.accountbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.accountbutton.Image = global::Meteo_Interface.Properties.Resources.man;
            this.accountbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountbutton.Location = new System.Drawing.Point(0, 306);
            this.accountbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountbutton.Name = "accountbutton";
            this.accountbutton.Size = new System.Drawing.Size(297, 77);
            this.accountbutton.TabIndex = 4;
            this.accountbutton.Text = "ACCOUNT";
            this.accountbutton.UseVisualStyleBackColor = false;
            this.accountbutton.Click += new System.EventHandler(this.accountbutton_Click);
            // 
            // chartbutton
            // 
            this.chartbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.chartbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartbutton.FlatAppearance.BorderSize = 0;
            this.chartbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chartbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chartbutton.Image = global::Meteo_Interface.Properties.Resources.growth;
            this.chartbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chartbutton.Location = new System.Drawing.Point(0, 220);
            this.chartbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartbutton.Name = "chartbutton";
            this.chartbutton.Size = new System.Drawing.Size(297, 77);
            this.chartbutton.TabIndex = 3;
            this.chartbutton.Text = "CHART";
            this.chartbutton.UseVisualStyleBackColor = false;
            this.chartbutton.Click += new System.EventHandler(this.chartbutton_Click);
            // 
            // databutton
            // 
            this.databutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.databutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.databutton.FlatAppearance.BorderSize = 0;
            this.databutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.databutton.Image = global::Meteo_Interface.Properties.Resources.database__1_;
            this.databutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.databutton.Location = new System.Drawing.Point(0, 48);
            this.databutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.databutton.Name = "databutton";
            this.databutton.Size = new System.Drawing.Size(297, 77);
            this.databutton.TabIndex = 0;
            this.databutton.Text = "DATA";
            this.databutton.UseVisualStyleBackColor = false;
            this.databutton.Click += new System.EventHandler(this.databutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.savebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.savebutton.Image = global::Meteo_Interface.Properties.Resources.folder;
            this.savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebutton.Location = new System.Drawing.Point(0, 392);
            this.savebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(297, 77);
            this.savebutton.TabIndex = 2;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // alertbutton
            // 
            this.alertbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.alertbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.alertbutton.FlatAppearance.BorderSize = 0;
            this.alertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alertbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.alertbutton.Image = global::Meteo_Interface.Properties.Resources.alarm;
            this.alertbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alertbutton.Location = new System.Drawing.Point(0, 134);
            this.alertbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.alertbutton.Name = "alertbutton";
            this.alertbutton.Size = new System.Drawing.Size(297, 77);
            this.alertbutton.TabIndex = 1;
            this.alertbutton.Text = "ALERT";
            this.alertbutton.UseVisualStyleBackColor = false;
            this.alertbutton.Click += new System.EventHandler(this.alertbutton_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1062, 142);
            this.panelHeader.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(524, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Connected as : none";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::Meteo_Interface.Properties.Resources.iconnn;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(298, 142);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(764, 323);
            this.mainPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 465);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Captor management App";
            this.panelSide.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button databutton;
        private System.Windows.Forms.Button accountbutton;
        private System.Windows.Forms.Button chartbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button alertbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel whereIam;
        private System.Windows.Forms.Label label1;
    }
}

