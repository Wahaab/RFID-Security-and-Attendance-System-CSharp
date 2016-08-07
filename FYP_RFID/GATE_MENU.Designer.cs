namespace FYP_RFID
{
    partial class GATE_MENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GATE_MENU));
            this.IN = new System.Windows.Forms.Button();
            this.OUT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IN
            // 
            this.IN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IN.BackgroundImage")));
            this.IN.ForeColor = System.Drawing.SystemColors.Control;
            this.IN.Location = new System.Drawing.Point(43, 196);
            this.IN.Name = "IN";
            this.IN.Size = new System.Drawing.Size(139, 69);
            this.IN.TabIndex = 0;
            this.IN.Text = "IN";
            this.IN.UseVisualStyleBackColor = true;
            this.IN.Click += new System.EventHandler(this.IN_Click);
            // 
            // OUT
            // 
            this.OUT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OUT.BackgroundImage")));
            this.OUT.ForeColor = System.Drawing.SystemColors.Control;
            this.OUT.Location = new System.Drawing.Point(429, 196);
            this.OUT.Name = "OUT";
            this.OUT.Size = new System.Drawing.Size(139, 69);
            this.OUT.TabIndex = 1;
            this.OUT.Text = "OUT";
            this.OUT.UseVisualStyleBackColor = true;
            this.OUT.Click += new System.EventHandler(this.OUT_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(233, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOG STATUS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GATE_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(609, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OUT);
            this.Controls.Add(this.IN);
            this.Name = "GATE_MENU";
            this.Text = "GATE MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IN;
        private System.Windows.Forms.Button OUT;
        private System.Windows.Forms.Button button1;
    }
}