using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class n:Function 
    {
        //field
        private int data;
        //property
        public int Data
        {
            get { return data; }
            set
            {
                data = value;
                notation = data.ToString();
            }
        }
        //Constructor
        public n()
        {
        }

        //Method
        public override string ToString()
        {
            return $"{Data}";
        }
        public override double Calculate(double X)
        {
            return Convert.ToDouble(Data);
        }
        public override Function GetDerivativeAnalytically()
        {
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
            return true;
        }

    }
}
