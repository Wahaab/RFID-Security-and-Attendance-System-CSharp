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
    public partial class GATE_OUT : Form
    {
        public static string INPUT = string.Empty;
        public static string IMAGE_LOCATION = string.Empty;
        public static int Valid_in;
        public static int Valid_out;

        public GATE_OUT()
        {
            InitializeComponent();

            GATEMENU.Items.Add("START");
        }


       

        private void GATEMENU_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PORT.Open();

        }

        private void PORT_DataReceived_1(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Valid_in = 0;
            Valid_out = 0;

            INPUT = PORT.ReadExisting();

            if (INPUT != String.Empty)
            {
                INPUT = INPUT.Substring(INPUT.Length + 1 - INPUT.Length, INPUT.Length - 4);


            }


            string connString = @"server = WAHAABJB-PC\SERVER;integrated security = False;database = FYPRFID;User Id=sa;Password=st";

            FYPRFID db = new FYPRFID(connString);

            GATE_LOG GATELO_G = new GATE_LOG();

            var cust = from c in db.RECORDS_OBJ

                       where c.RFID == INPUT

                       select c;

            foreach (var c in cust)
            {
                GATELO_G.FNAME = c.FNAME;
                GATELO_G.LNAME = c.LNAME;
                GATELO_G.USERNAME = c.USERNAME;
                GATELO_G.PROGRAM = c.PROGRAM;
                GATELO_G.CLASS = c.CLASS;
                IMAGE_LOCATION = c.ID_IMAGE;
                GATELO_G.DESIGNATION = c.DESIGNATION;
            }
            GATELO_G.DATE = DateTime.Now;
            GATELO_G.DIRECTION = "OUT";

            db.GATELOG_OBJ.InsertOnSubmit(GATELO_G);
            db.SubmitChanges();

            FNAME.Text = GATELO_G.FNAME;
            LNAME.Text = GATELO_G.LNAME;
            USERNAME.Text = GATELO_G.USERNAME;
            PROGRAM.Text = GATELO_G.PROGRAM;
            CLASS.Text = GATELO_G.CLASS;
            DATE.Text = Convert.ToString(DateTime.Now);
            GATE_ID.ImageLocation = IMAGE_LOCATION;
            designation.Text = GATELO_G.DESIGNATION;


            GATELOG_UPDATED OBJ = new GATELOG_UPDATED();

            var indupli = from c in db.GATELOGSTATUS_OBJ

                          where (c.DATE.Day == DateTime.Now.Day && c.USERNAME == GATELO_G.USERNAME && (c.DIRECTION == "IN" || c.DIRECTION == "OUT"))

                          select c;

            foreach (var c in indupli)
            {
                if (c.DIRECTION == "IN")
                {
                    Valid_in = 1;

                }

                else if (c.DIRECTION == "OUT")
                    Valid_out = 1;
            }

            if (Valid_in == 0 && Valid_out == 0)
            {

                OBJ.USERNAME = GATELO_G.USERNAME;
                OBJ.FNAME = GATELO_G.FNAME;
                OBJ.LNAME = GATELO_G.LNAME;
                OBJ.PROGRAM = GATELO_G.PROGRAM;
                OBJ.CLASS = GATELO_G.CLASS;
                OBJ.DATE = GATELO_G.DATE;
                OBJ.DESIGNATION = GATELO_G.DESIGNATION;
                OBJ.DIRECTION = GATELO_G.DIRECTION;

                db.GATELOGSTATUS_OBJ.InsertOnSubmit(OBJ);
                db.SubmitChanges();
            }

            else if (Valid_in == 1)
            {
                var ini = db.GATELOGSTATUS_OBJ.Single(p => p.USERNAME == GATELO_G.USERNAME && p.DATE.Day == DateTime.Now.Day && p.DIRECTION == "IN");
                ini.DATE = DateTime.Now;
                ini.DIRECTION = "OUT";

                db.SubmitChanges();
            }

            else if (Valid_out == 1)
            {
                var ino = db.GATELOGSTATUS_OBJ.Single(p => p.USERNAME == GATELO_G.USERNAME && p.DATE.Day == DateTime.Now.Day && p.DIRECTION == "OUT");
                ino.DATE = DateTime.Now;

                db.SubmitChanges();
            }



        }
    }
}
