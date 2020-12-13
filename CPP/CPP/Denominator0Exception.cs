using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class Denominator0Exception:Exception
    {
        public Denominator0Exception()
        {
        }

        public Denominator0Exception(string message)
            : base(message)
        {
        }

        public Denominator0Exception(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
