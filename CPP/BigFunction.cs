using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace CPP
{
    public class BigFunction
    {
        //properties
        public Function RootFunc
        { get; set; }

        //Constructor
        public BigFunction()
        {
            RootFunc = null;
            
        }

        //Method

        //Insert function to the binary tree
        public Function Insert(ref string s)
        {
            Function root = null;
            switch (s[0])
            {
                case '+':
                    {
                        root = new Plus();
                        s = s.Substring(2);
                        while (s[0] != ',')
                        {
                            root.LeftFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        s = s.Substring(1);
                        while(s[0]!=')')
                        {
                            root.RightFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        break;
                    }
                case '-':
                    {
                        root = new Substract();
                        if (s[1] != '(')
                            break;
                        s = s.Substring(2);
                        while (s[0] != ',')
                        {
                            root.LeftFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        s = s.Substring(1);
                        while (s[0] != ')')
                        {
                            root.RightFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        break;
                    }
                case '*':
                    {
                        root = new Multiply();
                        s = s.Substring(2);
                        while (s[0] != ',')
                        {
                            root.LeftFunc = Insert(ref s);
                            s = s.Substring(1);

                        }
                        s = s.Substring(1);
                        while (s[0] != ')')
                        {
                            root.RightFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        break;
                    }
                case '/':
                    {
                        root = new Divide();
                        s = s.Substring(2);
                        while (s[0] != ',')
                        {
                            root.LeftFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        s = s.Substring(1);
                        while (s[0] != ')')
                        {
                            root.RightFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        break;
                    }
                case '^':
                    {
                        root = new Power();
                        s = s.Substring(2);
                        while (s[0] != ',')
                        {
                            root.LeftFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        s = s.Substring(1);
                        while (s[0] != ')')
                        {
                            root.RightFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        break;
                    }
                case 'n':
                    {
                        root = new n();
                        s = s.Substring(2);
                        string[] parts = s.Split(')');
                        (root as n).Data = Convert.ToInt32(parts[0].ToString());
                        while(s[0]!=')')
                        {
                            s = s.Substring(1);
                        }
                        break;
                    }
                case 'r':
                    {
                        root = new r();
                        s = s.Substring(2);
                        string[] parts = s.Split(')');
                        (root as r).Data = Convert.ToDouble(parts[0].ToString());
                        while (s[0] != ')')
                        {
                            s = s.Substring(1);
                        }
                        break;
                    }
                case 's':
                    {
                        root = new S();
                        s = s.Substring(2);
                        while (s[0] != ')')
                        {
                            root.LeftFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        break;
                    }
                case 'c':
                    {
                        root = new c();
                        s = s.Substring(2);
                        while (s[0] != ')')
                        {
                            root.LeftFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        break;
                    }
                case 'e':
                    {
                        root = new e();
                        s = s.Substring(2);
                        while (s[0] != ')')
                        {
                            root.LeftFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        break;
                    }
                case 'l':
                    {
                        root = new l();
                        s = s.Substring(2);
                        while (s[0] != ')')
                        { 
                            root.LeftFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        break;
                    }
                case '!':
                    {
                        root = new Factorial();
                        s = s.Substring(2);
                        while (s[0] != ')')
                        {
                            root.LeftFunc = Insert(ref s);
                            s = s.Substring(1);
                        }
                        break;
                    }
                case 'p':
                    {
                        root = new pi();
                        break;
                    }
                case 'x':
                    {
                        root = new x();
                        break;
                    }
                default:
                    {
                        root = new Digit();
                        (root as Digit).Data =Convert.ToInt32(s[0].ToString());
                        break;
                    }
            }
            return root;
        }

        //Show the function in infix notation
        public string ParseToString(Function f)
        {
                return f.ToString();
        }

      
     
        //return a serie of points for main function
        public FunctionSeries GetFunctionSerieMainFunction()
        {
            FunctionSeries serie = new FunctionSeries();
            serie.Title = "Main Funtion";
            double result=0;
            for (double x = -50; x<50; x +=0.01)
            {
                try
                {
                    result = RootFunc.Calculate(x);
                    if (Math.Abs(result) > 100)
                        serie.Points.Add(DataPoint.Undefined);
                    else
                    {
                        DataPoint data = new DataPoint(x,result);
                        serie.Points.Add(data);
                    }
                }
                catch (DivideByZeroException)
                {
                    serie.Points.Add(DataPoint.Undefined);
                }

            }
            return serie;
        }

        //return a functionserie for derivative analytically
        public FunctionSeries GetFunctionSerieForDerivativeAnalytically()
        {
            FunctionSeries serie = new FunctionSeries();
            serie.Title = "Derivative analytically";
            double result;
            for (double x = -50; x <50; x+=0.001)
            {
                try
                {
                    result = RootFunc.GetDerivativeAnalytically().Calculate(x);
                    if (Math.Abs(result) > 100)
                        serie.Points.Add(DataPoint.Undefined);
                    else
                    {
                        DataPoint data = new DataPoint(x, (double)result);
                        serie.Points.Add(data);
                    }
                }
                catch (DivideByZeroException)
                {
                    serie.Points.Add(DataPoint.Undefined);
                }
            }
            return serie;
        }
        public FunctionSeries GetFunctionSerieForDerivativeAnalyticallySimplify()
        {
            FunctionSeries serie = new FunctionSeries();
            serie.Title = "Derivative simplified";
            double result;
            for (double x = -50; x < 50; x += 0.001)
            {
                try
                {
                    result = RootFunc.GetDerivativeAnalytically().SimplifyFunction().Calculate(x);
                    if (Math.Abs(result) > 100)
                        serie.Points.Add(DataPoint.Undefined);
                    else
                    {
                        DataPoint data = new DataPoint(x, (double)result);
                        serie.Points.Add(data);
                    }
                }
                catch (DivideByZeroException)
                {
                    serie.Points.Add(DataPoint.Undefined);
                }
            }
            return serie;
        }

        //return a functionserie for derivative Newton
        public FunctionSeries GetFunctionSerieForDerivativeNewton()
        {
            FunctionSeries serie = new FunctionSeries();
            serie.Title = "Derivative Newton";
            double result;
            double h = 0.1;
            for (double x = -50; x < 50; x+=0.001)
            {
                try
                {
                    result = (RootFunc.Calculate(x + h) - RootFunc.Calculate(x)) / h;
                    if (Math.Abs(result) > 100)
                        serie.Points.Add(DataPoint.Undefined);
                    else
                    {
                        DataPoint data = new DataPoint(x,result);
                        serie.Points.Add(data);
                    }
                }
                catch (DivideByZeroException)
                {
                    serie.Points.Add(DataPoint.Undefined);
                }
            }
            return serie;
        }

        //return a functionserie for integral
        public AreaSeries GetFunctionSerieIntegral(double lowerbound,double upperbound,ref double Result )
        {
            AreaSeries serie = new AreaSeries() {
                Title="Integral",
                StrokeThickness = 2,
                LineStyle = OxyPlot.LineStyle.Solid,
                Color = OxyColors.Blue,
                Color2 = OxyColors.Transparent,
                Fill = OxyColor.FromRgb(214, 231, 242),
                DataFieldX2 = "X",
                ConstantY2 = 0
            };
            double result=0, value = 0;
            double n=2000, x1=0, x2 = 0;
            double delta;
            if (lowerbound <= upperbound)
            {
                x1 = lowerbound;
                x2 = upperbound;
     
            }
            else
            {
                x1 = upperbound;
                x2 = lowerbound;
            }
            delta = (x2 - x1) / n;
           
            for (double x = x1; x<=x2; x += delta)
            {
                try
                {
                    value = RootFunc.Calculate(x);
                    result += value * delta;
                    DataPoint data = new DataPoint(x, value);
                    serie.Points.Add(data);
                }
                catch (DivideByZeroException)
                {
                    serie.Points.Add(DataPoint.Undefined);
                }
            }
            Result = result;
            return serie;
        }

        public double GetFactorial(double x)
        {
            if (x == 1)
                return 1;
            else
                return GetFactorial(x - 1) * x;
        }
        public List<double> GetCoefficientMcLaurin(int terms)//return the binary tree of McLaurin serie
        {
            Function derivative = RootFunc.SimplifyFunction();
            List<double> vector = new List<double>();
            vector.Add(derivative.Calculate(0));
            for (int i = 1; i <= terms; i++)
            {
                derivative = derivative.GetDerivativeAnalytically().SimplifyFunction();
                vector.Add(derivative.Calculate(0));
            }
            return vector;
        }
        public FunctionSeries GetFunctionSeriesMcLaurinSeriesAnalytically(int terms)
        {
            FunctionSeries serie = new FunctionSeries();
            serie.Title = "McLaurin serie "+terms;
            double result = 0; 
            List<double> vector = GetCoefficientMcLaurin(terms);
             for (double x = -50; x <= 50; x += 0.001)
             {
                try
                { 
                    result+= RootFunc.Calculate(0);
                    for (int i = 1; i < vector.Count; i++)
                    {
                         result += vector[i] * Math.Pow(x, i)/GetFactorial(i);
                    }
                    if (Math.Abs(result) > 1000)
                    {
                        serie.Points.Add(DataPoint.Undefined);
                    }
                    else
                    {
                        DataPoint data = new DataPoint(x, result);
                        serie.Points.Add(data);
                    }
                    result = 0;
                }
                catch (DivideByZeroException)
                {
                    serie.Points.Add(DataPoint.Undefined);
                }
            }
               
            return serie;
        }

      

        //preorder traversal and write the node to text file

        private void WriteNodeToTextFile(Function root,StreamWriter Sw)
        {
            if (root.Order == 0)
                root.Order = 1;
            Sw.WriteLine($"  node{root.Order} [ label = \"{root.notation}\" ]");
            if (root.LeftFunc != null)
            {
                root.LeftFunc.Order = root.Order * 2;
                Sw.WriteLine("   node" + root.Order + " -- node" + root.LeftFunc.Order);
                WriteNodeToTextFile(root.LeftFunc, Sw);
            }
            if (root.RightFunc != null)
            {
                root.RightFunc.Order = root.Order * 2+1;
                Sw.WriteLine("   node" + root.Order + " -- node" + root.RightFunc.Order);
                WriteNodeToTextFile(root.RightFunc, Sw);
            }
        }

        //Write the text file for the specific function
        public void GenerateTextFile(Function f)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            fs = new FileStream("functions.dot", FileMode.Create, FileAccess.Write);
            sw = new StreamWriter(fs);
            try
            {
                sw.WriteLine("graph calculus {");
                sw.WriteLine("   node [ fontname = \"Arial\" ]");
                WriteNodeToTextFile(f, sw);
                sw.WriteLine("}"); 
            }
            catch (IOException i)
            {
                MessageBox.Show(i.Message);
            }
            finally
            {
                if(sw!=null)
                sw.Close();
            }
        }

      

    }
}
