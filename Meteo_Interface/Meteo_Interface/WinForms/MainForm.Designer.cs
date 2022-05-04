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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.accountbutton = new System.Windows.Forms.Button();
            this.chartbutton = new System.Windows.Forms.Button();
            this.databutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.alertbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.panelSide.Controls.Add(this.accountbutton);
            this.panelSide.Controls.Add(this.chartbutton);
            this.panelSide.Controls.Add(this.databutton);
            this.panelSide.Controls.Add(this.savebutton);
            this.panelSide.Controls.Add(this.alertbutton);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelSide.Location = new System.Drawing.Point(0, 93);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(199, 476);
            this.panelSide.TabIndex = 5;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(910, 93);
            this.panelHeader.TabIndex = 6;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(199, 93);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(711, 476);
            this.mainPanel.TabIndex = 7;
            // 
            // accountbutton
            // 
            this.accountbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.accountbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accountbutton.FlatAppearance.BorderSize = 0;
            this.accountbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountbutton.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.accountbutton.Image = global::Meteo_Interface.Properties.Resources.man;
            this.accountbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountbutton.Location = new System.Drawing.Point(0, 199);
            this.accountbutton.Name = "accountbutton";
            this.accountbutton.Size = new System.Drawing.Size(199, 50);
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
            this.chartbutton.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.chartbutton.Image = global::Meteo_Interface.Properties.Resources.growth;
            this.chartbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chartbutton.Location = new System.Drawing.Point(0, 143);
            this.chartbutton.Name = "chartbutton";
            this.chartbutton.Size = new System.Drawing.Size(199, 50);
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
            this.databutton.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.databutton.Image = global::Meteo_Interface.Properties.Resources.database__1_;
            this.databutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.databutton.Location = new System.Drawing.Point(0, 31);
            this.databutton.Name = "databutton";
            this.databutton.Size = new System.Drawing.Size(199, 50);
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
            this.savebutton.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.savebutton.Image = global::Meteo_Interface.Properties.Resources.folder;
            this.savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebutton.Location = new System.Drawing.Point(0, 255);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(199, 50);
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
            this.alertbutton.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertbutton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.alertbutton.Image = global::Meteo_Interface.Properties.Resources.alarm;
            this.alertbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alertbutton.Location = new System.Drawing.Point(0, 87);
            this.alertbutton.Name = "alertbutton";
            this.alertbutton.Size = new System.Drawing.Size(199, 50);
            this.alertbutton.TabIndex = 1;
            this.alertbutton.Text = "ALERT";
            this.alertbutton.UseVisualStyleBackColor = false;
            this.alertbutton.Click += new System.EventHandler(this.alertbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = global::Meteo_Interface.Properties.Resources.iconnn;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 569);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Captor management App";
            this.panelSide.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
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

    }
}

