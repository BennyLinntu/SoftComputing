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
    public class Universe
    {
        // data fileds
        static int currentIndex = 1;
        string name = "Universe";
        int resolution = 100;
        double minimum = -20;
        double maximum = 20;
        double increment;
        TreeNode treenode;
        ChartArea chartarea;
        //Legend legend;
        public virtual event EventHandler ParameterChenged;

        // properity
        [Category("Parameters"), Description("the name of this Univers")]
        public string Name
        {
            get
            {
                return chartarea.AxisX.Title;
            }
            set
            {
                if(value != "")
                {
                    name = value;
                    chartarea.Name = value;
                    chartarea.AxisX.Title = value;
                    Treenode.Text = value;
                    if(ParameterChenged != null)
                    {
                        ParameterChenged(this, null);
                    }
                }
            }
        }
        [Category("Parameters"), Description("the resolution of this Univers")]
        public int Resolution
        { 
            get => resolution;
            set
            {
                if (resolution >= 10 && resolution <= 10000)
                {
                    resolution = value;
                }
                if (ParameterChenged != null)
                {
                    ParameterChenged(this, null);
                }
            }
        }
        [Category("Parameters"), Description("the minimum of this Univers")]
        public double Minimum
        { 
            get => minimum;
            set
            {
                if (minimum < maximum)
                {
                    minimum = value;
                    chartarea.AxisX.Minimum = value;
                }
                if (ParameterChenged != null)
                {
                    ParameterChenged(this, null);
                }
            }
        }
        [Category("Parameters"), Description("the maximum of this Univers")]
        public double Maximum 
        { 
            get => maximum;
            set
            {
                if(maximum > minimum)
                {
                    maximum = value;
                    chartarea.AxisX.Maximum = value;
                }
                if (ParameterChenged != null)
                {
                    ParameterChenged(this, null);
                }
            }
        }
        [Browsable(false)]
        public TreeNode Treenode { get => treenode; set => treenode = value; }
        public double Increment { get => increment; set => increment = value; }

        // here is function;
        public Universe(Chart cht)
        {
            name = $"{name}{currentIndex++}";
            chartarea = new ChartArea(name);
            chartarea.AxisX.Enabled = AxisEnabled.True;
            chartarea.AxisX.Title = name;
            chartarea.AxisX.Maximum = maximum;
            chartarea.AxisX.Minimum = minimum;
            chartarea.AxisY.Minimum = 0;
            chartarea.AxisY.Maximum = 1.5;
            chartarea.BackColor = Color.MistyRose;
            chartarea.AxisX.LineColor = Color.DarkGray;
            chartarea.AxisY.LineColor = Color.DarkGray;
            cht.ChartAreas.Add(chartarea);
            increment = Math.Abs((minimum - maximum) / resolution);
        }

        public void SetTreeNode(TreeNode tn)
        {
            Treenode = tn;
        }
        public ChartArea GetChartArea()
        {
            return chartarea;
        }

      
    }
}
