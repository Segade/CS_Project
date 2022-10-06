
namespace LibrarySYS
{
    partial class frmCatalogueBook
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCatalogue = new System.Windows.Forms.Button();
            this.gpbBook.SuspendLayout();
            this.SuspendLayout();
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
            this.gpbBook.Location = new System.Drawing.Point(180, 82);
            this.gpbBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbBook.Name = "gpbBook";
            this.gpbBook.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbBook.Size = new System.Drawing.Size(525, 327);
            this.gpbBook.TabIndex = 2;
            this.gpbBook.TabStop = false;
            this.gpbBook.Text = "Book Details";
            // 
            // cboGenre
            // 
            this.cboGenre.AccessibleName = " Genre";
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(130, 201);
            this.cboGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(121, 24);
            this.cboGenre.TabIndex = 6;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(35, 52);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(43, 17);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title: ";
            // 
            // txtISBN
            // 
            this.txtISBN.AccessibleName = " ISBN";
            this.txtISBN.Location = new System.Drawing.Point(130, 238);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISBN.MaxLength = 20;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 22);
            this.txtISBN.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.AccessibleName = " Title";
            this.txtTitle.Location = new System.Drawing.Point(130, 50);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.MaxLength = 30;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // txtEdition
            // 
            this.txtEdition.AccessibleName = " Edition";
            this.txtEdition.Location = new System.Drawing.Point(130, 172);
            this.txtEdition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdition.MaxLength = 25;
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(100, 22);
            this.txtEdition.TabIndex = 5;
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
            this.txtYear.AccessibleName = " Year";
            this.txtYear.Location = new System.Drawing.Point(130, 135);
            this.txtYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 4;
            // 
            // txtAuthor
            // 
            this.txtAuthor.AccessibleName = " Author";
            this.txtAuthor.Location = new System.Drawing.Point(130, 78);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthor.MaxLength = 30;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtAuthor.TabIndex = 2;
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
            this.txtPublisher.AccessibleName = "Publisher";
            this.txtPublisher.Location = new System.Drawing.Point(130, 110);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPublisher.MaxLength = 25;
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(100, 22);
            this.txtPublisher.TabIndex = 3;
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCatalogue
            // 
            this.btnCatalogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogue.Location = new System.Drawing.Point(363, 450);
            this.btnCatalogue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCatalogue.Name = "btnCatalogue";
            this.btnCatalogue.Size = new System.Drawing.Size(133, 62);
            this.btnCatalogue.TabIndex = 10;
            this.btnCatalogue.Text = "Catalogue Book ";
            this.btnCatalogue.UseVisualStyleBackColor = true;
            this.btnCatalogue.Click += new System.EventHandler(this.btnCatalogue_Click);
            // 
            // frmCatalogueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 702);
            this.Controls.Add(this.btnCatalogue);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gpbBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCatalogueBook";
            this.Text = "Library System | Catalogue a book";
            this.Load += new System.EventHandler(this.frmCatalogueBook_Load);
            this.gpbBook.ResumeLayout(false);
            this.gpbBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCatalogue;
    }
}