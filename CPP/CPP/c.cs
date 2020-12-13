using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class c : Function
    {

        //Constructor
        public c()
        {
            notation = " Cos ";
        }
        //Method
        public override string ToString()
        {
            return $"{notation}({LeftFunc.ToString()})";
        }
        public override decimal Calculate(decimal X)
        {
            return (decimal)Math.Cos(Convert.ToDouble(LeftFunc.Calculate(X)));
        }
       
        public override Function GetDerivativeAnalytically()
        {
            Multiply der = new Multiply();
            der.LeftFunc = LeftFunc.GetDerivativeAnalytically();
            der.RightFunc = new Substract();
            der.RightFunc.RightFunc = new S();
            der.RightFunc.RightFunc.LeftFunc = this.LeftFunc;
            return der;
        }
        public override Function SimplifyFunction()
        {
            return this;
        }



    }
}
