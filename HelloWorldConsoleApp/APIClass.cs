using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
    public class APIClass
    {
        public string DisplayDataFromService(int number)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            string message = client.GetData(number);

            return message;
        }       
    }
}
