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
   public class BEE8_CLASSES
    {

        [Column(DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int SR_NO;

        [Column]
        public string SUBJECT;

        [Column]
        public DateTime TIME;

        [Column]
        public string CLASS;

        [Column]
        public int HOURS;

    }

    public partial class FYPRFID : DataContext
    {

        public Table<BEE8_CLASSES> BEE8CLASSES_OBJ;

    }
}
