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
        public override double Calculate(double X)
        {
            return Math.Exp(Convert.ToDouble(LeftFunc.Calculate(X)));
        }
        public override Function GetDerivativeAnalytically()
        {
            Multiply multiply = new Multiply();
            multiply.LeftFunc = this.LeftFunc.GetDerivativeAnalytically();
            multiply.RightFunc = this;
            return multiply;
        }
        public override Function SimplifyFunction()
        {
            this.LeftFunc = this.LeftFunc.SimplifyFunction();
            return this;
        }

        public override bool IsNr()
        {
            return false;
        }
    }
}
