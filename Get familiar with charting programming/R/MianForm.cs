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

namespace R10546039YDLIN
{
    public partial class MianForm : Form
    {
        public MianForm()
        {
            InitializeComponent();
        }
        // Data Fileds 
        double a = 0.0;
        double b = 0.0;
        double c = 0.0;
        double sigma = 0.0;
        double y = 0.0;
        int tf, gf, bf, sif, lrf = 0;


        // Properity
        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public double Sigma { get => Sigma; set => Sigma = value; }
        public double Y { get => y; set => y = value; }



        // function
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (cbRecorded.Checked)
            {
                Series s = new Series();
                // Set the chart and data
                s.ChartType = SeriesChartType.Line;
                s.BorderWidth = 2;
                //chtShow.Series.Add(s);
                if (rbTFunction.Checked)
                {
                    
                    s.Color = Color.Lime;
                    s.Name = $"Triangular Function{tf}";
                    A = double.Parse(tbA.Text);
                    B = double.Parse(tbB.Text);
                    C = double.Parse(tbC.Text);
                    if (A > B || C > B)
                    {
                        MessageBox.Show("right need to bigger than the peak, also the peak need bigger than left");
                        return;
                    }
                    else
                    {
                        TriangularFunction t = new TriangularFunction(a, c, b);
                        s.Points.AddXY(a - 5, 0);
                        s.Points.AddXY(a, 0);
                        s.Points.AddXY(c, 1);
                        s.Points.AddXY(b, 0);
                        s.Points.AddXY(b + 5, 0);
                        tf++;
                    }
                    
                }
                else if (rbGFunction.Checked)
                {
                    s.Color = Color.Pink;
                    s.Name = $"Gaussian Function{gf}";
                    A = double.Parse(tbA.Text);
                    B = double.Parse(tbB.Text);
                    C = double.Parse(tbC.Text);
                    if(B <= 0)
                    {
                        MessageBox.Show("Sigma need bigger than 0");
                        return;
                    }
                    else
                    {
                        GaussianFunction g = new GaussianFunction(a, b, c);
                        double frontpoint = b;
                        double backpoint = b;
                        do
                        {
                            frontpoint--;
                        } while (g.GetFunctionValue(frontpoint) >= 0.01);

                        do
                        {
                            backpoint++;
                        } while (g.GetFunctionValue(backpoint) >= 0.01);
                        for (double i = 0; i < c + 1; i++)
                        {
                            double x = frontpoint + i * ((backpoint - frontpoint) / c);
                            double r = g.GetFunctionValue(x);
                            s.Points.AddXY(x, r);
                        }
                        gf++;
                    }
                        
                    
                }
                else if (rbBFunction.Checked)
                {
                    s.Color = Color.DarkBlue;
                    s.Name = $"Bell Function{bf}";
                    A = double.Parse(tbA.Text);
                    B = double.Parse(tbB.Text);
                    C = double.Parse(tbC.Text);
                    sigma = double.Parse(tbSigma.Text);
                    if(A == 0)
                    {
                        MessageBox.Show("variance is not allowed to equal to the 0");
                        return;
                    }

                    BellFunction bel = new BellFunction(a, b, c, sigma);
                    double frontpoint = c;
                    double backpoint = c;
                    do
                    {
                        frontpoint--;
                    } while (bel.GetFunctionValue(frontpoint) >= 0.01);

                    do
                    {
                        backpoint++;
                    } while (bel.GetFunctionValue(backpoint) >= 0.01);

                    for (double i = 0; i < sigma + 1; i++)
                    {
                        double x = frontpoint + i * ((backpoint - frontpoint) / sigma);
                        double p = bel.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    bf++;
                }
                else if (rbSFunction.Checked)
                {
                    s.Color = Color.Orange;
                    s.Name = $"Sigmoidal Function{sif}";
                    
                    A = double.Parse(tbA.Text);
                    B = double.Parse(tbB.Text);
                    C = double.Parse(tbC.Text);
                    SigmoidalFunction sigf = new SigmoidalFunction(a, b, c);
                    double frontpoint = b;
                    double backpoint = b;
                    do
                    {
                        frontpoint--;
                    } while (sigf.GetFunctionValue(frontpoint) >= 0.01);

                    do
                    {
                        backpoint++;
                    } while (sigf.GetFunctionValue(backpoint) <= 0.99);

                    for (double i = 0; i < c + 1; i++)
                    {
                        double x = frontpoint + i * ((backpoint - frontpoint) / c);
                        double p = sigf.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    sif++;

                }
                else if (rbLFunction.Checked)
                {
                    s.Color = Color.DarkOrchid;
                    s.Name = $"LeftRight Function{lrf}";
                    A = double.Parse(tbA.Text);
                    B = double.Parse(tbB.Text);
                    C = double.Parse(tbC.Text);
                    sigma = double.Parse(tbSigma.Text);
                    LeftRightFunction lrtf = new LeftRightFunction(a, b, c, sigma);
                    double Front_point = c;
                    double Back_point = c;

                    do
                    {
                        Front_point--;
                    } while (lrtf.GetFunctionValue(Front_point) >= 0.01);

                    do
                    {
                        Back_point++;
                    } while (lrtf.GetFunctionValue(Back_point) >= 0.01);

                    for (double i = 0; i < sigma + 1; i++)
                    {
                        double x = Front_point + i * ((Back_point - Front_point) / sigma);
                        double p = lrtf.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    lrf++;
                }
                chtShow.Series.Add(s);
            }
            else
            {
                // here we clear the chart and clear the date
                chtShow.Series.Clear();
                Series s = new Series();
                // Set the chart and data
                s.ChartType = SeriesChartType.Line;
                s.BorderWidth = 2;
                //chtShow.Series.Add(s);
                if (rbTFunction.Checked)
                {

                    s.Color = Color.Lime;
                    s.Name = $"Triangular Function{tf}";
                    A = double.Parse(tbA.Text);
                    B = double.Parse(tbB.Text);
                    C = double.Parse(tbC.Text);
                    if (A > B || C > B)
                    {
                        MessageBox.Show("right need to bigger than the peak, also the peak need bigger than left");
                        return;
                    }
                    else
                    {
                        TriangularFunction t = new TriangularFunction(a, c, b);
                        s.Points.AddXY(a - 5, 0);
                        s.Points.AddXY(a, 0);
                        s.Points.AddXY(c, 1);
                        s.Points.AddXY(b, 0);
                        s.Points.AddXY(b + 5, 0);
                        tf++;
                    }

                }
                else if (rbGFunction.Checked)
                {
                    s.Color = Color.Pink;
                    s.Name = $"Gaussian Function{gf}";
                    A = double.Parse(tbA.Text);
                    B = double.Parse(tbB.Text);
                    C = double.Parse(tbC.Text);
                    if (B <= 0)
                    {
                        MessageBox.Show("Sigma need bigger than 0");
                        return;
                    }
                    else
                    {
                        GaussianFunction g = new GaussianFunction(a, b, c);
                        double frontpoint = b;
                        double backpoint = b;
                        do
                        {
                            frontpoint--;
                        } while (g.GetFunctionValue(frontpoint) >= 0.01);

                        do
                        {
                            backpoint++;
                        } while (g.GetFunctionValue(backpoint) >= 0.01);
                        for (double i = 0; i < c + 1; i++)
                        {
                            double x = frontpoint + i * ((backpoint - frontpoint) / c);
                            double r = g.GetFunctionValue(x);
                            s.Points.AddXY(x, r);
                        }
                        gf++;
                    }


                }
                else if (rbBFunction.Checked)
                {
                    s.Color = Color.DarkBlue;
                    s.Name = $"Bell Function{bf}";
                    A = double.Parse(tbA.Text);
                    B = double.Parse(tbB.Text);
                    C = double.Parse(tbC.Text);
                    sigma = double.Parse(tbSigma.Text);
                    if (A == 0)
                    {
                        MessageBox.Show("variance is not allowed to equal to the 0");
                        return;
                    }

                    BellFunction bel = new BellFunction(a, b, c, sigma);
                    double frontpoint = c;
                    double backpoint = c;
                    do
                    {
                        frontpoint--;
                    } while (bel.GetFunctionValue(frontpoint) >= 0.01);

                    do
                    {
                        backpoint++;
                    } while (bel.GetFunctionValue(backpoint) >= 0.01);

                    for (double i = 0; i < sigma + 1; i++)
                    {
                        double x = frontpoint + i * ((backpoint - frontpoint) / sigma);
                        double p = bel.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    bf++;
                }
                else if (rbSFunction.Checked)
                {
                    s.Color = Color.Orange;
                    s.Name = $"Sigmoidal Function{sif}";

                    A = double.Parse(tbA.Text);
                    B = double.Parse(tbB.Text);
                    C = double.Parse(tbC.Text);
                    SigmoidalFunction sigf = new SigmoidalFunction(a, b, c);
                    double frontpoint = b;
                    double backpoint = b;
                    do
                    {
                        frontpoint--;
                    } while (sigf.GetFunctionValue(frontpoint) >= 0.01);

                    do
                    {
                        backpoint++;
                    } while (sigf.GetFunctionValue(backpoint) <= 0.99);

                    for (double i = 0; i < c + 1; i++)
                    {
                        double x = frontpoint + i * ((backpoint - frontpoint) / c);
                        double p = sigf.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    sif++;
                }
                else if (rbLFunction.Checked)
                {
                    s.Color = Color.DarkOrchid;
                    s.Name = $"LeftRight Function{lrf}";
                    A = double.Parse(tbA.Text);
                    B = double.Parse(tbB.Text);
                    C = double.Parse(tbC.Text);
                    sigma = double.Parse(tbSigma.Text);
                    LeftRightFunction lrtf = new LeftRightFunction(a, b, c, sigma);
                    double Front_point = c;
                    double Back_point = c;

                    do
                    {
                        Front_point--;
                    } while (lrtf.GetFunctionValue(Front_point) >= 0.01);

                    do
                    {
                        Back_point++;
                    } while (lrtf.GetFunctionValue(Back_point) >= 0.01);

                    for (double i = 0; i < sigma + 1; i++)
                    {
                        double x = Front_point + i * ((Back_point - Front_point) / sigma);
                        double p = lrtf.GetFunctionValue(x);
                        s.Points.AddXY(x, p);
                    }
                    lrf++;
                }
                chtShow.Series.Add(s);
            }

        }



        // here we Open the file
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
            tbA.Text = num[0];
            tbB.Text = num[1];
            tbC.Text = num[2];
            tbSigma.Text = num[3];
            sr.Close();
        }



        // here we Save the data
        private void tsmSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() != DialogResult.OK) return;
            StreamWriter sw = new StreamWriter(dlgSave.FileName);
            string[] num = new string[6];
            // here is the recorded
            num[0] = tbA.Text;
            num[1] = tbB.Text;
            num[2] = tbC.Text;
            num[3] = tbSigma.Text;
            for (int i = 0; i < 6; i++)
            {
                sw.WriteLine(num[i]);
            }
            sw.Close();
        }



        // label change 
        private void rbTFunction_CheckedChanged(object sender, EventArgs e)
        {
            labela.Text = "Left:";
            labelb.Text = "Right:";
            labelc.Text = "Peak:";
            labeld.Text = "";
            tbA.Text = "-2";
            tbB.Text = "2";
            tbC.Text = "0";
            tbSigma.Enabled = false;
            tbSigma.Text = "";
        }

        private void rbGFunction_CheckedChanged(object sender, EventArgs e)
        {
            labela.Text = "Mean:";
            labelb.Text = "Sigma:";
            labelc.Text = "Resolution";
            labeld.Text = "";
            tbA.Text = "0";
            tbB.Text = "1";
            tbC.Text = "100";
            tbSigma.Enabled = false;
            tbSigma.Text = "";

        }
        private void rbBFunction_CheckedChanged(object sender, EventArgs e)
        {
            labela.Text = "Variate:";
            labelb.Text = "Flatness:";
            labelc.Text = "Center:";
            labeld.Text = "Resolution:";
            tbA.Text = "1";
            tbB.Text = "1";
            tbC.Text = "0";
            tbSigma.Enabled = true;
            tbSigma.Text = "100";
        }

        private void rbSFunction_CheckedChanged(object sender, EventArgs e)
        {
            labela.Text = "Sharpness:";
            labelb.Text = "Center:";
            labelc.Text = "Resolution:";
            labeld.Text = "";
            tbA.Text = "1";
            tbB.Text = "0";
            tbC.Text = "100";
            tbSigma.Enabled = false;
            tbSigma.Text = "";
        }

        private void rbLFunction_CheckedChanged(object sender, EventArgs e)
        {
            labela.Text = "Center:";
            labelb.Text = "Alpha:";
            labelc.Text = "Beta:";
            labeld.Text = "Resolution:";
            tbA.Text = "0";
            tbB.Text = "1";
            tbC.Text = "1";
            tbSigma.Enabled = true;
            tbSigma.Text = "100";
        }






    }
}
