using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class UnacceptedFunctionForFactorialException:Exception
    {
        public UnacceptedFunctionForFactorialException()
        {
        }

        public UnacceptedFunctionForFactorialException(string message)
            : base(message)
        {
        }

        public UnacceptedFunctionForFactorialException(string message, Exception inner)
            : base(message, inner)
        {
        }

    }
}
