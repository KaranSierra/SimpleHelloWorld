using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldConsoleApp;

namespace UnitTestHelloWorld
{
    [TestClass]
    public class UnitTest1
    {        
        [TestMethod]
        public void TestAPIMethod()
        {
            APIClass clsAPI = new APIClass();
            string actualMessage = clsAPI.DisplayDataFromService(2000);
            string expectedMessage = "You entered: " + "2000";

            Assert.AreEqual<string>(expectedMessage, actualMessage, "Data from service is not displayed successfully");
        }

        [TestMethod]
        public void TestDatabaseMethods()
        {
            DBClass dbClass = new DBClass();
            int recordsCount = dbClass.GetEmployeeRecords();
            Employee emp = new Employee();
            emp.EmployeeID = 100 + recordsCount + 1;
            emp.EmployeeName = "Employee" + recordsCount + 1; 
            emp.Age = 31;            
            int insertedRecordsCount = dbClass.InsertEmployeeRecord(emp);
            Assert.AreEqual<int>(1, insertedRecordsCount, "Employee record is not inserted successfully");

            int actualRecords = dbClass.GetEmployeeRecords();
            Assert.AreEqual<int>(recordsCount + 1, actualRecords, "Employee Records are not fetched Successfully");
        }  

    }
}
