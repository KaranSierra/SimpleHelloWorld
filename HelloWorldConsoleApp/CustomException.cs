﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsoleApp
{
    public class CustomException : Exception 
    {
        public override string Message
        {
            get
            {
                return "value cannot be negative";
            }
        }
    }
}
