using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class Power:Function
    {
        //Constructor
        public Power()
        {
            notation = " ^ ";
        }

        //Method
        private void ThrowExceptionWithWrongInput()
        {
            if(!(this.RightFunc is Digit||this.RightFunc is n))
                throw new UnAcceptedDegreeForPowerException("Please input the natural number for degree of power!");
        }
        public override string ToString()
        {
            ThrowExceptionWithWrongInput();
            return $"({LeftFunc}{notation}{RightFunc})";
        }
        public override decimal Calculate(decimal X)
        {
            ThrowExceptionWithWrongInput();
            return (decimal)Math.Pow(Convert.ToDouble(LeftFunc.Calculate(X)),Convert.ToDouble(RightFunc.Calculate(X)));
        }
        public override Function GetDerivativeAnalytically()
        {
            ThrowExceptionWithWrongInput();

            Multiply derivative = new Multiply();
            derivative.LeftFunc = this.RightFunc;
            derivative.RightFunc = new Power();
            derivative.RightFunc.LeftFunc = this.LeftFunc;
            derivative.RightFunc.RightFunc = new Digit();
            (derivative.RightFunc.RightFunc as Digit).Data = (this.RightFunc as Digit).Data - 1;
            return derivative;
        }
        public override Function SimplifyFunction()
        {
            if (this.RightFunc is Digit && (this.RightFunc as Digit).Data == 1)
            {
                return this.LeftFunc.SimplifyFunction();
            }
            else
            {
                this.LeftFunc = this.LeftFunc.SimplifyFunction();
                this.RightFunc = this.RightFunc.SimplifyFunction();
                //return this function if there is no x
                if(this.LeftFunc is pi||this.LeftFunc is e)
                {
                    return this;
                }
                if ((this.LeftFunc is Digit || this.LeftFunc is n || this.LeftFunc is r) && (this.RightFunc is Digit || this.LeftFunc is n || this.LeftFunc is r))
                {
                    r func = new r();
                    (func as r).Data = this.Calculate(0);//There is no x in the function => replace with random value
                    return func.SimplifyFunction();
                }
                else
                    return this;
            }
        }

    }
}
