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

namespace CPP
{
    public partial class Form1 : Form
    {
        BigFunction b;
        OxyPlot.WindowsForms.PlotView pv1;
        //FunctionSeries s1;
        //bool bounderChecked = false;
        double lowerbound=0,upperbound=0,result=0;

        public Form1()
        {
            InitializeComponent();
            b = new BigFunction();

            pv1 = new PlotView();

            pv1.Location = new Point(100,50);
            pv1.Size = new Size(200,200);
            this.Controls.Add(pv1);
            pv1.Model = new PlotModel {Title = "Calculus" };

            //s1 = new FunctionSeries();

            //s1.MouseDown += (S, e) =>
            //{
            //        if (!bounderChecked)
            //        {
            //            lowerbound = s1.InverseTransform(e.Position).X;
            //            bounderChecked = true;
            //        }
            //        else
            //        {
            //            upperbound = s1.InverseTransform(e.Position).X;
            //            bounderChecked = false;
            //        }
            //};
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(1400, 600);
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            try
            {
                string input = tbInput.Text.Trim(' ');
                b.RootFunc = b.Insert(ref input);
                if (rbMainFunction.Checked)
                    tbResult.Text = b.ParseToString(b.RootFunc.SimplifyFunction());
                else if (rbDerAnalytically.Checked)
                    tbResult.Text = b.ParseToString(b.RootFunc.GetDerivativeAnalytically().SimplifyFunction());
            }
            catch(UnAcceptedDegreeForPowerException u)
            {
                MessageBox.Show(u.Message);
            }
            catch(UnacceptedFunctionForFactorialException u)
            {
                MessageBox.Show(u.Message);
            }
            catch(Denominator0Exception d)
            {
                MessageBox.Show(d.Message);
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("Please input the correct format!");
            }
            catch(FormatException)
            {
                MessageBox.Show("Please input the correct format!");
            }
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }
        private void GraphRefresh()
        {
           
        }
        private void btnPlot_Click(object sender, EventArgs e)
        {
            try
            {
                string input = tbInput.Text.Trim(' ');
                b.RootFunc = b.Insert(ref input);
                if (rbMainFunction.Checked)
                    pv1.Model.Series.Add(b.GetFunctionSerieMainFunction());
                else if (rbDerAnalytically.Checked)
                    pv1.Model.Series.Add(b.GetFunctionSerieForDerivativeAnalytically());
                else if (rbDerivativeNewton.Checked)
                    pv1.Model.Series.Add(b.GetFunctionSerieForDerivativeNewton());
                else if (rbIntegral.Checked)
                {
                    pv1.Model.Series.Add(b.GetFunctionSerieIntegral(Convert.ToDouble(tbLowerBound.Text),Convert.ToDouble(tbUpperBound.Text),ref result));
                    MessageBox.Show(result.ToString());
                }
                else if(rbMcLaurinSerie.Checked)
                {
                    for(int i=1;i<9;i++)
                      pv1.Model.Series.Add(b.GetFunctionSeriesMcLaurinSeries(i));
                }
            }
            catch (UnAcceptedDegreeForPowerException u)
            {
                MessageBox.Show(u.Message);
            }
            catch (UnacceptedFunctionForFactorialException u)
            {
                MessageBox.Show(u.Message);
            }
            catch (Denominator0Exception d)
            {
                MessageBox.Show(d.Message);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please input the correct format!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please input the correct format!");
            }

        }

        private void btnTextFile_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text.Trim(' ');
            b.RootFunc = b.Insert(ref input);

            if (rbMainFunction.Checked)
                b.GenerateTextFile(b.RootFunc.SimplifyFunction());
            else if (rbDerAnalytically.Checked)
                b.GenerateTextFile(b.RootFunc.GetDerivativeAnalytically().SimplifyFunction());

            //string filename = "";
            //using (OpenFileDialog ofd = new OpenFileDialog())
            //{
            //    if(ofd.ShowDialog()==DialogResult.OK)
            //    {
            //        filename = ofd.FileName;
            //    }
            //}
          
            Process dot = new Process();
            dot.StartInfo.FileName = "dot.exe";
            dot.StartInfo.Arguments = "-Tpng -oabc.png "+ "C://Users/Admin/Desktop/CPP/functions.dot";
            dot.Start();
            dot.WaitForExit();
           if(rbMainFunction.Checked)
              TreeMainFun.ImageLocation = "abc.png";
           else if(rbDerAnalytically.Checked)
              TreeOtherOper.ImageLocation = "abc.png";
        }

        private void rbMcLaurinSerie_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClearPlot_Click(object sender, EventArgs e)
        {
            pv1.Model.Series.Clear();
            pv1.Model.InvalidatePlot(true);
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
