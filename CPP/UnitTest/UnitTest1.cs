using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPP;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Parse_to_string()
        {
            var form = new btnAddPoint();
            BigFunction func = new BigFunction();
            string input = "*(/(s(x),+(c(x),l(-(*(p,x),4)))),e(!(2)))";
            func.RootFunc = func.Insert(ref input);
            OxyPlot.WindowsForms.PlotView pv1 = new PlotView();
            pv1.Model = new PlotModel { };
            FunctionSeries serie = new FunctionSeries();
            serie = func.GetFunctionSerieMainFunction();

            pv1.Model.Series.Add(serie);
            func.GenerateTextFile(func.RootFunc);
            Assert.AreEqual(func.ParseToString(func.RootFunc), "(( sin ( x ) / ( Cos ( x ) +  ln ((( p  *  x ) - 4)))) *  e (2 ! ))");
        }

        [TestMethod]
        public void Get_derivative()
        {
            BigFunction func = new BigFunction();
            string input = "-(*(/(c(*(r(-5.7),x)),s(l(+(n(27),*(3,^(p,8)))))),!(4)),e(-2))";
            func.RootFunc = func.Insert(ref input);
            OxyPlot.WindowsForms.PlotView pv1 = new PlotView();
            pv1.Model = new PlotModel { };

            FunctionSeries serie1 = new FunctionSeries();
            serie1 = func.GetFunctionSerieForDerivativeAnalytically();

            FunctionSeries serie2 = new FunctionSeries();
            serie2 = func.GetFunctionSerieForDerivativeNewton();

            pv1.Model.Series.Add(serie1);
            pv1.Model.Series.Add(serie2);
            Assert.AreEqual(func.ParseToString(func.RootFunc.GetDerivativeAnalytically()), "((((((((-1 * ((0 *  x ) + (-5.7 * 1))) *  sin ((-5.7 *  x ))) *  sin ( ln ((27 + (3 * ( p  ^ 8)))))) - ( Cos ((-5.7 *  x )) * (((0 + ((0 * ( p  ^ 8)) + (3 * ((8 * ( p  ^ 7)) * 0)))) / (27 + (3 * ( p  ^ 8)))) *  Cos ( ln ((27 + (3 * ( p  ^ 8)))))))) / ( sin ( ln ((27 + (3 * ( p  ^ 8))))) ^ 2)) * 4 ! ) + (( Cos ((-5.7 *  x )) /  sin ( ln ((27 + (3 * ( p  ^ 8)))))) * 0)) - (0 *  e (2)))");
        }



        [TestMethod]
        public void Get_derivative_simplified1()
        {
            BigFunction func = new BigFunction();
            string input = "-(*(/(c(*(r(-5.7),x)),s(l(+(n(27),*(3,^(p,8)))))),!(4)),e(-2))";
            func.RootFunc = func.Insert(ref input);
            OxyPlot.WindowsForms.PlotView pv1 = new PlotView();
            pv1.Model = new PlotModel { };

            FunctionSeries serie = new FunctionSeries();
            serie = func.GetFunctionSerieForDerivativeAnalyticallySimplify();

            pv1.Model.Series.Add(serie);
            Assert.AreEqual(func.ParseToString(func.RootFunc.GetDerivativeAnalytically().SimplifyFunction()), "((((5.7 *  sin ((-5.7 *  x ))) *  sin ( ln ((27 + (3 * ( p  ^ 8)))))) / ( sin ( ln ((27 + (3 * ( p  ^ 8))))) ^ 2)) * 4 ! )");
        }

        [TestMethod]
        public void Get_derivative_simplified2()
        {
            BigFunction func = new BigFunction();
            string input = "/(+(*(7,x),+(-(6,-(*(8,x),*(4,x))),*(n(12),x))),*(2,x))";
            func.RootFunc = func.Insert(ref input);
            OxyPlot.WindowsForms.PlotView pv1 = new PlotView();
            pv1.Model = new PlotModel { };

            FunctionSeries serie = new FunctionSeries();
            serie = func.GetFunctionSerieForDerivativeAnalyticallySimplify();

            pv1.Model.Series.Add(serie);
            Assert.AreEqual(func.ParseToString(func.RootFunc.GetDerivativeAnalytically().SimplifyFunction()), "((((7 + (( - 4) + 12)) * (2 *  x )) - (((7 *  x ) + ((6 - ((8 *  x ) - (4 *  x ))) + (12 *  x ))) * 2)) / ((2 *  x ) ^ 2))");
        }

        [TestMethod]
        public void Calculate_integral()
        {
            BigFunction func = new BigFunction();
            string input = "*(/(c(*(r(-5.7),x)),s(l(+(n(27),*(3,^(x,8)))))),!(4))";

            func.RootFunc = func.Insert(ref input);

            OxyPlot.WindowsForms.PlotView pv1=new PlotView();
            pv1.Model = new PlotModel {};
            double result = 0;

            AreaSeries serie = new AreaSeries();
            serie = func.GetFunctionSerieIntegral(-10, 10, ref result);

            pv1.Model.Series.Add(serie);
            Assert.AreEqual<double>(Math.Round(result),-5860);
        }

        [TestMethod]
        public void Check_McLaurinSerie()
        {
            OxyPlot.WindowsForms.PlotView pv1 = new PlotView();
            pv1.Model = new PlotModel { };

            BigFunction func = new BigFunction();
            string input = "+(/(s(x),c(x)),l(5))";
            func.RootFunc = func.Insert(ref input);
            List<double> vectors = func.GetCoefficientMcLaurin(8);
            List<double> coeffi = new List<double> { Math.Log(5), 1, 0, 2, 0, 16, 0, 272, 0 };

            FunctionSeries serie = new FunctionSeries();
            serie = func.GetFunctionSeriesMcLaurinSeriesAnalytically(8);

            pv1.Model.Series.Add(serie);
            Assert.IsTrue(vectors.SequenceEqual(coeffi));
        }

        [TestMethod]
        public void Test_Matrix()
        {
            OxyPlot.WindowsForms.PlotView pv1 = new PlotView();
            pv1.Model = new PlotModel { };
            BigFunction func = new BigFunction();

            Matrix m = new Matrix();
            m.AddPoint(2, 1);
            m.AddPoint(3, 2);
            m.AddPoint(4, 3);
            double[] coeffi=m.GetArrayOfCoefficient();
            double[] vector = new double[] { -1, 1, 0 };
            FunctionSeries serie = new FunctionSeries();
            serie = m.GetFunctionSerieForMatrix();
            pv1.Model.Series.Add(serie);
            Assert.IsTrue(coeffi.SequenceEqual(vector));
        }




    }
}
