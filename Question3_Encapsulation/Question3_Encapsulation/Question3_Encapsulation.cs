using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3_Encapsulation
{
    //3. Create a class Employee with properties (Id, Name, Salary) and demonstrate encapsulation.
    class Employee
    {
        // Private fields (data hiding)
        private int id;
        private string name;
        private double salary;

        // Public properties (controlled access)
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    Console.WriteLine("Invalid Salary!");
            }
        }
    }
    internal class Question3_Encapsulation
    {

        static void Main()
        {
            Employee emp = new Employee(); // Create object

            // Setting values using properties
            emp.Id = 101;
            emp.Name = "Pranav";
            emp.Salary = 50000;

            // Getting values
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Id: " + emp.Id);
            Console.WriteLine("Name: " + emp.Name);
            Console.WriteLine("Salary: " + emp.Salary);
        }

    }

}

