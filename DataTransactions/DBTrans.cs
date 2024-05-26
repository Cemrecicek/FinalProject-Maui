using FinalProject.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataTransactions
{
    public class DBTrans
    {
        public String dbPath;
        private SQLiteConnection conn;

        public DBTrans(String dbPath)
        { this.dbPath = dbPath; }


        public void Init()
        {
            if (conn == null)
            {
                conn = new SQLiteConnection(this.dbPath);
                conn.CreateTable<Student>();
                conn.CreateTable<Course>();
                conn.CreateTable<Enroll>();
            }
           


        }
         public List<Student> GetAllStudents()
        {
            Init();
            return conn.Table<Student>().ToList();
        }

        public void Add(Student student)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(student);
        }

        public void Delete(int  student_ID) 
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Student {ID=student_ID });
        }









        public List<Course> GetAllCourses()
        {
            Init();
            return conn.Table<Course>().ToList();
        }

        public void Add_course(Course course)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(course);
        }

        public void Delete_course(int course_ıd)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Course { Crs_Id = course_ıd });
        }






        public List<Enroll> GetAllEnrolls()
        {
            Init();
            return conn.Table<Enroll>().ToList();
        }

        public void Add_enroll(Enroll enroll)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(enroll);
        }

        public void Delete_enroll(int enroll_ID)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new Enroll { En_ıd = enroll_ID });
        }



    }
}
