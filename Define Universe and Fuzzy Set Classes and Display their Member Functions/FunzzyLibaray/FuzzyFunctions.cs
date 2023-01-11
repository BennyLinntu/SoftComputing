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
        protected Universe u;
        protected TreeNode treenode;
        protected Series series;
        protected Color color;
        protected double minimum;
        protected double maximum;
        string name;
        int seriesborderwith = 2;
        
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
                }
                else
                {
                    return;
                }
            }
        }

        // here we show the functions

        public FuzzyFunctions(Universe u)
        {
            this.u = u;  // here we input the Universe
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
                series.ChartArea = u.Name;
            }
        }
        public Series PlotGraph()
        {
            series.ChartArea = u.Name;
            return series;
        }


    }
}
