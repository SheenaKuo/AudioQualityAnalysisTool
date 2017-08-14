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
            this.AnalysisPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.RecordPage);
            this.tabControl1.Controls.Add(this.AnalysisPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1568, 1112);
            this.tabControl1.TabIndex = 0;
            // 
            // RecordPage
            // 
            this.RecordPage.Location = new System.Drawing.Point(10, 48);
            this.RecordPage.Name = "RecordPage";
            this.RecordPage.Padding = new System.Windows.Forms.Padding(3);
            this.RecordPage.Size = new System.Drawing.Size(1548, 1054);
            this.RecordPage.TabIndex = 0;
            this.RecordPage.Text = "Recorder";
            this.RecordPage.UseVisualStyleBackColor = true;
            // 
            // AnalysisPage
            // 
            this.AnalysisPage.Location = new System.Drawing.Point(10, 48);
            this.AnalysisPage.Name = "AnalysisPage";
            this.AnalysisPage.Padding = new System.Windows.Forms.Padding(3);
            this.AnalysisPage.Size = new System.Drawing.Size(1548, 1054);
            this.AnalysisPage.TabIndex = 1;
            this.AnalysisPage.Text = "Analysis";
            this.AnalysisPage.UseVisualStyleBackColor = true;
            // 
            // AudioQualityAnalysisTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1568, 1112);
            this.Controls.Add(this.tabControl1);
            this.Name = "AudioQualityAnalysisTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Quality Analysis Tool";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage RecordPage;
        private System.Windows.Forms.TabPage AnalysisPage;
    }
}

