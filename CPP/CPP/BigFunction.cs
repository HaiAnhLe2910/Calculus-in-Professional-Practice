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
    class BigFunction
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
                        (root as r).Data = Convert.ToDecimal(parts[0].ToString());
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
            decimal result;
            for (double x = -10; x < 10; x += 0.1)
            {
                result = RootFunc.Calculate((decimal)x);
                DataPoint data = new DataPoint(x, (double)result);
                serie.Points.Add(data);
            }
            return serie;
        }

        //return a functionserie for derivative analytically
        public FunctionSeries GetFunctionSerieForDerivativeAnalytically()
        {
            FunctionSeries serie = new FunctionSeries();
            decimal result;
            for (double x = -10; x < 10; x+=0.01)
            {
                result = RootFunc.GetDerivativeAnalytically().Calculate((decimal)x);
                DataPoint data = new DataPoint(x,(double)result);
                serie.Points.Add(data);
            }
            return serie;
        }

        //return a functionserie for derivative Newton
        public FunctionSeries GetFunctionSerieForDerivativeNewton()
        {
            FunctionSeries serie = new FunctionSeries();
            decimal result;
            decimal h = 0.1M;
            for (double x = -50; x < 50; x+=0.01)
            {
                result = (RootFunc.Calculate((decimal)x + h) - RootFunc.Calculate((decimal)x)) / h;
                DataPoint data = new DataPoint(x, (double)result);
                serie.Points.Add(data);
            }
            return serie;
        }

        //return a functionserie for integral
        public AreaSeries GetFunctionSerieIntegral(double lowerbound,double upperbound,ref double Result )
        {
            AreaSeries serie = new AreaSeries();
            decimal result=0;
            double n=20000, x1=0, x2 = 0;
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
                result += RootFunc.Calculate((decimal)x)*(decimal)delta;
                DataPoint data = new DataPoint(x, (double)RootFunc.Calculate((decimal)x));
                serie.Points.Add(data);
            }
            Result = (double)result;
            return serie;
        }


       
        public decimal getNthderivative(int numberofTerms,Function f)
        {
            if (numberofTerms == 1)
                return f.GetDerivativeAnalytically().Calculate(0);  
            else
                return getNthderivative(numberofTerms - 1, f.GetDerivativeAnalytically());
        }
        public Function getFunctionMcLaurinSeries(int terms)//return the binary tree of McLaurin serie
        {
            Plus func = new Plus();
            if(terms==1)
            {
                func.LeftFunc = new r();
                (func.LeftFunc as r).Data = RootFunc.Calculate(0);
                func.RightFunc = new Multiply();
                func.RightFunc.LeftFunc = new r();
                (func.RightFunc.LeftFunc as r).Data = getNthderivative(terms, RootFunc);
                func.RightFunc.RightFunc = new x();
            }
            else
            {
                func.RightFunc = new Multiply();
                func.RightFunc.LeftFunc = new r();
                Factorial f = new Factorial();
                (func.RightFunc.LeftFunc as r).Data = getNthderivative(terms, RootFunc)/f.getFactorial(terms);
                func.RightFunc.RightFunc = new Power();
                func.RightFunc.RightFunc.LeftFunc = new x();
                func.RightFunc.RightFunc.RightFunc = new Digit();
                (func.RightFunc.RightFunc.RightFunc as Digit).Data = terms;

                func.LeftFunc = getFunctionMcLaurinSeries(terms - 1);
            }
            return func;
        }
        public FunctionSeries GetFunctionSeriesMcLaurinSeries(int Terms)
        {
            FunctionSeries serie = new FunctionSeries();
            decimal result;
            for (double x = -50; x < 50; x += 0.01)
            {
                result =getFunctionMcLaurinSeries(Terms).Calculate((decimal)x);
                DataPoint data = new DataPoint(x, (double)result);
                serie.Points.Add(data);
            }
            return serie;
        }


        //preorder traversal and write the node to text file

        private void WriteNodeToTextFile(Function root,StreamWriter Sw)
        {
            Sw.WriteLine(root.GetContentOfNode());
            if (root.LeftFunc != null)
            {
                Sw.WriteLine("   node" + root.Order + " -- node" + root.LeftFunc.Order);
                WriteNodeToTextFile(root.LeftFunc, Sw);
            }
            if (root.RightFunc != null)
            {
                Sw.WriteLine("   node" + root.Order + " -- node" + root.RightFunc.Order);
                WriteNodeToTextFile(root.RightFunc, Sw);
            }
        }

        //Write the text file for the specific function
        public void GenerateTextFile(Function f)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            fs = new FileStream("C://Users/Admin/Desktop/CPP/functions.dot", FileMode.Create, FileAccess.Write);
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
