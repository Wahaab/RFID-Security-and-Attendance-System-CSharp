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
    public partial class COURSE_ADDITION : Form
    {
        public static string classl;
        public string checker_course;
        public string checker_code;


        public COURSE_ADDITION()
        {
            InitializeComponent();
            comboBox1.Items.Add("ENGG");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (classl == "BEE8")
            {
              



                string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

                FYPRFID db = new FYPRFID(connString);

                BEE8_COURSES courses = new BEE8_COURSES();

                var course_checker = from c in db.BEE8COURSES_OBJ

                                     where (c.COURSE == COURSE_NAME.Text )

                                     select c;

                foreach (var c in course_checker)
                {
                    checker_course = c.COURSE;
                    checker_code = c.COURSE_CODE;

                }


                if (checker_course == COURSE_NAME.Text || checker_code == CODE_COURSE.Text)
                {
                    goto a;
                }


                courses.COURSE = COURSE_NAME.Text;
                courses.COURSE_CODE = CODE_COURSE.Text;

                db.BEE8COURSES_OBJ.InsertOnSubmit(courses);
                db.SubmitChanges();

             
                    MessageBox.Show("COURSE ADDED");
                    goto b;


               a: MessageBox.Show("THIS COURSE ALREADY EXISTS");
            b: ;

            }







        }

        private void CLASSLIST_SelectedValueChanged(object sender, EventArgs e)
        {
           classl = CLASSLIST.Text;

            
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            CLASSLIST.Items.Add("BEE8");
        }

       

       
    }
}
