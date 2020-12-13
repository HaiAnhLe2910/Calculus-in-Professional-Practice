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
        public override decimal Calculate(decimal X)
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
            if (this.LeftFunc is Digit && (this.LeftFunc as Digit).Data == 0)
            {
                return this.LeftFunc.SimplifyFunction();
            }
            else if (this.RightFunc is Digit && (this.RightFunc as Digit).Data == 0)
            {
                return this.RightFunc.SimplifyFunction();
            }
            else if (this.LeftFunc is Digit && (this.LeftFunc as Digit).Data == 1)
            {
                return this.RightFunc.SimplifyFunction();
            }
            else if (this.RightFunc is Digit && (this.RightFunc as Digit).Data == 1)
            {
                return this.LeftFunc.SimplifyFunction();
            }
            else 
            {
                this.LeftFunc = this.LeftFunc.SimplifyFunction();
                this.RightFunc = this.RightFunc.SimplifyFunction();
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
                        return LeftFunc.SimplifyFunction();
                    else if (this.RightFunc is Digit && (this.RightFunc as Digit).Data == 0)
                        return RightFunc.SimplifyFunction();
                    else if (this.LeftFunc is Digit && (this.LeftFunc as Digit).Data == 1)
                        return RightFunc.SimplifyFunction();
                    else if (this.RightFunc is Digit && (this.RightFunc as Digit).Data == 1)
                        return LeftFunc.SimplifyFunction();
                    else
                        return this;

                }
            }
            
        }



    }
}
