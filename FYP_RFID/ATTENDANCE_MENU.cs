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
    public partial class ATTENDANCE_MENU : Form
    {
        public ATTENDANCE_MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            STUDENT_ATTENDANCE_MENU OBJ = new STUDENT_ATTENDANCE_MENU();
            OBJ.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FACULTYATTENDANCE_MENU OBJ = new FACULTYATTENDANCE_MENU();
            OBJ.Show();


        }
    }
}
