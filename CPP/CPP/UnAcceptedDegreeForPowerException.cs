using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class UnAcceptedDegreeForPowerException:Exception
    {
        public UnAcceptedDegreeForPowerException()
        {
        }

        public UnAcceptedDegreeForPowerException(string message)
            : base(message)
        {
        }

        public UnAcceptedDegreeForPowerException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
