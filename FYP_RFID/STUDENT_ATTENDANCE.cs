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
    public partial class STUDENT_ATTENDANCE : Form
    {
        public static string s;
        public static string subj;
        public static string prog;
        public static string cls;
        public static string fn;
        public static string ln;
        public static string usr;
        public static string FACULL;

        public static int hour;
        public static int valid = 3;
        public static int valid2 = 1;
        public static int valid3 = 0;
        public static int VALID4 = 1;
        public static int VALID5 = 0;

        public static int m1 = 0;
        public static int m2 = 0;
        

        public STUDENT_ATTENDANCE()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; i++)
                HALL.Items.Add("HALL-" + i);
            serialPort1.Open();
            
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {



            string INPUT;

            INPUT = serialPort1.ReadExisting();

            valid = 3;
            valid2 = 1;
            valid3 = 0;
            VALID4 = 1;
            VALID5 = 0;


            if (INPUT != String.Empty)
            {
                INPUT = INPUT.Substring(INPUT.Length + 1 - INPUT.Length, INPUT.Length - 4);
            }





            DateTime D = DateTime.Now;
            string day = D.DayOfWeek.ToString();

            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);






            var course_checker = from c in db.TIMETABLE_OBJ


                                 where (c.HALL == s && c.DAY == day && D.TimeOfDay >= c.START_TIME.TimeOfDay && D.TimeOfDay < c.END_TIME.TimeOfDay)


                                 select c;

            foreach (var c in course_checker)
            {
                m1 = c.START_TIME.TimeOfDay.Minutes;
                m2 = c.START_TIME.TimeOfDay.Hours;

                subj = c.SUBJECT;
                cls = c.CLASS;
                prog = c.PROGRAM;
                hour = c.HOURS;

            }





            var identifir = from c in db.BEE8STUDENTS_OBJ

                            where (c.RFID == INPUT)

                            select c;

            foreach (var c in identifir)
            {
                if (c.COURSE_1 == subj)
                {
                    valid = 1;
                    fn = c.FNAME;
                    ln = c.LNAME;
                    usr = c.USERNAME;
                }

                else if (c.COURSE_2 == subj)
                {
                    valid = 1;
                    fn = c.FNAME;
                    ln = c.LNAME;
                    usr = c.USERNAME;
                }

                else if (c.COURSE_3 == subj)
                {
                    valid = 1;
                    fn = c.FNAME;
                    ln = c.LNAME;
                    usr = c.USERNAME;
                }

                else if (c.COURSE_4 == subj)
                {
                    valid = 1;
                    fn = c.FNAME;
                    ln = c.LNAME;
                    usr = c.USERNAME;

                }

                else if (c.COURSE_5 == subj)
                {
                    valid = 1;
                    fn = c.FNAME;
                    ln = c.LNAME;
                    usr = c.USERNAME;
                }

                else if (c.COURSE_6 == subj)
                {
                    valid = 1;
                    fn = c.FNAME;
                    ln = c.LNAME;
                    usr = c.USERNAME;
                }

            }





            if (valid != 1)
            {
                var faculverfir = from c in db.FACULTYENGG_OBJ


                                  where (c.RFID == INPUT)

                                  select c;
                foreach (var c in faculverfir)
                {
                    if (c.USERNAME != null)
                    {
                        valid3 = 1;
                    }
                }

                if (valid3 == 1)
                {
                    

                    var MIKA = from X in db.BEE8CLASSES_OBJ
                               where (X.CLASS == cls && X.TIME.Date == DateTime.Now.Date && X.HOURS == hour)
                               select X;

                    foreach (var c in MIKA)
                    {
                        if (c.SUBJECT == subj)
                        {
                            VALID4 = 0;
                            
                        }


                    }
                }

               

              

                if (valid3 == 1 && VALID4 == 1)
                {




                    BEE8_CLASSES obj = new BEE8_CLASSES();

                    obj.CLASS = cls;
                    obj.HOURS = hour;
                    obj.SUBJECT = subj;
                    obj.TIME = D;
                    obj.CLASS = cls;

                    db.BEE8CLASSES_OBJ.InsertOnSubmit(obj);
                    db.SubmitChanges();

                }
            }

            if (valid == 1)
            {


                var atverifir = from c in db.BEE8BATTENDANCE_OBJ

                                where (c.USERNAME == usr && c.TIME.Date == DateTime.Now.Date && c.SUBJECT == subj)


                                select c;


                foreach (var c in atverifir)
                {

                    if (c.ATTENDANCE == "P")
                    {
                        valid2 = 0;
                    }

                    if (c.ATTENDANCE == "A")
                    {
                        VALID5 = 1;
                        valid2 = 0;
                    }


                }
            }

            if (valid2 != 0)
                valid2 = 1;

            else if (valid2 == 0 && VALID5 == 0)
            {
                var cust = db.BEE8BATTENDANCE_OBJ.Single(p => p.USERNAME == usr && p.SUBJECT == subj && p.TIME.Date == DateTime.Now.Date);
                cust.ATTENDANCE = "A";

                if (cust.PENALTY <= 2)
                    cust.PENALTY = cust.PENALTY + 1;

                cust.LEAVE = DateTime.Now;

                db.SubmitChanges();

                USRNAME.Text = usr;
                FIRST.Text = fn;
                LAST.Text = ln;
                PRGM.Text = prog;
                CLSS.Text = cls;
                ATTENDANCE.Text = "A";
                PENALTY.Text = cust.PENALTY.ToString();


            }

            else if (valid2 == 0 && VALID5 == 1)
            {
                var cust = db.BEE8BATTENDANCE_OBJ.Single(p => p.USERNAME == usr && p.SUBJECT == subj && p.TIME.Date == DateTime.Now.Date);
                if (cust.PENALTY == 1 && (cust.LEAVE.TimeOfDay.Minutes + 10) >= DateTime.Now.TimeOfDay.Minutes)
                {
                    cust.ATTENDANCE = "P";
                    db.SubmitChanges();

                    USRNAME.Text = usr;
                    FIRST.Text = fn;
                    LAST.Text = ln;
                    PRGM.Text = prog;
                    CLSS.Text = cls;
                    ATTENDANCE.Text = "P";
                    PENALTY.Text = cust.PENALTY.ToString();


                }

                else
                {
                    USRNAME.Text = usr;
                    FIRST.Text = fn;
                    LAST.Text = ln;
                    PRGM.Text = prog;
                    CLSS.Text = cls;
                    ATTENDANCE.Text = "A";
                    PENALTY.Text = "2";

                }

            }

            

            if (valid == 1 && valid2 == 1 && DateTime.Now.TimeOfDay.Minutes <= m1 + 10 && DateTime.Now.Hour == m2)
            {



                BEE8B_ATTENDANCE obj = new BEE8B_ATTENDANCE();

                obj.ATTENDANCE = "P";
                obj.FNAME = fn;
                obj.LNAME = ln;
                obj.USERNAME = usr;
                obj.SUBJECT = subj;
                obj.TIME = DateTime.Now;
                obj.HOURS = hour;
                obj.CLASS = cls;
                obj.PENALTY = 0;
                obj.LEAVE = DateTime.Now;


                db.BEE8BATTENDANCE_OBJ.InsertOnSubmit(obj);
                db.SubmitChanges();

                USRNAME.Text = usr;
                FIRST.Text = fn;
                LAST.Text = ln;
                PRGM.Text = prog;
                CLSS.Text = cls;
                ATTENDANCE.Text = "P";
                PENALTY.Text = "0";
            }

                

         }

            

        private void HALL_SelectedValueChanged(object sender, EventArgs e)
        {
            s = HALL.Text;
            
        }
        }
          
        

        
}

