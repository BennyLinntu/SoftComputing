using System;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunzzyLibaray
{
    public class TrapzoidalFunction : FuzzyFunctions
    {
        // data fields
        static int countindex = 1;
        double left;
        double right;
        double leftpoint;
        double rightpoint;
        // Properties
        public double Left 
        { 
            get => left; 
            set
            {
                if(value <= leftpoint)
                {
                    left = value;
                }
                GenerateSeries();
                ParameterChange();
            }
        }
        public double Right 
        { 
            get => right;
            set
            {
                if(value >= rightpoint)
                {
                    right = value;
                }
                GenerateSeries();
                ParameterChange();
            }
        }
        public double Leftpoint 
        { 
            get => leftpoint; 
            set
            {
                if(value >= left && value <= rightpoint)
                {
                    leftpoint = value;
                }
                GenerateSeries();
                ParameterChange();
            }
        }
        public double Rightpoint 
        { 
            get => rightpoint; 
            set
            {
                if(value  >= leftpoint && value <= right)
                {
                    rightpoint = value;
                }
                GenerateSeries();
                ParameterChange();
            }
        }
        // Functions
        public TrapzoidalFunction(Universe u) : base(u)
        {
            left = -2 + r.NextDouble();
            leftpoint = -1 + r.NextDouble();
            rightpoint = 1 + r.NextDouble();
            right = 2 + r.NextDouble();
            series.Name = "Trapzoidal_" + String.Format("{0:00}", countindex++);
            Color = series.Color;
            series.ChartType = SeriesChartType.Line;
            this.Name = series.Name;
            GenerateSeries();
        }

        

        public override double GetValue(double x)
        {
            if(rightpoint <= x && x <= right)
            {
                return Math.Abs(x - right) / Math.Abs(rightpoint - right);
            }
            else if(leftpoint <= x && x <= rightpoint)
            {
                return 1.0;
            }
            else if(left <= x && x <= leftpoint)
            {
                return Math.Abs(x - left) / Math.Abs(leftpoint - left);
            }
            else
            {
                return 0.0;
            }
            
        }



    }
}
