using System.ComponentModel.DataAnnotations;

namespace CodeFirstStudentApp
{
    // Defines the Student entity
    public class Student
    {
        [Key] // Primary key
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }
    }
}
