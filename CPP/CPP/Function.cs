using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPP
{
    abstract class Function
    {
        //field
        protected static int order = 0;

        // properties
        public Function LeftFunc
        { get; set; }
        public Function RightFunc
        { get; set; }
        public string notation
        { get; set; }
        public int Order { get; set; }

        //Constructor
        public Function()
        {
            LeftFunc = RightFunc = null;
            notation = "";
            Order = order++;
        }

        //Method

        public abstract decimal Calculate(decimal X);
        public virtual string GetContentOfNode()
        {
            return $"   node" + this.Order + " [ label = " + "\"" + this.notation + "\"" + " ]";
        }
        public abstract Function GetDerivativeAnalytically();
        public abstract Function SimplifyFunction();

    }
}
