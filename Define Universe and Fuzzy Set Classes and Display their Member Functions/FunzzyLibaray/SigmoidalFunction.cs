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


   public  class SigmoidalFunction : FuzzyFunctions
    {
        // here we set the data
        //Series SigmoidalSeries = new Series();
        static int currentIndex = 1;
        public string[] parametername = new string[] { "sharpness", "center", "resolution" };
        public double[] parameterinitial = new double[] { 1, 0, 100 };
        double sharpness = 1;
        double center = 0 + 10 * (currentIndex - 1);
        double resolution = 100;

        // Properities
        [Category("Parameters"), Description("the sharpness of the Sigmoidal function")]
        public double Sharpness 
        { 
            get => sharpness; 
            set => sharpness = value; 
        }
        [Category("Parameters"), Description("the center of the Sigmoidal function")]
        public double Center
        {
            get => center;
            set => center = value; 
        }
        [Category("Parameters"), Description("the resolution of the Sigmoidal function")]
        public double Resolution 
        {
            get => resolution; 
            set => resolution = value;
        }


        public SigmoidalFunction(Universe u) : base(u)
        {
            // here we set the data
            //this.sharpness = alpha;
            //this.center = theta;

            // here we set the series
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Pink;
            series.Name = $"Sigmoidal function{currentIndex++}";
            this.Name = series.Name;
            this.resolution = resolution;
            GenerateSeries();

        }

        

        // this function input the data will output the Y that we want
        public double GetValue(double x)
        {
            return 1 / (1 + Math.Exp(-Sharpness * (x - Center)));
        }
        // here is too long, so we set a function to include the code
        public void GenerateSeries()
        {
            series.Points.Clear();
            // initial data
            double frontpoint = center;
            double backpoint = center;

            do
            {
                frontpoint--;
            } while (GetValue(frontpoint) >= 0.01 && GetValue(frontpoint) <= 0.99);
            do
            {
                backpoint++;
            } while (GetValue(backpoint) >= 0.01 && GetValue(backpoint) <= 0.99);
            for (int i = 0; i <= resolution; i++)
            {
                double a = frontpoint + i * ((backpoint - frontpoint) / resolution);
                series.Points.AddXY(a, GetValue(a));
            }
        }

    }
}
