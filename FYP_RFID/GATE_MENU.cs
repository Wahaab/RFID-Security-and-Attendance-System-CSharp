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
    public partial class GATE_MENU : Form
    {
        public GATE_MENU()
        {
            InitializeComponent();
        }

        private void IN_Click(object sender, EventArgs e)
        {
            GATE_IN OBJ = new GATE_IN();
            OBJ.Show();

        }

        private void OUT_Click(object sender, EventArgs e)
        {
            GATE_OUT OBJ2 = new GATE_OUT();
            OBJ2.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOG_STATUS obj = new LOG_STATUS();
            obj.Show();
        }
    }
}
