namespace AudioQualityAnalysisTool
{
    partial class AudioQualityAnalysisTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RecordPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.sourceList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Playbtn = new System.Windows.Forms.Button();
            this.Stopbtn = new System.Windows.Forms.Button();
            this.Recordbtn = new System.Windows.Forms.Button();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.AnalysisPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.RecordPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RecordPage);
            this.tabControl1.Controls.Add(this.AnalysisPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(588, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // RecordPage
            // 
            this.RecordPage.Controls.Add(this.splitContainer1);
            this.RecordPage.Location = new System.Drawing.Point(4, 22);
            this.RecordPage.Margin = new System.Windows.Forms.Padding(1);
            this.RecordPage.Name = "RecordPage";
            this.RecordPage.Padding = new System.Windows.Forms.Padding(1);
            this.RecordPage.Size = new System.Drawing.Size(580, 412);
            this.RecordPage.TabIndex = 0;
            this.RecordPage.Text = "Recorder";
            this.RecordPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(1, 1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(578, 410);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.sourceList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Playbtn);
            this.splitContainer2.Panel2.Controls.Add(this.Stopbtn);
            this.splitContainer2.Panel2.Controls.Add(this.Recordbtn);
            this.splitContainer2.Panel2.Controls.Add(this.Refreshbtn);
            this.splitContainer2.Size = new System.Drawing.Size(578, 233);
            this.splitContainer2.SplitterDistance = 434;
            this.splitContainer2.TabIndex = 0;
            // 
            // sourceList
            // 
            this.sourceList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.sourceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceList.Location = new System.Drawing.Point(0, 0);
            this.sourceList.MultiSelect = false;
            this.sourceList.Name = "sourceList";
            this.sourceList.Size = new System.Drawing.Size(434, 233);
            this.sourceList.TabIndex = 0;
            this.sourceList.UseCompatibleStateImageBehavior = false;
            this.sourceList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Device";
            this.columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Channels";
            // 
            // Playbtn
            // 
            this.Playbtn.Location = new System.Drawing.Point(3, 82);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.Size = new System.Drawing.Size(133, 27);
            this.Playbtn.TabIndex = 3;
            this.Playbtn.Text = "Play";
            this.Playbtn.UseVisualStyleBackColor = true;
            // 
            // Stopbtn
            // 
            this.Stopbtn.Location = new System.Drawing.Point(3, 130);
            this.Stopbtn.Name = "Stopbtn";
            this.Stopbtn.Size = new System.Drawing.Size(133, 27);
            this.Stopbtn.TabIndex = 2;
            this.Stopbtn.Text = "Stop";
            this.Stopbtn.UseVisualStyleBackColor = true;
            this.Stopbtn.Click += new System.EventHandler(this.Stopbtn_Click);
            // 
            // Recordbtn
            // 
            this.Recordbtn.Location = new System.Drawing.Point(3, 49);
            this.Recordbtn.Name = "Recordbtn";
            this.Recordbtn.Size = new System.Drawing.Size(133, 27);
            this.Recordbtn.TabIndex = 1;
            this.Recordbtn.Text = "Record";
            this.Recordbtn.UseVisualStyleBackColor = true;
            this.Recordbtn.Click += new System.EventHandler(this.Recordbtn_Click);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(3, 3);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(133, 27);
            this.Refreshbtn.TabIndex = 0;
            this.Refreshbtn.Text = "Refresh Source";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // AnalysisPage
            // 
            this.AnalysisPage.Location = new System.Drawing.Point(4, 22);
            this.AnalysisPage.Margin = new System.Windows.Forms.Padding(1);
            this.AnalysisPage.Name = "AnalysisPage";
            this.AnalysisPage.Padding = new System.Windows.Forms.Padding(1);
            this.AnalysisPage.Size = new System.Drawing.Size(580, 412);
            this.AnalysisPage.TabIndex = 1;
            this.AnalysisPage.Text = "Analysis";
            this.AnalysisPage.UseVisualStyleBackColor = true;
            // 
            // AudioQualityAnalysisTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 438);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "AudioQualityAnalysisTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Quality Analysis Tool";
            this.tabControl1.ResumeLayout(false);
            this.RecordPage.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RecordPage;
        private System.Windows.Forms.TabPage AnalysisPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView sourceList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Stopbtn;
        private System.Windows.Forms.Button Recordbtn;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Button Playbtn;
    }
}

