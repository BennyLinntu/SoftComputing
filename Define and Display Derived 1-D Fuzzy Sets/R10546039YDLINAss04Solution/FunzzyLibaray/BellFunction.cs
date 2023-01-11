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
    public class BellFunction : FuzzyFunctions
    {
        // here we set the data
        //Series BellSeries = new Series();
        static int currentindex = 1;
        //public string[] parametername = new string[] { "varaiance", "flatness", "center", "resolution" };
        public double[] parameterinitial = new double[] { 2, 1, 0, 100 };
        double variance = 2;
        double flatness = 1;
        double center = 0 + 10 * (currentindex - 1);// same as others function
        double resolution = 100;

        // properties
        [Category("Parameters"), Description("the variance of the Bell function")]
        public double Variance
        { 
            get => variance; 
            set
            {
                if(value > 0)
                {
                    variance = value;
                }
                GenerateSeries();
                ParameterChange();
            }
        }
        [Category("Parameters"), Description("the flatness of the Bell function")]
        public double Flatness 
        { 
            get => flatness;
            set
            {
                if(value > 0)
                {
                    flatness = value;
                }
                GenerateSeries();
                ParameterChange();
            }
        }
        [Category("Parameters"), Description("the center of the Bell function")]
        public double Center 
        { 
            get => center;
            set
            {
                center = value;
                GenerateSeries();
                ParameterChange();
            }
        }
        [Category("Parameters"), Description("the resolution of the Bell function")]
        public double Resolution
        { 
            get => resolution; 
            set {
                if (value > 0)
                {
                    resolution = value;
                }
                GenerateSeries();
                ParameterChange();
            } 
        }

        public BellFunction(Universe u) : base(u)
        {
            // here we inpout the data
            //this.Variance = variance;
            //this.Flatness = flatness;
            //this.Center = center;

            // here we set the series
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Orange;
            series.Name = $"Bell function{currentindex++}";


            this.Name = series.Name;
            GenerateSeries();

        }

        public override double GetValue(double x)
        {
            return 1.0 / (1 + Math.Pow(Math.Abs((x - Center) / Variance), 2.0 * Flatness));
        }
        public override void GenerateSeries()
        {
            series.Points.Clear();
            double frontpoint = center;
            double backpoint = center;

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
