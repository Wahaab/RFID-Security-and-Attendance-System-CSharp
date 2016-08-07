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
    public partial class STUDENT_SHOWATTND : Form
    {
        public static string DEPT;
        public static string PROG;
        public static string CLAS;
        public static string SUBJ;

        public STUDENT_SHOWATTND()
        {
            InitializeComponent();
            comboBox3.Items.Add("ENGG");
            comboBox3.Items.Add("MGMT");
            
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            DEPT = comboBox3.Text;

            if (DEPT == "ENGG")
                comboBox4.Items.Add("BEE");

            else
                comboBox4.Items.Add("BBA");
        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            PROG = comboBox4.Text;

            if (PROG == "BEE")
                comboBox2.Items.Add("8B");

            else
                comboBox2.Items.Add("7B");
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            CLAS = comboBox2.Text;

            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);

            if (CLAS == "8B")
            {
                var cust = from c in db.BEE8COURSES_OBJ

                           select c;
                foreach (var c in cust)
                {
                    comboBox1.Items.Add(c.COURSE);
                }

            }

            

                
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SUBJ = comboBox1.Text;
           

        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            //comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            textBox1.Clear();
            dataGridView1.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            int row_num=0;
            int serial = 1;
            int absents = 0;
            int presents = 0;


            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);

            

            var cust = from c in db.BEE8CLASSES_OBJ
                       

                       where (c.CLASS ==CLAS && c.SUBJECT == SUBJ )

                       select c;
            foreach(var c in cust)
            {
                if (c.HOURS ==1)
                absents++;

                else if (c.HOURS == 2)
                {
                    absents++;
                    absents++;
                }
            }

            var cus = from b in db.BEE8BATTENDANCE_OBJ

                      where (b.USERNAME == textBox1.Text && b.SUBJECT == SUBJ)

                      select b;
            foreach (var b in cus)
            {
                if (b.HOURS == 1 && b.ATTENDANCE == "P")
                    presents++;

                else if (b.HOURS == 2 && b.ATTENDANCE == "P")
                {
                    presents=presents+2;
                    
                }


            }

            absents = absents - presents;

            dataGridView1.Rows.Add(1);
            dataGridView1[0, row_num].Value = serial;
            dataGridView1[1, row_num].Value = SUBJ;
            dataGridView1[2, row_num].Value = presents;
            dataGridView1[3, row_num].Value = absents;
                



         /*   foreach (var f in cust)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1[0, row_num].Value = serial;
                dataGridView1[1, row_num].Value = f.SUBJECT;
                serial++;

                if (f.SUBJECT==SUBJ && f.ATTENDANCE == "")
                {
                    absents++;

                    dataGridView1[2, row_num].Value = "A";
                    dataGridView1[3, row_num].Value = absents;
                }

                else if (f.SUBJECT == SUBJ && f.ATTENDANCE == "P")
                {
                    dataGridView1[2, row_num].Value = "P";
                    dataGridView1[3, row_num].Value = absents;
                }

                dataGridView1[4, row_num].Value = f.TIME.Date;
                row_num++;
            }
*/
        }

       
    }
}
