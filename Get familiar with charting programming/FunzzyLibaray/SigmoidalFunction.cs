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
        Series sigmoidalSeries = new Series();
        double alpha;
        double theta;
        // Properity
        public Series SigmoidalSeries { get => sigmoidalSeries; set => sigmoidalSeries = value; }
        public double Alpha { get => alpha; set => alpha = value; }
        public double Theta { get => theta; set => theta = value; }
        // functions

        public SigmoidalFunction(double alpha, double theta, double resolution)
        {
            // here we set the data
            this.Alpha = alpha;
            this.Theta = theta;

            // here we set the series
            SigmoidalSeries.ChartType = SeriesChartType.Line;
            SigmoidalSeries.Color = Color.Pink;
            SigmoidalSeries.BorderWidth = 2;

        }

        

        // this function input the data will output the Y that we want
        public double GetFunctionValue(double x)
        {
            return 1 / (1 + Math.Exp(-Alpha * (x - Theta)));
        }

    }
}
