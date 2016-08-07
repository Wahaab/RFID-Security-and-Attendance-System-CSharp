namespace FYP_RFID
{
    partial class STUDENT_ATTENDANCE
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HALL = new System.Windows.Forms.ComboBox();
            this.USRNAME = new System.Windows.Forms.TextBox();
            this.FIRST = new System.Windows.Forms.TextBox();
            this.LAST = new System.Windows.Forms.TextBox();
            this.PRGM = new System.Windows.Forms.TextBox();
            this.CLSS = new System.Windows.Forms.TextBox();
            this.ATTENDANCE = new System.Windows.Forms.TextBox();
            this.PENALTY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(732, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HALL
            // 
            this.HALL.FormattingEnabled = true;
            this.HALL.Location = new System.Drawing.Point(497, 115);
            this.HALL.Name = "HALL";
            this.HALL.Size = new System.Drawing.Size(121, 21);
            this.HALL.TabIndex = 1;
            this.HALL.SelectedValueChanged += new System.EventHandler(this.HALL_SelectedValueChanged);
            // 
            // USRNAME
            // 
            this.USRNAME.Location = new System.Drawing.Point(110, 215);
            this.USRNAME.Name = "USRNAME";
            this.USRNAME.Size = new System.Drawing.Size(100, 20);
            this.USRNAME.TabIndex = 2;
            // 
            // FIRST
            // 
            this.FIRST.Location = new System.Drawing.Point(311, 215);
            this.FIRST.Name = "FIRST";
            this.FIRST.Size = new System.Drawing.Size(100, 20);
            this.FIRST.TabIndex = 3;
            // 
            // LAST
            // 
            this.LAST.Location = new System.Drawing.Point(536, 215);
            this.LAST.Name = "LAST";
            this.LAST.Size = new System.Drawing.Size(100, 20);
            this.LAST.TabIndex = 4;
            // 
            // PRGM
            // 
            this.PRGM.Location = new System.Drawing.Point(204, 282);
            this.PRGM.Name = "PRGM";
            this.PRGM.Size = new System.Drawing.Size(100, 20);
            this.PRGM.TabIndex = 5;
            // 
            // CLSS
            // 
            this.CLSS.Location = new System.Drawing.Point(419, 282);
            this.CLSS.Name = "CLSS";
            this.CLSS.Size = new System.Drawing.Size(100, 20);
            this.CLSS.TabIndex = 6;
            // 
            // ATTENDANCE
            // 
            this.ATTENDANCE.Location = new System.Drawing.Point(110, 370);
            this.ATTENDANCE.Name = "ATTENDANCE";
            this.ATTENDANCE.Size = new System.Drawing.Size(100, 20);
            this.ATTENDANCE.TabIndex = 7;
            // 
            // PENALTY
            // 
            this.PENALTY.Location = new System.Drawing.Point(110, 455);
            this.PENALTY.Name = "PENALTY";
            this.PENALTY.Size = new System.Drawing.Size(100, 20);
            this.PENALTY.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ATTENDANCE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "PENALTY (MAX = 2)";
            // 
            // STUDENT_ATTENDANCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PENALTY);
            this.Controls.Add(this.ATTENDANCE);
            this.Controls.Add(this.CLSS);
            this.Controls.Add(this.PRGM);
            this.Controls.Add(this.LAST);
            this.Controls.Add(this.FIRST);
            this.Controls.Add(this.USRNAME);
            this.Controls.Add(this.HALL);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "STUDENT_ATTENDANCE";
            this.Text = "Form16";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox HALL;
        private System.Windows.Forms.TextBox USRNAME;
        private System.Windows.Forms.TextBox FIRST;
        private System.Windows.Forms.TextBox LAST;
        private System.Windows.Forms.TextBox PRGM;
        private System.Windows.Forms.TextBox CLSS;
        private System.Windows.Forms.TextBox ATTENDANCE;
        private System.Windows.Forms.TextBox PENALTY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}