using System;  // Import basic .NET functionality for Console

namespace InterfaceAssignment
{
    // Define an interface called IQuittable
    interface IQuittable
    {
        // Define a void method called Quit()
        void Quit();
    }

    // Employee class (from previous drill)
    class Employee : IQuittable
    {
        // Properties for Employee
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Implement the Quit() method from IQuittable interface
        public void Quit()
        {
            // Display a message indicating the employee is quitting
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee emp = new Employee
            {
                FirstName = "John",  // Assign first name
                LastName = "Doe"     // Assign last name
            };

            // Polymorphism: use the interface type to reference the Employee object
            IQuittable quittableEmp = emp;

            // Call the Quit() method through the interface reference
            quittableEmp.Quit();

            // Keep the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
