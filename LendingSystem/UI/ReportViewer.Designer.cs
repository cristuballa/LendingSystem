namespace LendingSystem.UI
{
    partial class ReportViewer
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
            this.crvReports = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReports
            // 
            this.crvReports.ActiveViewIndex = -1;
            this.crvReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReports.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReports.Location = new System.Drawing.Point(0, 0);
            this.crvReports.Name = "crvReports";
            this.crvReports.ShowCloseButton = false;
            this.crvReports.Size = new System.Drawing.Size(1015, 514);
            this.crvReports.TabIndex = 0;
            this.crvReports.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 514);
            this.Controls.Add(this.crvReports);
            this.Name = "ReportViewer";
            this.Text = "ReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReports;
    }
}