using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
    public class DBClass
    {
        string constr = Convert.ToString(ConfigurationSettings.AppSettings["SampleDBConString"]);
        public int GetEmployeeRecords()
        {
            int recordsCount = 0;
            using (SqlConnection connection = new SqlConnection(constr))
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM Employees", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("Id = ", reader["Id"]);
                            Console.WriteLine("Name = ", reader["Name"]);
                            Console.WriteLine("Age = ", reader["Age"]);
                            recordsCount++;
                        }
                    }
                    reader.Close();
                }
            }

            return recordsCount;
        }
              

        public int InsertEmployeeRecord(Employee emp)
        {
            int rows;
            using (SqlConnection sqlCon = new SqlConnection(constr))
            {
                sqlCon.Open();
                using (SqlCommand cmd =  new SqlCommand("INSERT INTO Employees VALUES(@Id, @Name, @Age)", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Id", emp.EmployeeID);
                    cmd.Parameters.AddWithValue("@Name", emp.EmployeeName);
                    cmd.Parameters.AddWithValue("@Age", emp.Age);

                    rows = cmd.ExecuteNonQuery();
                }
                sqlCon.Close();
            }
            return rows;
        }
    }
}
