using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------1. In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name---------
//------------   as well as an Id. At least two employees should have the first name "Joe".--------------------------------------------

namespace Lambda1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee() { fname = "Jim", lname = "Jones", ID = 1 };
            Employee employee2 = new Employee() { fname = "John", lname = "Smith", ID = 2 };
            Employee employee3 = new Employee() { fname = "Jerry", lname = "Jones", ID = 3 };
            Employee employee4 = new Employee() { fname = "Sammy", lname = "Smith", ID = 4 };
            Employee employee5 = new Employee() { fname = "Joe", lname = "Dickson", ID = 5 };
            Employee employee6 = new Employee() { fname = "Jim", lname = "Jones", ID = 6 };
            Employee employee7 = new Employee() { fname = "Joe", lname = "Smith", ID = 7 };
            Employee employee8 = new Employee() { fname = "Jerry", lname = "Jones", ID = 8 };
            Employee employee9 = new Employee() { fname = "Sammy", lname = "Smith", ID = 9 };
            Employee employee10 = new Employee() { fname = "Joe", lname = "Dickson", ID = 10 };

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);

            int count = (employees.Count());

            Console.WriteLine("Employee List");
            Console.WriteLine("-------------");
            Console.WriteLine("");

            for (int x = 0; x < count; x++)  Console.WriteLine("Employee " + x + ": {0} {1} {2}", employees[x].fname, employees[x].lname, employees[x].ID);

            Console.ReadLine();

            //------------------2. Using a foreach loop, create a new list of all employees with the first name "Joe".------------

            List<string> JoeList = new List<string>();

            foreach (Employee value in employees)  if (value.fname == "Joe") JoeList.Add(value.fname);

            Console.WriteLine("");
            Console.WriteLine("JoeList List after adding entries to the new list with a for/each loop: ");
            JoeList.ForEach(Console.WriteLine);
            Console.WriteLine("");
            Console.ReadLine();

            //-------------------3. Do the same thing again, but this time with a lambda expression.--------------------------------

            List<Employee> JoeList2 = employees.Where(x => x.fname == "Joe").ToList(); ;

            Console.WriteLine("");
            Console.WriteLine("JoeList2 after adding entries to the new list for first name Joe using a Lambda: ");

            count = (JoeList2.Count());
            for (int x = 0; x < count; x++)  Console.WriteLine("Employees named Joe:  {0} {1} {2}", JoeList2[x].fname, JoeList2[x].lname, JoeList2[x].ID);

            Console.ReadLine();

            //------------------4. Using a lambda expression, make a list of all employees with an Id number greater than 5.-------

            List<Employee> EmpList = employees.Where(x => x.ID > 5).ToList();

            Console.WriteLine("");
            Console.WriteLine("EmpList List after adding entries to the new list for ID > 5 using a Lambda: ");
            Console.WriteLine("");

            count = (EmpList.Count());
            for (int x = 0; x < count; x++)  Console.WriteLine("Employees with ID's > 5:  {0} {1} {2}", EmpList[x].fname, EmpList[x].lname, EmpList[x].ID);

            Console.ReadLine();

        }
    }
}
