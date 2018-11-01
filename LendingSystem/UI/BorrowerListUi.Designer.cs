namespace LendingSystem.UI
{
    partial class BorrowerListUi
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
            this.cboBorrowerList = new System.Windows.Forms.ComboBox();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboBorrowerList
            // 
            this.cboBorrowerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBorrowerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboBorrowerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBorrowerList.FormattingEnabled = true;
            this.cboBorrowerList.Location = new System.Drawing.Point(0, 3);
            this.cboBorrowerList.Name = "cboBorrowerList";
            this.cboBorrowerList.Size = new System.Drawing.Size(446, 442);
            this.cboBorrowerList.TabIndex = 0;
            // 
            // cmdSelect
            // 
            this.cmdSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSelect.Location = new System.Drawing.Point(354, 445);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(92, 31);
            this.cmdSelect.TabIndex = 2;
            this.cmdSelect.Text = "Select";
            this.cmdSelect.UseVisualStyleBackColor = true;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // BorrowerListUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 486);
            this.Controls.Add(this.cmdSelect);
            this.Controls.Add(this.cboBorrowerList);
            this.Name = "BorrowerListUi";
            this.Text = "Borrower List";
            this.Load += new System.EventHandler(this.BorrowerListUi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBorrowerList;
        private System.Windows.Forms.Button cmdSelect;
    }
}