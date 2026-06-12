using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabaseApp
{
    // 1. Define the Student entity (Table structure)
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public int Grade { get; set; }
    }

    // 2. Define the Database Context (The bridge between the code and the database)
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {
        }

        public DbSet<Student> Students { get; set; }
    }

    // 3. The main program execution class
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize the context and add one student to the database
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Dapo" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.WriteLine($"Student added successfully to the database: {stud.StudentName}");
            }

            Console.ReadKey();
        }
    }
}