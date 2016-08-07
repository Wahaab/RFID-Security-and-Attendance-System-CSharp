using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace FYP_RFID
{
    [Table]
    public class BEE8_STUDENTS
    {
        [Column(DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int SR_NO;

        [Column]
        public string RFID;

        [Column]
        public string FNAME;

        [Column]
        public string LNAME;

        [Column]
        public string USERNAME;

        [Column]
        public string CLASS;

        [Column]
        public string COURSE_1;

        [Column]
        public string COURSE_2;

        [Column]
        public string COURSE_3;

        [Column]
        public string COURSE_4;

        [Column]
        public string COURSE_5;

        [Column]
        public string COURSE_6;
        
    }

    public partial class FYPRFID : DataContext
    {
        public Table<BEE8_STUDENTS> BEE8STUDENTS_OBJ;
    }
}
