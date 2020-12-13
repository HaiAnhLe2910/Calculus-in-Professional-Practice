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
      
        public override string ToString()
        {
            return $"({LeftFunc}{notation}{RightFunc})";
        }
        public override double Calculate(double X)
        {
               return LeftFunc.Calculate(X) / RightFunc.Calculate(X);
        }
        public override Function GetDerivativeAnalytically()
        {
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
            divide.RightFunc.RightFunc = new n();
            (divide.RightFunc.RightFunc as n).Data = 2;
            return divide;
        }
        public override Function SimplifyFunction()
        {
            this.LeftFunc = this.LeftFunc.SimplifyFunction();
            this.RightFunc = this.RightFunc.SimplifyFunction();
            
            if (this.LeftFunc.IsNr()&& this.LeftFunc.Calculate(0) == 0)
            {
                n func = new n();
                (func as n).Data = 0;
                return func;
            }
            else if (this.LeftFunc.IsNr() && this.LeftFunc.Calculate(0) == 1)
            {
                this.RightFunc= this.RightFunc.SimplifyFunction();
                return this;
            }
            else if (this.RightFunc.IsNr() && this.RightFunc.Calculate(0) == 1)
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
