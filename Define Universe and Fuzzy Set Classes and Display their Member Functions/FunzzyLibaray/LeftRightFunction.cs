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
    public class LeftRightFunction : FuzzyFunctions
    {
        //Series LeftRightSeries = new Series();
        static int currentindex = 1;
        public string[] parameternames = new string[] { "alpha", "beta", "theta", "resolution" };
        public double[] parameterinitial = new double[] { 10, 0, 0, 100 };
        double alpha = 10;
        double beta = 10;
        double theta = 0 + 10 * (currentindex - 1);
        double resolution = 100;

        // Properties
        [Category("Parameters"), Description("the alpha of LeftRight function")]
        public double Alpha 
        { 
            get => alpha; 
            set
            {
                alpha = value;
                GenerateSeries();
                ParameterChange();
            }
        }
        [Category("Parameters"), Description("the beta of LeftRight function")]
        public double Beta 
        {
            get => beta;
            set
            {
                if(value >= 0)
                {
                    beta = value;
                    GenerateSeries();
                    ParameterChange();
                }
                
            }
        }
        [Category("Parameters"), Description("the theta of LeftRight function")]
        public double Theta 
        { 
            get => theta;
            set
            {
                theta = value;
                GenerateSeries();
                ParameterChange();
            }
        }
        [Category("Parameters"), Description("the resolution of LeftRight function")]
        public double Resolution 
        { 
            get => resolution;
            set
            {
                if(resolution > 0)
                {
                    resolution = value;
                }
            }
        }


        public LeftRightFunction(Universe u) : base(u)
        {
            //this.Alpha = alpha;
            //this.Beta = beta;
            //this.Theta = theta;

            // here we set the series
            //series.ChartType = SeriesChartType.Line;
            series.Color = Color.Purple;
            series.Name = $"LeftRight function{currentindex++}";
            this.Name = series.Name;
            GenerateSeries();

        }

      

        public double GetValue(double x)
        {
            if (x >= Theta)
            {
                return Math.Exp(-1.0 * Math.Pow((x - Theta) / Beta, 3));
            }
            else
            {
                return Math.Sqrt(Math.Max(0, 1 - Math.Pow((x - Theta) / Alpha, 2)));
            }
        }
        public void GenerateSeries()
        {
            series.Points.Clear();
            // initial data
            double frontpoint = theta;
            double backpoint = theta;

            do
            {
                frontpoint--;
            } while (GetValue(frontpoint) >= 0.01);
            do
            {
                backpoint++;
            } while (GetValue(backpoint) >= 0.01 );
            for (int i = 0; i <= resolution; i++)
            {
                double a = frontpoint + i * ((backpoint - frontpoint) / resolution);
                series.Points.AddXY(a, GetValue(a));
            }
        }
    }
}
