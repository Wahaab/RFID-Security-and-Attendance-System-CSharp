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
    public partial class FACULTY_ATTENDRECORD : Form
    {

        public static int MONT;
        public static string DEPRT;
      

        public FACULTY_ATTENDRECORD()
        {
            InitializeComponent();
            DEPT.Items.Add("ENGG");
            DEPT.Items.Add("MGMT");

            for (int i = 1; i <= DateTime.Now.Date.Month; i++)
            {
                MNTH.Items.Add(i);
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            MONT = Convert.ToInt32(MNTH.Text);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            DEPRT = DEPT.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int absents = 0;
            int overload = 1;
            int rows = 0;
            int sr = 1;
           

            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);


            if (DEPRT == "ENGG")
            {
                var cust = from c in db.FACENGGATTEND_OBJ

                           where (c.USERNAME == textBox1.Text && c.DATE.Month == MONT)

                           select c;

                foreach (var c in cust)
                {

                    if (DateTime.Now.Month == MONT )
                    {

                        for (int q = overload; q <= DateTime.Now.Date.Day; q++)
                        {
                            DateTime d = new DateTime(DateTime.Now.Date.Year, MONT, q);
                            
                            if (d.DayOfWeek.ToString() != "Saturday" && d.DayOfWeek.ToString() != "Sunday" )
                            {



                                if (c.DATE.Day == q)
                                {

                                    overload = q;

                                    dataGridView1.Rows.Add(1);

                                    dataGridView1[0, rows].Value = sr;
                                    dataGridView1[1, rows].Value = c.DATE;
                                    dataGridView1[2, rows].Value = "PRESENT";
                                    dataGridView1[3, rows].Value = absents;
                                    
                                    rows++;
                                    sr++;
                                    

                                }
                                else
                                {
                                    overload = q;

                                    absents++;

                                    dataGridView1.Rows.Add(1);

                                    dataGridView1[0, rows].Value = sr;
                                    dataGridView1[1, rows].Value = d.Date.Day+"/"+d.Date.Month+"/"+d.Date.Year;
                                    dataGridView1[2, rows].Value = "ABSENT";
                                    dataGridView1[3, rows].Value = absents;

                                    
                                    
                                    rows++;
                                    sr++;
                                }
                                

                              


                            }
                        }
                    }



                    else if (DateTime.Now.Date.Month != MONT &&  c.DATE.ToString() != string.Empty)
                    {
                        int u = DateTime.DaysInMonth(DateTime.Now.Year, MONT);

                        for (int q = overload; q <= u; q++)
                        {
                            DateTime d = new DateTime(DateTime.Now.Date.Year, MONT, q);

                            if (d.DayOfWeek.ToString() != "SATURDAY" && d.DayOfWeek.ToString() != "SUNDAY")
                            {
                                if (c.DATE.Day == q)
                                {

                                    overload = q;

                                    dataGridView1.Rows.Add(1);

                                    dataGridView1[0, rows].Value = sr;
                                    dataGridView1[1, rows].Value = c.DATE;
                                    dataGridView1[2, rows].Value = "PRESENT";
                                    dataGridView1[3, rows].Value = absents;

                                    rows++;
                                    sr++;


                                }
                                else
                                {
                                    absents++;

                                    dataGridView1.Rows.Add(1);

                                    dataGridView1[0, rows].Value = sr;
                                    dataGridView1[1, rows].Value = d.Date.Day + "/" + d.Date.Month + "/" + d.Date.Year;
                                    dataGridView1[2, rows].Value = "ABSENT";
                                    dataGridView1[3, rows].Value = absents;



                                    rows++;
                                    sr++;
                                }
                            }
                        }
                    }

                    


                }

            }



            if (DEPRT == "MGMT")
            {
                var cust = from c in db.FACMGMTATTEND_OBJ

                           where (c.USERNAME == textBox1.Text && c.DATE.Date.Month == MONT)

                           select c;

                foreach (var c in cust)
                {
                    if (DateTime.Now.Month == MONT && c.DATE.ToString() != string.Empty)
                    {

                        for (int q = overload; q <= DateTime.Now.Date.Day; q++)
                        {
                            DateTime d = new DateTime(DateTime.Now.Date.Year, MONT, q);

                            if (d.DayOfWeek.ToString() != "Saturday" && d.DayOfWeek.ToString() != "Sunday")
                            {



                                if (c.DATE.Day == q)
                                {

                                    overload = q;

                                    dataGridView1.Rows.Add(1);

                                    dataGridView1[0, rows].Value = sr;
                                    dataGridView1[1, rows].Value = c.DATE;
                                    dataGridView1[2, rows].Value = "PRESENT";
                                    dataGridView1[3, rows].Value = absents;

                                    rows++;
                                    sr++;


                                }
                                else
                                {
                                    absents++;

                                    dataGridView1.Rows.Add(1);

                                    dataGridView1[0, rows].Value = sr;
                                    dataGridView1[1, rows].Value = d.Date.Day + "/" + d.Date.Month + "/" + d.Date.Year;
                                    dataGridView1[2, rows].Value = "ABSENT";
                                    dataGridView1[3, rows].Value = absents;



                                    rows++;
                                    sr++;
                                }





                            }
                        }
                    }



                    else if (DateTime.Now.Date.Month != MONT && c.DATE.ToString() != string.Empty)
                    {
                        int u = DateTime.DaysInMonth(DateTime.Now.Year, MONT);

                        for (int q = overload; q <= u; q++)
                        {
                            DateTime d = new DateTime(DateTime.Now.Date.Year, MONT, q);

                            if (d.DayOfWeek.ToString() != "SATURDAY" && d.DayOfWeek.ToString() != "SUNDAY")
                            {
                                if (c.DATE.Day == q)
                                {

                                    overload = q;

                                    dataGridView1.Rows.Add(1);

                                    dataGridView1[0, rows].Value = sr;
                                    dataGridView1[1, rows].Value = c.DATE;
                                    dataGridView1[2, rows].Value = "PRESENT";
                                    dataGridView1[3, rows].Value = absents;

                                    rows++;
                                    sr++;


                                }
                                else
                                {
                                    absents++;

                                    dataGridView1.Rows.Add(1);

                                    dataGridView1[0, rows].Value = sr;
                                    dataGridView1[1, rows].Value = d.Date.Day + "/" + d.Date.Month + "/" + d.Date.Year;
                                    dataGridView1[2, rows].Value = "ABSENT";
                                    dataGridView1[3, rows].Value = absents;



                                    rows++;
                                    sr++;
                                }
                            }
                        }
                    }


                }            

                   

            }



        }



        private void button2_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            textBox1.Clear();

        }
    }
}

