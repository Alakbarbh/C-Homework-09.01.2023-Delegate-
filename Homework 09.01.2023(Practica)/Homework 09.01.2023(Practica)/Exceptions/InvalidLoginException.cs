using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_09._01._2023_Practica_.Exceptions
{
    internal class InvalidLoginException : Exception
    {
        public InvalidLoginException(string message):base(message) { }
    }
}
