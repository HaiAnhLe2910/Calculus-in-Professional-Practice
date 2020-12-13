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
        public override double Calculate(double X)
        {
            return Math.Sin(LeftFunc.Calculate(X));
        }
        public override Function GetDerivativeAnalytically()
        {
            Multiply derivative = new Multiply();
            derivative.LeftFunc = this.LeftFunc.GetDerivativeAnalytically();
            derivative.RightFunc = new c();
            derivative.RightFunc.LeftFunc = this.LeftFunc;
            return derivative;
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
