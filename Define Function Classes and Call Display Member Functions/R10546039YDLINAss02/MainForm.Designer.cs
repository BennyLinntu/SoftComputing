
namespace R10546039YDLINAss02
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.tbR = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbShow = new System.Windows.Forms.ComboBox();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.Form = new System.Windows.Forms.SplitContainer();
            this.btnShow = new System.Windows.Forms.Button();
            this.labelD = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.cbRecord = new System.Windows.Forms.CheckBox();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.nudC = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.chtShow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSave = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form)).BeginInit();
            this.Form.Panel1.SuspendLayout();
            this.Form.Panel2.SuspendLayout();
            this.Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtShow)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudA
            // 
            this.nudA.DecimalPlaces = 1;
            this.nudA.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudA.Location = new System.Drawing.Point(548, 52);
            this.nudA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(222, 30);
            this.nudA.TabIndex = 0;
            this.nudA.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(902, 176);
            this.tbR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbR.Maximum = 1000;
            this.tbR.Minimum = 1;
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(222, 56);
            this.tbR.TabIndex = 1;
            this.tbR.Value = 1;
            // 
            // cbShow
            // 
            this.cbShow.FormattingEnabled = true;
            this.cbShow.Items.AddRange(new object[] {
            "Triangular Function",
            "Gaussian Function",
            "Bell Function",
            "Sigmoidal Function",
            "LeftRight Function"});
            this.cbShow.Location = new System.Drawing.Point(197, 49);
            this.cbShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbShow.Name = "cbShow";
            this.cbShow.Size = new System.Drawing.Size(221, 33);
            this.cbShow.TabIndex = 2;
            this.cbShow.Text = "Triangular Function";
            this.cbShow.SelectedIndexChanged += new System.EventHandler(this.cbShow_SelectedIndexChanged);
            // 
            // lbShow
            // 
            this.lbShow.FormattingEnabled = true;
            this.lbShow.ItemHeight = 25;
            this.lbShow.Location = new System.Drawing.Point(57, 175);
            this.lbShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(361, 129);
            this.lbShow.TabIndex = 3;
            // 
            // Form
            // 
            this.Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form.Location = new System.Drawing.Point(0, 33);
            this.Form.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Form.Name = "Form";
            this.Form.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Form.Panel1
            // 
            this.Form.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Form.Panel1.Controls.Add(this.btnShow);
            this.Form.Panel1.Controls.Add(this.labelD);
            this.Form.Panel1.Controls.Add(this.labelC);
            this.Form.Panel1.Controls.Add(this.cbRecord);
            this.Form.Panel1.Controls.Add(this.labelB);
            this.Form.Panel1.Controls.Add(this.labelA);
            this.Form.Panel1.Controls.Add(this.nudC);
            this.Form.Panel1.Controls.Add(this.nudB);
            this.Form.Panel1.Controls.Add(this.label1);
            this.Form.Panel1.Controls.Add(this.cbShow);
            this.Form.Panel1.Controls.Add(this.lbShow);
            this.Form.Panel1.Controls.Add(this.nudA);
            this.Form.Panel1.Controls.Add(this.tbR);
            // 
            // Form.Panel2
            // 
            this.Form.Panel2.Controls.Add(this.chtShow);
            this.Form.Size = new System.Drawing.Size(1200, 670);
            this.Form.SplitterDistance = 350;
            this.Form.SplitterWidth = 5;
            this.Form.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(819, 246);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(265, 63);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "Run";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(814, 174);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(0, 29);
            this.labelD.TabIndex = 11;
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC.Location = new System.Drawing.Point(805, 53);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(74, 29);
            this.labelC.TabIndex = 10;
            this.labelC.Text = "Peak:";
            // 
            // cbRecord
            // 
            this.cbRecord.AutoSize = true;
            this.cbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecord.Location = new System.Drawing.Point(448, 276);
            this.cbRecord.Name = "cbRecord";
            this.cbRecord.Size = new System.Drawing.Size(186, 33);
            this.cbRecord.TabIndex = 9;
            this.cbRecord.Text = "Record or Not";
            this.cbRecord.UseVisualStyleBackColor = true;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelB.Location = new System.Drawing.Point(443, 176);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(75, 29);
            this.labelB.TabIndex = 8;
            this.labelB.Text = "Right:";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(443, 53);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(58, 29);
            this.labelA.TabIndex = 7;
            this.labelA.Text = "Left:";
            // 
            // nudC
            // 
            this.nudC.DecimalPlaces = 1;
            this.nudC.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudC.Location = new System.Drawing.Point(902, 52);
            this.nudC.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudC.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudC.Name = "nudC";
            this.nudC.Size = new System.Drawing.Size(222, 30);
            this.nudC.TabIndex = 6;
            // 
            // nudB
            // 
            this.nudB.DecimalPlaces = 1;
            this.nudB.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudB.Location = new System.Drawing.Point(548, 175);
            this.nudB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(222, 30);
            this.nudB.TabIndex = 5;
            this.nudB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Function:";
            // 
            // chtShow
            // 
            this.chtShow.BackColor = System.Drawing.Color.PaleTurquoise;
            chartArea1.Name = "ChartArea1";
            this.chtShow.ChartAreas.Add(chartArea1);
            this.chtShow.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chtShow.Legends.Add(legend1);
            this.chtShow.Location = new System.Drawing.Point(0, 0);
            this.chtShow.Name = "chtShow";
            this.chtShow.Size = new System.Drawing.Size(1200, 315);
            this.chtShow.TabIndex = 0;
            this.chtShow.Text = "Run";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpen,
            this.tsmSave});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsmOpen
            // 
            this.tsmOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsmOpen.Image")));
            this.tsmOpen.Name = "tsmOpen";
            this.tsmOpen.Size = new System.Drawing.Size(144, 30);
            this.tsmOpen.Text = "Open";
            this.tsmOpen.Click += new System.EventHandler(this.tsmOpen_Click);
            // 
            // tsmSave
            // 
            this.tsmSave.Image = ((System.Drawing.Image)(resources.GetObject("tsmSave.Image")));
            this.tsmSave.Name = "tsmSave";
            this.tsmSave.Size = new System.Drawing.Size(144, 30);
            this.tsmSave.Text = "Save";
            this.tsmSave.Click += new System.EventHandler(this.tsmSave_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.Form);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "R10546039YDLINAss02";
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbR)).EndInit();
            this.Form.Panel1.ResumeLayout(false);
            this.Form.Panel1.PerformLayout();
            this.Form.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Form)).EndInit();
            this.Form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtShow)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.TrackBar tbR;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbShow;
        private System.Windows.Forms.ListBox lbShow;
        private System.Windows.Forms.SplitContainer Form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtShow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.CheckBox cbRecord;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.NumericUpDown nudC;
    }
}

