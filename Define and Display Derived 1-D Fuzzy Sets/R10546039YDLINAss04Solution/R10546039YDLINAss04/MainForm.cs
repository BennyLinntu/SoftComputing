using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FunzzyLibaray;

namespace R10546039YDLINAss04
{
    public partial class MainForm : Form
    {

        // data fileds


        // properities




        // functions
        // here we click the butten, the chart area will add
        public MainForm()
        {
            InitializeComponent();
            chtShow.Series.Clear();
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            Universe u = new Universe(chtShow);
            TreeNode tn = new TreeNode(u.Name);
            
            tn.Name = u.Name;
            tn.Tag = u;
            u.SetTreeNode(tn);
            tvShow.Nodes.Add(tn);
        }
        // here we delete the chart area
        private void btnDelete_Click(object sender, EventArgs e)
        {
            TreeNode tn = tvShow.SelectedNode; // here we select the area
            if(tn != null)
            {
                tvShow.Nodes.Remove(tn);
                chtShow.ChartAreas.Remove(GetChartAreaByXaxisTitle(tn.Text));
                chtShow.Series.Remove(GetSeriesByName(tn.Text));
            }
            else
            {
                MessageBox.Show("Please select a Universe or Function!");
                return;
                    
            }
            if(tvShow.Nodes.Count == 0 || tvShow.SelectedNode.Nodes.Count == 0)
            {
                btnUnaryOperate.Enabled = false;
                btnBinaryOperate.Enabled = false;
                btnSeriesA.Enabled = false;
                btnSeriesB.Enabled = false;
                btnCancel.Enabled = false;
            }
        }
        public ChartArea GetChartAreaByXaxisTitle(string title)
        {
            ChartArea ca = new ChartArea();
            for (int i = 0; i < chtShow.ChartAreas.Count; i++)
            {
                if(chtShow.ChartAreas[i].AxisX.Title == title)
                {
                    ca = chtShow.ChartAreas[i];
                }
            }
            return ca;
        }
        public Series GetSeriesByName(string name)
        {
            Series s = new Series();
            s = chtShow.Series.FindByName(name);
            return s;
        }

        // here we add functions
        private void btnAddFunction_Click(object sender, EventArgs e)
        {
            if(tvShow.SelectedNode == null)
            {
                MessageBox.Show("Please select a Universe!");
                return;
            }
            Universe u = tvShow.SelectedNode.Tag as Universe;
            if(u == null)
            {
                return;
            }
            TreeNode tn = new TreeNode();
            FuzzyFunctions ffc = new FuzzyFunctions(u);
            //Triangular Function
            if (cbSelect.SelectedIndex == 0)
            {
                ffc = new TriangularFunction(u);
            }
            // Gaussian Function
            else if (cbSelect.SelectedIndex == 1)
            {
                ffc = new GaussianFunction(u);
            }
            // Bell Function
            else if (cbSelect.SelectedIndex == 2)
            {
                ffc = new BellFunction(u);
            }
            // Sigmoidal Function
            else if (cbSelect.SelectedIndex == 3)
            {
                ffc = new SigmoidalFunction(u);
            }
            // LeftRight Function
            else
            {
                ffc = new LeftRightFunction(u);
            }
            chtShow.Series.Add(ffc.PlotGraph());
            tn.Tag = ffc;
            ffc.SetTreeNode(tn);
            tn.Text = ffc.Name;
            tvShow.SelectedNode.Nodes.Add(tn);
            u.GetChartArea().RecalculateAxesScale();
            chtShow.Update();
            btnUnaryOperate.Enabled = true;
        }
        // after the tvshow's tree node selected
        private void tvShow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int num = 0;
            for (int i = 0; i < chtShow.ChartAreas.Count; i++)
            {
                chtShow.ChartAreas[i].BackColor = Color.White;
            }
            ppgShow.SelectedObject = e.Node.Tag;
            if(GetChartAreaByXaxisTitle(tvShow.SelectedNode.Text) != null)
            {
                GetChartAreaByXaxisTitle(tvShow.SelectedNode.Text).BackColor = Color.LightGoldenrodYellow;
            }
            if (tvShow.SelectedNode.Tag.ToString() == "FunzzyLibaray.Universe")
            {
                btnUnaryOperate.Enabled = false;
                btnBinaryOperate.Enabled = false;
                btnAddFunction.Enabled = true;
                btnSeriesA.Enabled = false;
                btnSeriesB.Enabled = false;
                btnCancel.Enabled = false;
            }
            else
            {
                btnUnaryOperate.Enabled = true;
                btnBinaryOperate.Enabled = true;
                btnAddFunction.Enabled = true;
                btnSeriesA.Enabled = true;
                btnSeriesB.Enabled = true;
                btnCancel.Enabled = true;
            }


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;
            StreamReader sr = new StreamReader(dlgOpen.FileName);
            List<string> function = new List<string>();
            for (int i = 0; i < function.Count; i++)
            {
                function[i] = sr.ReadLine();
            }

