namespace FYP_RFID
{
    partial class MAIN_MENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN_MENU));
            this.GATE = new System.Windows.Forms.Button();
            this.REGISTRATION = new System.Windows.Forms.Button();
            this.ATTENDANCE = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GATE
            // 
            this.GATE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GATE.BackgroundImage")));
            this.GATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GATE.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GATE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GATE.Location = new System.Drawing.Point(774, 26);
            this.GATE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GATE.Name = "GATE";
            this.GATE.Size = new System.Drawing.Size(240, 30);
            this.GATE.TabIndex = 0;
            this.GATE.Text = " MONITORING";
            this.GATE.UseVisualStyleBackColor = true;
            this.GATE.Click += new System.EventHandler(this.GATE_Click);
            // 
            // REGISTRATION
            // 
            this.REGISTRATION.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("REGISTRATION.BackgroundImage")));
            this.REGISTRATION.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.REGISTRATION.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REGISTRATION.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.REGISTRATION.Location = new System.Drawing.Point(75, 26);
            this.REGISTRATION.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.REGISTRATION.Name = "REGISTRATION";
            this.REGISTRATION.Size = new System.Drawing.Size(240, 30);
            this.REGISTRATION.TabIndex = 1;
            this.REGISTRATION.Text = "REGISTRATION";
            this.REGISTRATION.UseVisualStyleBackColor = true;
            this.REGISTRATION.Click += new System.EventHandler(this.REGISTRATION_Click);
            // 
            // ATTENDANCE
            // 
            this.ATTENDANCE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ATTENDANCE.BackgroundImage")));
            this.ATTENDANCE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ATTENDANCE.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ATTENDANCE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ATTENDANCE.Location = new System.Drawing.Point(419, 26);
            this.ATTENDANCE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ATTENDANCE.Name = "ATTENDANCE";
            this.ATTENDANCE.Size = new System.Drawing.Size(240, 30);
            this.ATTENDANCE.TabIndex = 3;
            this.ATTENDANCE.Text = "ATTENDANCE";
            this.ATTENDANCE.UseVisualStyleBackColor = true;
            this.ATTENDANCE.Click += new System.EventHandler(this.ATTENDANCE_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Jing Jing", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(811, 431);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "3 W\'s @Copyright 2011";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MAIN_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ATTENDANCE);
            this.Controls.Add(this.REGISTRATION);
            this.Controls.Add(this.GATE);
            this.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MAIN_MENU";
            this.Text = "                                                                                 " +
                "                 RFID ATTENDANCE AND MONITORING SYSTEM";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GATE;
        private System.Windows.Forms.Button REGISTRATION;
        private System.Windows.Forms.Button ATTENDANCE;
        private System.Windows.Forms.Button button1;
    }
}

