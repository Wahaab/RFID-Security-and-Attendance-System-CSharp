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
    public partial class TIMETABLE_MENU : Form
    {
        public static string COURS;
        public static string CLAS;
        public static string PROGRAM;
        

        public TIMETABLE_MENU()
        {
            

            InitializeComponent();

            for(int i=1 ; i<=10 ; i++)
            HALL1.Items.Add("HALL-"+i);

            for (int i = 1; i <= 10; i++)
            HALL2.Items.Add("HALL-" + i);

            PROGRAMBOX.Items.Add("BEE");
            CLASSBOX.Items.Add("8B");

            DAYBOX1.Items.Add("MONDAY");
            DAYBOX1.Items.Add("TUESDAY");
            DAYBOX1.Items.Add("WEDNESDAY");
            DAYBOX1.Items.Add("THURSDAY");
            DAYBOX1.Items.Add("FRIDAY");

            DAYBOX2.Items.Add("MONDAY");
            DAYBOX2.Items.Add("TUESDAY");
            DAYBOX2.Items.Add("WEDNESDAY");
            DAYBOX2.Items.Add("THURSDAY");
            DAYBOX2.Items.Add("FRIDAY");


            for (int i = 00; i <= 23; i++)
                HOURBOX1.Items.Add(i);

            for (int i = 00; i <= 23; i++)
                HOURBOX2.Items.Add(i);

            for (int i = 00; i <= 59; i++)
                MINUTEBOX1.Items.Add(i);

            for (int i = 00; i <= 59; i++)
                MINUTEBOX2.Items.Add(i);

            for (int i = 00; i <= 59; i++)
                SECONDBOX1.Items.Add(i);

            for (int i = 00; i <= 59; i++)
                SECONDBOX2.Items.Add(i);


        }

        private void PROGRAMBOX_SelectedValueChanged(object sender, EventArgs e)
        {

            PROGRAM = PROGRAMBOX.Text;

        }

        private void CLASSBOX_SelectedValueChanged(object sender, EventArgs e)
        {
            CLAS = CLASSBOX.Text;


            if (CLAS == "8B")
            {
                string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

                FYPRFID db = new FYPRFID(connString);

                BEE8_COURSES courses = new BEE8_COURSES();

                var course_checker = from c in db.BEE8COURSES_OBJ

                                     
                                     select c;

                foreach (var c in course_checker)
                {
                    COURSESBOX.Items.Add(c.COURSE);
                }

            }

        }

        private void COURSESBOX_SelectedValueChanged(object sender, EventArgs e)
        {
            COURS = COURSESBOX.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string b = HOURBOX1.Text;


            DateTime g = new DateTime(2011, 1, 1, int.Parse(HOURBOX1.Text), int.Parse(MINUTEBOX1.Text), int.Parse(SECONDBOX1.Text));
            DateTime p = new DateTime(2011, 1, 1, (int.Parse(HOURBOX1.Text)) + 1, int.Parse(MINUTEBOX1.Text), int.Parse(SECONDBOX1.Text));

            
            

            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);

            object l = "TIMETABLE TIME_TABLE";

            TIMETABLE TIME_TABLE = new TIMETABLE();

           

            
               TIME_TABLE. DAY = DAYBOX1.Text;
               TIME_TABLE.PROGRAM = PROGRAMBOX.Text;
               TIME_TABLE.CLASS = CLASSBOX.Text;
               TIME_TABLE.HALL = HALL1.Text;
               TIME_TABLE.START_TIME = g;
               TIME_TABLE.END_TIME = p;
               TIME_TABLE.SUBJECT = COURSESBOX.Text;
               TIME_TABLE.HOURS = 1;

                
           

            db.TIMETABLE_OBJ.InsertOnSubmit(TIME_TABLE);
            db.SubmitChanges();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAYBOX1.Text = string.Empty;
            HOURBOX1.Text = string.Empty;
            MINUTEBOX1.Text = string.Empty;
            SECONDBOX1.Text = string.Empty;
            HALL1.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime  g= new DateTime(2011, 1, 1, int.Parse(HOURBOX2.Text), int.Parse(MINUTEBOX2.Text), int.Parse(SECONDBOX2.Text));
            DateTime  p= new DateTime(2011, 1, 1, (int.Parse(HOURBOX2.Text)) + 1, int.Parse(MINUTEBOX2.Text), int.Parse(SECONDBOX2.Text));


            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);

            TIMETABLE TIME_TABLE = new TIMETABLE();

            TIME_TABLE.DAY = DAYBOX1.Text;
            TIME_TABLE.PROGRAM = PROGRAMBOX.Text;
            TIME_TABLE.CLASS = CLASSBOX.Text;
            TIME_TABLE.HALL = HALL1.Text;
            TIME_TABLE.START_TIME = g;
            TIME_TABLE.END_TIME = p;
            TIME_TABLE.SUBJECT = COURSESBOX.Text;
            TIME_TABLE.HOURS = 2;


            db.TIMETABLE_OBJ.InsertOnSubmit(TIME_TABLE);
            db.SubmitChanges();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            DAYBOX2.Text = string.Empty;
            HOURBOX2.Text = string.Empty;
            MINUTEBOX2.Text = string.Empty;
            SECONDBOX2.Text = string.Empty;
            HALL2.Text = string.Empty;
        }

      

        private void SECONDBOX1_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime g = new DateTime(2011, 1, 1, Convert.ToInt32(HOURBOX1.Text), Convert.ToInt32(MINUTEBOX1.Text), Convert.ToInt32(SECONDBOX1.Text));
            DateTime p = new DateTime(2011, 1, 1, (Convert.ToInt32((HOURBOX1.Text)) + 1), Convert.ToInt32(MINUTEBOX1.Text), Convert.ToInt32(SECONDBOX1.Text));

            
           

            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);

            TIMETABLE TIME_TABLE = new TIMETABLE();

            var TIMETABLE_ENTRY = from c in db.TIMETABLE_OBJ

                                  where (c.DAY == DAYBOX1.Text && c.START_TIME == g && c.END_TIME == p)

                                  select c;

            foreach (var c in TIMETABLE_ENTRY)
            {
                for (int o = 1; o <= 10; o++)
                {
                    if (c.HALL == "HALL-" + o)
                    {
                        HALL1.Items.Remove("HALL-" + o);
                    }
                }
            }


            }
         

        }

        
    }

