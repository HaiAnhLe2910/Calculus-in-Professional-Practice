using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class Substract:Function
    {
        //Constructor
        public Substract()
        {
            notation = " - ";
        }

        //Method
        public override string ToString()
        {
            return $"({LeftFunc}{notation}{RightFunc})";
        }
        public override decimal Calculate(decimal X)
        {
            if (LeftFunc != null)
                return LeftFunc.Calculate(X) - RightFunc.Calculate(X);
            else
                return -RightFunc.Calculate(X);
        }
        public override Function GetDerivativeAnalytically()
        {
            Substract derivative = new Substract();
            if (this.LeftFunc != null)
            {
                derivative.LeftFunc = this.LeftFunc.GetDerivativeAnalytically();
            }
            derivative.RightFunc = this.RightFunc.GetDerivativeAnalytically();
            return derivative;
        }
        public override Function SimplifyFunction()
        {
            if (this.RightFunc is Digit && (this.RightFunc as Digit).Data == 0)
            {
                return this.LeftFunc.SimplifyFunction();
            }
            else if (this.LeftFunc is Digit && (this.LeftFunc as Digit).Data == 0)
            {
                this.LeftFunc = null;
                return this;
                
            }
            else
            {
                if (this.LeftFunc != null)
                {
                    this.LeftFunc = this.LeftFunc.SimplifyFunction();
                }
                this.RightFunc = this.RightFunc.SimplifyFunction();
                //return the simplified function if there is no x
                if ((this.LeftFunc is Digit || this.LeftFunc is n || this.LeftFunc is r) && (this.RightFunc is Digit || this.LeftFunc is n || this.LeftFunc is r))
                {
                    r func = new r();
                    (func as r).Data = this.Calculate(0);
                    return func;
                }
                else
                {
                    if (this.LeftFunc is Digit && (this.LeftFunc as Digit).Data == 0)
                    {
                        this.LeftFunc = null;
                        return this;
                    }
                    else if (this.RightFunc is Digit && (this.RightFunc as Digit).Data == 0)
                    {
                        return LeftFunc.SimplifyFunction();
                    }
                    else
                        return this;
                }
            }
        }
    }
}
