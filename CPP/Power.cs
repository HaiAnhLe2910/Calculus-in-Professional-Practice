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
            if (!(this.RightFunc is Digit) && !(this.RightFunc is n) &&  !(this.RightFunc is Factorial))
                throw new UnAcceptedDegreeForPowerException("Please input the natural number for degree of power!");
        }


        public override string ToString()
        {
            ThrowExceptionWithWrongInput();
            return $"({LeftFunc}{notation}{RightFunc})";
        }
        public override double Calculate(double X)
        {
            ThrowExceptionWithWrongInput();
            return Math.Pow(LeftFunc.Calculate(X), RightFunc.Calculate(X));
        }
        public override Function GetDerivativeAnalytically()
        {
            ThrowExceptionWithWrongInput();
            Multiply derivative = new Multiply();
            derivative.LeftFunc = new Multiply();

            derivative.LeftFunc.LeftFunc = this.RightFunc;
            derivative.LeftFunc.RightFunc= new Power();
            derivative.LeftFunc.RightFunc.LeftFunc = this.LeftFunc;
            derivative.LeftFunc.RightFunc.RightFunc = new n();
            (derivative.LeftFunc.RightFunc.RightFunc as n).Data = Convert.ToInt32(this.RightFunc.Calculate(0) - 1); 
                

            derivative.RightFunc = this.LeftFunc.GetDerivativeAnalytically();

            return derivative;
        }
        public override Function SimplifyFunction()
        {
            this.LeftFunc = this.LeftFunc.SimplifyFunction();
            this.RightFunc = this.RightFunc.SimplifyFunction();
            if (this.RightFunc.IsNr() && this.RightFunc.Calculate(0) == 1)
            {
                return this.LeftFunc.SimplifyFunction();
            }
            else if (this.RightFunc.IsNr() && this.RightFunc.Calculate(0) == 0)
            {
                n func = new n();
                func.Data = 0;
                return func;
            }
            else if (this.LeftFunc is pi || this.LeftFunc is e)
            {
                return this;
            }

            //return this function if there is no x
            if (this.LeftFunc.IsNr() && this.RightFunc.IsNr())
            {
                r func = new r();
                (func as r).Data = this.Calculate(0);//There is no x in the function => replace with random value
                return func;
            }
            else
                return this;
           
        }
        public override bool IsNr()
        {
            return false;
        }

    }
}
