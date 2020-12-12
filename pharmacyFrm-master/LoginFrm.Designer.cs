namespace pharmacyFrm
{
    partial class LoginFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.ImagePnl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LinePnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.Joinbtn = new System.Windows.Forms.Button();
            this.ImagePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImagePnl
            // 
            this.ImagePnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagePnl.BackgroundImage")));
            this.ImagePnl.Controls.Add(this.panel2);
            this.ImagePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImagePnl.Location = new System.Drawing.Point(0, 0);
            this.ImagePnl.Name = "ImagePnl";
            this.ImagePnl.Size = new System.Drawing.Size(297, 190);
            this.ImagePnl.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 210);
            this.panel2.TabIndex = 0;
            // 
            // LinePnl
            // 
            this.LinePnl.BackColor = System.Drawing.Color.Black;
            this.LinePnl.Location = new System.Drawing.Point(39, 268);
            this.LinePnl.Name = "LinePnl";
            this.LinePnl.Size = new System.Drawing.Size(215, 1);
            this.LinePnl.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(39, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 1);
            this.panel1.TabIndex = 2;
            // 
            // IDbox
            // 
            this.IDbox.BackColor = System.Drawing.Color.White;
            this.IDbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDbox.Location = new System.Drawing.Point(39, 245);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(215, 20);
            this.IDbox.TabIndex = 3;
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.White;
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassBox.Location = new System.Drawing.Point(39, 315);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(215, 20);
            this.PassBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(37, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(37, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginBtn.Location = new System.Drawing.Point(52, 366);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(77, 39);
            this.LoginBtn.TabIndex = 7;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // Joinbtn
            // 
            this.Joinbtn.BackColor = System.Drawing.Color.SkyBlue;
            this.Joinbtn.FlatAppearance.BorderSize = 0;
            this.Joinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Joinbtn.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Joinbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Joinbtn.Location = new System.Drawing.Point(162, 366);
            this.Joinbtn.Name = "Joinbtn";
            this.Joinbtn.Size = new System.Drawing.Size(78, 39);
            this.Joinbtn.TabIndex = 8;
            this.Joinbtn.Text = "Join";
            this.Joinbtn.UseVisualStyleBackColor = false;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(297, 450);
            this.Controls.Add(this.Joinbtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LinePnl);
            this.Controls.Add(this.ImagePnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFrm";
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginFrm_KeyDown);
            this.ImagePnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ImagePnl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel LinePnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button Joinbtn;
    }
}