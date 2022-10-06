
namespace LibrarySYS
{
    partial class frmWithdrawBook
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
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lbl_bookid = new System.Windows.Forms.Label();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.lbl_search_book = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.gpbBook = new System.Windows.Forms.GroupBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.lbl_author = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lbl_publisher = new System.Windows.Forms.Label();
            this.lbl_isbn = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_edition = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lbl_withdrawn = new System.Windows.Forms.Label();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.grdSearchBook = new System.Windows.Forms.DataGridView();
            this.btnSelectBook = new System.Windows.Forms.Button();
            this.gpbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchBook)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(336, 124);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(100, 22);
            this.txtBookID.TabIndex = 9;
            this.txtBookID.Visible = false;
            // 
            // lbl_bookid
            // 
            this.lbl_bookid.AutoSize = true;
            this.lbl_bookid.Location = new System.Drawing.Point(253, 130);
            this.lbl_bookid.Name = "lbl_bookid";
            this.lbl_bookid.Size = new System.Drawing.Size(65, 17);
            this.lbl_bookid.TabIndex = 36;
            this.lbl_bookid.Text = "Book ID: ";
            this.lbl_bookid.Visible = false;
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.AccessibleDescription = " Search";
            this.txtSearchBook.AccessibleName = " Search";
            this.txtSearchBook.Location = new System.Drawing.Point(336, 80);
            this.txtSearchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(100, 22);
            this.txtSearchBook.TabIndex = 1;
            // 
            // lbl_search_book
            // 
            this.lbl_search_book.AutoSize = true;
            this.lbl_search_book.Location = new System.Drawing.Point(253, 82);
            this.lbl_search_book.Name = "lbl_search_book";
            this.lbl_search_book.Size = new System.Drawing.Size(74, 17);
            this.lbl_search_book.TabIndex = 33;
            this.lbl_search_book.Text = "Book title: ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(7, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gpbBook
            // 
            this.gpbBook.Controls.Add(this.cboGenre);
            this.gpbBook.Controls.Add(this.lbl_title);
            this.gpbBook.Controls.Add(this.txtISBN);
            this.gpbBook.Controls.Add(this.txtTitle);
            this.gpbBook.Controls.Add(this.txtEdition);
            this.gpbBook.Controls.Add(this.lbl_author);
            this.gpbBook.Controls.Add(this.txtYear);
            this.gpbBook.Controls.Add(this.txtAuthor);
            this.gpbBook.Controls.Add(this.lbl_publisher);
            this.gpbBook.Controls.Add(this.lbl_isbn);
            this.gpbBook.Controls.Add(this.txtPublisher);
            this.gpbBook.Controls.Add(this.lbl_genre);
            this.gpbBook.Controls.Add(this.lbl_year);
            this.gpbBook.Controls.Add(this.lbl_edition);
            this.gpbBook.Enabled = false;
            this.gpbBook.Location = new System.Drawing.Point(251, 180);
            this.gpbBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbBook.Name = "gpbBook";
            this.gpbBook.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbBook.Size = new System.Drawing.Size(525, 327);
            this.gpbBook.TabIndex = 10;
            this.gpbBook.TabStop = false;
            this.gpbBook.Text = "Book Details";
            this.gpbBook.Visible = false;
            // 
            // cboGenre
            // 
            this.cboGenre.Enabled = false;
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(130, 201);
            this.cboGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(121, 24);
            this.cboGenre.TabIndex = 16;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(35, 53);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(43, 17);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title: ";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(130, 238);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(100, 22);
            this.txtISBN.TabIndex = 17;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(130, 50);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 11;
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(130, 174);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.ReadOnly = true;
            this.txtEdition.Size = new System.Drawing.Size(100, 22);
            this.txtEdition.TabIndex = 15;
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(35, 82);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(58, 17);
            this.lbl_author.TabIndex = 2;
            this.lbl_author.Text = "Author: ";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(130, 135);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 14;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(130, 78);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtAuthor.TabIndex = 12;
            // 
            // lbl_publisher
            // 
            this.lbl_publisher.AutoSize = true;
            this.lbl_publisher.Location = new System.Drawing.Point(35, 116);
            this.lbl_publisher.Name = "lbl_publisher";
            this.lbl_publisher.Size = new System.Drawing.Size(75, 17);
            this.lbl_publisher.TabIndex = 4;
            this.lbl_publisher.Text = "Publisher: ";
            // 
            // lbl_isbn
            // 
            this.lbl_isbn.AutoSize = true;
            this.lbl_isbn.Location = new System.Drawing.Point(35, 238);
            this.lbl_isbn.Name = "lbl_isbn";
            this.lbl_isbn.Size = new System.Drawing.Size(47, 17);
            this.lbl_isbn.TabIndex = 9;
            this.lbl_isbn.Text = "ISBN: ";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(130, 110);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(100, 22);
            this.txtPublisher.TabIndex = 13;
            // 
            // lbl_genre
            // 
            this.lbl_genre.AutoSize = true;
            this.lbl_genre.Location = new System.Drawing.Point(35, 208);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(56, 17);
            this.lbl_genre.TabIndex = 8;
            this.lbl_genre.Text = "Genre: ";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(35, 139);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(46, 17);
            this.lbl_year.TabIndex = 6;
            this.lbl_year.Text = "Year: ";
            // 
            // lbl_edition
            // 
            this.lbl_edition.AutoSize = true;
            this.lbl_edition.Location = new System.Drawing.Point(35, 178);
            this.lbl_edition.Name = "lbl_edition";
            this.lbl_edition.Size = new System.Drawing.Size(59, 17);
            this.lbl_edition.TabIndex = 7;
            this.lbl_edition.Text = "Edition: ";
            // 
            // btnChange
            // 
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(563, 513);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 25;
            this.btnChange.Text = "Change Status";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(387, 514);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStatus.MaximumSize = new System.Drawing.Size(149, 0);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(149, 24);
            this.cboStatus.TabIndex = 20;
            this.cboStatus.Visible = false;
            // 
            // lbl_withdrawn
            // 
            this.lbl_withdrawn.AutoSize = true;
            this.lbl_withdrawn.Location = new System.Drawing.Point(285, 516);
            this.lbl_withdrawn.Name = "lbl_withdrawn";
            this.lbl_withdrawn.Size = new System.Drawing.Size(82, 17);
            this.lbl_withdrawn.TabIndex = 28;
            this.lbl_withdrawn.Text = "Withdrawn: ";
            this.lbl_withdrawn.Visible = false;
            this.lbl_withdrawn.Click += new System.EventHandler(this.lbl_withdrawn_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(493, 78);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // grdSearchBook
            // 
            this.grdSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchBook.Location = new System.Drawing.Point(636, 78);
            this.grdSearchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdSearchBook.Name = "grdSearchBook";
            this.grdSearchBook.ReadOnly = true;
            this.grdSearchBook.RowHeadersWidth = 51;
            this.grdSearchBook.RowTemplate.Height = 24;
            this.grdSearchBook.Size = new System.Drawing.Size(240, 150);
            this.grdSearchBook.TabIndex = 5;
            this.grdSearchBook.Visible = false;
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.Enabled = false;
            this.btnSelectBook.Location = new System.Drawing.Point(493, 124);
            this.btnSelectBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(100, 23);
            this.btnSelectBook.TabIndex = 6;
            this.btnSelectBook.Text = "Select Boo&k";
            this.btnSelectBook.UseVisualStyleBackColor = true;
            this.btnSelectBook.Visible = false;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // frmWithdrawBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 755);
            this.Controls.Add(this.btnSelectBook);
            this.Controls.Add(this.grdSearchBook);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lbl_bookid);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.lbl_search_book);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gpbBook);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lbl_withdrawn);
            this.Controls.Add(this.btnSearchBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmWithdrawBook";
            this.Text = "Library System | Withdraw a book";
            this.gpbBook.ResumeLayout(false);
            this.gpbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lbl_bookid;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Label lbl_search_book;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gpbBook;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lbl_publisher;
        private System.Windows.Forms.Label lbl_isbn;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_edition;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lbl_withdrawn;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.DataGridView grdSearchBook;
        private System.Windows.Forms.Button btnSelectBook;
    }
}