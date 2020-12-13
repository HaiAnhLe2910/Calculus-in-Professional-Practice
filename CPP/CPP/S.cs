using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class S:Function
    {
        //Constructor
        public S()
        {
            notation = " sin ";
        }
        //Method
        public override string ToString()
        {
            return $"{notation}({LeftFunc.ToString()})";
        }
        public override decimal Calculate(decimal X)
        {
            return (decimal)Math.Sin(Convert.ToDouble(LeftFunc.Calculate(X)));
        }
        public override Function GetDerivativeAnalytically()
        {
            Multiply derivative = new Multiply();
            derivative.LeftFunc = this.LeftFunc.GetDerivativeAnalytically();
            derivative.RightFunc = new c();
            derivative.RightFunc.LeftFunc = this.LeftFunc;
            SimplifyFunction();
            return derivative;
        }
        public override Function SimplifyFunction()
        {
            return this;
        }

    }
}
