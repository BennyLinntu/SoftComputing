using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        Random r = new Random();
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





    }
}
