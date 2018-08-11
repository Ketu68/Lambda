// This works.  But I know it is WAYYYYYY too obfuscated.  I spent hours and hours trying to populate a simple list with all the required values.  To no avail.
// I'm guessing there's a much easier way to do this.  Eliminating about 100 lines of code or so......

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//------------1. In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name---------
//------------   as well as an Id.At least two employees should have the first name "Joe".--------------------------------------------

namespace Lambda1
{
    class Program
    {
        static void Main(string[] args)
        {

        Employee employee1 = new Employee();
        employee1.fname = "Jim";
        employee1.lname = "Jones";
        employee1.ID = 1;
        Employee employee2 = new Employee();
        employee2.fname = "John";
        employee2.lname = "Smith";
        employee2.ID = 2;
        Employee employee3 = new Employee();
        employee3.fname = "Joe";
        employee3.lname = "Jones";
        employee3.ID = 3;
        Employee employee4 = new Employee();
        employee4.fname = "Sammy";
        employee4.lname = "Smith";
        employee4.ID = 4;
        Employee employee5 = new Employee();
        employee5.fname = "Joe";
        employee5.lname = "Dickson";
        employee5.ID = 5;
        Employee employee6 = new Employee();
        employee6.fname = "Jerry";
        employee6.lname = "Jones";
        employee6.ID = 6;
        Employee employee7 = new Employee();
        employee7.fname = "Jimbo";
        employee7.lname = "Jenkins";
        employee7.ID = 7;
        Employee employee8 = new Employee();
        employee8.fname = "Tony";
        employee8.lname = "Gunk";
        employee8.ID = 8;
        Employee employee9 = new Employee();
        employee9.fname = "Captain";
        employee9.lname = "Fatbelly";
        employee9.ID = 9;
        Employee employee10 = new Employee();
        employee10.fname = "Jesus";
        employee10.lname = "Jones";
        employee10.ID = 10;

        List<string> firstnamesList = new List<string>();
        List<string> lastnamesList = new List<string>();
        List<int> IDList = new List<int>();

        firstnamesList.Add(employee1.fname);
        firstnamesList.Add(employee2.fname);
        firstnamesList.Add(employee3.fname);
        firstnamesList.Add(employee4.fname);
        firstnamesList.Add(employee5.fname);
        firstnamesList.Add(employee6.fname);
        firstnamesList.Add(employee7.fname);
        firstnamesList.Add(employee8.fname);
        firstnamesList.Add(employee9.fname);
        firstnamesList.Add(employee10.fname);

        lastnamesList.Add(employee1.lname);
        lastnamesList.Add(employee2.lname);
        lastnamesList.Add(employee3.lname);
        lastnamesList.Add(employee4.lname);
        lastnamesList.Add(employee5.lname);
        lastnamesList.Add(employee6.lname);
        lastnamesList.Add(employee7.lname);
        lastnamesList.Add(employee8.lname);
        lastnamesList.Add(employee9.lname);
        lastnamesList.Add(employee10.lname);

        IDList.Add(employee1.ID);
        IDList.Add(employee2.ID);
        IDList.Add(employee3.ID);
        IDList.Add(employee4.ID);
        IDList.Add(employee5.ID);
        IDList.Add(employee6.ID);
        IDList.Add(employee7.ID);
        IDList.Add(employee8.ID);
        IDList.Add(employee9.ID);
        IDList.Add(employee10.ID);

        int count = (IDList.Count());
    
        for (int x = 0; x < count; x++)
        {
            Console.WriteLine(firstnamesList[x]);
            Console.WriteLine(lastnamesList[x]);
            Console.WriteLine(IDList[x]);
        }

        List<string> JoeList = new List<string>();

        //------------------2. Using a foreach loop, create a new list of all employees with the first name "Joe".------------

        foreach (string value in firstnamesList)
        {
            Console.WriteLine(value);
            if (value == "Joe")
            {
                JoeList.Add(value);
            }
        }

        Console.WriteLine("");
        Console.WriteLine("JoeList List after adding entries to the new list: ");
        JoeList.ForEach(Console.WriteLine);
        Console.WriteLine("");

        //-------------------3. Do the same thing again, but this time with a lambda expression.--------------------------------

        List<string> JoeList2 = firstnamesList.Where(x => x == "Joe").ToList();

        Console.WriteLine("");
        Console.WriteLine("JoeList2 List after adding entries to the new list: ");
        JoeList2.ForEach(Console.WriteLine);
        Console.WriteLine("");

        //------------------4. Using a lambda expression, make a list of all employees with an Id number greater than 5.-------

        List<int> EmpList = IDList.Where(x=> x > 5).ToList();

        Console.WriteLine("");
        Console.WriteLine("EmpList List after adding entries to the new list: ");
        EmpList.ForEach(Console.WriteLine);
        Console.WriteLine("");


        Console.ReadLine();

        }
    }
}
