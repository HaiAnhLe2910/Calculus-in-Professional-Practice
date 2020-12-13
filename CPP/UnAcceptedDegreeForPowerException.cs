using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class UnAcceptedDegreeForPowerException:Exception
    {
        public UnAcceptedDegreeForPowerException(string message)
            : base(message)
        {
        }

    }
}
