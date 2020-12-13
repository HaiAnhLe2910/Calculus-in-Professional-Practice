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
        public override double Calculate(double X)
        {
            return Math.PI;
        }
        public override Function GetDerivativeAnalytically()
        {
            n derivative = new n();
            derivative.Data = 0;
            return derivative;
        }
        public override Function SimplifyFunction()
        {
            return this;
        }
        public override bool IsNr()
        {
            return false;
        }

    }
}
