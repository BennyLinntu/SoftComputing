using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunzzyLibaray
{
    public class BellFunction
    {
        // here we set the data
        Series BellSeries = new Series();
        double variance;
        double flatness;
        double center;

        public BellFunction(double variance, double flatness, double center, double resolution)
        {
            // here we inpout the data
            this.variance = variance;
            this.flatness = flatness;
            this.center = center;

            // here we set the series
            BellSeries.ChartType = SeriesChartType.Line;
            BellSeries.Color = Color.Orange;
            BellSeries.BorderWidth = 2;

        }
        public double GetValue(double x)
        {
            return 1.0 / (1 + Math.Pow(Math.Abs((x - center) / variance), 2.0 * flatness));
        }
             



    }
}
