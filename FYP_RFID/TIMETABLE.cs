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
    public class TIMETABLE
    {

        [Column(DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Sr_No;

        [Column]
        public string DAY;

        [Column]
        public string HALL;

        [Column]
        public string PROGRAM;

        [Column]
        public string CLASS;

        [Column]
        public string SUBJECT;

        [Column]
        public DateTime START_TIME;

        [Column]
        public DateTime END_TIME;

        [Column]
        public int HOURS;


    }

    public partial class FYPRFID : DataContext
    {

        public Table<TIMETABLE> TIMETABLE_OBJ;

    }
}
