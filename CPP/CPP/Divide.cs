using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class Divide : Function
    {

        //Constructor
        public Divide()
        {
            notation = " / ";
        }

        //Method
        private void ThrowExceptionWithDenominator0()
        {
            if (this.RightFunc is Digit && (this.RightFunc as Digit).Data == 0)
                throw new Denominator0Exception("Denominator can not be 0!");
        }
        public override string ToString()
        {
            ThrowExceptionWithDenominator0();
            return $"({LeftFunc}{notation}{RightFunc})";
        }
        public override decimal Calculate(decimal X)
        {
            ThrowExceptionWithDenominator0();
            return LeftFunc.Calculate(X) / RightFunc.Calculate(X);
        }
        public override Function GetDerivativeAnalytically()
        {
            ThrowExceptionWithDenominator0();

            Divide divide = new Divide();
            divide.LeftFunc = new Substract();
            divide.LeftFunc.LeftFunc = new Multiply();
            divide.LeftFunc.LeftFunc.LeftFunc = this.LeftFunc.GetDerivativeAnalytically();
            divide.LeftFunc.LeftFunc.RightFunc = this.RightFunc;
            divide.LeftFunc.RightFunc = new Multiply();
            divide.LeftFunc.RightFunc.LeftFunc = this.LeftFunc;
            divide.LeftFunc.RightFunc.RightFunc = this.RightFunc.GetDerivativeAnalytically();

            divide.RightFunc = new Power();
            divide.RightFunc.LeftFunc = RightFunc;
            divide.RightFunc.RightFunc = new Digit();
            (divide.RightFunc.RightFunc as Digit).Data = 2;
            return divide;
        }
        public override Function SimplifyFunction()
        {
            if (this.RightFunc is Digit && (this.RightFunc as Digit).Data == 1)
            {
                return this.LeftFunc.SimplifyFunction();
            }
            else if(this.LeftFunc is Digit &&(this.LeftFunc as Digit).Data==0)
            {
                return this.LeftFunc.SimplifyFunction();
            } 
            else
            {
                this.LeftFunc = this.LeftFunc.SimplifyFunction();
                this.RightFunc = this.RightFunc.SimplifyFunction();
                //return this function if there is no x
                if ((this.LeftFunc is Digit || this.LeftFunc is n || this.LeftFunc is r)&& (this.RightFunc is Digit || this.LeftFunc is n||this.LeftFunc is r))
                {
                    r func = new r();
                    (func as r).Data = this.Calculate(0);
                    return func;
                }
                else
                    return this;
            }
        }
    }
}
