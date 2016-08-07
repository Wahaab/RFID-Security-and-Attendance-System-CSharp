namespace FYP_RFID
{
    partial class FACULTY_REGISTRATION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FACULTY_REGISTRATION));
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.USERNAME = new System.Windows.Forms.TextBox();
            this.LNAME = new System.Windows.Forms.TextBox();
            this.FNAME = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DATE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BROWSE = new System.Windows.Forms.Button();
            this.REGBUTTON = new System.Windows.Forms.Button();
            this.REGLIST = new System.Windows.Forms.ComboBox();
            this.REGPIC = new System.Windows.Forms.PictureBox();
            this.PORT = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.DESIGNATION = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1b = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.REGPIC)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "DEPARTMENT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "USERNAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "LNAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "FNAME:";
            // 
            // USERNAME
            // 
            this.USERNAME.Location = new System.Drawing.Point(162, 160);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.USERNAME.Size = new System.Drawing.Size(140, 20);
            this.USERNAME.TabIndex = 24;
            // 
            // LNAME
            // 
            this.LNAME.Location = new System.Drawing.Point(162, 99);
            this.LNAME.Name = "LNAME";
            this.LNAME.Size = new System.Drawing.Size(140, 20);
            this.LNAME.TabIndex = 23;
            // 
            // FNAME
            // 
            this.FNAME.Location = new System.Drawing.Point(162, 43);
            this.FNAME.Name = "FNAME";
            this.FNAME.Size = new System.Drawing.Size(140, 20);
            this.FNAME.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "DATE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "RFID:";
            // 
            // DATE
            // 
            this.DATE.Location = new System.Drawing.Point(162, 441);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(140, 20);
            this.DATE.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(522, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BROWSE
            // 
            this.BROWSE.Location = new System.Drawing.Point(522, 267);
            this.BROWSE.Name = "BROWSE";
            this.BROWSE.Size = new System.Drawing.Size(105, 26);
            this.BROWSE.TabIndex = 37;
            this.BROWSE.Text = "BROWSE";
            this.BROWSE.UseVisualStyleBackColor = true;
            this.BROWSE.Click += new System.EventHandler(this.BROWSE_Click);
            // 
            // REGBUTTON
            // 
            this.REGBUTTON.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("REGBUTTON.BackgroundImage")));
            this.REGBUTTON.Image = ((System.Drawing.Image)(resources.GetObject("REGBUTTON.Image")));
            this.REGBUTTON.Location = new System.Drawing.Point(522, 383);
            this.REGBUTTON.Name = "REGBUTTON";
            this.REGBUTTON.Size = new System.Drawing.Size(147, 30);
            this.REGBUTTON.TabIndex = 36;
            this.REGBUTTON.Text = "REGISTER";
            this.REGBUTTON.UseVisualStyleBackColor = true;
            this.REGBUTTON.Click += new System.EventHandler(this.REGBUTTON_Click);
            // 
            // REGLIST
            // 
            this.REGLIST.FormattingEnabled = true;
            this.REGLIST.Location = new System.Drawing.Point(508, 316);
            this.REGLIST.Name = "REGLIST";
            this.REGLIST.Size = new System.Drawing.Size(131, 21);
            this.REGLIST.TabIndex = 35;
            this.REGLIST.SelectionChangeCommitted += new System.EventHandler(this.REGLIST_SelectionChangeCommitted);
            // 
            // REGPIC
            // 
            this.REGPIC.BackColor = System.Drawing.Color.White;
            this.REGPIC.Location = new System.Drawing.Point(395, 13);
            this.REGPIC.Name = "REGPIC";
            this.REGPIC.Size = new System.Drawing.Size(328, 236);
            this.REGPIC.TabIndex = 34;
            this.REGPIC.TabStop = false;
            // 
            // PORT
            // 
            this.PORT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PORT_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "DESIGNATION:";
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.Location = new System.Drawing.Point(162, 306);
            this.DESIGNATION.Name = "DESIGNATION";
            this.DESIGNATION.Size = new System.Drawing.Size(140, 20);
            this.DESIGNATION.TabIndex = 39;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // textBox1b
            // 
            this.textBox1b.Location = new System.Drawing.Point(162, 369);
            this.textBox1b.Name = "textBox1b";
            this.textBox1b.Size = new System.Drawing.Size(140, 20);
            this.textBox1b.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 60);
            this.button2.TabIndex = 47;
            this.button2.Text = " CHECK AVAILABILITY";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FACULTY_REGISTRATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(768, 521);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1b);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DESIGNATION);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BROWSE);
            this.Controls.Add(this.REGBUTTON);
            this.Controls.Add(this.REGLIST);
            this.Controls.Add(this.REGPIC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DATE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.LNAME);
            this.Controls.Add(this.FNAME);
            this.Name = "FACULTY_REGISTRATION";
            this.Text = "                                    FACULTY REGISTRATION";
            ((System.ComponentModel.ISupportInitialize)(this.REGPIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox USERNAME;
        private System.Windows.Forms.TextBox LNAME;
        private System.Windows.Forms.TextBox FNAME;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DATE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BROWSE;
        private System.Windows.Forms.Button REGBUTTON;
        private System.Windows.Forms.ComboBox REGLIST;
        private System.Windows.Forms.PictureBox REGPIC;
        private System.IO.Ports.SerialPort PORT;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DESIGNATION;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1b;
        private System.Windows.Forms.Button button2;
    }
}