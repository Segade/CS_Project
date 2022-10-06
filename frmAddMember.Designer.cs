
namespace LibrarySYS
{
    partial class frmAddMember
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
            this.gpb_member = new System.Windows.Forms.GroupBox();
            this.lbl_town = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lbl_county = new System.Windows.Forms.Label();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.lbl_eircode = new System.Windows.Forms.Label();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lbl_street = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gpb_member.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_member
            // 
            this.gpb_member.Controls.Add(this.lbl_town);
            this.gpb_member.Controls.Add(this.txtTown);
            this.gpb_member.Controls.Add(this.lbl_county);
            this.gpb_member.Controls.Add(this.cboCounty);
            this.gpb_member.Controls.Add(this.lbl_eircode);
            this.gpb_member.Controls.Add(this.txtEircode);
            this.gpb_member.Controls.Add(this.lbl_surname);
            this.gpb_member.Controls.Add(this.lbl_name);
            this.gpb_member.Controls.Add(this.txtForename);
            this.gpb_member.Controls.Add(this.txtSurname);
            this.gpb_member.Controls.Add(this.lbl_street);
            this.gpb_member.Controls.Add(this.dtpDOB);
            this.gpb_member.Controls.Add(this.txtStreet);
            this.gpb_member.Controls.Add(this.lbl_dob);
            this.gpb_member.Controls.Add(this.lbl_phone);
            this.gpb_member.Controls.Add(this.txtEmail);
            this.gpb_member.Controls.Add(this.txtPhone);
            this.gpb_member.Controls.Add(this.lbl_email);
            this.gpb_member.Location = new System.Drawing.Point(174, 50);
            this.gpb_member.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_member.Name = "gpb_member";
            this.gpb_member.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpb_member.Size = new System.Drawing.Size(445, 340);
            this.gpb_member.TabIndex = 2;
            this.gpb_member.TabStop = false;
            this.gpb_member.Text = "Member details";
            // 
            // lbl_town
            // 
            this.lbl_town.AutoSize = true;
            this.lbl_town.Location = new System.Drawing.Point(85, 150);
            this.lbl_town.Name = "lbl_town";
            this.lbl_town.Size = new System.Drawing.Size(50, 17);
            this.lbl_town.TabIndex = 19;
            this.lbl_town.Text = "Town: ";
            // 
            // txtTown
            // 
            this.txtTown.AccessibleName = " Town";
            this.txtTown.Location = new System.Drawing.Point(211, 146);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(100, 22);
            this.txtTown.TabIndex = 4;
            // 
            // lbl_county
            // 
            this.lbl_county.AutoSize = true;
            this.lbl_county.Location = new System.Drawing.Point(87, 187);
            this.lbl_county.Name = "lbl_county";
            this.lbl_county.Size = new System.Drawing.Size(56, 17);
            this.lbl_county.TabIndex = 21;
            this.lbl_county.Text = "County:";
            // 
            // cboCounty
            // 
            this.cboCounty.AccessibleName = "counties";
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(211, 178);
            this.cboCounty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(121, 24);
            this.cboCounty.TabIndex = 5;
            // 
            // lbl_eircode
            // 
            this.lbl_eircode.AutoSize = true;
            this.lbl_eircode.Location = new System.Drawing.Point(87, 215);
            this.lbl_eircode.Name = "lbl_eircode";
            this.lbl_eircode.Size = new System.Drawing.Size(64, 17);
            this.lbl_eircode.TabIndex = 23;
            this.lbl_eircode.Text = "Eircode: ";
            // 
            // txtEircode
            // 
            this.txtEircode.AccessibleName = " Eircode";
            this.txtEircode.Location = new System.Drawing.Point(211, 210);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(100, 22);
            this.txtEircode.TabIndex = 6;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(85, 82);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(73, 17);
            this.lbl_surname.TabIndex = 2;
            this.lbl_surname.Text = "Surname: ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(85, 52);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(80, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Forename: ";
            // 
            // txtForename
            // 
            this.txtForename.AccessibleName = "Forename";
            this.txtForename.Location = new System.Drawing.Point(211, 50);
            this.txtForename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 22);
            this.txtForename.TabIndex = 1;
            // 
            // txtSurname
            // 
            this.txtSurname.AccessibleName = " Surname";
            this.txtSurname.Location = new System.Drawing.Point(211, 78);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.MaxLength = 30;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 2;
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Location = new System.Drawing.Point(87, 122);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(54, 17);
            this.lbl_street.TabIndex = 4;
            this.lbl_street.Text = "Street: ";
            // 
            // dtpDOB
            // 
            this.dtpDOB.AccessibleName = "date of birth";
            this.dtpDOB.Location = new System.Drawing.Point(211, 294);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 9;
            // 
            // txtStreet
            // 
            this.txtStreet.AccessibleName = " Street";
            this.txtStreet.Location = new System.Drawing.Point(211, 117);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.MaxLength = 50;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 22);
            this.txtStreet.TabIndex = 3;
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(85, 299);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(95, 17);
            this.lbl_dob.TabIndex = 10;
            this.lbl_dob.Text = "Date of Birth: ";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(87, 242);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(53, 17);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleName = " Email";
            this.txtEmail.Location = new System.Drawing.Point(211, 266);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.AccessibleName = " Phone";
            this.txtPhone.Location = new System.Drawing.Point(211, 238);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(85, 270);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(50, 17);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email: ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(29, 50);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(386, 452);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 62);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add Member";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 702);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gpb_member);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddMember";
            this.Text = "Library System | Add a member";
            this.Load += new System.EventHandler(this.frmAddMember_Load);
            this.gpb_member.ResumeLayout(false);
            this.gpb_member.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_member;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl_town;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lbl_county;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.Label lbl_eircode;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lbl_street;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbl_email;
    }
}