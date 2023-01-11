using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FunzzyLibaray
{
    public class SShapeFunction : FuzzyFunctions
    {
        // data fileds 
        static int currentindexdex = 1;
        //public string[] parametername = new string[] { "variance", "flatness", "Center", "resolution" };
        public double[] parameterinitial = new double[] { 2, 1, 0, 100 };
        //Series TriangularSeries = new Series();

        //  here we do not repaer in the same universe
        double variance = 2 + 10 * (currentindexdex - 1);
        double flatness = 1 + 10 * (currentindexdex - 1);
        double center = 0;
        double resolution = 100;

        //here is Properties
        [Category("Parameters"), Description("the variance of the s shape function")]
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
        [Category("Parameters"), Description("the flatness of the s shape function")]
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
        [Category("Parameters"), Description("the center of the s shape function")]
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
        [Category("Parameters"), Description("the resolution of the s shape function")]
        public double Resolution
        {
            get => resolution;
            set
            {
                if (value > 0)
                {
                    resolution = value;
                }
                GenerateSeries();
                ParameterChange();
            }
        }

        // functions
        public SShapeFunction(Universe u) : base(u)
        {
            series.Name = $"S Shape function{currentindexdex++}";
            series.Color = Color.DeepSkyBlue;
            this.Name = series.Name;
            GenerateSeries();
        }

        public override double GetValue(double x)
        {
            if (x <= 1)
            {
                return 0;
            }
            else if (1 < x && x <= ((center + variance) / 2.0))
            {
                return 2 * Math.Pow(((x - center) / (variance - center)), 2);
            }
            else if (x <= variance && (center + variance) / 2.0 <= x)
            {
                return 1  - (2 * Math.Pow(((variance - x) / (variance - center)), 2));
            }
            else
            {
                return 0;
            }
        }

    }
}
