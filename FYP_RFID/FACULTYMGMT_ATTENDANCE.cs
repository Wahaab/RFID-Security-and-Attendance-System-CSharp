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
   public class FACULTYMGMT_ATTENDANCE
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
        public DateTime DATE;

        [Column]
        public string ATTENDANCE;
    }

    public partial class FYPRFID : DataContext
    {
        public Table<FACULTYMGMT_ATTENDANCE> FACMGMTATTEND_OBJ;
    }
}
