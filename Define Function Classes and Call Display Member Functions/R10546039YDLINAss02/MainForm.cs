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

namespace R10546039YDLINAss02
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // data fileds
        Series s;
        double a;
        double b;
        double c;
        double d;
        // properites
        public Series S { get => s; set => s = value; }
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public double D { get => d; set => d = value; }
        int tf, gf, bf, sif, lrf, lb_num= 0;

        //here we show the functions
        private void btnShow_Click(object sender, EventArgs e)
        {
            if(cbRecord.Checked)
            {
                // Triangular Function
                if (cbShow.SelectedIndex == 0)
                {
                    // here we input the data, and show the chart
                    a = (double)nudA.Value;
                    b = (double)nudB.Value;
                    c = (double)nudC.Value;
                    if (a > b || c > b)
                    {
                        MessageBox.Show("right need to bigger than the peak, also the peak need bigger than left");
                        return;
                    }
                    TriangularFunction f = new TriangularFunction(a, c, b);
                    s = f.TriangularSeries;
                    s.Name = s.Name = $"Triangular Function{tf}";
                    s.Points.AddXY(a - 10, 0);
                    s.Points.AddXY(a, 0);
                    s.Points.AddXY(c, 1);
                    s.Points.AddXY(b, 0);
                    s.Points.AddXY(b + 10, 0);
                    tf++;
                }
                // Gaussian Function
                else if (cbShow.SelectedIndex == 1)
                {

                    // here we input the data, and show the chart
                    a = (double)nudA.Value;
                    b = (double)nudB.Value;
                    c = (double)tbR.Value;
                    if (b <= 0)
                    {
                        MessageBox.Show("Sigma need bigger than 0");
                        return;
                    }
                    GaussianFunction f = new GaussianFunction(a, b, c);
                    s = f.GaussiaSeries;
                    s.Name = s.Name = $"Gaussian Function{gf}";
                    double frontpoint = b;
                    double backpoint = b;
                    do
                    {
                        frontpoint--;
                    } while (f.GetFunctionValue(frontpoint) >= 0.01);

                    do
                    {
                        backpoint++;
                    } while (f.GetFunctionValue(backpoint) >= 0.01);
                    for (double i = 0; i < c + 1; i++)
                    {
                        double x = frontpoint + i * ((backpoint - frontpoint) / c);
                        double r = f.GetFunctionValue(x);
                        s.Points.AddXY(x, r);
                    }
                    gf++;
                }
                // Bell Function
                else if (cbShow.SelectedIndex == 2)
                {

                    // here we input the data, and show the chart
                    a = (double)nudA.Value;
                    b = (double)nudB.Value;
                    c = (double)nudC.Value;
                    d = (double)tbR.Value;
                    if (a == 0)
                    {
                        MessageBox.Show("variance is not allowed to equal to the 0");
                        return;
                    }
                    BellFunction f = new BellFunction(a, b, c, d);
                    s = f.BellSeries;
                    s.Name = s.Name = $"Bell Function{bf}";
                    double frontpoint = c;
                    double backpoint = c;
                    do
                    {
                        frontpoint--;
                    } while (f.GetFunctionValue(frontpoint) >= 0.01);

                    do
                    {
                        backpoint++;
                    } while (f.GetFunctionValue(backpoint) >= 0.01);

                    for (double i = 0; i < d + 1; i++)
                    {
                        double x = frontpoint + i * ((backpoint - frontpoint) / d);
                        double p = f.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    bf++;
                }
                // Sigmoidal Function
                else if (cbShow.SelectedIndex == 3)
                {
                    // here we input the data, and show the chart
                    a = (double)nudA.Value;
                    b = (double)nudB.Value;
                    c = (double)tbR.Value;
                    SigmoidalFunction f = new SigmoidalFunction(a, b, c);
                    s = f.SigmoidalSeries;
                    s.Name = s.Name = $"Sigmoidal Function{sif}";
                    double frontpoint = b;
                    double backpoint = b;
                    do
                    {
                        frontpoint--;
                    } while (f.GetFunctionValue(frontpoint) >= 0.01);

                    do
                    {
                        backpoint++;
                    } while (f.GetFunctionValue(backpoint) <= 0.99);

                    for (double i = 0; i < c + 1; i++)
                    {
                        double x = frontpoint + i * ((backpoint - frontpoint) / c);
                        double p = f.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    sif++;
                }
                // LeftRight Function
                else
                {

                    // here we input the data, and show the chart
                    a = (double)nudA.Value;
                    b = (double)nudB.Value;
                    c = (double)nudC.Value;
                    d = (double)tbR.Value;
                    LeftRightFunction f = new LeftRightFunction(a, b, c, d);
                    s = f.LeftRightSeries;
                    s.Name = s.Name = $"LeftRight Function{lrf}";
                    double Front_point = c;
                    double Back_point = c;

                    do
                    {
                        Front_point--;
                    } while (f.GetFunctionValue(Front_point) >= 0.01);

                    do
                    {
                        Back_point++;
                    } while (f.GetFunctionValue(Back_point) >= 0.01);

                    for (double i = 0; i < d + 1; i++)
                    {
                        double x = Front_point + i * ((Back_point - Front_point) / d);
                        double p = f.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    lrf++;
                }
                
            }
            else
            {
                chtShow.Series.Clear();
                // Triangular Function
                if (cbShow.SelectedIndex == 0)
                {
                    // here we input the data, and show the chart
                    a = (double)nudA.Value;
                    b = (double)nudB.Value;
                    c = (double)nudC.Value;
                    if (a > b || c > b)
                    {
                        MessageBox.Show("right need to bigger than the peak, also the peak need bigger than left");
                        return;
                    }
                    TriangularFunction f = new TriangularFunction(a, c, b);
                    s = f.TriangularSeries;
                    s.Name = s.Name = $"Triangular Function{tf}";
                    s.Points.AddXY(a - 10, 0);
                    s.Points.AddXY(a, 0);
                    s.Points.AddXY(c, 1);
                    s.Points.AddXY(b, 0);
                    s.Points.AddXY(b + 10, 0);
                    tf++;
                }
                // Gaussian Function
                else if (cbShow.SelectedIndex == 1)
                {

                    // here we input the data, and show the chart
                    a = (double)nudA.Value;
                    b = (double)nudB.Value;
                    c = (double)tbR.Value;
                    if (b <= 0)
                    {
                        MessageBox.Show("Sigma need bigger than 0");
                        return;
                    }
                    GaussianFunction f = new GaussianFunction(a, b, c);
                    s = f.GaussiaSeries;
                    s.Name = s.Name = $"Gaussian Function{gf}";
                    double frontpoint = b;
                    double backpoint = b;
                    do
                    {
                        frontpoint--;
                    } while (f.GetFunctionValue(frontpoint) >= 0.01);

                    do
                    {
                        backpoint++;
                    } while (f.GetFunctionValue(backpoint) >= 0.01);
                    for (double i = 0; i < c + 1; i++)
                    {
                        double x = frontpoint + i * ((backpoint - frontpoint) / c);
                        double r = f.GetFunctionValue(x);
                        s.Points.AddXY(x, r);
                    }
                    gf++;
                }
                // Bell Function
                else if (cbShow.SelectedIndex == 2)
                {

                    // here we input the data, and show the chart
                    a = (double)nudA.Value;
                    b = (double)nudB.Value;
                    c = (double)nudC.Value;
                    d = (double)tbR.Value;
                    if (a == 0)
                    {
                        MessageBox.Show("variance is not allowed to equal to the 0");
                        return;
                    }
                    BellFunction f = new BellFunction(a, b, c, d);
                    s = f.BellSeries;
                    s.Name = s.Name = $"Bell Function{bf}";
                    double frontpoint = c;
                    double backpoint = c;
                    do
                    {
                        frontpoint--;
                    } while (f.GetFunctionValue(frontpoint) >= 0.01);

                    do
                    {
                        backpoint++;
                    } while (f.GetFunctionValue(backpoint) >= 0.01);

                    for (double i = 0; i < d + 1; i++)
                    {
                        double x = frontpoint + i * ((backpoint - frontpoint) / d);
                        double p = f.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    bf++;
                }
                // Sigmoidal Function
                else if (cbShow.SelectedIndex == 3)
                {
                    // here we input the data, and show the chart
                    a = (double)nudA.Value;
                    b = (double)nudB.Value;
                    c = (double)tbR.Value;
                    SigmoidalFunction f = new SigmoidalFunction(a, b, c);
                    s = f.SigmoidalSeries;
                    s.Name = s.Name = $"Sigmoidal Function{sif}";
                    double frontpoint = b;
                    double backpoint = b;
                    do
                    {
                        frontpoint--;
                    } while (f.GetFunctionValue(frontpoint) >= 0.01);

                    do
                    {
                        backpoint++;
                    } while (f.GetFunctionValue(backpoint) <= 0.99);

                    for (double i = 0; i < c + 1; i++)
                    {
                        double x = frontpoint + i * ((backpoint - frontpoint) / c);
                        double p = f.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    sif++;
                }
                // LeftRight Function
                else
                {

                    // here we input the data, and show the chart
                    a = (double)nudA.Value;
                    b = (double)nudB.Value;
                    c = (double)nudC.Value;
                    d = (double)tbR.Value;
                    LeftRightFunction f = new LeftRightFunction(a, b, c, d);
                    s = f.LeftRightSeries;
                    s.Name = s.Name = $"LeftRight Function{lrf}";
                    double Front_point = c;
                    double Back_point = c;

                    do
                    {
                        Front_point--;
                    } while (f.GetFunctionValue(Front_point) >= 0.01);

                    do
                    {
                        Back_point++;
                    } while (f.GetFunctionValue(Back_point) >= 0.01);

                    for (double i = 0; i < d + 1; i++)
                    {
                        double x = Front_point + i * ((Back_point - Front_point) / d);
                        double p = f.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    lrf++;
                }

            }

            chtShow.Series.Add(s);
            lbShow.Items.Add($"({lb_num})" + s.Name);
            lb_num++;
        }
        // Open the data

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK) return;
            StreamReader sr = new StreamReader(dlgOpen.FileName);
            string[] num = new string[6];
            for (int i = 0; i < 6; i++)
            {
                num[i] = sr.ReadLine();
            }
            // and let it show in the form
            nudA.Text = num[0];
            nudB.Text = num[1];
            nudC.Text = num[2];
            tbR.Text = num[3];
            sr.Close();
        }

        // save the data
        private void tsmSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() != DialogResult.OK) return;
            StreamWriter sw = new StreamWriter(dlgSave.FileName);
            string[] num = new string[6];
            // here is the recorded
            num[0] = nudA.Text;
            num[1] = nudB.Text;
            num[2] = nudC.Text;
            num[3] = tbR.Text;
            for (int i = 0; i < 6; i++)
            {
                sw.WriteLine(num[i]);
            }
            sw.Close();
        }
        // according to the selected index change, the label, and the value also will change
        private void cbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Triangular Function
            if (cbShow.SelectedIndex == 0)
            {
                // here we set the label, also set the data
                labelA.Text = "Left:";
                labelB.Text = "Right:";
                labelC.Text = "Peak";
                labelD.Text = "";
                tbR.Enabled = false;
                nudC.Enabled = true;
                nudA.Value = -1;
                nudB.Value = 1;
                nudC.Value = 0;

            }
            // Gaussian Function
            else if (cbShow.SelectedIndex == 1)
            {
                labelA.Text = "Mean:";
                labelB.Text = "Sigma:";
                labelC.Text = "";
                labelD.Text = "Resolution";
                nudC.Enabled = false;
                tbR.Enabled = true;
                nudA.Value = -1;
                nudB.Value = 1;
                tbR.Value = 100;
            }
            // Bell Function
            else if (cbShow.SelectedIndex == 2)
            {
                labelA.Text = "Variate:";
                labelB.Text = "Flatness:";
                labelC.Text = "Center:";
                labelD.Text = "Resolution:";
                nudC.Enabled = true;
                tbR.Enabled = true;
                nudA.Value = 1;
                nudB.Value = 1;
                nudC.Value = 0;
                tbR.Value = 100;

            }
            // Sigmoidal Function
            else if (cbShow.SelectedIndex == 3)
            {
                labelA.Text = "Sharpness:";
                labelB.Text = "Center:";
                labelC.Text = "";
                labelD.Text = "Resolution:";
                nudC.Enabled = false;
                tbR.Enabled = true;
                nudA.Value = 1;
                nudB.Value = 0;
                tbR.Value = 100;
            }
            // LeftRight Function
            else
            {
                labelA.Text = "Center:";
                labelB.Text = "Alpha:";
                labelC.Text = "Beta:";
                labelD.Text = "Resolution:";
                nudC.Enabled = true;
                tbR.Enabled = true;
                nudA.Value = 0;
                nudB.Value = 1;
                nudC.Value = 1;
                tbR.Value = 100;
            }
        }
    }
}
