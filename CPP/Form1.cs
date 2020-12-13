using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.IO;
using System.Diagnostics;
using OxyPlot.Axes;

namespace CPP
{
    public partial class btnAddPoint : Form
    {
        OxyPlot.WindowsForms.PlotView pv1;
        BigFunction b;
        Matrix m;

        //x,y value when people click on the plotview
        double x,y;

        public btnAddPoint()
        {
            InitializeComponent();
            b = new BigFunction();
            m = new Matrix();
            
            pv1 = new PlotView();
            DrawGraph();

     
           for (int i=1;i<=8;i++)
           {
                cbNrOfTerms.Items.Add(i);
           }

            

        }
        private void DrawGraph()
        {
            var yaxis = new LinearAxis()
            {
                Position = OxyPlot.Axes.AxisPosition.Left,
                Minimum = -50,
                Maximum = 50,
                PositionAtZeroCrossing = true,
                ExtraGridlines = new double[] { 0 },
                ExtraGridlineThickness = 1,
                ExtraGridlineColor = OxyColors.Black,
            };
            var xaxis = new LinearAxis()
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                Minimum = -50,
                Maximum = 50,
                //TickStyle = TickStyle.Crossing,
                PositionAtZeroCrossing = true,
                ExtraGridlines = new double[] { 0 },
                ExtraGridlineThickness = 1,
                ExtraGridlineColor = OxyColors.Black,
            };
            pv1.Location = new Point(500, 50);
            pv1.Size = new Size(500, 500);
            this.Controls.Add(pv1);
            pv1.Model = new PlotModel { Title = "Calculus" };
            pv1.Model.PlotType = PlotType.XY;
            pv1.Model.Axes.Add(xaxis);
            pv1.Model.Axes.Add(yaxis);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 700);

        }

        private void btnParse_Click(object sender, EventArgs e)
        { 
            try
            {
                pv1.Model.InvalidatePlot(true);

                string input = tbInput.Text.Trim(' ');
                b.RootFunc = b.Insert(ref input);
                tbResult.Text = b.ParseToString(b.RootFunc);
                pv1.Model.Series.Add(b.GetFunctionSerieMainFunction());

            }
            catch (UnAcceptedDegreeForPowerException u)
            {
                MessageBox.Show(u.Message);
            }
            catch(UnacceptedFunctionForFactorialException u)
            {
                MessageBox.Show(u.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the correct format!");
            }
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }
        

        private void btnTextFile_Click(object sender, EventArgs e)
        {
           
            string input = tbInput.Text.Trim(' ');
            b.RootFunc = b.Insert(ref input);
            b.GenerateTextFile(b.RootFunc);
          
            Process dot = new Process();
            dot.StartInfo.FileName = "dot.exe";
            dot.StartInfo.Arguments = "-Tpng -oabc.png "+ "functions.dot";
            dot.Start();
            dot.WaitForExit();
            Process photoViewer = new Process();
            photoViewer.StartInfo.FileName = @"abc.png";
            photoViewer.Start();
        }

        private void rbMcLaurinSerie_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RefreshGraph()
        {
            pv1.Model.Series.Clear();
            pv1.Model.InvalidatePlot(true);

        }
        private void btnClearPlot_Click(object sender, EventArgs e)
        {
            RefreshGraph();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbNrOfTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnderAnalytic_Click(object sender, EventArgs e)
        {
            try
            {
                pv1.Model.InvalidatePlot(true);
                string input = tbInput.Text.Trim(' ');
                b.RootFunc = b.Insert(ref input);
                b.GenerateTextFile(b.RootFunc.GetDerivativeAnalytically());
                tbResult.Text = b.ParseToString(b.RootFunc.GetDerivativeAnalytically());
                pv1.Model.Series.Add(b.GetFunctionSerieForDerivativeAnalytically());

                Process dot = new Process();
                dot.StartInfo.FileName = "dot.exe";
                dot.StartInfo.Arguments = "-Tpng -oabc.png " + "functions.dot";
                dot.Start();
                dot.WaitForExit();
                Process photoViewer = new Process();
                photoViewer.StartInfo.FileName = @"abc.png";
                photoViewer.Start();
                //TreeOtherOper.ImageLocation = "abc.png";

            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the correct format!");
            }
            catch (UnAcceptedDegreeForPowerException u)
            {
                MessageBox.Show(u.Message);
            }
            catch (UnacceptedFunctionForFactorialException u)
            {
                MessageBox.Show(u.Message);
            }

        }

        private void btnNewton_Click(object sender, EventArgs e)
        {
            try
            {
                pv1.Model.InvalidatePlot(true);
                pv1.Model.Series.Add(b.GetFunctionSerieForDerivativeNewton());
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the correct format!");
            }
            catch (UnAcceptedDegreeForPowerException u)
            {
                MessageBox.Show(u.Message);
            }
            catch (UnacceptedFunctionForFactorialException u)
            {
                MessageBox.Show(u.Message);
            }
        }

        private void btnIntegral_Click(object sender, EventArgs e)
        {
            try
            {
                pv1.Model.InvalidatePlot(true);
                double result = 0,lowBound= Convert.ToDouble(tbLowerBound.Text),upperBound= Convert.ToDouble(tbUpperBound.Text);
                pv1.Model.Series.Add(b.GetFunctionSerieIntegral(lowBound, upperBound, ref result));
                tbInteValue.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the correct format!");
            }
            catch (UnAcceptedDegreeForPowerException u)
            {
                MessageBox.Show(u.Message);
            }
            catch (UnacceptedFunctionForFactorialException u)
            {
                MessageBox.Show(u.Message);
            }

        }

        private void btnMcLaurinPlot_Click(object sender, EventArgs e)
        {
            try
            {
                pv1.Model.InvalidatePlot(true);
                string input = tbInput.Text.Trim(' ');
                b.RootFunc = b.Insert(ref input);
                int value = Convert.ToInt32(cbNrOfTerms.SelectedItem.ToString());

                    List<double> vector = b.GetCoefficientMcLaurin(value);
                    string mcLaurin = $"McLaurin serie {value}: {vector[0]}";
                    for (int i = 1; i <vector.Count; i++)
                    {
                        mcLaurin += $" + {vector[i]}*x^{i}/{b.GetFactorial(i)}";
                    }
                    lbMcLaurinSerie.Text = mcLaurin;
                    pv1.Model.Series.Add(b.GetFunctionSeriesMcLaurinSeriesAnalytically(value));

               
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the correct format!");
            }
            catch (UnAcceptedDegreeForPowerException u)
            {
                MessageBox.Show(u.Message);
            }
            catch (UnacceptedFunctionForFactorialException u)
            {
                MessageBox.Show(u.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbNrOfPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnPlotNpoli_Click(object sender, EventArgs e)
        {
            pv1.Model.InvalidatePlot(true);
            pv1.Model.Series.Add(m.GetFunctionSerieForMatrix());

            double [] vector = m.GetArrayOfCoefficient();
            string Npoli = $" {vector.Length-1} - polinomial : {vector[0]}";
            for (int i = 1; i < vector.Length; i++)
            {
                Npoli += $" + {vector[i]}*x^{i}";
            }
            lbNpolinomial.Text = Npoli;

        }

        private void rbMcLaurinAna_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            m.PointList.Clear();
            pv1.Model.MouseDown -= new EventHandler<OxyMouseDownEventArgs>(Plot_OxyMouseDown);
            lbPointNr.Text = m.PointList.Count.ToString();
            tbXCoor.Text = "";
            tbYCoor.Text = "";
            lbNpolinomial.Text = "0";
            btnSetpoint.Enabled = true;
        }

        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void lbNpolinomial_Click(object sender, EventArgs e)
        {

        }

        private void btnSetpoint_Click(object sender, EventArgs ex)
        {
            pv1.Model.MouseDown += new EventHandler<OxyMouseDownEventArgs>(Plot_OxyMouseDown);
            btnSetpoint.Enabled = false;

        }

        private void btnpointAdd_Click(object sender, EventArgs e)
        {
            try
            {
                m.AddPoint(Convert.ToDouble(tbXCoor.Text), Convert.ToDouble(tbYCoor.Text));
                lbPointNr.Text = m.PointList.Count.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the correct format!");
            }

        }

        private void btnSimplify_Click(object sender, EventArgs e)
        {
            try
            {
                pv1.Model.InvalidatePlot(true);
                string input = tbInput.Text.Trim(' ');
                b.RootFunc = b.Insert(ref input);
                b.GenerateTextFile(b.RootFunc.GetDerivativeAnalytically().SimplifyFunction());
                tbResult.Text = b.ParseToString(b.RootFunc.GetDerivativeAnalytically().SimplifyFunction());
                pv1.Model.Series.Add(b.GetFunctionSerieForDerivativeAnalyticallySimplify());


                Process dot = new Process();
                dot.StartInfo.FileName = "dot.exe";
                dot.StartInfo.Arguments = "-Tpng -oabc.png " + "C://Users/Admin/Desktop/CPP/functions.dot";
                dot.Start();
                dot.WaitForExit();
                Process photoViewer = new Process();
                photoViewer.StartInfo.FileName = @"abc.png";
                photoViewer.Start();
                //TreeOtherOper.ImageLocation = "abc.png";

            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the correct format!");
            }
            catch (UnAcceptedDegreeForPowerException u)
            {
                MessageBox.Show(u.Message);
            }
            catch (UnacceptedFunctionForFactorialException u)
            {
                MessageBox.Show(u.Message);
            }

        }

        private void gbMcLaurin_Enter(object sender, EventArgs e)
        {

        }

        private void rbNewTonMcLaurin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbMainOper_Enter(object sender, EventArgs e)
        {

        }

        private void Plot_OxyMouseDown (object s, OxyMouseDownEventArgs e)
        {
            OxyPlot.ElementCollection<OxyPlot.Axes.Axis> axisList = pv1.Model.Axes;
            Axis xaxis = null;
            Axis yaxis = null;

            foreach (OxyPlot.Axes.Axis ax in axisList)
            {
                if (ax.Position == AxisPosition.Bottom)
                    xaxis = ax;
                else if (ax.Position == AxisPosition.Left)
                    yaxis = ax;
            }
                x = Axis.InverseTransform(e.Position, xaxis, yaxis).X;
                y = Axis.InverseTransform(e.Position, xaxis, yaxis).Y;
 
                tbXCoor.Text = x.ToString();
                tbYCoor.Text = y.ToString();

                m.AddPoint(x, y);
                lbPointNr.Text = m.PointList.Count.ToString();

                var s1 = new LineSeries()
                {
                    Color = OxyColors.SkyBlue,
                    MarkerType = MarkerType.Circle,
                    MarkerSize = 6,
                    MarkerStroke = OxyColors.White,
                    MarkerFill = OxyColors.SkyBlue,
                    MarkerStrokeThickness = 1.5,
                    LineStyle = LineStyle.None,
                };

                s1.Points.Add(new DataPoint(x, y));
                pv1.Model.Series.Add(s1);
                pv1.Model.InvalidatePlot(true);

             


            }

       }
}
