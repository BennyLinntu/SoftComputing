using System;
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


        // here we show the functions
        public FuzzyFunctions(Universe u)
        {
            this.U = u;  // here we input the Universe
            series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 2;
            maximum = u.Maximum;
            minimum = u.Minimum;
            
        }
        public void SetTreeNode(TreeNode tn)
        {
            treenode = tn;
        }

        protected void ParameterChange()
        {
            if(series != null)
            {
                series.ChartArea = U.Name;
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

        public void SetSeries(Color c, SeriesChartType sct)
        {
            series.Color = c;
            series.ChartType = sct;
        }






    }
}
