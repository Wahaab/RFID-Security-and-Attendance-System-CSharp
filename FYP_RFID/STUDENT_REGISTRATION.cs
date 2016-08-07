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
    public partial class STUDENT_REGISTRATION : Form
    {
        public static string INPUT = string.Empty;
        public static string IMAGE_LOCATION = string.Empty;
        public static string DEPT;
        public static string CLAS;
        public static string prog;

        public static int valid = 1;

        public STUDENT_REGISTRATION()
        {
            InitializeComponent();
          
            REGLIST.Items.Add("START");
            comboBox1.Items.Add("ENGG");
            //comboBox1.Items.Add("MGMT");
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            INPUT = PORT.ReadExisting();

            if (INPUT != String.Empty)
            {
                INPUT = INPUT.Substring(INPUT.Length + 1 - INPUT.Length, INPUT.Length - 4);

                this.RFID.Text = INPUT;

                
            }
           

        }

        private void REGBUTTON_Click(object sender, EventArgs e)
        {
            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);

            

           RECORDS RECORD_S = new RECORDS();

           
            RECORD_S.FNAME = FNAME.Text;
            RECORD_S.LNAME = LNAME.Text;
            RECORD_S.USERNAME = USERNAME.Text;
            RECORD_S.PROGRAM = prog;
            RECORD_S.CLASS = CLAS;
            RECORD_S.RFID = INPUT;
            RECORD_S.CREATED = DateTime.Now;
            RECORD_S.ID_IMAGE = IMAGE_LOCATION;
            RECORD_S.DEPARTMENT = DEPT;
            RECORD_S.DESIGNATION = DESIGNATION.Text;

           DATE.Text = Convert.ToString(DateTime.Now);





           db.RECORDS_OBJ.InsertOnSubmit(RECORD_S);
            db.SubmitChanges();


            
          

        }

        private void REGLIST_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            
            PORT.Open();
        }

        private void BROWSE_Click(object sender, EventArgs e)
        {
            
         
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                
                
                 
                    
                    IMAGE_LOCATION = openFileDialog1.FileName;
                    REGPIC.ImageLocation = IMAGE_LOCATION;
                      

                
               
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            DEPT = comboBox1.Text;
            comboBox2.Items.Add("BEE");

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            prog = comboBox2.Text;
            comboBox3.Items.Add("8B");

        }

        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            CLAS = comboBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valid = 1;
            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);
            MessageBox.Show(USERNAME.Text);

            var X = from c in db.RECORDS_OBJ

                    where (c.USERNAME == USERNAME.Text)

                    select c;

            foreach (var c in X)
            {
                if (c.USERNAME == USERNAME.Text)
                {
                    valid = 0;
                }
            }

            if (valid == 0)
            {
                MessageBox.Show("USERNAME ALREADY EXISTS");
            }

            else if (valid == 1 && USERNAME.Text != string.Empty)
            {
                MessageBox.Show("USERNAME AVAILABLE");
            }

            else
            {
                MessageBox.Show("NO USERNAME ENTERED");
            }


        }

        

        

        

        
    }
}
