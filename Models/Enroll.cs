using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Enroll
    {

        [PrimaryKey, AutoIncrement]
        public int En_ıd { get; set; }

        public int Stu_ID { get; set; }

        public string Crs_Cod { get; set; }
    }
}
