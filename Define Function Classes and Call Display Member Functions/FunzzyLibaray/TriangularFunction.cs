using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunzzyLibaray
{

   public class TriangularFunction
    {
        // here is data set
        Series TriangularSeries = new Series();
        double left;
        double peak;
        double right;

        //here is Properties
        public Series TriangularSeries1 { get => TriangularSeries; set => TriangularSeries = value; }
        public double Left { get => left; set => left = value; }
        public double Peak { get => peak; set => peak = value; }
        public double Right { get => right; set => right = value; }

        public TriangularFunction(double left, double peak, double right)
        {
            // here we input the data
            this.left = left;
            this.peak = peak;
            this.right = right;
            // here we set the chart

            TriangularSeries.ChartType = SeriesChartType.Line;
            TriangularSeries.Color = Color.Lime;
            TriangularSeries.BorderWidth = 2;
        }
        public double GettheValue(double x)
        {
            if (x < Left)
            {
                return 0;

            }
            else if (x <= right && x >= peak)
            {
                return Math.Abs(x - left) / Math.Abs(peak - left);
            }
            else if (x <= peak && x >= left)
            {
                return Math.Abs(left - x) / Math.Abs(left - peak);
            }
            else
            {
                return 0;
            }
        }
        

        
    }
}
