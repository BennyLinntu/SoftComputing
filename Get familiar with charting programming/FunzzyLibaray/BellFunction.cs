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
        Series bellSeries = new Series();
        double variance;
        double flatness;
        double center;
        // here is the properity
        public Series BellSeries { get => bellSeries; set => bellSeries = value; }
        public double Variance { get => variance; set => variance = value; }
        public double Flatness { get => flatness; set => flatness = value; }
        public double Center { get => center; set => center = value; }


        public BellFunction(double variance, double flatness, double center, double resolution)
        {
            // here we inpout the data
            this.Variance = variance;
            this.Flatness = flatness;
            this.Center = center;

            // here we set the series
            BellSeries.ChartType = SeriesChartType.Line;
            BellSeries.Color = Color.Orange;
            BellSeries.BorderWidth = 2;

        }

       

        public double GetFunctionValue(double x)
        {
            return 1.0 / (1 + Math.Pow(Math.Abs((x - Center) / Variance), 2.0 * Flatness));
        }
             



    }
}
