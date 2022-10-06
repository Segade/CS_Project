
namespace LibrarySYS
{
    partial class frmUpdateMember
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
            this.lbl_member_active = new System.Windows.Forms.Label();
            this.chkWithdrawn = new System.Windows.Forms.CheckBox();
            this.lbl_memberid = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.gpbMember = new System.Windows.Forms.GroupBox();
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
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.lbl_search_member = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grdSearchMember = new System.Windows.Forms.DataGridView();
            this.btnSelectMember = new System.Windows.Forms.Button();
            this.gpbMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchMember)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_member_active
            // 
            this.lbl_member_active.AutoSize = true;
            this.lbl_member_active.Location = new System.Drawing.Point(343, 482);
            this.lbl_member_active.Name = "lbl_member_active";
            this.lbl_member_active.Size = new System.Drawing.Size(109, 17);
            this.lbl_member_active.TabIndex = 51;
            this.lbl_member_active.Text = "Member Active: ";
            // 
            // chkWithdrawn
            // 
            this.chkWithdrawn.AutoSize = true;
            this.chkWithdrawn.Location = new System.Drawing.Point(549, 482);
            this.chkWithdrawn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkWithdrawn.Name = "chkWithdrawn";
            this.chkWithdrawn.Size = new System.Drawing.Size(18, 17);
            this.chkWithdrawn.TabIndex = 20;
            this.chkWithdrawn.UseVisualStyleBackColor = true;
            this.chkWithdrawn.Visible = false;
            // 
            // lbl_memberid
            // 
            this.lbl_memberid.AutoSize = true;
            this.lbl_memberid.Location = new System.Drawing.Point(253, 98);
            this.lbl_memberid.Name = "lbl_memberid";
            this.lbl_memberid.Size = new System.Drawing.Size(84, 17);
            this.lbl_memberid.TabIndex = 9;
            this.lbl_memberid.Text = "Member ID: ";
            this.lbl_memberid.Visible = false;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(459, 92);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(100, 22);
            this.txtMemberID.TabIndex = 9;
            this.txtMemberID.Visible = false;
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
            this.gpbMember.Enabled = false;
            this.gpbMember.Location = new System.Drawing.Point(256, 139);
            this.gpbMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbMember.Name = "gpbMember";
            this.gpbMember.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbMember.Size = new System.Drawing.Size(445, 340);
            this.gpbMember.TabIndex = 10;
            this.gpbMember.TabStop = false;
            this.gpbMember.Text = "Member details";
            this.gpbMember.Visible = false;
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
            this.txtTown.Location = new System.Drawing.Point(211, 146);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTown.Name = "txtTown";
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
            this.cboCounty.Location = new System.Drawing.Point(211, 180);
            this.cboCounty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtEircode.Location = new System.Drawing.Point(211, 210);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(100, 22);
            this.txtEircode.TabIndex = 15;
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
            this.txtForename.Location = new System.Drawing.Point(211, 50);
            this.txtForename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 22);
            this.txtForename.TabIndex = 11;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(211, 78);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 22);
            this.txtSurname.TabIndex = 12;
            // 
            // lbl_street
            // 
            this.lbl_street.AutoSize = true;
            this.lbl_street.Location = new System.Drawing.Point(87, 122);
            this.lbl_street.Name = "lbl_street";
            this.lbl_street.Size = new System.Drawing.Size(54, 17);
            this.lbl_street.TabIndex = 14;
            this.lbl_street.Text = "Street: ";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(211, 294);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 19;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(211, 117);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 22);
            this.txtStreet.TabIndex = 13;
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
            this.txtEmail.Location = new System.Drawing.Point(211, 266);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(211, 238);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 17;
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
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(574, 46);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMember.TabIndex = 2;
            this.btnSearchMember.Text = "Search Member";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.Location = new System.Drawing.Point(459, 46);
            this.txtSearchMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(100, 22);
            this.txtSearchMember.TabIndex = 1;
            // 
            // lbl_search_member
            // 
            this.lbl_search_member.AccessibleName = "Search";
            this.lbl_search_member.AutoSize = true;
            this.lbl_search_member.Location = new System.Drawing.Point(253, 50);
            this.lbl_search_member.Name = "lbl_search_member";
            this.lbl_search_member.Size = new System.Drawing.Size(126, 17);
            this.lbl_search_member.TabIndex = 46;
            this.lbl_search_member.Text = "Member surname: ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(491, 530);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 62);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = " Update member";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            // grdSearchMember
            // 
            this.grdSearchMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchMember.Location = new System.Drawing.Point(708, 46);
            this.grdSearchMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdSearchMember.Name = "grdSearchMember";
            this.grdSearchMember.ReadOnly = true;
            this.grdSearchMember.RowHeadersWidth = 51;
            this.grdSearchMember.RowTemplate.Height = 24;
            this.grdSearchMember.Size = new System.Drawing.Size(240, 150);
            this.grdSearchMember.TabIndex = 5;
            this.grdSearchMember.Visible = false;
            // 
            // btnSelectMember
            // 
            this.btnSelectMember.Enabled = false;
            this.btnSelectMember.Location = new System.Drawing.Point(574, 91);
            this.btnSelectMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectMember.Name = "btnSelectMember";
            this.btnSelectMember.Size = new System.Drawing.Size(120, 23);
            this.btnSelectMember.TabIndex = 6;
            this.btnSelectMember.Text = "Select Me&mber";
            this.btnSelectMember.UseVisualStyleBackColor = true;
            this.btnSelectMember.Visible = false;
            this.btnSelectMember.Click += new System.EventHandler(this.btnSelectMember_Click);
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 702);
            this.Controls.Add(this.btnSelectMember);
            this.Controls.Add(this.grdSearchMember);
            this.Controls.Add(this.lbl_member_active);
            this.Controls.Add(this.chkWithdrawn);
            this.Controls.Add(this.lbl_memberid);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.gpbMember);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.txtSearchMember);
            this.Controls.Add(this.lbl_search_member);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUpdateMember";
            this.Text = "Library System | Update a member";
            this.gpbMember.ResumeLayout(false);
            this.gpbMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_member_active;
        private System.Windows.Forms.CheckBox chkWithdrawn;
        private System.Windows.Forms.Label lbl_memberid;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.GroupBox gpbMember;
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
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Label lbl_search_member;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdSearchMember;
        private System.Windows.Forms.Button btnSelectMember;
    }
}