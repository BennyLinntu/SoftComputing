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
        Series GaussiaSeries = new Series();
        double mean;
        double variance;


        public GaussianFunction(double mean, double  variance, double resolution)
        {
            // here we input the data, but not the resolution
            this.mean = mean;
            this.variance = variance;
            // here we set the series
            GaussiaSeries.ChartType = SeriesChartType.Line;
            GaussiaSeries.Color = Color.BlueViolet;
            GaussiaSeries.BorderWidth = 2;
        }
        public double GetValue(double x)
        {
            return Math.Exp(-((x - mean) * (x - mean)) / (2 * (variance * variance)));
        }




    }
}
