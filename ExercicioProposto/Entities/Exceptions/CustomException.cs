using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto.Entities.Exceptions
{
    internal class CustomException : InvalidOperationException
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}
