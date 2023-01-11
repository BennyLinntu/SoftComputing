using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunzzyLibaray
{
    public class FuzzyFunctions
    {
        // data fields
        protected string[] parametername;
        protected double[] parameter;
        private Universe u;
        protected TreeNode treenode;
        protected Series series;
        protected Random r = new Random();
        protected Color color;
        protected double minimum;
        protected double maximum;
        protected double resolution;
        private double interval;
        string name;
        int seriesborderwith = 2;
        public event EventHandler UniverseParametersChanged;

        
        [Category("Function Setting"), Description("the name of the this function")]
        // Properties
        public string Name
        { 
            get => name; 
            set
            {
                if(value != "")
                {
                    name = value;
                    series.Name = value;
                    if(treenode != null)
                    {
                        treenode.Text = value;
                    }
                    ParameterChange();
                }
            }
        }
        // color set
        [Category("Function Setting"), Description("the Color of the this function")]
        public Color Color 
        {
            get => color;
            set
            {
                color = value;
                series.Color = value;
                ParameterChange();
            }
        }
        [Category("Function Setting"), Description("the series of the this function")]
        public int Seriesborderwith 
        { 
            get => seriesborderwith; 
            set
            {
                if(value > 0)
                {
                    series.BorderWidth = value;
                    seriesborderwith = value;
                    ParameterChange();
                }
                else
                {
                    return;
                }
            }
        }
        [Browsable(false)]
        public Universe U { get => u; set => u = value; }

        [Browsable(false)]
        public virtual double maxdegree
        {
            get => 1.0;
        }
        [Browsable(false)]
        public virtual bool Ismonotonic { get => false; }

        [Browsable(false)]
        public int HashCodeStore { get; set; }

        // here we show the functions
        public FuzzyFunctions(Universe u)
        {
            this.u = u;  // here we input the Universe
            series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            //series.Legend = u.Get
            maximum = u.Maximum;
            minimum = u.Minimum;
            resolution = u.Resolution;
            //u.ParameterChenged += UParameterChange;


        }
        public virtual double Area
        {
            get
            {
                double area = 0;
                for (double x = minimum; x < maximum; x = x + Interval)
                {
                    double delta = GetValue(x) * interval;
                    area += delta;
                }
                return area;
            }
        }


        public void SetTreeNode(TreeNode tn)
        {
            treenode = tn;
        }

        
        protected void ParameterChange()
        {
            if(series != null)
            {
                GenerateSeries();
                PlotGraph();
            }
            if(UniverseParametersChanged == null)
            {
                return;
            }
            else
            {
                UniverseParametersChanged(this, null);
            }
        }
        public Series PlotGraph()
        {
            series.ChartArea = U.Name;
            return series;
        }
        // here we use the virtual to summarize all functions, and let all need override it
        public virtual void GenerateSeries()
        {
            series.Points.Clear();
            double min = U.Minimum;
            double max = U.Maximum;
            double resolution = U.Resolution;
            double interval = (max - min) / resolution;
            for (double i = min; i <= max; i = i + interval)
            {
                series.Points.AddXY(i, GetValue(i));
            }
        }
        public virtual double GetValue(double x)
        {
            throw new Exception();
        }

       
        public void SetSeries(Color c, SeriesChartType sct)
        {
            series.Color = c;
            series.ChartType = sct;
        }
       
        public virtual double MOM
        {
            // return Max Degree half point
            get
            {
                List<double> maxlocation = new List<double>();
                CalulateMaxDegree();
                for (double x = minimum; x < maximum; x = x + Interval)
                {
                    if (GetValue(x) == maxdegree)
                    {
                        maxlocation.Add(x);
                    }
                }
                if (maxlocation.Count == 0) return double.NaN;
                double[] Max_location = new double[maxlocation.Count];
                Max_location = maxlocation.ToArray();
                double mid = Max_location[(Max_location.Length / 2)];
                return mid;
            }
        }
        public virtual double SOM
        {
            // return first Max Degree X value
            get
            {
                double value = double.NaN;
                for (double x = minimum; x < maximum; x = x + Interval)
                {
                    CalulateMaxDegree();
                    if (GetValue(x) == maxdegree)
                    {
                        value = x;
                        break;
                    }
                }
                return value;
            }
        }
        public virtual double LOM
        {
            // return Last Max Degree X value
            get
            {
                double value = double.NaN;
                for (double x = maximum; x > minimum; x = x - Interval)
                {
                    CalulateMaxDegree();
                    if (GetValue(x) == maxdegree)
                    {
                        value = x;
                        break;
                    }
                }
                return value;
            }
        }
        public virtual double BOA
        {

            get
            {
                double half_area = 0;
                double value = double.NaN;
                for (double x = u.Minimum; x < u.Maximum; x = x + Interval)
                {
                    double delta_Area = GetValue(x) * Interval;
                    half_area += delta_Area;
                    if (half_area >= 0.5 * Area)
                    {
                        value = x;
                        break;
                    }
                }
                return value;
            }
        }
        public virtual double COA
        {

            get
            {
                double area_Distance = 0;
                for (double x = u.Minimum; x < u.Maximum; x = x + Interval)
                {
                    double delta_Area = GetValue(x) * Interval;
                    area_Distance += delta_Area * x;

                }
                if (Area == 0) return Math.Abs(u.Minimum + u.Maximum) / 2.0;
                return area_Distance / Area;
            }
        }

        protected double Interval { get => interval; set => interval = value; }
        protected double CalulateMaxDegree()
        {
            double max = double.MinValue;
            for (double x = minimum; x < maximum; x = x + Interval)
            {
                double md = GetValue(x);
                if (md > max)
                    max = md;
            }
            return max;
        }
        protected void UParameterChange(object sender, EventArgs e)
        {

            if(series.Name != "")
            {
                GenerateSeries();
            }
        }
        // Unary Operator
        public static UnaryOperatedFuzzyFunction operator !(FuzzyFunctions operand)
        {
            // negate
            UnaryOperatedFuzzyFunction result = null;
            UnaryOperator op = new ValueNegativeOperate();
            result = new UnaryOperatedFuzzyFunction(op, operand);
            return result;
        }
        public static UnaryOperatedFuzzyFunction operator ~(FuzzyFunctions operand)
        {
            // concentration
            UnaryOperatedFuzzyFunction result = null;
            UnaryOperator op = new ValueConcentrationOperate();
            result = new UnaryOperatedFuzzyFunction(op, operand);
            return result;
        }
        public static UnaryOperatedFuzzyFunction operator ++(FuzzyFunctions operand)
        {
            //Extremely
            UnaryOperatedFuzzyFunction result = null;
            UnaryOperator op = new ValueExtremelyOperate();
            result = new UnaryOperatedFuzzyFunction(op, operand);
            return result;
        }
        public static UnaryOperatedFuzzyFunction operator --(FuzzyFunctions operand)
        {
            //Intensification
            UnaryOperatedFuzzyFunction result = null;
            UnaryOperator op = new ValueIntensificationOperate();
            result = new UnaryOperatedFuzzyFunction(op, operand);
            return result;
        }
        public static UnaryOperatedFuzzyFunction operator -(FuzzyFunctions operand)
        {
            //Diminish
            UnaryOperatedFuzzyFunction result = null;
            UnaryOperator op = new VlaueDiminishOperate();
            result = new UnaryOperatedFuzzyFunction(op, operand);
            return result;
        }

        public static UnaryOperatedFuzzyFunction operator -(double cutvalue, FuzzyFunctions operand)
        {
            // cut
            UnaryOperatedFuzzyFunction result = null;
            UnaryOperator op = new ValueCutOperate();
            result = new UnaryOperatedFuzzyFunction(op, operand);
            return result;
        }
        public static UnaryOperatedFuzzyFunction operator *(double scalevalue, FuzzyFunctions operand)
        {
            // scale
            UnaryOperatedFuzzyFunction result = null;
            UnaryOperator op = new ValueScaleOperate();
            result = new UnaryOperatedFuzzyFunction(op, operand);
            return result;
        }

        // Binary Operator
        public static BinaryOperatedFuzzyFunction operator &(FuzzyFunctions operanda, FuzzyFunctions operandb)
        {
            // intersection
            BinaryOperatedFuzzyFunction result = null;
            BinaryOperator op = new ValueIntersectionOperate();
            result = new BinaryOperatedFuzzyFunction(op, operanda, operandb);
            return result;
        }

        public static BinaryOperatedFuzzyFunction operator |(FuzzyFunctions operanda, FuzzyFunctions operandb)
        {
            BinaryOperatedFuzzyFunction result = null;
            BinaryOperator op = new ValueUnionOpeate();
            result = new BinaryOperatedFuzzyFunction(op, operanda, operandb);
            return result;
        }
        public static BinaryOperatedFuzzyFunction operator <(FuzzyFunctions operanda, FuzzyFunctions operandb)
        {
            BinaryOperatedFuzzyFunction result = null;
            BinaryOperator op = new ValueAlgebraicProductOperate();
            result = new BinaryOperatedFuzzyFunction(op, operanda, operandb);
            return result;
        }
        public static BinaryOperatedFuzzyFunction operator >(FuzzyFunctions operanda, FuzzyFunctions operandb)
        {
            BinaryOperatedFuzzyFunction result = null;
            BinaryOperator op = new ValueAlgebraicProductOperate();
            result = new BinaryOperatedFuzzyFunction(op, operanda, operandb);
            return result;
        }
        public static BinaryOperatedFuzzyFunction operator +(FuzzyFunctions operanda, FuzzyFunctions operandb)
        {
            BinaryOperatedFuzzyFunction result = null;
            BinaryOperator op = new ValueDombiTormOperate();
            result = new BinaryOperatedFuzzyFunction(op, operanda, operandb);
            return result;
        }

        public static BinaryOperatedFuzzyFunction operator %(FuzzyFunctions operanda, FuzzyFunctions operandb)
        {
            BinaryOperatedFuzzyFunction result = null;
            BinaryOperator op = new ValueBoundedProductOperate();
            result = new BinaryOperatedFuzzyFunction(op, operanda, operandb);
            return result;
        }
        public static BinaryOperatedFuzzyFunction operator ^(FuzzyFunctions operanda, FuzzyFunctions operandb)
        {

            BinaryOperatedFuzzyFunction result = null;
            BinaryOperator op = new ValueBoundedSumOperate();
            result = new BinaryOperatedFuzzyFunction(op, operanda, operandb);
            return result;
        }
        public static BinaryOperatedFuzzyFunction operator /(FuzzyFunctions operanda, FuzzyFunctions operandb)
        {
            BinaryOperatedFuzzyFunction result = null;
            BinaryOperator op = new ValueSubtractionOperate();
            result = new BinaryOperatedFuzzyFunction(op, operanda, operandb);
            return result;
        }


    }
}
