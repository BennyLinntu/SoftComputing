using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FunzzyLibaray
{
    class ZShapeFunction : FuzzyFunctions
    {
        // data fileds
        static int currentindex = 1;
        public double[] parameterintinal = new double[] { 2, 1, 0, 100 };
        double center = 2;
        double variance = 1;
        double flatness = 0;

        // properties
        [Category("Parameters"), Description("the center of Z shape function")]
        public double Center
        { 
            get => center;
            set
            {
                center = value;
                GenerateSeries();
                ParameterChange();
            }
        }
        [Category("Parameters"), Description("the variance of Z shape function")]
        public double Variance 
        {
            get => variance;
            set
            {
                if(value > 0)
                {
                    variance = value;
                    GenerateSeries();
                    ParameterChange();
                }
            }
        }
        [Category("Parameters"), Description("the flatness of Z shape function")]
        public double Flatness 
        { 
            get => flatness;
            set
            {
                flatness = value;
                GenerateSeries();
                ParameterChange();
            }
        }


        // functions
        public ZShapeFunction(Universe u) : base (u)
        {

            series.Name = $"Z shape function{currentindex++}";
            series.Color = Color.LightCyan;
            this.Name = series.Name;
            GenerateSeries();
        }

        public override double GetValue(double x)
        {
            if(x <= 1)
            {
                return 1.0;
            }
            else if(center < x && x < (center + variance) / 2.0)
            {
                return 1 - (2 * Math.Pow(((x - center) / (variance - center)), 2));
            }
            else if((center + variance) / 2.0 <= x && x <= variance)
            {
               return 1 - (1 - 2 * Math.Pow(((center - x) / (variance - center)), 2));
            }
            else
            {
                return 0.0;
            }
        }




    }
}
