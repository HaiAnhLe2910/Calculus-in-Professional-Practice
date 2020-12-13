namespace CPP
{
    class Substract:Function
    {
        //Constructor
        public Substract()
        {
            notation = " - ";
        }

        //Method
        public override string ToString()
        {
            return $"({LeftFunc}{notation}{RightFunc})";
        }
        public override double Calculate(double X)
        {
            if (LeftFunc != null)
                return LeftFunc.Calculate(X) - RightFunc.Calculate(X);
            else
                return -RightFunc.Calculate(X);
        }
        public override Function GetDerivativeAnalytically()
        {
            Substract derivative = new Substract();
            if (this.LeftFunc != null)
            {
                derivative.LeftFunc = this.LeftFunc.GetDerivativeAnalytically();
            }
            derivative.RightFunc = this.RightFunc.GetDerivativeAnalytically();
            return derivative;
        }
        public override Function SimplifyFunction()
        {
            this.RightFunc = this.RightFunc.SimplifyFunction();
            if (this.LeftFunc!=null)
            {
                this.LeftFunc = this.LeftFunc.SimplifyFunction();
                if (this.RightFunc.IsNr() && this.RightFunc.Calculate(0) == 0)
                {
                    return this.LeftFunc;
                }
                else if(this.LeftFunc.IsNr() && this.LeftFunc.Calculate(0) == 0)
                {
                    this.LeftFunc = null;
                    return this;
                }
                else if (this.LeftFunc.IsNr() && this.RightFunc.IsNr())
                {
                        r func = new r();
                        (func as r).Data = this.Calculate(0);
                        return func;
                }
                    return this;
            }
            else
            {
                Substract func = new Substract();
                func.RightFunc = this.RightFunc.SimplifyFunction();
                return func;
            }
        }

        public override bool IsNr()
        {
            return false;
        }
    }

}
