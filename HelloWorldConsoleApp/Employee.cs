namespace HelloWorldConsoleApp
{
    public class Employee
    {
        private int empID;

        public int EmployeeID
        {
            get
            {
                return empID;
            }

            set
            {
                if (value < 0)
                    throw new CustomException();
                empID = value;
            }
        }

        private string empName;

        public string EmployeeName
        {
            get
            {
                return empName;
            }

            set
            {
                if (value.Length == 20)
                    throw new System.Exception("Employee Name is too Long");
                
                empName = value;
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}