using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Task1: Printed the Hello World in the Console Window
            Console.WriteLine("Hello World");

            // Task2: Consuming the WCF Service
            //APIClass cls = new APIClass();
            //Console.WriteLine(cls.DisplayDataFromService(2000));

            // Task 3: Inserting data into the database
            Employee emp = new Employee();
            emp.EmployeeID = 101;
            emp.EmployeeName = "Employee1";
            emp.Age = 31;
            DBClass dbClass = new DBClass();
            dbClass.InsertEmployeeRecord(emp);

            //  Get the data from database           
            dbClass.GetEmployeeRecords();

            Console.ReadLine();
        }     

    }

}
