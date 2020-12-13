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
    public class Matrix
    {
        //properties
        public List<double[]> PointList
        { get; set; }

        // Constructor
        public Matrix()
        {
            PointList = new List<double[]>();
        }
        //Method
        public void AddPoint(double x, double y)
        {
            PointList.Add(new double[] { x, y });

        }
        private double[,] FilltheMatrix()
        {
            double[,] matrix = new double[PointList.Count, PointList.Count+1];
            for (int row = 0; row < PointList.Count; row++)
            {
                for (int col = 0; col < PointList.Count; col++)
                {
                    matrix[row, col] = Math.Pow(PointList[row][0], col);
                }
                matrix[row, PointList.Count] = PointList[row][1];
            }

            return matrix;
        }
        public double[] GetArrayOfCoefficient()
        {
            double a;
            double[,] matrix = FilltheMatrix();

            //find the elements of diagonal matrix
            for (int col = 0; col < PointList.Count; col++)
            {
                for (int row = 0; row < PointList.Count; row++)
                {
                    if (row != col)
                    {
                        a = matrix[row, col] / matrix[col, col];
                        for (int k = 0; k <= PointList.Count; k++)
                        {
                            matrix[row, k] = matrix[row, k] - a * matrix[col, k];
                        }
                    }
                }
            }

            double[] coefficent = new double[PointList.Count];

            //find the value of variable
            for (int row = 0; row < PointList.Count; row++)
            {
                coefficent[row] = matrix[row,PointList.Count] / matrix[row,row];
            }

            return coefficent;
        }

     
        //return the functionserie for the n-polinomial
        public FunctionSeries GetFunctionSerieForMatrix()
        {
            FunctionSeries serie = new FunctionSeries();
            serie.Title = (PointList.Count - 1) + "-polinomial";
            double[] coefficient = GetArrayOfCoefficient();
            double result = 0;

            try
            {
                for (double x = -50; x <= 50; x +=0.01)
                {
                    for (int i = 0; i <GetArrayOfCoefficient().Length; i++)
                    {
                        result += coefficient[i] * Math.Pow(x, i);
                    }
                    DataPoint data = new DataPoint(x,(double)result);
                    serie.Points.Add(data);
                    result = 0;
                }
                
            }
            catch (DivideByZeroException)
            {
                serie.Points.Add(DataPoint.Undefined);
            }
            return serie;
        }



    }
}
