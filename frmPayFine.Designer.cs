    
namespace LibrarySYS
{
    partial class frmPayFine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
            /// </summary>
        //      / <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.lbl_search_member = new System.Windows.Forms.Label();
            this.txtSearchMember = new System.Windows.Forms.TextBox();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.grdSearchMember = new System.Windows.Forms.DataGridView();
            this.btnSelectMember = new System.Windows.Forms.Button();
            this.lbl_total_amount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lbl_due_pay = new System.Windows.Forms.Label();
            this.txtDuePay = new System.Windows.Forms.TextBox();
            this.btnPayFine = new System.Windows.Forms.Button();
            this.lbl_to_pay = new System.Windows.Forms.Label();
            this.txtToPay = new System.Windows.Forms.TextBox();
            this.gpbFine = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchMember)).BeginInit();
            this.gpbFine.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_search_member
            // 
            this.lbl_search_member.AutoSize = true;
            this.lbl_search_member.Location = new System.Drawing.Point(1, 52);
            this.lbl_search_member.Name = "lbl_search_member";
            this.lbl_search_member.Size = new System.Drawing.Size(120, 17);
            this.lbl_search_member.TabIndex = 0;
            this.lbl_search_member.Text = " Search Member: ";
            // 
            // txtSearchMember
            // 
            this.txtSearchMember.AccessibleName = "Search member by surname";
            this.txtSearchMember.Location = new System.Drawing.Point(127, 50);
            this.txtSearchMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchMember.Name = "txtSearchMember";
            this.txtSearchMember.Size = new System.Drawing.Size(100, 22);
            this.txtSearchMember.TabIndex = 2;
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Location = new System.Drawing.Point(45, 101);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMember.TabIndex = 3;
            this.btnSearchMember.Text = "Search Member";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // grdSearchMember
            // 
            this.grdSearchMember.AccessibleName = " Member results";
            this.grdSearchMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSearchMember.Location = new System.Drawing.Point(242, 13);
            this.grdSearchMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdSearchMember.Name = "grdSearchMember";
            this.grdSearchMember.ReadOnly = true;
            this.grdSearchMember.RowHeadersWidth = 51;
            this.grdSearchMember.RowTemplate.Height = 24;
            this.grdSearchMember.Size = new System.Drawing.Size(240, 150);
            this.grdSearchMember.TabIndex = 10;
            this.grdSearchMember.Visible = false;
            // 
            // btnSelectMember
            // 
            this.btnSelectMember.Enabled = false;
            this.btnSelectMember.Location = new System.Drawing.Point(12, 139);
            this.btnSelectMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectMember.Name = "btnSelectMember";
            this.btnSelectMember.Size = new System.Drawing.Size(120, 23);
            this.btnSelectMember.TabIndex = 12;
            this.btnSelectMember.Text = "Select boo&k";
            this.btnSelectMember.UseVisualStyleBackColor = true;
            this.btnSelectMember.Visible = false;
            this.btnSelectMember.Click += new System.EventHandler(this.btnSelectMember_Click);
            // 
            // lbl_total_amount
            // 
            this.lbl_total_amount.AutoSize = true;
            this.lbl_total_amount.Location = new System.Drawing.Point(5, 46);
            this.lbl_total_amount.Name = "lbl_total_amount";
            this.lbl_total_amount.Size = new System.Drawing.Size(99, 17);
            this.lbl_total_amount.TabIndex = 48;
            this.lbl_total_amount.Text = "Total amount: ";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(144, 44);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 22);
            this.txtTotalAmount.TabIndex = 49;
            // 
            // lbl_due_pay
            // 
            this.lbl_due_pay.AutoSize = true;
            this.lbl_due_pay.Location = new System.Drawing.Point(5, 102);
            this.lbl_due_pay.Name = "lbl_due_pay";
            this.lbl_due_pay.Size = new System.Drawing.Size(104, 17);
            this.lbl_due_pay.TabIndex = 50;
            this.lbl_due_pay.Text = " Due payment: ";
            // 
            // txtDuePay
            // 
            this.txtDuePay.Location = new System.Drawing.Point(144, 102);
            this.txtDuePay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDuePay.Name = "txtDuePay";
            this.txtDuePay.ReadOnly = true;
            this.txtDuePay.Size = new System.Drawing.Size(100, 22);
            this.txtDuePay.TabIndex = 51;
            // 
            // btnPayFine
            // 
            this.btnPayFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayFine.Location = new System.Drawing.Point(715, 482);
            this.btnPayFine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPayFine.Name = "btnPayFine";
            this.btnPayFine.Size = new System.Drawing.Size(133, 62);
            this.btnPayFine.TabIndex = 52;
            this.btnPayFine.Text = "Pay fine";
            this.btnPayFine.UseVisualStyleBackColor = true;
            this.btnPayFine.Visible = false;
            this.btnPayFine.Click += new System.EventHandler(this.btnPayFine_Click);
            // 
            // lbl_to_pay
            // 
            this.lbl_to_pay.AutoSize = true;
            this.lbl_to_pay.Location = new System.Drawing.Point(14, 174);
            this.lbl_to_pay.Name = "lbl_to_pay";
            this.lbl_to_pay.Size = new System.Drawing.Size(60, 17);
            this.lbl_to_pay.TabIndex = 53;
            this.lbl_to_pay.Text = "To pay: ";
            // 
            // txtToPay
            // 
            this.txtToPay.Location = new System.Drawing.Point(144, 170);
            this.txtToPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.Size = new System.Drawing.Size(100, 22);
            this.txtToPay.TabIndex = 54;
            this.txtToPay.Text = "0.00";
            // 
            // gpbFine
            // 
            this.gpbFine.Controls.Add(this.txtTotalAmount);
            this.gpbFine.Controls.Add(this.lbl_to_pay);
            this.gpbFine.Controls.Add(this.txtToPay);
            this.gpbFine.Controls.Add(this.lbl_total_amount);
            this.gpbFine.Controls.Add(this.txtDuePay);
            this.gpbFine.Controls.Add(this.lbl_due_pay);
            this.gpbFine.Location = new System.Drawing.Point(45, 270);
            this.gpbFine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFine.Name = "gpbFine";
            this.gpbFine.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpbFine.Size = new System.Drawing.Size(307, 231);
            this.gpbFine.TabIndex = 20;
            this.gpbFine.TabStop = false;
            this.gpbFine.Text = "Penalties";
            this.gpbFine.Visible = false;
            this.gpbFine.Enter += new System.EventHandler(this.gpbFine_Enter);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1, 1);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(67, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = " Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmPayFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 702);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gpbFine);
            this.Controls.Add(this.btnPayFine);
            this.Controls.Add(this.btnSelectMember);
            this.Controls.Add(this.grdSearchMember);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.txtSearchMember);
            this.Controls.Add(this.lbl_search_member);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPayFine";
            this.Text = "Library System | Pay a fine";
            ((System.ComponentModel.ISupportInitialize)(this.grdSearchMember)).EndInit();
            this.gpbFine.ResumeLayout(false);
            this.gpbFine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_search_member;
        private System.Windows.Forms.TextBox txtSearchMember;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.DataGridView grdSearchMember;
        private System.Windows.Forms.Button btnSelectMember;
        private System.Windows.Forms.Label lbl_total_amount;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lbl_due_pay;
        private System.Windows.Forms.TextBox txtDuePay;
        private System.Windows.Forms.Button btnPayFine;
        private System.Windows.Forms.Label lbl_to_pay;
        private System.Windows.Forms.TextBox txtToPay;
        private System.Windows.Forms.GroupBox gpbFine;
        private System.Windows.Forms.Button btnBack;
    }
}