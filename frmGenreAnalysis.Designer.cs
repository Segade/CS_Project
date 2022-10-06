
namespace LibrarySYS
{
    partial class frmGenreAnalysis
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
            this.btnBack = new System.Windows.Forms.Button();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.cboGenres = new System.Windows.Forms.ComboBox();
            this.btnGenerateRep = new System.Windows.Forms.Button();
            this.grdYearlyRev = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblgenre = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdYearlyRev)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboYears
            // 
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(149, 59);
            this.cboYears.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(108, 24);
            this.cboYears.TabIndex = 1;
            // 
            // cboGenres
            // 
            this.cboGenres.FormattingEnabled = true;
            this.cboGenres.Location = new System.Drawing.Point(391, 59);
            this.cboGenres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGenres.Name = "cboGenres";
            this.cboGenres.Size = new System.Drawing.Size(108, 24);
            this.cboGenres.TabIndex = 2;
            // 
            // btnGenerateRep
            // 
            this.btnGenerateRep.Location = new System.Drawing.Point(528, 59);
            this.btnGenerateRep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateRep.Name = "btnGenerateRep";
            this.btnGenerateRep.Size = new System.Drawing.Size(88, 26);
            this.btnGenerateRep.TabIndex = 3;
            this.btnGenerateRep.Text = "Generate report";
            this.btnGenerateRep.UseVisualStyleBackColor = true;
            this.btnGenerateRep.Click += new System.EventHandler(this.btnGenerateRep_Click);
            // 
            // grdYearlyRev
            // 
            this.grdYearlyRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYearlyRev.Location = new System.Drawing.Point(21, 184);
            this.grdYearlyRev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdYearlyRev.Name = "grdYearlyRev";
            this.grdYearlyRev.RowHeadersVisible = false;
            this.grdYearlyRev.RowHeadersWidth = 62;
            this.grdYearlyRev.RowTemplate.Height = 28;
            this.grdYearlyRev.Size = new System.Drawing.Size(628, 120);
            this.grdYearlyRev.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(271, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 17);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Genre analysis";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblgenre
            // 
            this.lblgenre.AutoSize = true;
            this.lblgenre.Location = new System.Drawing.Point(277, 62);
            this.lblgenre.Name = "lblgenre";
            this.lblgenre.Size = new System.Drawing.Size(96, 17);
            this.lblgenre.TabIndex = 6;
            this.lblgenre.Text = "Select genre: ";
            // 
            // lblyear
            // 
            this.lblyear.AutoSize = true;
            this.lblyear.Location = new System.Drawing.Point(27, 60);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(87, 17);
            this.lblyear.TabIndex = 7;
            this.lblyear.Text = "Select year: ";
            // 
            // frmGenreAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblgenre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdYearlyRev);
            this.Controls.Add(this.btnGenerateRep);
            this.Controls.Add(this.cboGenres);
            this.Controls.Add(this.cboYears);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGenreAnalysis";
            this.Text = "Library System | Genre analysis";
            this.Load += new System.EventHandler(this.frmGenreAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdYearlyRev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.ComboBox cboGenres;
        private System.Windows.Forms.Button btnGenerateRep;
        private System.Windows.Forms.DataGridView grdYearlyRev;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblgenre;
        private System.Windows.Forms.Label lblyear;
    }
}