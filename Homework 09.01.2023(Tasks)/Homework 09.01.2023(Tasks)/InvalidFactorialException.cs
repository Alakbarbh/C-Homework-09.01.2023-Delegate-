using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09._01._2023_Tasks_
{
    public class InvalidFactorialException : Exception
    {
        public InvalidFactorialException(string message) : base(message) { }
    }
}
