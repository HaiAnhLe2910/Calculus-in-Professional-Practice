﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class UnacceptedFunctionForFactorialException:Exception
    {
        public UnacceptedFunctionForFactorialException(string message)
            : base(message)
        {
        }

    }
}