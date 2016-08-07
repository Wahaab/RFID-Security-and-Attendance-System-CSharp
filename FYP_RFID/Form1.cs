using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FYP_RFID
{
    public partial class Form1 : Form
    {
        string x = "GTO";
        public Form1()
        {
            InitializeComponent();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "GTO")
            {
                MAIN_MENU obj = new MAIN_MENU();
                Form1 OBJ = new Form1();
                
                obj.Show();
                
            }
        }


    }
}
