
namespace LibrarySYS
{
    partial class frmRevenueAnalysis
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
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.grdYearlyRev = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSelectYear = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdYearlyRev)).BeginInit();
            this.SuspendLayout();
            // 
            // cboYears
            // 
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(172, 77);
            this.cboYears.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(108, 24);
            this.cboYears.TabIndex = 0;
            this.cboYears.SelectedIndexChanged += new System.EventHandler(this.cboYears_SelectedIndexChanged);
            // 
            // grdYearlyRev
            // 
            this.grdYearlyRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYearlyRev.Location = new System.Drawing.Point(75, 174);
            this.grdYearlyRev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdYearlyRev.Name = "grdYearlyRev";
            this.grdYearlyRev.RowHeadersVisible = false;
            this.grdYearlyRev.RowHeadersWidth = 62;
            this.grdYearlyRev.RowTemplate.Height = 28;
            this.grdYearlyRev.Size = new System.Drawing.Size(626, 120);
            this.grdYearlyRev.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(0, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 17);
            this.lblTitle.TabIndex = 2;
            // 
            // lblSelectYear
            // 
            this.lblSelectYear.AutoSize = true;
            this.lblSelectYear.Location = new System.Drawing.Point(81, 77);
            this.lblSelectYear.Name = "lblSelectYear";
            this.lblSelectYear.Size = new System.Drawing.Size(87, 17);
            this.lblSelectYear.TabIndex = 3;
            this.lblSelectYear.Text = "Select year: ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 28);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSelectYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdYearlyRev);
            this.Controls.Add(this.cboYears);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRevenueAnalysis";
            this.Text = "Library System | Revenue analysis";
            this.Load += new System.EventHandler(this.frmRevenueAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdYearlyRev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.DataGridView grdYearlyRev;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSelectYear;
        private System.Windows.Forms.Button btnBack;
    }
}