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
    public partial class FACULTY_ATTENDNACE : Form
    {
        public static string INPUT;
        public static string DEPT;
        public static int valid = 1;

        public FACULTY_ATTENDNACE()
        {
            InitializeComponent();
            serialPort1.Open();

            comboBox1.Items.Add("ENGG");
            comboBox1.Items.Add("MGMT");
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            INPUT = serialPort1.ReadExisting();

            if (INPUT != String.Empty)
            {


                INPUT = INPUT.Substring(INPUT.Length + 1 - INPUT.Length, INPUT.Length - 4);
                
            }

           
            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);

            if (DEPT == "ENGG")
            {

                FACULTYENGG_ATTENDANCE obj = new FACULTYENGG_ATTENDANCE();

                var dupl = from x in db.FACENGGATTEND_OBJ

                           where (x.RFID == INPUT && x.DATE.Date == DateTime.Now.Date && x.DATE.Month == DateTime.Now.Month)

                           select x;

                foreach (var x in dupl)
                {
                    if (x.DATE.Date == DateTime.Now.Date)
                    {
                        valid = 0;
                        MessageBox.Show("ALREADY MARKED :) ");
                    }

                }


                if (valid == 1)
                {
                    var cust = from c in db.FACULTYENGG_OBJ

                               where (c.RFID == INPUT)

                               select c;

                    foreach (var c in cust)
                    {
                        obj.FNAME = c.FNAME;
                        obj.LNAME = c.LNAME;
                        obj.USERNAME = c.USERNAME;
                        obj.ATTENDANCE = "P";
                        obj.DATE = DateTime.Now;
                        textBox5.Text = c.DESIGNATION;
                        textBox6.Text = c.DEPARTMENT;
                        pictureBox1.ImageLocation = c.ID_IMAGE;
                        obj.RFID = INPUT;

                    }

                    db.FACENGGATTEND_OBJ.InsertOnSubmit(obj);
                    db.SubmitChanges();

                    textBox1.Text = obj.USERNAME;
                    textBox2.Text = obj.FNAME;
                    textBox3.Text = obj.LNAME;
                    textBox4.Text = obj.DATE.ToString();


                }
            }
            else if (DEPT == "MGMT")
            {
                FACULTYMGMT_ATTENDANCE obj = new FACULTYMGMT_ATTENDANCE();

                var cust = from c in db.FACULTYMGMT_OBJ

                           where (c.RFID == INPUT)

                           select c;

                foreach (var c in cust)
                {
                    obj.FNAME = c.FNAME;
                    obj.LNAME = c.LNAME;
                    obj.USERNAME = c.USERNAME;
                    obj.ATTENDANCE = "P";
                    obj.DATE = DateTime.Now;
                    textBox5.Text = c.DESIGNATION;
                    textBox6.Text = c.DEPARTMENT;
                    pictureBox1.ImageLocation = c.ID_IMAGE;


                }

                db.FACMGMTATTEND_OBJ.InsertOnSubmit(obj);
                db.SubmitChanges();

                textBox1.Text = obj.USERNAME;
                textBox2.Text = obj.FNAME;
                textBox3.Text = obj.LNAME;
                textBox4.Text = obj.DATE.ToString();


            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            DEPT = comboBox1.Text;
            
        }
    }
}
