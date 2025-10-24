using System;

namespace CodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new database context
            using (var db = new StudentContext())
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "Mariam",
                    LastName = "Hejazi",
                    Age = 25
                };

                // Add student to database
                db.Students.Add(student);

                // Save changes to the database
                db.SaveChanges();

                Console.WriteLine("Student added successfully!");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
