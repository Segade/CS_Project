
namespace LibrarySYS
{
    partial class frmView
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
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbl_memberid = new System.Windows.Forms.Label();
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
            this.gpbMember = new System.Windows.Forms.GroupBox();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.lbl_search_member = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.grdSearchMember = new System.Windows.Forms.DataGridView();
            this.btnSelectMember = new System.Windows.Forms.Button();
            this.gpbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchMember)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(303, 108);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(100, 22);
            this.txtMemberID.TabIndex = 9;
            // 
            // lbl_memberid
            // 
            this.lbl_memberid.AutoSize = true;
            this.lbl_memberid.Location = new System.Drawing.Point(170, 111);
            this.lbl_memberid.Name = "lbl_memberid";
            this.lbl_memberid.Size = new System.Drawing.Size(84, 17);
            this.lbl_memberid.TabIndex = 49;
            this.lbl_memberid.Text = "Member ID: ";
            // 
            // lbl_town
            // 
            this.lbl_town.AutoSize = true;
            this.lbl_town.Location = new System.Drawing.Point(86, 150);
            this.lbl_town.Name = "lbl_town";
            this.lbl_town.Size = new System.Drawing.Size(50, 17);
            this.lbl_town.TabIndex = 19;
            this.lbl_town.Text = "Town: ";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(210, 145);
            this.txtTown.Name = "txtTown";
            this.txtTown.ReadOnly = true;
            this.txtTown.Size = new System.Drawing.Size(100, 22);
            this.txtTown.TabIndex = 14;
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
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(210, 180);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(121, 24);
            this.cboCounty.TabIndex = 16;
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
            this.txtEircode.Location = new System.Drawing.Point(210, 210);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.ReadOnly = true;
            this.txtEircode.Size = new System.Drawing.Size(100, 22);
            this.txtEircode.TabIndex = 15;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(86, 82);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(73, 17);
            this.lbl_surname.TabIndex = 12;
            this.lbl_surname.Text = "Surname: ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(86, 52);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(80, 17);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Forename: ";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(210, 49);
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(100, 22);
            this.txtForename.TabIndex = 11;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(210, 77);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 3;
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
            this.dtpDOB.Location = new System.Drawing.Point(210, 294);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 19;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(210, 117);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(100, 22);
            this.txtStreet.TabIndex = 13;
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(86, 299);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(95, 17);
            this.lbl_dob.TabIndex = 10;
            this.lbl_dob.Text = "Date of Birth: ";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Location = new System.Drawing.Point(87, 243);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(53, 17);
            this.lbl_phone.TabIndex = 6;
            this.lbl_phone.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(210, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(210, 238);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 17;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(86, 271);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(50, 17);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email: ";
            // 
            // gpbMember
            // 
            this.gpbMember.Controls.Add(this.lbl_town);
            this.gpbMember.Controls.Add(this.txtTown);
            this.gpbMember.Controls.Add(this.lbl_county);
            this.gpbMember.Controls.Add(this.cboCounty);
            this.gpbMember.Controls.Add(this.lbl_eircode);
            this.gpbMember.Controls.Add(this.txtEircode);
            this.gpbMember.Controls.Add(this.lbl_surname);
            this.gpbMember.Controls.Add(this.lbl_name);
            this.gpbMember.Controls.Add(this.txtForename);
            this.gpbMember.Controls.Add(this.txtSurname);
            this.gpbMember.Controls.Add(this.lbl_street);
            this.gpbMember.Controls.Add(this.dtpDOB);
            this.gpbMember.Controls.Add(this.txtStreet);
            this.gpbMember.Controls.Add(this.lbl_dob);
            this.gpbMember.Controls.Add(this.lbl_phone);
            this.gpbMember.Controls.Add(this.txtEmail);
            this.gpbMember.Controls.Add(this.txtPhone);
            this.gpbMember.Controls.Add(this.lbl_email);
            this.gpbMember.Location = new System.Drawing.Point(162, 149);
            this.gpbMember.Name = "gpbMember";
            this.gpbMember.Size = new System.Drawing.Size(446, 340);
            this.gpbMember.TabIndex = 10;
            this.gpbMember.TabStop = false;
            this.gpbMember.Text = "Member details";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Location = new System.Drawing.Point(302, 69);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(100, 22);
            this.txtSearchMember.TabIndex = 1;
            // 
            // lbl_search_member
            // 
            this.lbl_search_member.AutoSize = true;
            this.lbl_search_member.Location = new System.Drawing.Point(170, 69);
            this.lbl_search_member.Name = "lbl_search_member";
            this.lbl_search_member.Size = new System.Drawing.Size(126, 17);
            this.lbl_search_member.TabIndex = 44;
            this.lbl_search_member.Text = "Member surname: ";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(418, 69);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "Search Member";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // grdSearchMember
            // 
            this.grdSearchMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchMember.Location = new System.Drawing.Point(579, 69);
            this.grdSearchMember.Name = "grdSearchMember";
            this.grdSearchMember.RowHeadersWidth = 51;
            this.grdSearchMember.RowTemplate.Height = 24;
            this.grdSearchMember.Size = new System.Drawing.Size(240, 150);
            this.grdSearchMember.TabIndex = 5;
            // 
            // btnSelectMember
            // 
            this.btnSelectMember.Location = new System.Drawing.Point(418, 108);
            this.btnSelectMember.Name = "btnSelectMember";
            this.btnSelectMember.Size = new System.Drawing.Size(120, 23);
            this.btnSelectMember.TabIndex = 6;
            this.btnSelectMember.Text = "Select Me&mber";
            this.btnSelectMember.UseVisualStyleBackColor = true;
            this.btnSelectMember.Click += new System.EventHandler(this.btnSelectMember_Click);
            // 
            // frmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 840);
            this.Controls.Add(this.btnSelectMember);
            this.Controls.Add(this.grdSearchMember);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lbl_memberid);
            this.Controls.Add(this.gpbMember);
            this.Controls.Add(this.txtSearchMember);
            this.Controls.Add(this.lbl_search_member);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearchMember);
            this.Name = "frmView";
            this.Text = "Library System | View a member";
            this.gpbMember.ResumeLayout(false);
            this.gpbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbl_memberid;
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
        private System.Windows.Forms.GroupBox gpbMember;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Label lbl_search_member;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.DataGridView grdSearchMember;
        private System.Windows.Forms.Button btnSelectMember;
    }
}