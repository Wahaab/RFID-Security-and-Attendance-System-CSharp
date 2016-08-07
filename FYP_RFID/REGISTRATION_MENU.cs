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
    public partial class REGISTRATION_MENU : Form
    {
        public REGISTRATION_MENU()
        {
            InitializeComponent();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            FACULTY_REGISTRATION OBJ = new FACULTY_REGISTRATION();
            OBJ.Show(); 


        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            STUDENT_REGISTRATION obj = new STUDENT_REGISTRATION();
            obj.Show();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {

            COURSE_ADDITION OBJ = new COURSE_ADDITION();
            OBJ.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            COURSE_REGISTRATION OBJ = new COURSE_REGISTRATION();
            OBJ.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TIMETABLE_MENU obj = new TIMETABLE_MENU();
            obj.Show();
        }

        
    }
}

