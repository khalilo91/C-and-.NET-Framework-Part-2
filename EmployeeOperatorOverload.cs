using System;  // Import basic .NET functionality like Console

namespace EmployeeOperatorOverload
{
    // Employee class definition
    class Employee
    {
        // Properties for Employee
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the == operator to compare two Employee objects by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null
            if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
                return true;

            // Check if either object is null
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare Employee Ids
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must be paired with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);  // Use the == operator logic
        }

        // Override Equals() to satisfy compiler warning
        public override bool Equals(object obj)
        {
            if (obj is Employee emp)
            {
                return this.Id == emp.Id;
            }
            return false;
        }

        // Override GetHashCode() to satisfy compiler warning
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate first Employee object and assign properties
            Employee emp1 = new Employee
            {
                Id = 101,
                FirstName = "Alice",
                LastName = "Smith"
            };

            // Instantiate second Employee object and assign properties
            Employee emp2 = new Employee
            {
                Id = 102,
                FirstName = "Bob",
                LastName = "Johnson"
            };

            // Compare the two Employee objects using overloaded == operator
            if (emp1 == emp2)
            {
                Console.WriteLine("The employees are the same (Ids match).");
            }
            else
            {
                Console.WriteLine("The employees are different (Ids do not match).");
            }

            // Compare the two Employee objects using overloaded != operator
            if (emp1 != emp2)
            {
                Console.WriteLine("Confirmed: The employees are not the same.");
            }
            else
            {
                Console.WriteLine("Confirmed: The employees are the same.");
            }

            // Keep console open until a key is pressed
            Console.ReadLine();
        }
    }
}
