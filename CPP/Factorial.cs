using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class Factorial:Function
    {
        //Constructor
        public Factorial()
        {
            notation = " ! ";
        }

        //Method
        private void ThrowExceptionWithWrongInput()
        {
            if (!(this.LeftFunc is Digit && (this.LeftFunc as Digit).Data > 0) && !(this.LeftFunc is n && (this.LeftFunc as n).Data > 0))
                throw new UnacceptedFunctionForFactorialException("Please input the positive natural number for factorial!");
        }

        public override string ToString()
        {
            ThrowExceptionWithWrongInput();
            return $"{LeftFunc}{notation}";
        }
        public override double Calculate(double X)
        {
            ThrowExceptionWithWrongInput();
            return GetFactorial(LeftFunc.Calculate(X));
        }
        public double GetFactorial(double x)
        {
            if (x == 1)
                return 1;
            else
                return GetFactorial(x - 1) * x;
        }
        public override Function GetDerivativeAnalytically()
        {
            ThrowExceptionWithWrongInput();
            n derivative = new n();
            derivative.Data = 0;
            return derivative;
        }
        public override Function SimplifyFunction()
        {
            return this;
        }
        public override bool IsNr()
        {
            return false;
        }
    }
}
