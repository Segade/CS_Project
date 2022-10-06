
namespace LibrarySYS
{
    partial class frmLoanBook
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
            this.gpbMember = new System.Windows.Forms.GroupBox();
            this.lbl_memberid = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.lblSearchMember = new System.Windows.Forms.Label();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.grdSearchMember = new System.Windows.Forms.DataGridView();
            this.btnSelectMember = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbl_search_member = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbl_search_book = new System.Windows.Forms.Label();
            this.grdSearchBook = new System.Windows.Forms.DataGridView();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.lblSearchBook = new System.Windows.Forms.Label();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.gpbBook = new System.Windows.Forms.GroupBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbl_author = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lbl_isbn = new System.Windows.Forms.Label();
            this.btnSelectBook = new System.Windows.Forms.Button();
            this.gpbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchBook)).BeginInit();
            this.gpbBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMember
            // 
            this.gpbMember.Controls.Add(this.lbl_memberid);
            this.gpbMember.Controls.Add(this.txtMemberID);
            this.gpbMember.Controls.Add(this.lbl_surname);
            this.gpbMember.Controls.Add(this.lbl_name);
            this.gpbMember.Controls.Add(this.txtForename);
            this.gpbMember.Controls.Add(this.txtSurname);
            this.gpbMember.Controls.Add(this.lbl_address);
            this.gpbMember.Controls.Add(this.dtpDOB);
            this.gpbMember.Controls.Add(this.txtStreet);
            this.gpbMember.Controls.Add(this.lbl_dob);
            this.gpbMember.Controls.Add(this.lbl_phone);
            this.gpbMember.Controls.Add(this.txtEmail);
            this.gpbMember.Controls.Add(this.txtPhone);
            this.gpbMember.Controls.Add(this.lbl_email);
            this.gpbMember.Location = new System.Drawing.Point(112, 231);
            this.gpbMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbMember.Name = "gpbMember";
            this.gpbMember.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbMember.Size = new System.Drawing.Size(445, 286);
            this.gpbMember.TabIndex = 10;
            this.gpbMember.TabStop = false;
            this.gpbMember.Text = "Member details";
            this.gpbMember.Visible = false;
            // 
            // lbl_memberid
            // 
            this.lbl_memberid.AutoSize = true;
            this.lbl_memberid.Location = new System.Drawing.Point(85, 42);
            this.lbl_memberid.Name = "lbl_memberid";
            this.lbl_memberid.Size = new System.Drawing.Size(84, 17);
            this.lbl_memberid.TabIndex = 39;
            this.lbl_memberid.Text = "Member ID: ";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(211, 39);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(100, 22);
            this.txtMemberID.TabIndex = 11;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(85, 116);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(73, 17);
            this.lbl_surname.TabIndex = 2;
            this.lbl_surname.Text = "Surname: ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(85, 82);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(53, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name: ";
            // 
            // txtForename
            // 
            this.txtForename.AccessibleName = " Forename";
            this.txtForename.Location = new System.Drawing.Point(211, 78);
            this.txtForename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(100, 22);
            this.txtForename.TabIndex = 12;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(211, 114);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 13;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(85, 155);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(54, 17);
            this.lbl_address.TabIndex = 4;
            this.lbl_address.Text = "Street: ";
            // 
            // dtpDOB
            // 
            this.dtpDOB.AccessibleName = " Date of Birth";
            this.dtpDOB.Location = new System.Drawing.Point(211, 234);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 17;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(211, 150);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(100, 22);
            this.txtStreet.TabIndex = 14;
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(85, 238);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(95, 17);
            this.lbl_dob.TabIndex = 10;
            this.lbl_dob.Text = "Date of Birth: ";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(85, 183);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(53, 17);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(211, 206);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(211, 178);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 15;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(85, 210);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(50, 17);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email: ";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.AccessibleName = "Search member by surname";
            this.txtSearchMember.Location = new System.Drawing.Point(181, 50);
            this.txtSearchMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(100, 22);
            this.txtSearchMember.TabIndex = 1;
            // 
            // lblSearchMember
            // 
            this.lblSearchMember.AutoSize = true;
            this.lblSearchMember.Location = new System.Drawing.Point(108, 48);
            this.lblSearchMember.Name = "lblSearchMember";
            this.lblSearchMember.Size = new System.Drawing.Size(73, 17);
            this.lblSearchMember.TabIndex = 41;
            this.lblSearchMember.Text = "Surname: ";
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(295, 50);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "Search Member";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // grdSearchMember
            // 
            this.grdSearchMember.AccessibleName = " Member results";
            this.grdSearchMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchMember.Location = new System.Drawing.Point(110, 75);
            this.grdSearchMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdSearchMember.Name = "grdSearchMember";
            this.grdSearchMember.ReadOnly = true;
            this.grdSearchMember.RowHeadersWidth = 51;
            this.grdSearchMember.RowTemplate.Height = 24;
            this.grdSearchMember.Size = new System.Drawing.Size(477, 107);
            this.grdSearchMember.TabIndex = 8;
            this.grdSearchMember.Visible = false;
            this.grdSearchMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSearchMember_CellClick);
            this.grdSearchMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSearchMember_CellContentClick);
            // 
            // btnSelectMember
            // 
            this.btnSelectMember.Enabled = false;
            this.btnSelectMember.Location = new System.Drawing.Point(112, 194);
            this.btnSelectMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectMember.Name = "btnSelectMember";
            this.btnSelectMember.Size = new System.Drawing.Size(120, 23);
            this.btnSelectMember.TabIndex = 9;
            this.btnSelectMember.Text = "Select Me&mber";
            this.btnSelectMember.UseVisualStyleBackColor = true;
            this.btnSelectMember.Visible = false;
            this.btnSelectMember.Click += new System.EventHandler(this.btnSelectMember_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Enabled = false;
            this.btnBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBook.Location = new System.Drawing.Point(631, 494);
            this.btnBorrowBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(206, 30);
            this.btnBorrowBook.TabIndex = 57;
            this.btnBorrowBook.Text = "F&inalise Loan";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Visible = false;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 42);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbl_search_member
            // 
            this.lbl_search_member.AutoSize = true;
            this.lbl_search_member.Location = new System.Drawing.Point(107, 18);
            this.lbl_search_member.Name = "lbl_search_member";
            this.lbl_search_member.Size = new System.Drawing.Size(116, 17);
            this.lbl_search_member.TabIndex = 51;
            this.lbl_search_member.Text = "Search Member: ";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Enabled = false;
            this.btnAddBook.Location = new System.Drawing.Point(100, 137);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(160, 23);
            this.btnAddBook.TabIndex = 54;
            this.btnAddBook.Text = " Ad&d book to loan";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Visible = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 16;
            this.lstBooks.Location = new System.Drawing.Point(631, 407);
            this.lstBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(327, 84);
            this.lstBooks.TabIndex = 55;
            this.lstBooks.Visible = false;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(973, 407);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "De&lete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbl_search_book
            // 
            this.lbl_search_book.AutoSize = true;
            this.lbl_search_book.Location = new System.Drawing.Point(628, 18);
            this.lbl_search_book.Name = "lbl_search_book";
            this.lbl_search_book.Size = new System.Drawing.Size(97, 17);
            this.lbl_search_book.TabIndex = 63;
            this.lbl_search_book.Text = "Search Book: ";
            // 
            // grdSearchBook
            // 
            this.grdSearchBook.AccessibleName = " Book results";
            this.grdSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchBook.Location = new System.Drawing.Point(631, 75);
            this.grdSearchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdSearchBook.Name = "grdSearchBook";
            this.grdSearchBook.ReadOnly = true;
            this.grdSearchBook.RowHeadersWidth = 51;
            this.grdSearchBook.RowTemplate.Height = 24;
            this.grdSearchBook.Size = new System.Drawing.Size(240, 107);
            this.grdSearchBook.TabIndex = 25;
            this.grdSearchBook.Visible = false;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(793, 40);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBook.TabIndex = 21;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Visible = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Location = new System.Drawing.Point(628, 46);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(43, 17);
            this.lblSearchBook.TabIndex = 60;
            this.lblSearchBook.Text = "Title: ";
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.AccessibleName = "Search book by title";
            this.txtSearchBook.Location = new System.Drawing.Point(674, 42);
            this.txtSearchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(100, 22);
            this.txtSearchBook.TabIndex = 20;
            this.txtSearchBook.Visible = false;
            // 
            // gpbBook
            // 
            this.gpbBook.Controls.Add(this.lblBookID);
            this.gpbBook.Controls.Add(this.txtBookID);
            this.gpbBook.Controls.Add(this.lbl_title);
            this.gpbBook.Controls.Add(this.txtISBN);
            this.gpbBook.Controls.Add(this.txtTitle);
            this.gpbBook.Controls.Add(this.lbl_author);
            this.gpbBook.Controls.Add(this.txtAuthor);
            this.gpbBook.Controls.Add(this.lbl_isbn);
            this.gpbBook.Controls.Add(this.btnAddBook);
            this.gpbBook.Location = new System.Drawing.Point(631, 232);
            this.gpbBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbBook.Name = "gpbBook";
            this.gpbBook.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbBook.Size = new System.Drawing.Size(417, 170);
            this.gpbBook.TabIndex = 30;
            this.gpbBook.TabStop = false;
            this.gpbBook.Text = "Book Details";
            this.gpbBook.Visible = false;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(35, 26);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(57, 17);
            this.lblBookID.TabIndex = 52;
            this.lblBookID.Text = "BookID:";
            // 
            // txtBookID
            // 
            this.txtBookID.AccessibleName = "Book ID";
            this.txtBookID.Location = new System.Drawing.Point(100, 21);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(100, 22);
            this.txtBookID.TabIndex = 53;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(39, 54);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(43, 17);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Title: ";
            // 
            // txtISBN
            // 
            this.txtISBN.AccessibleName = " ISBN";
            this.txtISBN.Location = new System.Drawing.Point(98, 104);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(162, 22);
            this.txtISBN.TabIndex = 13;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.AccessibleName = " Title";
            this.txtTitle.Location = new System.Drawing.Point(100, 54);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(295, 22);
            this.txtTitle.TabIndex = 1;
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
            // txtAuthor
            // 
            this.txtAuthor.AccessibleName = " Author";
            this.txtAuthor.Location = new System.Drawing.Point(98, 78);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(217, 22);
            this.txtAuthor.TabIndex = 3;
            // 
            // lbl_isbn
            // 
            this.lbl_isbn.AutoSize = true;
            this.lbl_isbn.Location = new System.Drawing.Point(35, 104);
            this.lbl_isbn.Name = "lbl_isbn";
            this.lbl_isbn.Size = new System.Drawing.Size(47, 17);
            this.lbl_isbn.TabIndex = 9;
            this.lbl_isbn.Text = "ISBN: ";
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.Enabled = false;
            this.btnSelectBook.Location = new System.Drawing.Point(631, 194);
            this.btnSelectBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(100, 23);
            this.btnSelectBook.TabIndex = 26;
            this.btnSelectBook.Text = "Select Boo&k";
            this.btnSelectBook.UseVisualStyleBackColor = true;
            this.btnSelectBook.Visible = false;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
            // 
            // frmLoanBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 539);
            this.Controls.Add(this.lbl_search_book);
            this.Controls.Add(this.btnSelectBook);
            this.Controls.Add(this.grdSearchBook);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.lblSearchBook);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.gpbBook);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.lbl_search_member);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.btnSelectMember);
            this.Controls.Add(this.grdSearchMember);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.lblSearchMember);
            this.Controls.Add(this.txtSearchMember);
            this.Controls.Add(this.gpbMember);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLoanBook";
            this.Text = "Library System | Loan a book";
            this.Load += new System.EventHandler(this.frmLoanBook_Load);
            this.gpbMember.ResumeLayout(false);
            this.gpbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchBook)).EndInit();
            this.gpbBook.ResumeLayout(false);
            this.gpbBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMember;
        private System.Windows.Forms.Label lbl_memberid;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Label lblSearchMember;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.DataGridView grdSearchMember;
        private System.Windows.Forms.Button btnSelectMember;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbl_search_member;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbl_search_book;
        private System.Windows.Forms.DataGridView grdSearchBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.Label lblSearchBook;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.GroupBox gpbBook;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lbl_isbn;
        private System.Windows.Forms.Button btnSelectBook;
    }
}