using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class Multiply:Function
    {
        //Constructor
        public Multiply()
        {
            notation = " * ";
        }

        //Method
        public override string ToString()
        {
            return $"({LeftFunc}{notation}{RightFunc})";
        }
        public override double Calculate(double X)
        {
            return LeftFunc.Calculate(X) * RightFunc.Calculate(X);
        }
        public override Function GetDerivativeAnalytically()
        {
            Plus plus = new Plus();
            plus.LeftFunc = new Multiply();
            plus.LeftFunc.LeftFunc = this.LeftFunc.GetDerivativeAnalytically();
            plus.LeftFunc.RightFunc = this.RightFunc;

            plus.RightFunc = new Multiply();
            plus.RightFunc.LeftFunc = this.LeftFunc;
            plus.RightFunc.RightFunc = this.RightFunc.GetDerivativeAnalytically();
            return plus;
        }
        public override Function SimplifyFunction()
        {
            this.LeftFunc = this.LeftFunc.SimplifyFunction();
            this.RightFunc = this.RightFunc.SimplifyFunction();
            if (this.LeftFunc.IsNr() && this.LeftFunc.Calculate(0) == 0)
            {
                n func = new n();
                (func as n).Data = 0;
                return func;
            }
            else if (this.RightFunc.IsNr() && this.RightFunc.Calculate(0) == 0)
            {
                n func = new n();
                (func as n).Data = 0;
                return func;
            }
            else if (this.LeftFunc.IsNr() && this.LeftFunc.Calculate(0) == 1)
            {
                return this.RightFunc.SimplifyFunction();
            }
            else if (this.RightFunc.IsNr() && this.RightFunc.Calculate(0) == 1)
            {
                return this.LeftFunc.SimplifyFunction();
            }

            //return this function if there is no x
            else if (this.LeftFunc.IsNr() && this.RightFunc.IsNr())
            {
                r func = new r();
                (func as r).Data = this.Calculate(0);
                return func;
            }
                return this;
        }
        public override bool IsNr()
        {
            return false;
        }
    }
}
