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
   public class FACULTY_ENGG
    {

        [Column(DbType = "int NOT NULL IDENTITY", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Sr_No;

        [Column]
        public string FNAME;

        [Column]
        public string LNAME;

        [Column]
        public string USERNAME;

        [Column]
        public DateTime DATE;

        [Column]
        public string ID_IMAGE;

        [Column]
        public string RFID;

        [Column]
        public string DEPARTMENT;

        [Column]
        public string DESIGNATION;
    }


    public partial class FYPRFID : DataContext
    {

        public Table<FACULTY_ENGG> FACULTYENGG_OBJ;

    }
}
