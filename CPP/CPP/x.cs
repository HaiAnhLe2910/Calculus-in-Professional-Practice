using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class x:Function
    {
       
        //Constructor
        public x()
        {
            notation = " x ";
        }

        //Method
        public override string ToString()
        {
            return notation;
        }
        public override decimal Calculate(decimal X)
        {
            return X;
        }
        public override Function GetDerivativeAnalytically()
        {
            Digit derivative = new Digit();
            derivative.Data = 1;
            return derivative;
        }
        public override Function SimplifyFunction()
        {
            return this;
        }
    }
}
