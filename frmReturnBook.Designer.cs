
namespace LibrarySYS
{
    partial class frmReturnBook
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
            this.cboApplyFine = new System.Windows.Forms.ComboBox();
            this.lbl_fine_amount = new System.Windows.Forms.Label();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.lbl_applies_fine = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.lbl_search_book = new System.Windows.Forms.Label();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.grdSearchBook = new System.Windows.Forms.DataGridView();
            this.btnSelectBook = new System.Windows.Forms.Button();
            this.gpbBook = new System.Windows.Forms.GroupBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lbl_author = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lbl_isbn = new System.Windows.Forms.Label();
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
            this.gpbFine = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchBook)).BeginInit();
            this.gpbBook.SuspendLayout();
            this.gpbMember.SuspendLayout();
            this.gpbFine.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboApplyFine
            // 
            this.cboApplyFine.FormattingEnabled = true;
            this.cboApplyFine.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.cboApplyFine.Location = new System.Drawing.Point(151, 36);
            this.cboApplyFine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboApplyFine.Name = "cboApplyFine";
            this.cboApplyFine.Size = new System.Drawing.Size(121, 24);
            this.cboApplyFine.TabIndex = 49;
            // 
            // lbl_fine_amount
            // 
            this.lbl_fine_amount.AutoSize = true;
            this.lbl_fine_amount.Location = new System.Drawing.Point(7, 78);
            this.lbl_fine_amount.Name = "lbl_fine_amount";
            this.lbl_fine_amount.Size = new System.Drawing.Size(94, 17);
            this.lbl_fine_amount.TabIndex = 48;
            this.lbl_fine_amount.Text = "Fine amount: ";
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.Location = new System.Drawing.Point(151, 75);
            this.txtFineAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.ReadOnly = true;
            this.txtFineAmount.Size = new System.Drawing.Size(100, 22);
            this.txtFineAmount.TabIndex = 47;
            // 
            // lbl_applies_fine
            // 
            this.lbl_applies_fine.AutoSize = true;
            this.lbl_applies_fine.Location = new System.Drawing.Point(7, 39);
            this.lbl_applies_fine.Name = "lbl_applies_fine";
            this.lbl_applies_fine.Size = new System.Drawing.Size(135, 17);
            this.lbl_applies_fine.TabIndex = 46;
            this.lbl_applies_fine.Text = "Fine Applies Yes/No";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.Location = new System.Drawing.Point(440, 594);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(133, 62);
            this.btnReturnBook.TabIndex = 50;
            this.btnReturnBook.Text = "Return";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Visible = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // lbl_search_book
            // 
            this.lbl_search_book.AutoSize = true;
            this.lbl_search_book.Location = new System.Drawing.Point(140, 50);
            this.lbl_search_book.Name = "lbl_search_book";
            this.lbl_search_book.Size = new System.Drawing.Size(43, 17);
            this.lbl_search_book.TabIndex = 39;
            this.lbl_search_book.Text = "Title: ";
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(141, 89);
            this.txtSearchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(100, 22);
            this.txtSearchBook.TabIndex = 1;
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
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(141, 134);
            this.btnSearchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBook.TabIndex = 2;
            this.btnSearchBook.Text = "Search book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // grdSearchBook
            // 
            this.grdSearchBook.AccessibleName = " Book results";
            this.grdSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchBook.Location = new System.Drawing.Point(276, 50);
            this.grdSearchBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdSearchBook.Name = "grdSearchBook";
            this.grdSearchBook.ReadOnly = true;
            this.grdSearchBook.RowHeadersWidth = 51;
            this.grdSearchBook.RowTemplate.Height = 24;
            this.grdSearchBook.Size = new System.Drawing.Size(240, 150);
            this.grdSearchBook.TabIndex = 3;
            this.grdSearchBook.Visible = false;
            this.grdSearchBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSearchBook_CellContentClick);
            // 
            // btnSelectBook
            // 
            this.btnSelectBook.Location = new System.Drawing.Point(141, 178);
            this.btnSelectBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectBook.Name = "btnSelectBook";
            this.btnSelectBook.Size = new System.Drawing.Size(100, 23);
            this.btnSelectBook.TabIndex = 5;
            this.btnSelectBook.Text = "Select Boo&k";
            this.btnSelectBook.UseVisualStyleBackColor = true;
            this.btnSelectBook.Visible = false;
            this.btnSelectBook.Click += new System.EventHandler(this.btnSelectBook_Click);
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
            this.gpbBook.Location = new System.Drawing.Point(144, 254);
            this.gpbBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbBook.Name = "gpbBook";
            this.gpbBook.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbBook.Size = new System.Drawing.Size(277, 286);
            this.gpbBook.TabIndex = 10;
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
            this.txtBookID.Location = new System.Drawing.Point(130, 21);
            this.txtBookID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.ReadOnly = true;
            this.txtBookID.Size = new System.Drawing.Size(100, 22);
            this.txtBookID.TabIndex = 53;
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
            this.txtISBN.Location = new System.Drawing.Point(130, 130);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(100, 22);
            this.txtISBN.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.AccessibleName = " Title";
            this.txtTitle.Location = new System.Drawing.Point(130, 50);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
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
            this.txtAuthor.Location = new System.Drawing.Point(130, 78);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtAuthor.TabIndex = 3;
            // 
            // lbl_isbn
            // 
            this.lbl_isbn.AutoSize = true;
            this.lbl_isbn.Location = new System.Drawing.Point(35, 130);
            this.lbl_isbn.Name = "lbl_isbn";
            this.lbl_isbn.Size = new System.Drawing.Size(47, 17);
            this.lbl_isbn.TabIndex = 9;
            this.lbl_isbn.Text = "ISBN: ";
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
            this.gpbMember.Location = new System.Drawing.Point(612, 46);
            this.gpbMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbMember.Name = "gpbMember";
            this.gpbMember.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbMember.Size = new System.Drawing.Size(445, 327);
            this.gpbMember.TabIndex = 20;
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
            this.txtMemberID.TabIndex = 40;
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
            this.txtForename.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(211, 114);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 3;
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
            this.dtpDOB.TabIndex = 11;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(211, 150);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(100, 22);
            this.txtStreet.TabIndex = 5;
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
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(211, 178);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 7;
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
            // gpbFine
            // 
            this.gpbFine.Controls.Add(this.lbl_applies_fine);
            this.gpbFine.Controls.Add(this.cboApplyFine);
            this.gpbFine.Controls.Add(this.lbl_fine_amount);
            this.gpbFine.Controls.Add(this.txtFineAmount);
            this.gpbFine.Location = new System.Drawing.Point(612, 418);
            this.gpbFine.Margin = new System.Windows.Forms.Padding(4);
            this.gpbFine.Name = "gpbFine";
            this.gpbFine.Padding = new System.Windows.Forms.Padding(4);
            this.gpbFine.Size = new System.Drawing.Size(445, 123);
            this.gpbFine.TabIndex = 41;
            this.gpbFine.TabStop = false;
            this.gpbFine.Text = " Penalties";
            this.gpbFine.Visible = false;
            // 
            // frmReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 840);
            this.Controls.Add(this.gpbFine);
            this.Controls.Add(this.gpbMember);
            this.Controls.Add(this.gpbBook);
            this.Controls.Add(this.btnSelectBook);
            this.Controls.Add(this.grdSearchBook);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.lbl_search_book);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchBook);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmReturnBook";
            this.Text = "Library System | Return a book";
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchBook)).EndInit();
            this.gpbBook.ResumeLayout(false);
            this.gpbBook.PerformLayout();
            this.gpbMember.ResumeLayout(false);
            this.gpbMember.PerformLayout();
            this.gpbFine.ResumeLayout(false);
            this.gpbFine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboApplyFine;
        private System.Windows.Forms.Label lbl_fine_amount;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.Label lbl_applies_fine;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Label lbl_search_book;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.DataGridView grdSearchBook;
        private System.Windows.Forms.Button btnSelectBook;
        private System.Windows.Forms.GroupBox gpbBook;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lbl_isbn;
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
        private System.Windows.Forms.GroupBox gpbFine;
    }
}