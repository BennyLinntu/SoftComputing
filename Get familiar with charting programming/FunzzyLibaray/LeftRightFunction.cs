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
        Series leftRightSeries = new Series();
        double alpha;
        double beta;
        double theta;


        // properity
        public Series LeftRightSeries { get => leftRightSeries; set => leftRightSeries = value; }
        public double Alpha { get => alpha; set => alpha = value; }
        public double Beta { get => beta; set => beta = value; }
        public double Theta { get => theta; set => theta = value; }


        public LeftRightFunction(double alpha, double beta, double theta, double resolution)
        {
            this.Alpha = alpha;
            this.Beta = beta;
            this.Theta = theta;

            // here we set the series
            LeftRightSeries.ChartType = SeriesChartType.Line;
            LeftRightSeries.Color = Color.Purple;
            LeftRightSeries.BorderWidth = 2;


        }


        public double GetFunctionValue(double x)
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
    }
}
