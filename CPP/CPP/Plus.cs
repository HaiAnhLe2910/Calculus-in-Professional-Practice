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
        public override decimal Calculate(decimal X)
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
            if ((this.RightFunc is Digit) && (this.RightFunc as Digit).Data == 0)
            {
               return this.LeftFunc.SimplifyFunction();
            }
            else if(this.LeftFunc is Digit && (this.LeftFunc as Digit).Data == 0)
            {
                return this.RightFunc.SimplifyFunction();
            }
            else
            {
                this.LeftFunc=this.LeftFunc.SimplifyFunction();
                this.RightFunc=this.RightFunc.SimplifyFunction();
                //return this function if there is no x
                if ((this.LeftFunc is Digit || this.LeftFunc is n || this.LeftFunc is r) && (this.RightFunc is Digit || this.LeftFunc is n || this.LeftFunc is r))
                {
                    r func = new r();
                    (func as r).Data = this.Calculate(0);
                    return func;
                }
                else
                {
                    if (this.LeftFunc is Digit && (this.LeftFunc as Digit).Data == 0)
                        return RightFunc.SimplifyFunction();
                    else if (this.RightFunc is Digit && (this.RightFunc as Digit).Data == 0)
                        return LeftFunc.SimplifyFunction();
                    else
                        return this;
                }
            }
        }

    }
}
