namespace LendingSystem.UI
{
    partial class OfficeUi
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
            this.dgvOffices = new System.Windows.Forms.DataGridView();
            this.txtOffice = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.txtOfficeId = new System.Windows.Forms.TextBox();
            this.cmdNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOffices
            // 
            this.dgvOffices.AllowUserToAddRows = false;
            this.dgvOffices.AllowUserToDeleteRows = false;
            this.dgvOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffices.Location = new System.Drawing.Point(3, 3);
            this.dgvOffices.Name = "dgvOffices";
            this.dgvOffices.ReadOnly = true;
            this.dgvOffices.Size = new System.Drawing.Size(428, 385);
            this.dgvOffices.TabIndex = 0;
            this.dgvOffices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOffices_CellContentClick);
            this.dgvOffices.SelectionChanged += new System.EventHandler(this.dgvOffices_SelectionChanged);
            // 
            // txtOffice
            // 
            this.txtOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffice.Location = new System.Drawing.Point(46, 394);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Size = new System.Drawing.Size(194, 26);
            this.txtOffice.TabIndex = 16;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(280, 394);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(40, 28);
            this.cmdAdd.TabIndex = 17;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Location = new System.Drawing.Point(319, 394);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(51, 28);
            this.cmdUpdate.TabIndex = 18;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // cmdRemove
            // 
            this.cmdRemove.Location = new System.Drawing.Point(369, 394);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(57, 28);
            this.cmdRemove.TabIndex = 19;
            this.cmdRemove.Text = "Remove";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // txtOfficeId
            // 
            this.txtOfficeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOfficeId.Location = new System.Drawing.Point(2, 394);
            this.txtOfficeId.Name = "txtOfficeId";
            this.txtOfficeId.Size = new System.Drawing.Size(45, 26);
            this.txtOfficeId.TabIndex = 20;
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(243, 394);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(38, 28);
            this.cmdNew.TabIndex = 21;
            this.cmdNew.Text = "New";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click);
            // 
            // OfficeUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 456);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.txtOfficeId);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.cmdUpdate);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtOffice);
            this.Controls.Add(this.dgvOffices);
            this.DoubleBuffered = true;
            this.Name = "OfficeUi";
            this.Text = "Offices";
            this.Load += new System.EventHandler(this.OfficeUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOffices;
        private System.Windows.Forms.TextBox txtOffice;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdRemove;
        private System.Windows.Forms.TextBox txtOfficeId;
        private System.Windows.Forms.Button cmdNew;
    }
}