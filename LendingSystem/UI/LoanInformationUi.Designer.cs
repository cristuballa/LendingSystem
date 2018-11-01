namespace LendingSystem.UI
{
    partial class LoanInformationUi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoanInformationUi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNewBorrower = new System.Windows.Forms.ToolStripButton();
            this.tsbNewLoan = new System.Windows.Forms.ToolStripButton();
            this.tsbNewPayment = new System.Windows.Forms.ToolStripButton();
            this.tsbNewCharge = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPayments = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmScheduleOfPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLedger = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgingByOffice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgingOfReceivable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTodaysCollectible = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmdFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.dgvBorrowers = new System.Windows.Forms.DataGridView();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.dgvLedger = new System.Windows.Forms.DataGridView();
            this.bsBorrower = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBorrower)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewBorrower,
            this.tsbNewLoan,
            this.tsbNewPayment,
            this.tsbNewCharge,
            this.toolStripSeparator1,
            this.tsbPayments,
            this.tsbPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1047, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNewBorrower
            // 
            this.tsbNewBorrower.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewBorrower.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewBorrower.Image")));
            this.tsbNewBorrower.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewBorrower.Name = "tsbNewBorrower";
            this.tsbNewBorrower.Size = new System.Drawing.Size(86, 22);
            this.tsbNewBorrower.Text = "New Borrower";
            this.tsbNewBorrower.Click += new System.EventHandler(this.tsbNewBorrower_Click);
            // 
            // tsbNewLoan
            // 
            this.tsbNewLoan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewLoan.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewLoan.Image")));
            this.tsbNewLoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewLoan.Name = "tsbNewLoan";
            this.tsbNewLoan.Size = new System.Drawing.Size(64, 22);
            this.tsbNewLoan.Text = "New Loan";
            this.tsbNewLoan.Click += new System.EventHandler(this.tsbNewLoan_Click);
            // 
            // tsbNewPayment
            // 
            this.tsbNewPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewPayment.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewPayment.Image")));
            this.tsbNewPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewPayment.Name = "tsbNewPayment";
            this.tsbNewPayment.Size = new System.Drawing.Size(85, 22);
            this.tsbNewPayment.Text = "New Payment";
            this.tsbNewPayment.Click += new System.EventHandler(this.tsbNewPayment_Click);
            // 
            // tsbNewCharge
            // 
            this.tsbNewCharge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNewCharge.Image = ((System.Drawing.Image)(resources.GetObject("tsbNewCharge.Image")));
            this.tsbNewCharge.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewCharge.Name = "tsbNewCharge";
            this.tsbNewCharge.Size = new System.Drawing.Size(76, 22);
            this.tsbNewCharge.Text = "New Charge";
            this.tsbNewCharge.Click += new System.EventHandler(this.tsbNewCharge_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPayments
            // 
            this.tsbPayments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPayments.Image = ((System.Drawing.Image)(resources.GetObject("tsbPayments.Image")));
            this.tsbPayments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPayments.Name = "tsbPayments";
            this.tsbPayments.Size = new System.Drawing.Size(79, 22);
            this.tsbPayments.Text = "Payment List";
            this.tsbPayments.Click += new System.EventHandler(this.tsbPayments_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmScheduleOfPayment,
            this.tsmLedger,
            this.tsmAgingByOffice,
            this.tsmAgingOfReceivable,
            this.tsmTodaysCollectible});
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(45, 22);
            this.tsbPrint.Text = "Print";
            // 
            // tsmScheduleOfPayment
            // 
            this.tsmScheduleOfPayment.Name = "tsmScheduleOfPayment";
            this.tsmScheduleOfPayment.Size = new System.Drawing.Size(188, 22);
            this.tsmScheduleOfPayment.Text = "Schedule Of Payment";
            this.tsmScheduleOfPayment.Click += new System.EventHandler(this.tsmScheduleOfPayment_Click);
            // 
            // tsmLedger
            // 
            this.tsmLedger.Name = "tsmLedger";
            this.tsmLedger.Size = new System.Drawing.Size(188, 22);
            this.tsmLedger.Text = "Ledger";
            this.tsmLedger.Click += new System.EventHandler(this.tsmLedger_Click);
            // 
            // tsmAgingByOffice
            // 
            this.tsmAgingByOffice.Name = "tsmAgingByOffice";
            this.tsmAgingByOffice.Size = new System.Drawing.Size(188, 22);
            this.tsmAgingByOffice.Text = "Aging By Office";
            this.tsmAgingByOffice.Click += new System.EventHandler(this.tsmAgingByOffice_Click);
            // 
            // tsmAgingOfReceivable
            // 
            this.tsmAgingOfReceivable.Name = "tsmAgingOfReceivable";
            this.tsmAgingOfReceivable.Size = new System.Drawing.Size(188, 22);
            this.tsmAgingOfReceivable.Text = "Aging of Receivable";
            this.tsmAgingOfReceivable.Click += new System.EventHandler(this.tsmAgingOfReceivable_Click);
            // 
            // tsmTodaysCollectible
            // 
            this.tsmTodaysCollectible.Name = "tsmTodaysCollectible";
            this.tsmTodaysCollectible.Size = new System.Drawing.Size(188, 22);
            this.tsmTodaysCollectible.Text = "Todays Collectible";
            this.tsmTodaysCollectible.Click += new System.EventHandler(this.tsmTodaysCollectible_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1047, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmdFind);
            this.splitContainer1.Panel1.Controls.Add(this.txtFind);
            this.splitContainer1.Panel1.Controls.Add(this.dgvBorrowers);
            this.splitContainer1.Panel1.Controls.Add(this.cmdRefresh);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvLoans);
            this.splitContainer1.Panel2.Controls.Add(this.dgvLedger);
            this.splitContainer1.Size = new System.Drawing.Size(1047, 433);
            this.splitContainer1.SplitterDistance = 306;
            this.splitContainer1.TabIndex = 26;
            // 
            // cmdFind
            // 
            this.cmdFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFind.Location = new System.Drawing.Point(205, 402);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(44, 26);
            this.cmdFind.TabIndex = 5;
            this.cmdFind.Text = "Find";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFind.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(3, 403);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(201, 25);
            this.txtFind.TabIndex = 4;
            this.txtFind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyUp);
            // 
            // dgvBorrowers
            // 
            this.dgvBorrowers.AllowUserToAddRows = false;
            this.dgvBorrowers.AllowUserToDeleteRows = false;
            this.dgvBorrowers.AllowUserToOrderColumns = true;
            this.dgvBorrowers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBorrowers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBorrowers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBorrowers.Location = new System.Drawing.Point(3, 3);
            this.dgvBorrowers.Name = "dgvBorrowers";
            this.dgvBorrowers.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBorrowers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBorrowers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowers.Size = new System.Drawing.Size(300, 393);
            this.dgvBorrowers.TabIndex = 3;
            this.dgvBorrowers.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvBorrowers_RowPrePaint);
            this.dgvBorrowers.SelectionChanged += new System.EventHandler(this.dgvBorrowers_SelectionChanged);
            this.dgvBorrowers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvBorrowers_MouseDoubleClick);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRefresh.Location = new System.Drawing.Point(249, 402);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(53, 26);
            this.cmdRefresh.TabIndex = 1;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loan Ledger";
            // 
            // dgvLoans
            // 
            this.dgvLoans.AllowUserToAddRows = false;
            this.dgvLoans.AllowUserToDeleteRows = false;
            this.dgvLoans.AllowUserToOrderColumns = true;
            this.dgvLoans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoans.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLoans.Location = new System.Drawing.Point(3, 4);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoans.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLoans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoans.Size = new System.Drawing.Size(731, 161);
            this.dgvLoans.TabIndex = 1;
            this.dgvLoans.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvLoans_RowPrePaint);
            this.dgvLoans.SelectionChanged += new System.EventHandler(this.dgvLoans_SelectionChanged);
            this.dgvLoans.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvLoans_MouseDoubleClick);
            // 
            // dgvLedger
            // 
            this.dgvLedger.AllowUserToAddRows = false;
            this.dgvLedger.AllowUserToDeleteRows = false;
            this.dgvLedger.AllowUserToOrderColumns = true;
            this.dgvLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLedger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLedger.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvLedger.Location = new System.Drawing.Point(3, 200);
            this.dgvLedger.Name = "dgvLedger";
            this.dgvLedger.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLedger.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLedger.Size = new System.Drawing.Size(731, 233);
            this.dgvLedger.TabIndex = 0;
            this.dgvLedger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLedger_CellContentClick);
            this.dgvLedger.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLedger_CellFormatting);
            this.dgvLedger.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvLedger_RowPrePaint);
            this.dgvLedger.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvLedger_MouseDoubleClick);
            // 
            // LoanInformationUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 504);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoanInformationUi";
            this.Text = "Loan Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBorrower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNewBorrower;
        private System.Windows.Forms.ToolStripButton tsbNewLoan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.DataGridView dgvLedger;
        private System.Windows.Forms.ToolStripButton tsbNewPayment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsBorrower;
        private System.Windows.Forms.DataGridView dgvBorrowers;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.ToolStripButton tsbNewCharge;
        private System.Windows.Forms.ToolStripButton tsbPayments;
        private System.Windows.Forms.ToolStripDropDownButton tsbPrint;
        private System.Windows.Forms.ToolStripMenuItem tsmScheduleOfPayment;
        private System.Windows.Forms.ToolStripMenuItem tsmLedger;
        private System.Windows.Forms.ToolStripMenuItem tsmAgingByOffice;
        private System.Windows.Forms.ToolStripMenuItem tsmAgingOfReceivable;
        private System.Windows.Forms.ToolStripMenuItem tsmTodaysCollectible;

    }
}