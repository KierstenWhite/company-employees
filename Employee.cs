using System;

namespace Classes {
    public class Employee
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Title { get; set;}
        public DateTime StartedOn { get; set;}

        public Employee(string firstname, string lastname, string title) {
            FirstName = firstname;
            LastName = lastname;
            Title = title;
        }

    }
}


/*
Expand on the Company class code by
Adding an Employees property (Its type should be List<Employee>)
Setting the value of Employees in the constructor as a new List<Employee> (News Flash: Declaring a property gives it an initial vlaue of null). This will allow you to add newly created employees to the Employees list in the final step below.
Create an Employee.cs file and then define a class for Employee. An employee has the following properties.
First name (string)
Last name (string)
Title (string)
Start date (DateTime)
The Company class should also have a ListEmployees() method which writes a string to the console about each employee, such as "Jane Doe works for Acme, Inc. as Lion Tamer since 3/23/15."
In the Main method of your console application, create a new instance of Company, and three instances of Employee. Then assign the employees to the company.

*/