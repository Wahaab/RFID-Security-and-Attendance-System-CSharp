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
    public class BEE8_COURSES   
    {
        [Column(DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Sr_No;

        [Column]
        public string COURSE;

        [Column]
        public string COURSE_CODE;

    }


    public partial class FYPRFID : DataContext
    {
        public Table<BEE8_COURSES> BEE8COURSES_OBJ;



    }
}
