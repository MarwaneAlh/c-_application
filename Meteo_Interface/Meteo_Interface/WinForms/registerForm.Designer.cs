
namespace Meteo_Interface.WinForms
{
    partial class registerForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(301, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.connectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.connectBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectBtn.ForeColor = System.Drawing.Color.White;
            this.connectBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.connectBtn.Location = new System.Drawing.Point(301, 239);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(169, 29);
            this.connectBtn.TabIndex = 15;
            this.connectBtn.Text = "INSCRIPTION";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.GrayText;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(301, 136);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(172, 23);
            this.password.TabIndex = 14;
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.GrayText;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.White;
            this.userName.Location = new System.Drawing.Point(301, 83);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(172, 23);
            this.userName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mot de passe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nom d\'utilisateur :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(45, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "INSCRIPTION";
            // 
            // password2
            // 
            this.password2.BackColor = System.Drawing.SystemColors.GrayText;
            this.password2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2.ForeColor = System.Drawing.Color.White;
            this.password2.Location = new System.Drawing.Point(301, 190);
            this.password2.Name = "password2";
            this.password2.PasswordChar = '*';
            this.password2.Size = new System.Drawing.Size(172, 23);
            this.password2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirme mot de passe :";
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registerForm";
            this.Text = "registerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.Label label4;
    }
}