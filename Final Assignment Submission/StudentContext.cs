using System.Data.Entity;

namespace CodeFirstStudentApp
{
    // DbContext represents the database
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDBConnection") { }

        // DbSet represents the Students table
        public DbSet<Student> Students { get; set; }
    }
}
