using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunzzyLibaray
{
    public class LeftRightFunction
    {
        Series LeftRightSeries = new Series();
        double alpha;
        double beta;
        double theta;


        public LeftRightFunction(double alpha, double beta, double theta, double resolution)
        {
            this.alpha = alpha;
            this.beta = beta;
            this.theta = theta;

            // here we set the series
            LeftRightSeries.ChartType = SeriesChartType.Line;
            LeftRightSeries.Color = Color.Purple;
            LeftRightSeries.BorderWidth = 2;


        }
        public double GetValue(double x)
        {
            if (x >= theta)
            {
                return Math.Exp(-1.0 * Math.Pow((x - theta) / beta, 3));
            }
            else
            {
                return Math.Sqrt(Math.Max(0, 1 - Math.Pow((x - theta) / alpha, 2)));
            }
        }
    }
}
