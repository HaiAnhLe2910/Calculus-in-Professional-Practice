using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class e:Function
    {
        //Constructor
        public e()
        {
            notation = " e ";
        }

        //Method
        public override string ToString()
        {
            return $"{notation}({LeftFunc.ToString()})";
        }
        public override decimal Calculate(decimal X)
        {
            return (decimal)Math.Exp(Convert.ToDouble(LeftFunc.Calculate(X)));
        }
        public override Function GetDerivativeAnalytically()
        {
            Multiply multiply = new Multiply();
            multiply.LeftFunc = LeftFunc.GetDerivativeAnalytically();
            multiply.RightFunc = this;
            return multiply;
        }
        public override Function SimplifyFunction()
        {
            return this;
        }
    }
}
