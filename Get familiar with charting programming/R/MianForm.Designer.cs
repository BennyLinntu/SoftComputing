
namespace R10546039YDLIN
{
    partial class MianForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MianForm));
            this.chtShow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rbLFunction = new System.Windows.Forms.RadioButton();
            this.rbSFunction = new System.Windows.Forms.RadioButton();
            this.cbRecorded = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbSigma = new System.Windows.Forms.TextBox();
            this.labeld = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.labelc = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.labelb = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.labela = new System.Windows.Forms.Label();
            this.rbBFunction = new System.Windows.Forms.RadioButton();
            this.rbGFunction = new System.Windows.Forms.RadioButton();
            this.rbTFunction = new System.Windows.Forms.RadioButton();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chtShow)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtShow
            // 
            this.chtShow.BackColor = System.Drawing.Color.LightCyan;
            chartArea1.Name = "ChartArea1";
            this.chtShow.ChartAreas.Add(chartArea1);
            this.chtShow.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chtShow.Legends.Add(legend1);
            this.chtShow.Location = new System.Drawing.Point(0, 0);
            this.chtShow.Name = "chtShow";
            this.chtShow.Size = new System.Drawing.Size(1112, 384);
            this.chtShow.TabIndex = 0;
            this.chtShow.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.tsmSave});
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(76, 32);
            this.saveToolStripMenuItem.Text = "File";
            // 
            // tsmOpen
            // 
            this.tsmOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsmOpen.Image")));
            this.tsmOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(146, 32);
            this.tsmOpen.Text = "Open";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // tsmSave
            // 
            this.tsmSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmSave.Image")));
            this.tsmSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(146, 32);
            this.tsmSave.Text = "Save";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.rbLFunction);
            this.splitContainer1.Panel1.Controls.Add(this.rbSFunction);
            this.splitContainer1.Panel1.Controls.Add(this.cbRecorded);
            this.splitContainer1.Panel1.Controls.Add(this.btnRun);
            this.splitContainer1.Panel1.Controls.Add(this.tbSigma);
            this.splitContainer1.Panel1.Controls.Add(this.labeld);
            this.splitContainer1.Panel1.Controls.Add(this.tbC);
            this.splitContainer1.Panel1.Controls.Add(this.labelc);
            this.splitContainer1.Panel1.Controls.Add(this.tbB);
            this.splitContainer1.Panel1.Controls.Add(this.labelb);
            this.splitContainer1.Panel1.Controls.Add(this.tbA);
            this.splitContainer1.Panel1.Controls.Add(this.labela);
            this.splitContainer1.Panel1.Controls.Add(this.rbBFunction);
            this.splitContainer1.Panel1.Controls.Add(this.rbGFunction);
            this.splitContainer1.Panel1.Controls.Add(this.rbTFunction);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chtShow);
            this.splitContainer1.Size = new System.Drawing.Size(1112, 806);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 2;
            // 
            // rbLFunction
            // 
            this.rbLFunction.AutoSize = true;
            this.rbLFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLFunction.Location = new System.Drawing.Point(871, 33);
            this.rbLFunction.Name = "rbLFunction";
            this.rbLFunction.Size = new System.Drawing.Size(189, 29);
            this.rbLFunction.TabIndex = 22;
            this.rbLFunction.Text = "LeftRight Function";
            this.rbLFunction.UseVisualStyleBackColor = true;
            this.rbLFunction.CheckedChanged += new System.EventHandler(this.rbLFunction_CheckedChanged);
            // 
            // rbSFunction
            // 
            this.rbSFunction.AutoSize = true;
            this.rbSFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSFunction.Location = new System.Drawing.Point(631, 33);
            this.rbSFunction.Name = "rbSFunction";
            this.rbSFunction.Size = new System.Drawing.Size(199, 29);
            this.rbSFunction.TabIndex = 21;
            this.rbSFunction.Text = "Sigmoidal Function";
            this.rbSFunction.UseVisualStyleBackColor = true;
            this.rbSFunction.CheckedChanged += new System.EventHandler(this.rbSFunction_CheckedChanged);
            // 
            // cbRecorded
            // 
            this.cbRecorded.AutoSize = true;
            this.cbRecorded.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecorded.Location = new System.Drawing.Point(44, 275);
            this.cbRecorded.Name = "cbRecorded";
            this.cbRecorded.Size = new System.Drawing.Size(158, 28);
            this.cbRecorded.TabIndex = 18;
            this.cbRecorded.Text = "Recored or not";
            this.cbRecorded.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(714, 261);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(237, 58);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbSigma
            // 
            this.tbSigma.Enabled = false;
            this.tbSigma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSigma.Location = new System.Drawing.Point(678, 186);
            this.tbSigma.Name = "tbSigma";
            this.tbSigma.Size = new System.Drawing.Size(116, 28);
            this.tbSigma.TabIndex = 12;
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeld.Location = new System.Drawing.Point(552, 186);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(0, 25);
            this.labeld.TabIndex = 11;
            // 
            // tbC
            // 
            this.tbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbC.Location = new System.Drawing.Point(678, 110);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(116, 28);
            this.tbC.TabIndex = 10;
            this.tbC.Text = "0";
            // 
            // labelc
            // 
            this.labelc.AutoSize = true;
            this.labelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelc.Location = new System.Drawing.Point(552, 111);
            this.labelc.Name = "labelc";
            this.labelc.Size = new System.Drawing.Size(63, 25);
            this.labelc.TabIndex = 9;
            this.labelc.Text = "Peak:";
            // 
            // tbB
            // 
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbB.Location = new System.Drawing.Point(175, 183);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(116, 28);
            this.tbB.TabIndex = 8;
            this.tbB.Text = "1";
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelb.Location = new System.Drawing.Point(65, 186);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(62, 25);
            this.labelb.TabIndex = 7;
            this.labelb.Text = "Right:";
            // 
            // tbA
            // 
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbA.Location = new System.Drawing.Point(175, 110);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(116, 28);
            this.tbA.TabIndex = 6;
            this.tbA.Text = "-1";
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labela.Location = new System.Drawing.Point(68, 110);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(50, 25);
            this.labela.TabIndex = 5;
            this.labela.Text = "Left:";
            // 
            // rbBFunction
            // 
            this.rbBFunction.AutoSize = true;
            this.rbBFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBFunction.Location = new System.Drawing.Point(480, 33);
            this.rbBFunction.Name = "rbBFunction";
            this.rbBFunction.Size = new System.Drawing.Size(145, 29);
            this.rbBFunction.TabIndex = 4;
            this.rbBFunction.Text = "Bell Function";
            this.rbBFunction.UseVisualStyleBackColor = true;
            this.rbBFunction.CheckedChanged += new System.EventHandler(this.rbBFunction_CheckedChanged);
            // 
            // rbGFunction
            // 
            this.rbGFunction.AutoSize = true;
            this.rbGFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGFunction.Location = new System.Drawing.Point(268, 33);
            this.rbGFunction.Name = "rbGFunction";
            this.rbGFunction.Size = new System.Drawing.Size(196, 29);
            this.rbGFunction.TabIndex = 3;
            this.rbGFunction.Text = "Gaussian Function";
            this.rbGFunction.UseVisualStyleBackColor = true;
            this.rbGFunction.CheckedChanged += new System.EventHandler(this.rbGFunction_CheckedChanged);
            // 
            // rbTFunction
            // 
            this.rbTFunction.AutoSize = true;
            this.rbTFunction.Checked = true;
            this.rbTFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTFunction.Location = new System.Drawing.Point(44, 33);
            this.rbTFunction.Name = "rbTFunction";
            this.rbTFunction.Size = new System.Drawing.Size(201, 29);
            this.rbTFunction.TabIndex = 2;
            this.rbTFunction.TabStop = true;
            this.rbTFunction.Text = "Triangular Function";
            this.rbTFunction.UseVisualStyleBackColor = true;
            this.rbTFunction.CheckedChanged += new System.EventHandler(this.rbTFunction_CheckedChanged);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // MianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 842);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MianForm";
            this.Text = "R10546039Homework1";
            ((System.ComponentModel.ISupportInitialize)(this.chtShow)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtShow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label labelc;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.RadioButton rbBFunction;
        private System.Windows.Forms.RadioButton rbGFunction;
        private System.Windows.Forms.RadioButton rbTFunction;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbSigma;
        private System.Windows.Forms.Label labeld;
        public System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.CheckBox cbRecorded;
        private System.Windows.Forms.RadioButton rbLFunction;
        private System.Windows.Forms.RadioButton rbSFunction;
    }
}

