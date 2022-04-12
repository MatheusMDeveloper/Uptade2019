using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityException : AplicationException
    {
        public IntegrityException(string message) : base(message)
        {
        }
    }
}