            sr.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() != DialogResult.OK) return;
            StreamWriter sw = new StreamWriter(dlgSave.FileName);
            List<string> function = new List<string>();
            // here is the recorded
            for (int i = 0; i < function.Count; i++)
            {
                sw.WriteLine(function[i]);
            }
            sw.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" you can see the textbook of the soft computing");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        // here we show the Unary operate
        private void btnUnaryOperate_Click(object sender, EventArgs e)
        {
            if (tvShow.SelectedNode == null)
            {
                MessageBox.Show("please selected a function");
                return;
            }
            if(tvShow.SelectedNode.Nodes.Count > 0)
            {
                btnUnaryOperate.Enabled = true;
                btnBinaryOperate.Enabled = true;
                btnSeriesA.Enabled = true;
                btnSeriesB.Enabled = true;
                btnCancel.Enabled = true;
            }
            FuzzyFunctions ffc = (FuzzyFunctions)tvShow.SelectedNode.Tag;
            if (ffc == null) return;
            //Value Negate Operate
            UnaryOperator uo = new UnaryOperator();
            if(cbUnaryOperator.SelectedIndex== 0)
            {
                uo = new ValueNegativeOperate();
            }
            //Value Very Operate
            else if (cbUnaryOperator.SelectedIndex == 1)
            {
                uo = new ValueVeryOperate();
            }
            //Value Extremely Operate
            else if (cbUnaryOperator.SelectedIndex == 2)
            {
                uo = new ValueExtremelyOperate();
            }
            //Value Intensification Operate
            else if (cbUnaryOperator.SelectedIndex == 3)
            {
                uo = new ValueIntensificationOperate();
            }
            //Value Diminish Operate
            else if (cbUnaryOperator.SelectedIndex == 4)
            {
                uo = new VlaueDiminishOperate();
            }
            //Value Cut Operate
            else if (cbUnaryOperator.SelectedIndex == 5)
            {
                uo = new ValueCutOperate();
            }
            //Value Scale Operate
            else
            {
                uo = new ValueScaleOperate();
            }
            UnaryOperatedFuzzyFunction uoff = new UnaryOperatedFuzzyFunction(uo, ffc);
            uoff.GenerateSeries();
            if(chtShow.Series.FindByName(uoff.PlotGraph().Name) != null)
            {
                chtShow.Series.Remove(chtShow.Series.FindByName((uoff.PlotGraph().Name)));
            }
            chtShow.Series.Add(uoff.PlotGraph());
            TreeNode tn = new TreeNode(uoff.Name);
            tn.Name = uoff.Name;
            tn.Tag = uoff;
            uoff.SetTreeNode(tn);
            ffc.U.Treenode.Nodes.Add(tn);
            ffc.U.GetChartArea().RecalculateAxesScale();
            chtShow.Update();


        }
        // here we show the Binary Operate
        private void btnBinaryOperate_Click(object sender, EventArgs e)
        {

            FuzzyFunctions ffca = (FuzzyFunctions)btnSeriesA.Tag;
            FuzzyFunctions ffcb = (FuzzyFunctions)btnSeriesB.Tag;
            if(ffca.U != ffcb.U)
            {
                MessageBox.Show("please let the series A and series B at the same Universe!");
                return;
            }
            BinaryOperator bo = new BinaryOperator();
            // Intersection Operate
            if(cbBinaryOperator.SelectedIndex == 0)
            {
                bo = new ValueIntersectionOperate();
            }
            // Union Operate
            else if(cbBinaryOperator.SelectedIndex == 1)
            {
                bo = new ValueUnionOpeate();
            }
            //Subtraction Operate
            else if(cbBinaryOperator.SelectedIndex == 2)
            {
                bo = new ValueSubtractionOperate();
            }
            BinaryOperatedFuzzyFunction boff = new BinaryOperatedFuzzyFunction(bo, ffca, ffcb);
            boff.GenerateSeries();
            chtShow.Series.Add(boff.PlotGraph());
            TreeNode tn = new TreeNode(boff.Name);
            tn.Tag = boff;
            tn.Name = boff.Name;
            boff.SetTreeNode(tn);
            ffca.U.Treenode.Nodes.Add(tn); // same as the ffcb
            ffca.U.GetChartArea().RecalculateAxesScale();
            chtShow.Update();
        }

        // here we check the series a are,
        private void btnSeriesA_Click(object sender, EventArgs e)
        {
            TreeNode tn = tvShow.SelectedNode;
            btnSeriesA.Tag = (FuzzyFunctions)tn.Tag;
            btnSeriesA.Text = $"Series A selected";
            btnSeriesA.BackColor = Color.Yellow;
            tn.BackColor = Color.Yellow;
            btnSeriesA.Enabled = false;
            if(btnSeriesA.Tag != null && btnSeriesB.Tag != null)
            {
                btnBinaryOperate.Enabled = true;
            }

        }
        // here we also check the series b are
        private void btnSeriesB_Click(object sender, EventArgs e)
        {
            TreeNode tn = tvShow.SelectedNode;
            btnSeriesB.Tag = (FuzzyFunctions)tn.Tag;
            btnSeriesB.Text = $"Series B selected";
            btnSeriesB.BackColor = Color.Green;
            tn.BackColor = Color.Green;
            btnSeriesB.Enabled = false;
            if (btnSeriesA.Tag != null && btnSeriesB.Tag != null)
            {
                btnBinaryOperate.Enabled = true;
            }
        }
        // here cancel the series a and series b checked
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // let all tag be null
            btnSeriesA.Tag = null;
            btnSeriesB.Tag = null;
            // and enabled be true
            btnSeriesA.Enabled = true;
            btnSeriesB.Enabled = true;
            btnSeriesA.Text = "Select Series A";
            btnSeriesB.Text = "Select Series B";
            btnBinaryOperate.Enabled = false;
        }
    }
}
