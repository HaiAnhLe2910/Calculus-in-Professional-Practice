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
            if (!(this.LeftFunc is Digit&&(this.LeftFunc as Digit).Data>0)&&!(this.LeftFunc is n&&(this.LeftFunc as n).Data>0))
                throw new UnAcceptedDegreeForPowerException("Please input the positive natural number for factorial!");
        }
        public override string ToString()
        {
            ThrowExceptionWithWrongInput();
            return $"{LeftFunc}{notation}";
        }
        public override decimal Calculate(decimal X)
        {
            ThrowExceptionWithWrongInput();
            return getFactorial(LeftFunc.Calculate(X));
        }
        public decimal getFactorial(decimal x)
        {
            if (x == 1)
                return 1;
            else
                return getFactorial(x - 1) * x;
        }
        public override Function GetDerivativeAnalytically()
        {
            ThrowExceptionWithWrongInput();
            Digit derivative = new Digit();
            derivative.Data = 0;
            return derivative;
        }
        public override Function SimplifyFunction()
        {
            n simplifiedFunc = new n();
            (simplifiedFunc as n).Data = Convert.ToInt32(this.Calculate(0));
            return simplifiedFunc;
        }

    }
}
