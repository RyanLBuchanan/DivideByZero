using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    public class NegativeNumberException : Exception
    {
        // Default constructor 
        public NegativeNumberException()
            : base ("Illegal operation for a negative number")
        {
            // Empty body
        }

        // Constructor for customizing error message 
        public NegativeNumberException(string messageValue)
            : base(messageValue)
        {
            // Empty body
        }

        // Constructor for customizing the exception's error message and specifying the InnerException object
        public NegativeNumberException(string messageValue, Exception inner)
            : base(messageValue, inner)
        {
            // Empty body
        }
    }
}
