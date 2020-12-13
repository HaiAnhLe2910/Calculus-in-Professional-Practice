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
        public override double Calculate(double X)
        {
            return Math.Cos(LeftFunc.Calculate(X));
        }
       
        public override Function GetDerivativeAnalytically()
        {
            Multiply der = new Multiply();
            der.LeftFunc = new Multiply();
            der.LeftFunc.LeftFunc = new n();
            (der.LeftFunc.LeftFunc as n).Data = -1;
            der.LeftFunc.RightFunc = LeftFunc.GetDerivativeAnalytically();
            der.RightFunc = new S();
            der.RightFunc.LeftFunc = this.LeftFunc;
            //der.LeftFunc = LeftFunc.GetDerivativeAnalytically();
            //der.RightFunc = new Substract();
            //der.RightFunc.RightFunc = new S();
            //der.RightFunc.RightFunc.LeftFunc = this.LeftFunc;
            return der;
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
