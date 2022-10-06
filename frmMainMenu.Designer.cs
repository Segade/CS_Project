
namespace LibrarySYS
{
    partial class frmMainMenu
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
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCatalogueBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDrawBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoanBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPayFine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporting = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGenreAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBook,
            this.mnuMember,
            this.mnuLoan,
            this.mnuReporting});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.mnuMainMenu.Size = new System.Drawing.Size(982, 28);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuBook
            // 
            this.mnuBook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCatalogueBook,
            this.mnuDrawBook});
            this.mnuBook.Name = "mnuBook";
            this.mnuBook.Size = new System.Drawing.Size(57, 24);
            this.mnuBook.Text = "Book";
            // 
            // mnuCatalogueBook
            // 
            this.mnuCatalogueBook.Name = "mnuCatalogueBook";
            this.mnuCatalogueBook.Size = new System.Drawing.Size(198, 26);
            this.mnuCatalogueBook.Text = "Catalogue Book";
            this.mnuCatalogueBook.Click += new System.EventHandler(this.mnuCatalogueBook_Click);
            // 
            // mnuDrawBook
            // 
            this.mnuDrawBook.Name = "mnuDrawBook";
            this.mnuDrawBook.Size = new System.Drawing.Size(198, 26);
            this.mnuDrawBook.Text = "Withdraw Book";
            this.mnuDrawBook.Click += new System.EventHandler(this.mnuDrawBook_Click);
            // 
            // mnuMember
            // 
            this.mnuMember.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddMember,
            this.mnuUpdateMember,
            this.mnuViewMember});
            this.mnuMember.Name = "mnuMember";
            this.mnuMember.Size = new System.Drawing.Size(79, 24);
            this.mnuMember.Text = "Member";
            // 
            // mnuAddMember
            // 
            this.mnuAddMember.Name = "mnuAddMember";
            this.mnuAddMember.Size = new System.Drawing.Size(213, 26);
            this.mnuAddMember.Text = "Add a Member";
            this.mnuAddMember.Click += new System.EventHandler(this.mnuAddMember_Click);
            // 
            // mnuUpdateMember
            // 
            this.mnuUpdateMember.Name = "mnuUpdateMember";
            this.mnuUpdateMember.Size = new System.Drawing.Size(213, 26);
            this.mnuUpdateMember.Text = "Update a Member";
            this.mnuUpdateMember.Click += new System.EventHandler(this.mnuUpdateMember_Click);
            // 
            // mnuViewMember
            // 
            this.mnuViewMember.Name = "mnuViewMember";
            this.mnuViewMember.Size = new System.Drawing.Size(213, 26);
            this.mnuViewMember.Text = "View a Member";
            this.mnuViewMember.Click += new System.EventHandler(this.mnuViewMember_Click);
            // 
            // mnuLoan
            // 
            this.mnuLoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoanBook,
            this.mnuReturnBook,
            this.mnuPayFine});
            this.mnuLoan.Name = "mnuLoan";
            this.mnuLoan.Size = new System.Drawing.Size(61, 24);
            this.mnuLoan.Text = "Loans";
            this.mnuLoan.Click += new System.EventHandler(this.mnuLoan_Click);
            // 
            // mnuLoanBook
            // 
            this.mnuLoanBook.Name = "mnuLoanBook";
            this.mnuLoanBook.Size = new System.Drawing.Size(190, 26);
            this.mnuLoanBook.Text = "Borrow a Book";
            this.mnuLoanBook.Click += new System.EventHandler(this.mnuLoanBook_Click);
            // 
            // mnuReturnBook
            // 
            this.mnuReturnBook.Name = "mnuReturnBook";
            this.mnuReturnBook.Size = new System.Drawing.Size(190, 26);
            this.mnuReturnBook.Text = "Return a Book";
            this.mnuReturnBook.Click += new System.EventHandler(this.mnuReturnBook_Click);
            // 
            // mnuPayFine
            // 
            this.mnuPayFine.Name = "mnuPayFine";
            this.mnuPayFine.Size = new System.Drawing.Size(190, 26);
            this.mnuPayFine.Text = "Pay a Fine";
            this.mnuPayFine.Click += new System.EventHandler(this.mnuPayFine_Click);
            // 
            // mnuReporting
            // 
            this.mnuReporting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearAnalysis,
            this.mnuGenreAnalysis});
            this.mnuReporting.Name = "mnuReporting";
            this.mnuReporting.Size = new System.Drawing.Size(89, 24);
            this.mnuReporting.Text = "Reporting";
            // 
            // mnuYearAnalysis
            // 
            this.mnuYearAnalysis.Name = "mnuYearAnalysis";
            this.mnuYearAnalysis.Size = new System.Drawing.Size(188, 26);
            this.mnuYearAnalysis.Text = "Yearly Analysis";
            this.mnuYearAnalysis.Click += new System.EventHandler(this.mnuYearAnalysis_Click);
            // 
            // mnuGenreAnalysis
            // 
            this.mnuGenreAnalysis.Name = "mnuGenreAnalysis";
            this.mnuGenreAnalysis.Size = new System.Drawing.Size(188, 26);
            this.mnuGenreAnalysis.Text = "Genre Report";
            this.mnuGenreAnalysis.Click += new System.EventHandler(this.mnuGenreAnalysis_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 840);
            this.Controls.Add(this.mnuMainMenu);
            this.Name = "frmMainMenu";
            this.Text = "Library System | Main menu";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBook;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalogueBook;
        private System.Windows.Forms.ToolStripMenuItem mnuDrawBook;
        private System.Windows.Forms.ToolStripMenuItem mnuMember;
        private System.Windows.Forms.ToolStripMenuItem mnuAddMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateMember;
        private System.Windows.Forms.ToolStripMenuItem mnuViewMember;
        private System.Windows.Forms.ToolStripMenuItem mnuLoan;
        private System.Windows.Forms.ToolStripMenuItem mnuLoanBook;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnBook;
        private System.Windows.Forms.ToolStripMenuItem mnuPayFine;
        private System.Windows.Forms.ToolStripMenuItem mnuReporting;
        private System.Windows.Forms.ToolStripMenuItem mnuYearAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuGenreAnalysis;
    }
}