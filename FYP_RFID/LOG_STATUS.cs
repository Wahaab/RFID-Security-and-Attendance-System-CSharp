using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FYP_RFID;

namespace FYP_RFID
{
    public partial class LOG_STATUS : Form
    {
        public string user;
        public string first;
        public string last;
        public string progr;
        public string clas;
        public string stats;
        public int row_num = 0;
        public string statics;

        
        public static DateTime b;

        public LOG_STATUS()
        {
            InitializeComponent();
            b = DateTime.Now.Date;
            comboBox1.Items.Add("IN");
            comboBox1.Items.Add("OUT");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            row_num = 0;

            
            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";
            string j = Convert.ToString(b);
            

            FYPRFID db = new FYPRFID(connString);

          //  GATE_LOG GATELO_G = new GATE_LOG();

           
            
            if (radioButton1.Checked)
            {
                first = F_NAME.Text;
            }

            else if (radioButton2.Checked)
            {
                last = L_NAME.Text;
            }

            else if (radioButton3.Checked)
            {
                user = USER_NAME.Text;
            }

            else if (radioButton4.Checked)
            {
                progr = PRO_GRAM.Text;
            }

            else if (radioButton5.Checked)
            {
                clas = CLA_SS.Text;
            }

            else if (radioButton6.Checked)
            {
                stats = STATU_S.Text;
            }

            
            var cust = from c in db.GATELOG_OBJ
                      
                     where ( c.DATE.Date==b &&( c.USERNAME == user || c.FNAME == first || c.LNAME == last || c.PROGRAM == progr || c.CLASS == clas || c.DIRECTION == stats))
                      orderby c.FNAME         
                       select c;

            foreach (var c in cust)
            {

                dataGridView1.Rows.Add(1);
                dataGridView1[0,row_num].Value = c.USERNAME;
                dataGridView1[1,row_num].Value = c.FNAME;
                dataGridView1[2,row_num].Value = c.LNAME;
                dataGridView1[3,row_num].Value = c.PROGRAM;
                dataGridView1[4,row_num].Value = c.CLASS;
                dataGridView1[5,row_num].Value = c.DIRECTION;
                dataGridView1[6,row_num].Value = c.DATE;
                
                row_num++;
                
                
            }

             if (radioButton7.Checked)
            {
                var ds = from c in db.GATELOGSTATUS_OBJ
                         where (c.DATE.Date == b && c.DIRECTION == statics)
                         select c;

                 foreach(var c in ds)
                 {
                     dataGridView1.Rows.Add(1);
                     dataGridView1[0, row_num].Value = c.USERNAME;
                     dataGridView1[1, row_num].Value = c.FNAME;
                     dataGridView1[2, row_num].Value = c.LNAME;
                     dataGridView1[3, row_num].Value = c.PROGRAM;
                     dataGridView1[4, row_num].Value = c.CLASS;
                     dataGridView1[5, row_num].Value = c.DIRECTION;
                     dataGridView1[6, row_num].Value = c.DATE;

                     row_num++;
                 }

            }
            

            
             
                       }

      

       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            b = dateTimePicker1.Value.Date;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            USER_NAME.Clear();
            STATU_S.Clear();
            CLA_SS.Clear();
            PRO_GRAM.Clear();
            F_NAME.Clear();
            L_NAME.Clear();
            dataGridView1.Rows.Clear();

            row_num = 0;

            user = string.Empty;
            first = string.Empty;
            last = string.Empty;
            progr = string.Empty;
            clas = string.Empty;
            stats = string.Empty;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            statics = comboBox1.Text;

        }
             
              
        
    }
}
