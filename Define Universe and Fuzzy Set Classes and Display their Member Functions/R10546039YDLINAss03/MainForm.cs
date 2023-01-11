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

namespace R10546039YDLINAss03
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

        }
        // after the tvshow's tree node selected
        private void tvShow_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ppgShow.SelectedObject = e.Node.Tag;

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
    }
}
