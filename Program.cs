using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company hospital = new Company("Grey Sloan Mercy West DeathTrap Hospital");
            
            // Create three employees
            Employee employeeOne = new Employee("Meredith", "Grey", "Head of General Surgery");
            Employee employeeTwo = new Employee("Lexi", "Grey", "Surgical Intern (Deceased)");
            Employee employeeThree = new Employee("Derek", "Shepherd", "Head of Neurosurgery, McDreamy");
            
            // Assign the employees to the company
            hospital.ListEmployee(employeeOne);
            hospital.ListEmployee(employeeTwo);
            hospital.ListEmployee(employeeThree);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            //Console.WriteLine($"{Employee} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartedOn}.");
            
        }
    }
}

/*
In the Main method of your console application, create a new instance of Company, 
and three instances of Employee. Then assign the employees to the company.

*/