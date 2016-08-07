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
    public partial class COURSE_REGISTRATION : Form
    {
        public int row_num = 0;
        public int serial = 1;
        public static string h;

        public static string course1 = string.Empty;
        public static string course2 = string.Empty;
        public static string course3 = string.Empty;
        public static string course4 = string.Empty;
        public static string course5 = string.Empty;
        public static string course6 = string.Empty;


        public COURSE_REGISTRATION()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CLASSBOX.Text == "8A" || CLASSBOX.Text == "8B")
            {
                string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

                FYPRFID db = new FYPRFID(connString);

                BEE8_COURSES courses = new BEE8_COURSES();


                var course_checker = from c in db.BEE8COURSES_OBJ

                                     select c;

                foreach (var c in course_checker)
                {

                    dataGridView1.Rows.Add(1);

                    dataGridView1[0, row_num].Value = serial;
                    dataGridView1[1, row_num].Value = c.COURSE;
                    dataGridView1[2, row_num].Value = c.COURSE_CODE;

                    row_num++;
                    serial++;

                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            h = PORT.ReadExisting();

            if (h != String.Empty)
            {
                h = h.Substring(h.Length + 1 - h.Length, h.Length - 4);

            }

            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);

            RECORDS RECORD_S = new RECORDS();

            var cust = from c in db.RECORDS_OBJ

                       where c.RFID == h

                       select c;

            foreach (var c in cust)
            {
                textBox1.Text = c.USERNAME;
                textBox2.Text = c.FNAME;
                textBox3.Text = c.LNAME;
                CLASSBOX.Text = c.CLASS;

            }

            if (CLASSBOX.Text == "8A" || CLASSBOX.Text == "8B")
            {

                BEE8_COURSES courses = new BEE8_COURSES();


                var course_checker = from c in db.BEE8COURSES_OBJ

                                     select c;

                foreach (var c in course_checker)
                {

                    comboBox1.Items.Add(c.COURSE);
                    comboBox2.Items.Add(c.COURSE);
                    comboBox3.Items.Add(c.COURSE);
                    comboBox4.Items.Add(c.COURSE);
                    comboBox5.Items.Add(c.COURSE);
                    comboBox6.Items.Add(c.COURSE);


                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);

            BEE8_STUDENTS obj = new BEE8_STUDENTS();

            obj.RFID = h;
            obj.USERNAME = textBox1.Text;
            obj.FNAME = textBox2.Text;
            obj.LNAME = textBox3.Text;
            obj.CLASS = CLASSBOX.Text;
            obj.COURSE_1 = course1;
            obj.COURSE_2 = course2;
            obj.COURSE_3 = course3;
            obj.COURSE_4 = course4;
            obj.COURSE_5 = course5;
            obj.COURSE_6 = course6;

            db.BEE8STUDENTS_OBJ.InsertOnSubmit(obj);
            db.SubmitChanges();  


        }



        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            course1 = comboBox1.Text;
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            course2 = comboBox2.Text;
        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            course3 = comboBox3.Text;
        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            course4 = comboBox4.Text;
        }

        private void comboBox5_SelectedValueChanged(object sender, EventArgs e)
        {
            course5 = comboBox5.Text;
        }

        private void comboBox6_SelectedValueChanged(object sender, EventArgs e)
        {
            course6 = comboBox6.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PORT.Open();
            }

            if (checkBox1.Checked != true)
            {
                PORT.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                CLASSBOX.Clear();
                row_num = 0;
                serial = 1;
                dataGridView1.Rows.Clear();
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();
               


        }


    }
}
