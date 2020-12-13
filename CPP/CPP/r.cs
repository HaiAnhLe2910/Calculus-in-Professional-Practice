using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    class r:Function
    {
        //field
        private decimal data;
        //properties
        public decimal Data
        {
            get { return data; }
            set
            {
                data = value;
                notation = data.ToString();
            }
        }
        //Constructor
        public r()
        {
        }
        //Method
        public override string ToString()
        {
            return $"{Data}";
        }
        public override decimal Calculate(decimal X)
        {
            return Convert.ToDecimal(Data);
        }
        public override Function GetDerivativeAnalytically()
        {
            Digit derivative = new Digit();
            derivative.Data = 0;
            return derivative;
        }
        public override Function SimplifyFunction()
        {
            return this;
        }

    }
}
