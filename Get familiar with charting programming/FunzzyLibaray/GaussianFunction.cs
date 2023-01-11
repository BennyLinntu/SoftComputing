using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunzzyLibaray
{
    public  class GaussianFunction
    {
        //here we set the data
        Series gaussiaSeries = new Series();
        double mean;
        double variance;


        // here is properity
        public Series GaussiaSeries { get => gaussiaSeries; set => gaussiaSeries = value; }
        public double Mean { get => mean; set => mean = value; }
        public double Variance { get => variance; set => variance = value; }



        public GaussianFunction(double mean, double  variance, double resolution)
        {
            // here we input the data, but not the resolution
            this.Mean = mean;
            this.Variance = variance;
            // here we set the series
            GaussiaSeries.ChartType = SeriesChartType.Line;
            GaussiaSeries.Color = Color.BlueViolet;
            GaussiaSeries.BorderWidth = 2;
        }

       

        public double GetFunctionValue(double x)
        {
            return Math.Exp(-((x - Mean) * (x - Mean)) / (2 * (Variance * Variance)));
        }




    }
}
