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

   public class TriangularFunction : FuzzyFunctions
    {
        // here is data set
        static int incurrentIndexdex = 1;
        public string[] parametername = new string[] { "left", "peak", "right" };
        public double[] parameterinitial = new double[] { -10, 0, 10 };
        double[] parameters;
        //Series TriangularSeries = new Series();

        //  here we do not repaer in the same universe
        double left = -10 + 10 * (incurrentIndexdex - 1);
        double peak = 0 + 10 * (incurrentIndexdex - 1) ;
        double right = 10 + 10 * (incurrentIndexdex - 1);

        //here is Properties
        //public Series TriangularSeries1 { get => TriangularSeries; set => TriangularSeries = value; }
        [Category("Parameters"), Description("the left point of the triangular function")]
        public double Left 
        { 
            get => left;
            set
            {
                if(value <= peak)
                {
                    left = value;
                }
                // draw the chart, when the paramter is changed
                series.Points.Clear();
                series.Points.AddXY(left, 0);
                series.Points.AddXY(peak, 1);
                series.Points.AddXY(right, 0);
                ParameterChange();
            }
        }
        [Category("Parameters"), Description("the center point of the triangular function")]
        public double Peak 
        { 
            get => peak;
            set
            {
                if(value >= left && value <= right)
                {
                    peak = value;
                }
                series.Points.Clear();
                series.Points.AddXY(left, 0);
                series.Points.AddXY(peak, 1);
                series.Points.AddXY(right, 0);
                ParameterChange();
            }
        }
        [Category("Parameters"), Description("the right point of the triangular function")]
        public double Right 
        { 
            get => right;
            set
            {
                if (value >= peak)
                {
                    right = value;
                }
                series.Points.Clear();
                series.Points.AddXY(left, 0);
                series.Points.AddXY(peak, 1);
                series.Points.AddXY(right, 0);
                ParameterChange();
            }
        }

        public TriangularFunction(Universe u) : base(u)
        {
            // here we input the data
            //this.left = left;
            //this.peak = peak;
            //this.right = right;
            parameters = new double[3];// set the parameters
            parameters[0] = left;
            parameters[1] = peak;
            parameters[2] = right;

            // here we set the chart
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Lime;
            series.Name = $"Trianguular function{incurrentIndexdex++}";
            this.Name = series.Name;
            // draw the chart
            series.Points.Clear();
            series.Points.AddXY(left, 0);
            series.Points.AddXY(peak, 1);
            series.Points.AddXY(right, 0);

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
