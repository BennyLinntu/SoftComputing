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

namespace R10546039YDLINAss05
{
    public partial class MainForm : Form
    {

        // data fileds
        DataGridViewColumn lastcolumn;

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
            tvShow.SelectedNode.Nodes.Add(tn);

            if (tvShow.SelectedNode.Index == 0) // if we chance the input universe
            {
                dgvRules.Columns.Add(u.Name, u.Name);
                dgvRules.Columns[dgvRules.Columns.Count - 1].Tag = u;
                dgvConditions.Columns.Add(u.Name, u.Name);
                dgvConditions.Columns[dgvConditions.Columns.Count - 1].Tag = u;
                if (dgvConditions.RowCount == 0)
                {
                    dgvConditions.Rows.Add();
                }
                if (lastcolumn != null)
                {
                    lastcolumn.DisplayIndex = dgvRules.ColumnCount - 1;
                }
            }
            if (tvShow.SelectedNode.Index == 1)// if we chance the output universe
            {
                dgvRules.Columns.Add(u.Name, u.Name);
                dgvRules.Columns[dgvRules.Columns.Count - 1].Tag = u;
                dgvRules.Columns[dgvRules.Columns.Count - 1].DefaultCellStyle.BackColor = Color.LightCyan;

                lastcolumn = new DataGridViewColumn();
                lastcolumn = dgvRules.Columns[dgvRules.Columns.Count - 1];
            }
            dgvRules.Columns[dgvRules.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            gbRules.Enabled = true;
            gbConditions.Enabled = true;
            if (tvShow.SelectedNode.Level == 0) // the first level
            {
                btnAddArea.Enabled = true;
                btnDelete.Enabled = false;
                if (tvShow.SelectedNode.Index == 1 && tvShow.SelectedNode.Nodes.Count != 0)
                {
                    btnAddArea.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }


        }
        // here we delete the chart area
        private void btnDelete_Click(object sender, EventArgs e)
        {
            TreeNode tn = tvShow.SelectedNode; // here we select the area
            if (tn != null)
            {

                tvShow.Nodes.Remove(tn);
                if (tn.Level == 0)
                {
                    chtShow.ChartAreas.Remove(GetChartAreaByXaxisTitle(tn.Text));
                    chtShow.Series.Remove(GetSeriesByName(tn.Text));
                    if (dgvRules.Columns[tn.Text] != null)
                    {
                        dgvRules.Columns.Remove(tn.Text);
                    }
                    if (dgvConditions.Columns[tn.Text] != null)
                    {
                        dgvConditions.Columns.Remove(tn.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Universe or Function!");
                return;

            }
            if (tvShow.Nodes.Count == 0 || tvShow.SelectedNode.Nodes.Count == 0)
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
                if (chtShow.ChartAreas[i].AxisX.Title == title)
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
            if (tvShow.SelectedNode == null)
            {
                MessageBox.Show("Please select a Universe!");
                return;
            }
            Universe u = tvShow.SelectedNode.Tag as Universe;
            if (u == null)
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
            else if (cbSelect.SelectedIndex == 4)
            {
                ffc = new LeftRightFunction(u);
            }
            // S shape function
            else if (cbSelect.SelectedIndex == 5)
            {
                ffc = new SShapeFunction(u);
            }
            else
            {
                ffc = new ZShapeFunction(u);
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
            //int num = 0;
            Universe u = (tvShow.SelectedNode.Tag as Universe);
            if (tvShow.SelectedNode.Level == 0)
            {
                btnAddArea.Enabled = true;
                btnDelete.Enabled = false;

                if (tvShow.SelectedNode.Index == 1 && tvShow.SelectedNode.Nodes.Count != 0)
                {
                    btnAddArea.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            else if (tvShow.SelectedNode.Level == 1)
            {
                gbFunctions.Enabled = true;
                gbUnaryOperation.Enabled = false;
                gbBinaryOperation.Enabled = false;
                btnAddArea.Enabled = false;
                btnDelete.Enabled = true;

            }
            else
            {
                gbFunctions.Enabled = false;
                gbUnaryOperation.Enabled = true;
                gbBinaryOperation.Enabled = true;
                gbSeriesSelected.Enabled = true;
                btnAddArea.Enabled = false;
                btnDelete.Enabled = true;
            }
            ppgShow.SelectedObject = e.Node.Tag;

            for (int i = 0; i < chtShow.ChartAreas.Count; i++)
            {
                chtShow.ChartAreas[i].BackColor = Color.White;
            }
            if (GetChartAreaByXaxisTitle(tvShow.SelectedNode.Text) != null)
            {
                GetChartAreaByXaxisTitle(tvShow.SelectedNode.Text).BackColor = Color.LightGoldenrodYellow;
            }
            for (int i = 0; i < chtShow.Series.Count; i++)
            {
                chtShow.Series[i].MarkerStyle = MarkerStyle.None;
                chtShow.Series[i].BorderWidth = 2;
            }
            if (GetSeriesByName(tvShow.SelectedNode.Text) != null)
            {
                GetSeriesByName(tvShow.SelectedNode.Text).MarkerStyle = MarkerStyle.Cross;
                GetSeriesByName(tvShow.SelectedNode.Text).BorderWidth = 2;
            }


            //for (int i = 0; i < chtShow.ChartAreas.Count; i++)
            //{
            //    chtShow.ChartAreas[i].BackColor = Color.White;
            //}
            //ppgShow.SelectedObject = e.Node.Tag;
            //if(GetChartAreaByXaxisTitle(tvShow.SelectedNode.Text) != null)
            //{
            //    GetChartAreaByXaxisTitle(tvShow.SelectedNode.Text).BackColor = Color.LightGoldenrodYellow;
            //}
            //if (tvShow.SelectedNode.Tag.ToString() == "FunzzyLibaray.Universe")
            //{
            //    btnUnaryOperate.Enabled = false;
            //    btnBinaryOperate.Enabled = false;
            //    btnAddFunction.Enabled = true;
            //    btnSeriesA.Enabled = false;
            //    btnSeriesB.Enabled = false;
            //    btnCancel.Enabled = false;
            //}
            //else
            //{
            //    btnUnaryOperate.Enabled = true;
            //    btnBinaryOperate.Enabled = true;
            //    btnAddFunction.Enabled = true;
            //    btnSeriesA.Enabled = true;
            //    btnSeriesB.Enabled = true;
            //    btnCancel.Enabled = true;
            //}


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
            if (tvShow.SelectedNode.Nodes.Count > 0)
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
            UnaryOperatedFuzzyFunction uoff = null;
            UnaryOperator uo = null;
            if (cbUnaryOperator.SelectedIndex == 0)
            {
                uoff = !ffc;
            }
            //Value Very Operate
            else if (cbUnaryOperator.SelectedIndex == 1)
            {
                uoff = ~ffc;
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
                uoff = 0.5 - ffc;
            }
            //Value Scale Operate
            else
            {
                uoff = 0.5 * ffc;
            }
            if (uoff == null)
            {
                uoff = new UnaryOperatedFuzzyFunction(uo, ffc);
            }
            // UnaryOperatedFuzzyFunction uoff = new UnaryOperatedFuzzyFunction(uo, ffc);
            uoff.GenerateSeries();
            if (chtShow.Series.FindByName(uoff.PlotGraph().Name) != null)
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
            if (ffca.U != ffcb.U)
            {
                MessageBox.Show("please let the series A and series B at the same Universe!");
                return;
            }
            BinaryOperatedFuzzyFunction boff = null;
            BinaryOperator bo = null;
            // Intersection Operate
            if (cbBinaryOperator.SelectedIndex == 0)
            {
                boff = ffca & ffcb;
            }
            // Union Operate
            else if (cbBinaryOperator.SelectedIndex == 1)
            {
                boff = ffca | ffcb;
            }
            //Subtraction Operate
            else if (cbBinaryOperator.SelectedIndex == 2)
            {
                boff = ffca / ffcb;
            }
            // bounded sum Operate
            else if (cbBinaryOperator.SelectedIndex == 3)
            {
                boff = ffca ^ ffcb;
            }
            // Bounded Product Operate
            else if (cbBinaryOperator.SelectedIndex == 4)
            {
                boff = ffca % ffcb;
            }

            // logical sum Operate
            else if (cbBinaryOperator.SelectedIndex == 5)
            {
                bo = new ValueLogicalSumOperate();
            }
            // Logical Product Operate
            else if (cbBinaryOperator.SelectedIndex == 6)
            {
                bo = new ValueLogicalProductOperate();
            }
            // algebraic sum Operate
            else if (cbBinaryOperator.SelectedIndex == 7)
            {
                boff = ffca < ffcb;
            }
            // Algebraic Product Operate Operate
            else if (cbBinaryOperator.SelectedIndex == 8)
            {
                bo = new ValueAlgebraicProductOperate();
            }
            // drastic sum Operate
            else if (cbBinaryOperator.SelectedIndex == 9)
            {
                bo = new ValueDrasticSumOperate();
            }
            //Drastic Product Operate
            else if (cbBinaryOperator.SelectedIndex == 10)
            {
                bo = new ValueDrasticProductOperate();
            }
            // einstein sum Operate
            else if (cbBinaryOperator.SelectedIndex == 11)
            {
                bo = new ValueEinsteinSumOperate();
            }
            //Einstein Product Operate
            else if (cbBinaryOperator.SelectedIndex == 12)
            {
                bo = new ValueEinsteinProductOperate();
            }
            // Hamacher T Norm Operate
            else if (cbBinaryOperator.SelectedIndex == 13)
            {
                bo = new ValueHamacherTNormOperate();
            }
            // Hamacher S Norm Operate
            else if (cbBinaryOperator.SelectedIndex == 14)
            {
                bo = new ValueHamacherSNormOperate();
            }
            //Dombi TNorm Operate
            else
            {
                boff = ffca + ffcb;
            }
            if (boff == null)
            {
                boff = new BinaryOperatedFuzzyFunction(bo, ffca, ffcb);
            }

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
            if (btnSeriesA.Tag != null && btnSeriesB.Tag != null)
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

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            dgvRules.Rows.Add();
        }

        private void btnDeleteRule_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvRules.SelectedRows)
            {
                dgvRules.Rows.RemoveAt(item.Index);
            }
        }

        private void btnIfThemRun_Click(object sender, EventArgs e)
        {
            List<FuzzyFunctions> ffcs;
            List<FuzzyFunctions> conditions;
            FuzzyFunctions ffc = null;
            int currentidnex = lastcolumn.Index;

            for (int i = 0; i < dgvRules.RowCount; i++)
            {
                ffcs = new List<FuzzyFunctions>();
                conditions = new List<FuzzyFunctions>();
                ffc = (FuzzyFunctions)dgvRules.Rows[i].Cells[currentidnex].Value;
                for (int m = 0; m < dgvRules.ColumnCount; m++)
                {
                    ffcs.Add((FuzzyFunctions)dgvRules.Rows[i].Cells[m].Value);
                }
                for (int n = 0; n < dgvConditions.ColumnCount; n++)
                {
                    conditions.Add((FuzzyFunctions)dgvConditions.Rows[0].Cells[n].Value);
                }
                ffcs.RemoveAt(currentidnex);
                IfThenRule itr = new IfThenRule(ffcs, ffc);
                FuzzyFunctions result = itr.FuzzyInFuzzyOutInferening(conditions, rbCut.Checked);
                result.GenerateSeries();
                chtShow.Series.Add(result.PlotGraph());

            }

        }

        private void tvShow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TreeNode tn = tvShow.SelectedNode;
                if (tn != null)
                {
                    tvShow.Nodes.Remove(tn);
                    chtShow.ChartAreas.Remove(GetChartAreaByXaxisTitle(tn.Text));
                    chtShow.Series.Remove(GetSeriesByName(tn.Text));
                }
                if (tvShow.Nodes.Count == 0)
                {
                    gbUnaryOperation.Enabled = false;
                    gbBinaryOperation.Enabled = false;
                    gbFunctions.Enabled = false;
                }

            }
        }

        private void dgvRules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FuzzyFunctions ffc = (FuzzyFunctions)tvShow.SelectedNode.Tag;
            if (ffc == null)
            {
                return;
            }
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            if (dgvRules.Columns[e.ColumnIndex].Tag != ffc.U)
            {
                return;
            }
            dgvRules.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = ffc;

        }

        private void dgvConditions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FuzzyFunctions ffc = (FuzzyFunctions)tvShow.SelectedNode.Tag;
            if (ffc == null)
            {
                return;
            }
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            if (dgvConditions.Columns[e.ColumnIndex].Tag != ffc.U)
            {
                return;
            }
            dgvConditions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = ffc;

        }
    }
}
