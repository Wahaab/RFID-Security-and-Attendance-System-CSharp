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
    public partial class FACULTYATTENDANCE_MENU : Form
    {
        public FACULTYATTENDANCE_MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FACULTY_ATTENDNACE OBJ = new FACULTY_ATTENDNACE();
            OBJ.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FACULTY_ATTENDRECORD OBJ = new FACULTY_ATTENDRECORD();
            OBJ.Show();
        }
    }
}
