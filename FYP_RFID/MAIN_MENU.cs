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
    public partial class MAIN_MENU : Form
    {
        public MAIN_MENU()
        {
            InitializeComponent();
        }

        private void REGISTRATION_Click(object sender, EventArgs e)
        {
            REGISTRATION_MENU obj = new REGISTRATION_MENU();
            obj.Show();
            
            
            
        }

        private void GATE_Click(object sender, EventArgs e)
        {
            GATE_MENU OBJ = new GATE_MENU();
            OBJ.Show();
        }

        private void ATTENDANCE_Click(object sender, EventArgs e)
        {
            ATTENDANCE_MENU OBJ = new ATTENDANCE_MENU();
            OBJ.Show();
        }

        
    }
}
