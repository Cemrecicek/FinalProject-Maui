using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class Course
    {
        [PrimaryKey, AutoIncrement]
        public int Crs_Id { get; set; }
  
        public string Crs_Code { get; set; }

        public string Crs_Name { get; set; }
    }
}
