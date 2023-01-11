using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunzzyLibaray
{


   public  class SigmoidalFunction
    {
        // here we set the data
        Series SigmoidalSeries = new Series();
        double alpha;
        double theta;


        public SigmoidalFunction(double alpha, double theta, double resolution)
        {
            // here we set the data
            this.alpha = alpha;
            this.theta = theta;

            // here we set the series
            SigmoidalSeries.ChartType = SeriesChartType.Line;
            SigmoidalSeries.Color = Color.Pink;
            SigmoidalSeries.BorderWidth = 2;

        }
        // this function input the data will output the Y that we want
        public double GetValue(double x)
        {
            return 1 / (1 + Math.Exp(-alpha * (x - theta)));
        }

    }
}
