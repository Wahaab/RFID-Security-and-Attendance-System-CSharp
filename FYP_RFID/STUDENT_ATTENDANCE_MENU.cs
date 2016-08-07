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
    public partial class STUDENT_ATTENDANCE_MENU : Form
    {
        public STUDENT_ATTENDANCE_MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            STUDENT_ATTENDANCE obj = new STUDENT_ATTENDANCE();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            STUDENT_SHOWATTND OBJ = new STUDENT_SHOWATTND();
            OBJ.Show();
        }
    }
}
