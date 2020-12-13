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
        public override decimal Calculate(decimal X)
        {
            return (decimal)Math.Log(Convert.ToDouble(LeftFunc.Calculate(X)));
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
            return this;
        }

    }
}
