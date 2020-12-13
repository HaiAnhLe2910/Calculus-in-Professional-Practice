using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class pi:Function
    {
        //Constructor
        public pi()
        {
            notation = " p ";
        }

        //Method
        public override string ToString()
        {
            return notation;
        }
        public override decimal Calculate(decimal X)
        {
            return Convert.ToDecimal(Math.PI);
        }
        public override Function GetDerivativeAnalytically()
        {
            Digit derivative = new Digit();
            derivative.Data = 0;
            return derivative;
        }
        public override Function SimplifyFunction()
        {
            return this;
        }

    }
}
