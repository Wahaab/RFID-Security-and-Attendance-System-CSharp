namespace FYP_RFID
{
    partial class STUDENT_REGISTRATION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STUDENT_REGISTRATION));
            this.PORT = new System.IO.Ports.SerialPort(this.components);
            this.FNAME = new System.Windows.Forms.TextBox();
            this.LNAME = new System.Windows.Forms.TextBox();
            this.USERNAME = new System.Windows.Forms.TextBox();
            this.REGPIC = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RFID = new System.Windows.Forms.TextBox();
            this.DATE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.REGLIST = new System.Windows.Forms.ComboBox();
            this.REGBUTTON = new System.Windows.Forms.Button();
            this.BROWSE = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DESIGNATION = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.REGPIC)).BeginInit();
            this.SuspendLayout();
            // 
            // PORT
            // 
            this.PORT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // FNAME
            // 
            this.FNAME.Location = new System.Drawing.Point(153, 30);
            this.FNAME.Name = "FNAME";
            this.FNAME.Size = new System.Drawing.Size(140, 20);
            this.FNAME.TabIndex = 0;
            // 
            // LNAME
            // 
            this.LNAME.Location = new System.Drawing.Point(153, 86);
            this.LNAME.Name = "LNAME";
            this.LNAME.Size = new System.Drawing.Size(140, 20);
            this.LNAME.TabIndex = 1;
            // 
            // USERNAME
            // 
            this.USERNAME.Location = new System.Drawing.Point(153, 147);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.USERNAME.Size = new System.Drawing.Size(140, 20);
            this.USERNAME.TabIndex = 2;
            // 
            // REGPIC
            // 
            this.REGPIC.BackColor = System.Drawing.Color.White;
            this.REGPIC.Location = new System.Drawing.Point(394, 12);
            this.REGPIC.Name = "REGPIC";
            this.REGPIC.Size = new System.Drawing.Size(279, 264);
            this.REGPIC.TabIndex = 5;
            this.REGPIC.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "FNAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "LNAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "USERNAME:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CLASS:";
            // 
            // RFID
            // 
            this.RFID.Location = new System.Drawing.Point(153, 466);
            this.RFID.Name = "RFID";
            this.RFID.Size = new System.Drawing.Size(140, 20);
            this.RFID.TabIndex = 11;
            // 
            // DATE
            // 
            this.DATE.Location = new System.Drawing.Point(153, 515);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(140, 20);
            this.DATE.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 473);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "RFID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "DATE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "PROGRAM:";
            // 
            // REGLIST
            // 
            this.REGLIST.FormattingEnabled = true;
            this.REGLIST.Location = new System.Drawing.Point(567, 345);
            this.REGLIST.Name = "REGLIST";
            this.REGLIST.Size = new System.Drawing.Size(131, 21);
            this.REGLIST.TabIndex = 16;
            this.REGLIST.SelectionChangeCommitted += new System.EventHandler(this.REGLIST_SelectionChangeCommitted);
            // 
            // REGBUTTON
            // 
            this.REGBUTTON.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("REGBUTTON.BackgroundImage")));
            this.REGBUTTON.Image = ((System.Drawing.Image)(resources.GetObject("REGBUTTON.Image")));
            this.REGBUTTON.Location = new System.Drawing.Point(466, 416);
            this.REGBUTTON.Name = "REGBUTTON";
            this.REGBUTTON.Size = new System.Drawing.Size(147, 30);
            this.REGBUTTON.TabIndex = 17;
            this.REGBUTTON.Text = "REGISTER";
            this.REGBUTTON.UseVisualStyleBackColor = true;
            this.REGBUTTON.Click += new System.EventHandler(this.REGBUTTON_Click);
            // 
            // BROWSE
            // 
            this.BROWSE.Location = new System.Drawing.Point(481, 281);
            this.BROWSE.Name = "BROWSE";
            this.BROWSE.Size = new System.Drawing.Size(105, 26);
            this.BROWSE.TabIndex = 18;
            this.BROWSE.Text = "BROWSE";
            this.BROWSE.UseVisualStyleBackColor = true;
            this.BROWSE.Click += new System.EventHandler(this.BROWSE_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(466, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 30);
            this.button1.TabIndex = 19;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "DEPARTMENT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "DESIGNATION:";
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.Location = new System.Drawing.Point(153, 346);
            this.DESIGNATION.Name = "DESIGNATION";
            this.DESIGNATION.Size = new System.Drawing.Size(140, 20);
            this.DESIGNATION.TabIndex = 41;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(153, 286);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 21);
            this.comboBox2.TabIndex = 44;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(153, 408);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 21);
            this.comboBox3.TabIndex = 45;
            this.comboBox3.SelectedValueChanged += new System.EventHandler(this.comboBox3_SelectedValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 60);
            this.button2.TabIndex = 46;
            this.button2.Text = " CHECK AVAILABILITY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // STUDENT_REGISTRATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 536);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DESIGNATION);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BROWSE);
            this.Controls.Add(this.REGBUTTON);
            this.Controls.Add(this.REGLIST);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DATE);
            this.Controls.Add(this.RFID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.REGPIC);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.LNAME);
            this.Controls.Add(this.FNAME);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "STUDENT_REGISTRATION";
            this.Text = "REGISTRATION";
            ((System.ComponentModel.ISupportInitialize)(this.REGPIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort PORT;
        private System.Windows.Forms.TextBox FNAME;
        private System.Windows.Forms.TextBox LNAME;
        private System.Windows.Forms.TextBox USERNAME;
        private System.Windows.Forms.PictureBox REGPIC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RFID;
        private System.Windows.Forms.TextBox DATE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox REGLIST;
        private System.Windows.Forms.Button REGBUTTON;
        private System.Windows.Forms.Button BROWSE;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DESIGNATION;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
    }
}