using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class l:Function
    {
        //Constructor
        public l()
        {
            notation = " ln ";
        }

        //Method
        public override string ToString()
        {
            return $"{notation}({LeftFunc.ToString()})";
        }
        public override double Calculate(double X)
        {
            return Math.Log(LeftFunc.Calculate(X));
        }
        public override Function GetDerivativeAnalytically()
        {
            Divide divide = new Divide();
            divide.LeftFunc = this.LeftFunc.GetDerivativeAnalytically();
            divide.RightFunc = this.LeftFunc;
            return divide;
        }
        public override Function SimplifyFunction()
        {
            this.LeftFunc = this.LeftFunc.SimplifyFunction();
            return this;
        }
        public override bool IsNr()
        {
            return false;
        }
    }
}
