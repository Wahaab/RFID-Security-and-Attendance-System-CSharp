namespace FYP_RFID
{
    partial class GATE_IN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GATE_IN));
            this.GATE_ID = new System.Windows.Forms.PictureBox();
            this.USERNAME = new System.Windows.Forms.TextBox();
            this.FNAME = new System.Windows.Forms.TextBox();
            this.LNAME = new System.Windows.Forms.TextBox();
            this.PROGRAM = new System.Windows.Forms.TextBox();
            this.CLASS = new System.Windows.Forms.TextBox();
            this.DATE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PORT = new System.IO.Ports.SerialPort(this.components);
            this.GATEMENU = new System.Windows.Forms.ComboBox();
            this.designation = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GATE_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GATE_ID
            // 
            this.GATE_ID.Location = new System.Drawing.Point(248, 12);
            this.GATE_ID.Name = "GATE_ID";
            this.GATE_ID.Size = new System.Drawing.Size(225, 258);
            this.GATE_ID.TabIndex = 0;
            this.GATE_ID.TabStop = false;
            // 
            // USERNAME
            // 
            this.USERNAME.Location = new System.Drawing.Point(34, 332);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(138, 20);
            this.USERNAME.TabIndex = 1;
            // 
            // FNAME
            // 
            this.FNAME.Location = new System.Drawing.Point(248, 331);
            this.FNAME.Name = "FNAME";
            this.FNAME.Size = new System.Drawing.Size(155, 20);
            this.FNAME.TabIndex = 2;
            // 
            // LNAME
            // 
            this.LNAME.Location = new System.Drawing.Point(477, 330);
            this.LNAME.Name = "LNAME";
            this.LNAME.Size = new System.Drawing.Size(140, 20);
            this.LNAME.TabIndex = 3;
            // 
            // PROGRAM
            // 
            this.PROGRAM.Location = new System.Drawing.Point(34, 404);
            this.PROGRAM.Name = "PROGRAM";
            this.PROGRAM.Size = new System.Drawing.Size(138, 20);
            this.PROGRAM.TabIndex = 4;
            // 
            // CLASS
            // 
            this.CLASS.Location = new System.Drawing.Point(249, 404);
            this.CLASS.Name = "CLASS";
            this.CLASS.Size = new System.Drawing.Size(154, 20);
            this.CLASS.TabIndex = 5;
            // 
            // DATE
            // 
            this.DATE.Location = new System.Drawing.Point(477, 404);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(140, 20);
            this.DATE.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "USERNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "FNAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "LNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "PROGRAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CLASS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "DATE";
            // 
            // PORT
            // 
            this.PORT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PORT_DataReceived);
            // 
            // GATEMENU
            // 
            this.GATEMENU.FormattingEnabled = true;
            this.GATEMENU.Location = new System.Drawing.Point(512, 77);
            this.GATEMENU.Name = "GATEMENU";
            this.GATEMENU.Size = new System.Drawing.Size(121, 21);
            this.GATEMENU.TabIndex = 13;
            this.GATEMENU.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(249, 465);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(154, 20);
            this.designation.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 208);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 449);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "DESIGNATION";
            // 
            // GATE_IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 497);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.GATEMENU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DATE);
            this.Controls.Add(this.CLASS);
            this.Controls.Add(this.PROGRAM);
            this.Controls.Add(this.LNAME);
            this.Controls.Add(this.FNAME);
            this.Controls.Add(this.USERNAME);
            this.Controls.Add(this.GATE_ID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GATE_IN";
            this.Text = "GATE IN";
            ((System.ComponentModel.ISupportInitialize)(this.GATE_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GATE_ID;
        private System.Windows.Forms.TextBox USERNAME;
        private System.Windows.Forms.TextBox FNAME;
        private System.Windows.Forms.TextBox LNAME;
        private System.Windows.Forms.TextBox PROGRAM;
        private System.Windows.Forms.TextBox CLASS;
        private System.Windows.Forms.TextBox DATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.IO.Ports.SerialPort PORT;
        private System.Windows.Forms.ComboBox GATEMENU;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
    }
}