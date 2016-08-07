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
    public class GATE_LOG
    {
        [Column(DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int SR_NO;

        [Column]
        public string FNAME;

        [Column]
        public string LNAME;

        [Column]
        public string USERNAME;

        [Column]
        public string PROGRAM;

        [Column]
        public string CLASS;

        [Column]
        public DateTime DATE;

        [Column]
        public string DIRECTION;

        [Column]
        public string DESIGNATION;

    }

    public partial class FYPRFID : DataContext
    {
        public Table<GATE_LOG> GATELOG_OBJ;

    }

}
