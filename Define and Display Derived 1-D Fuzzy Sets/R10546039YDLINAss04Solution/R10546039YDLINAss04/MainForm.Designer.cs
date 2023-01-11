
namespace R10546039YDLINAss04
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvShow = new System.Windows.Forms.TreeView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.btnAddFunction = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbUnaryOperator = new System.Windows.Forms.ComboBox();
            this.btnUnaryOperate = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSeriesA = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSeriesB = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbBinaryOperator = new System.Windows.Forms.ComboBox();
            this.btnBinaryOperate = new System.Windows.Forms.Button();
            this.ppgShow = new System.Windows.Forms.PropertyGrid();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chtShow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtShow)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1349, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1349, 668);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1341, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Graph Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ppgShow);
            this.splitContainer1.Size = new System.Drawing.Size(1335, 627);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvShow);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer2.Size = new System.Drawing.Size(1335, 306);
            this.splitContainer2.SplitterDistance = 559;
            this.splitContainer2.TabIndex = 2;
            // 
            // tvShow
            // 
            this.tvShow.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvShow.Location = new System.Drawing.Point(0, 0);
            this.tvShow.Name = "tvShow";
            this.tvShow.Size = new System.Drawing.Size(559, 306);
            this.tvShow.TabIndex = 1;
            this.tvShow.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvShow_AfterSelect);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(772, 306);
            this.tabControl2.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(764, 271);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Universe & Function Create";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbSelect);
            this.groupBox2.Controls.Add(this.btnAddFunction);
            this.groupBox2.Location = new System.Drawing.Point(27, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 101);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select";
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Items.AddRange(new object[] {
            "Triangular Function",
            "Gaussian Function",
            "Bell Function",
            "Sigmoidal Function",
            "LeftRight Function"});
            this.cbSelect.Location = new System.Drawing.Point(91, 41);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(212, 30);
            this.cbSelect.TabIndex = 0;
            this.cbSelect.Text = "Triangular Function";
            // 
            // btnAddFunction
            // 
            this.btnAddFunction.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFunction.Image")));
            this.btnAddFunction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFunction.Location = new System.Drawing.Point(405, 27);
            this.btnAddFunction.Name = "btnAddFunction";
            this.btnAddFunction.Size = new System.Drawing.Size(231, 56);
            this.btnAddFunction.TabIndex = 3;
            this.btnAddFunction.Text = "Add Function";
            this.btnAddFunction.UseVisualStyleBackColor = true;
            this.btnAddFunction.Click += new System.EventHandler(this.btnAddFunction_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddArea);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(27, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Areas";
            // 
            // btnAddArea
            // 
            this.btnAddArea.Image = ((System.Drawing.Image)(resources.GetObject("btnAddArea.Image")));
            this.btnAddArea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddArea.Location = new System.Drawing.Point(91, 29);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(212, 59);
            this.btnAddArea.TabIndex = 1;
            this.btnAddArea.Text = "Add Universe";
            this.btnAddArea.UseVisualStyleBackColor = true;
            this.btnAddArea.Click += new System.EventHandler(this.btnAddArea_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(405, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(231, 63);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabControl3);
            this.tabPage4.Location = new System.Drawing.Point(4, 31);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(764, 271);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Functions Operation";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl3.Location = new System.Drawing.Point(3, 3);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(758, 265);
            this.tabControl3.TabIndex = 6;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox3);
            this.tabPage5.Location = new System.Drawing.Point(4, 31);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(750, 230);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Unary Operation";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbUnaryOperator);
            this.groupBox3.Controls.Add(this.btnUnaryOperate);
            this.groupBox3.Location = new System.Drawing.Point(24, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 117);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type of Operation";
            // 
            // cbUnaryOperator
            // 
            this.cbUnaryOperator.FormattingEnabled = true;
            this.cbUnaryOperator.Items.AddRange(new object[] {
            "Value Negate Operate",
            "Value Very Operate",
            "Value Extremely Operate",
            "Value Intensification Operate",
            "Value Diminish Operate",
            "Value Cut Operate",
            "Value Scale Operate"});
            this.cbUnaryOperator.Location = new System.Drawing.Point(37, 61);
            this.cbUnaryOperator.Name = "cbUnaryOperator";
            this.cbUnaryOperator.Size = new System.Drawing.Size(225, 30);
            this.cbUnaryOperator.TabIndex = 3;
            this.cbUnaryOperator.Text = "Value Negate Operate";
            // 
            // btnUnaryOperate
            // 
            this.btnUnaryOperate.Enabled = false;
            this.btnUnaryOperate.Image = ((System.Drawing.Image)(resources.GetObject("btnUnaryOperate.Image")));
            this.btnUnaryOperate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnaryOperate.Location = new System.Drawing.Point(332, 48);
            this.btnUnaryOperate.Name = "btnUnaryOperate";
            this.btnUnaryOperate.Size = new System.Drawing.Size(244, 55);
            this.btnUnaryOperate.TabIndex = 2;
            this.btnUnaryOperate.Text = "Unary Operate";
            this.btnUnaryOperate.UseVisualStyleBackColor = true;
            this.btnUnaryOperate.Click += new System.EventHandler(this.btnUnaryOperate_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox5);
            this.tabPage6.Controls.Add(this.groupBox4);
            this.tabPage6.Location = new System.Drawing.Point(4, 31);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(750, 230);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Binary Operation";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSeriesA);
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Controls.Add(this.btnSeriesB);
            this.groupBox5.Location = new System.Drawing.Point(20, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(724, 100);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selected Series(Operated)";
            // 
            // btnSeriesA
            // 
            this.btnSeriesA.Enabled = false;
            this.btnSeriesA.Image = ((System.Drawing.Image)(resources.GetObject("btnSeriesA.Image")));
            this.btnSeriesA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeriesA.Location = new System.Drawing.Point(19, 39);
            this.btnSeriesA.Name = "btnSeriesA";
            this.btnSeriesA.Size = new System.Drawing.Size(241, 43);
            this.btnSeriesA.TabIndex = 6;
            this.btnSeriesA.Text = "Select Series A";
            this.btnSeriesA.UseVisualStyleBackColor = true;
            this.btnSeriesA.Click += new System.EventHandler(this.btnSeriesA_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(529, 39);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 43);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSeriesB
            // 
            this.btnSeriesB.Enabled = false;
            this.btnSeriesB.Image = ((System.Drawing.Image)(resources.GetObject("btnSeriesB.Image")));
            this.btnSeriesB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeriesB.Location = new System.Drawing.Point(277, 39);
            this.btnSeriesB.Name = "btnSeriesB";
            this.btnSeriesB.Size = new System.Drawing.Size(229, 43);
            this.btnSeriesB.TabIndex = 7;
            this.btnSeriesB.Text = "Select Series B";
            this.btnSeriesB.UseVisualStyleBackColor = true;
            this.btnSeriesB.Click += new System.EventHandler(this.btnSeriesB_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbBinaryOperator);
            this.groupBox4.Controls.Add(this.btnBinaryOperate);
            this.groupBox4.Location = new System.Drawing.Point(20, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(724, 87);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Type of Operation";
            // 
            // cbBinaryOperator
            // 
            this.cbBinaryOperator.FormattingEnabled = true;
            this.cbBinaryOperator.Items.AddRange(new object[] {
            "Value Intersection Operate",
            "Value Union Operate",
            "Value Substraction Operate"});
            this.cbBinaryOperator.Location = new System.Drawing.Point(19, 33);
            this.cbBinaryOperator.Name = "cbBinaryOperator";
            this.cbBinaryOperator.Size = new System.Drawing.Size(241, 30);
            this.cbBinaryOperator.TabIndex = 4;
            this.cbBinaryOperator.Text = "Value Intersection Operate";
            // 
            // btnBinaryOperate
            // 
            this.btnBinaryOperate.BackColor = System.Drawing.Color.Transparent;
            this.btnBinaryOperate.Enabled = false;
            this.btnBinaryOperate.Image = ((System.Drawing.Image)(resources.GetObject("btnBinaryOperate.Image")));
            this.btnBinaryOperate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBinaryOperate.Location = new System.Drawing.Point(290, 22);
            this.btnBinaryOperate.Name = "btnBinaryOperate";
            this.btnBinaryOperate.Size = new System.Drawing.Size(216, 41);
            this.btnBinaryOperate.TabIndex = 2;
            this.btnBinaryOperate.Text = "Binary Operate";
            this.btnBinaryOperate.UseVisualStyleBackColor = false;
            this.btnBinaryOperate.Click += new System.EventHandler(this.btnBinaryOperate_Click);
            // 
            // ppgShow
            // 
            this.ppgShow.BackColor = System.Drawing.Color.LightCyan;
            this.ppgShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppgShow.Location = new System.Drawing.Point(0, 0);
            this.ppgShow.Name = "ppgShow";
            this.ppgShow.Size = new System.Drawing.Size(1335, 317);
            this.ppgShow.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chtShow);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1341, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chart Show";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chtShow
            // 
            this.chtShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chtShow.BorderlineColor = System.Drawing.SystemColors.ActiveCaption;
            this.chtShow.BorderlineWidth = 2;
            this.chtShow.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chtShow.Legends.Add(legend1);
            this.chtShow.Location = new System.Drawing.Point(3, 3);
            this.chtShow.Name = "chtShow";
            this.chtShow.Size = new System.Drawing.Size(1335, 627);
            this.chtShow.TabIndex = 0;
            this.chtShow.Text = "chart1";
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 696);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "R10546039YDLINAss004";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Button btnAddFunction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddArea;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PropertyGrid ppgShow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtShow;
        private System.Windows.Forms.TreeView tvShow;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbUnaryOperator;
        private System.Windows.Forms.Button btnUnaryOperate;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbBinaryOperator;
        private System.Windows.Forms.Button btnBinaryOperate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSeriesB;
        private System.Windows.Forms.Button btnSeriesA;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

