using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunzzyLibaray
{
    public  class GaussianFunction : FuzzyFunctions
    {
        //here we set the data
        // Series GaussiaSeries = new Series();
        static int currentindex = 1;
        public string[] parametername = new string[] { "mean", "variance", "resolution" };
        public double[] parameterinitial = new double[] { 0, 10, 100 };
        double mean = 0 + 10 * (currentindex - 1);
        double variance = 10;
        double resolution = 100;
        [Category("Parameters"), Description("the mean of the gaussian function")]
        public double Mean 
        { 
            get => mean;
            set
            {
                mean = value;
                GenerateSeries();
                ParameterChange();
            }
        }
        [Category("Parameters"), Description("the variance of the gaussian function")]
        public double Variance
        { 
            get => variance;
            set
            {
                if(value > 0)
                {
                    variance = value;
                    GenerateSeries();
                    ParameterChange();
                }
            }
        }
        [Category("Parameters"), Description("the resolution of the gaussian function")]
        public double Resolution 
        {
            get => resolution;
            set
            {
                if(value > 0)
                {
                    resolution = value;
                    GenerateSeries();
                    ParameterChange();
                }
            }
        }

        public GaussianFunction(Universe u) : base(u)
        {
            // here we input the data, but not the resolution
            //this.Mean = mean;
            //this.Variance = variance;
            //parameter = new double[3];
            //parameter[0] = 0;
            //parameter[1] = 10;
            //parameter[2] = 100;
            // here we set the series
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.BlueViolet;
            series.Name = $"Gaussian function{currentindex++}";
            this.Name = series.Name;
            GenerateSeries();
        }
        public double GetValue(double x)
        {
            return Math.Exp(-((x - Mean) * (x - Mean)) / (2 * (Variance * Variance)));
        }
        public void GenerateSeries()
        {
            series.Points.Clear();

            double frontpoint = mean;
            double backpoint = mean;
            do
            {
                frontpoint--;

            } while (GetValue(frontpoint) >= 0.01);
            do
            {
                backpoint++;
            } while (GetValue(backpoint) >= 0.01);
            for (int i = 0; i <= resolution; i++)
            {
                double a = frontpoint + i * ((backpoint - frontpoint) / resolution);
                series.Points.AddXY(a, GetValue(a));
            }
        }




    }
}
