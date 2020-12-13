using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    public abstract class Function
    {

        // properties
        public Function LeftFunc
        { get; set; }
        public Function RightFunc
        { get; set; }
        public string notation
        { get; set; }
        public int Order
        { get; set; }

        //Constructor
        public Function()
        {
            LeftFunc = RightFunc = null;
            notation = "";
            Order = 0;
        }

        //Method
        public abstract double Calculate(double X);
        public abstract Function GetDerivativeAnalytically();
        public abstract Function SimplifyFunction();
        public abstract bool IsNr();

    }
}
