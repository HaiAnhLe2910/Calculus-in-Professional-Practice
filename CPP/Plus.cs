using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class Plus:Function
    {
        // properties

        //Constructor
        public Plus()
        {
            notation = " + ";
        }
        //Method
        public override string ToString()
        {
            return $"({LeftFunc}{notation}{RightFunc})";
        }
        public override double Calculate(double X)
        {
            return LeftFunc.Calculate(X) +RightFunc.Calculate(X);
        }
        public override Function GetDerivativeAnalytically()
        {
            Plus derivative = new Plus();
            derivative.LeftFunc = this.LeftFunc.GetDerivativeAnalytically();
            derivative.RightFunc = this.RightFunc.GetDerivativeAnalytically();
            return derivative;
        }
        public override Function SimplifyFunction()
        {
            this.LeftFunc = this.LeftFunc.SimplifyFunction();
            this.RightFunc = this.RightFunc.SimplifyFunction();

            if (this.RightFunc.IsNr() && this.RightFunc.Calculate(0) == 0)
            {
               return this.LeftFunc.SimplifyFunction();
            }
            else if (this.LeftFunc.IsNr() && this.LeftFunc.Calculate(0) == 0)
            {
                return this.RightFunc.SimplifyFunction();
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
