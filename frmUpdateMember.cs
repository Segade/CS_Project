using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; 

namespace LibrarySYS
{
    public partial class frmUpdateMember : Form
    {
        //frm_Main_Menu parent1;
        frmMainMenu parent;
        public frmUpdateMember()
        {
            InitializeComponent();
        } // end empty constructor
        /*
        public frmUpdateMember(frm_Main_Menu Parent)
        {
            InitializeComponent();
            parent1 = Parent;
        } // end 
         */
        public frmUpdateMember(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
         


        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            if (txtSearchMember.Text.Trim() == "")
            {
                MessageBox.Show("Enter a surname");
                txtSearchMember.Focus();
                return;
            }

            DataSet ds = Member.findAllMembers(txtSearchMember.Text);
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No member found");
                txtSearchMember.Focus();
                return;
            }

            grdSearchMember.DataSource = ds.Tables[0];
            grdSearchMember.Visible = true;

            grdSearchMember.Focus();

            btnSelectMember.Visible = true;
            btnSelectMember.Enabled = true;
            
        } // end search member

        private void btnSelectMember_Click(object sender, EventArgs e)
        {
            String myID = grdSearchMember.Rows[grdSearchMember.CurrentCell.RowIndex].Cells[0].Value.ToString();

            Member aMember = new Member();
            aMember.getMember(Convert.ToInt32(myID));

            txtMemberID.Text = aMember.getMemberID().ToString("000000");
            txtForename.Text = aMember.getForename();
            txtSurname.Text = aMember.getSurname();
            txtStreet.Text = aMember.getStreet();
            txtTown.Text = aMember.getTown();
            txtEircode.Text = aMember.getEircode();
            txtPhone.Text = aMember.getPhone();
            txtEmail.Text = aMember.getEmail();
            dtpDOB.Value = Convert.ToDateTime(aMember.getDOB());
            dtpDOB.MaxDate = DateTime.Today;
 
            if (aMember.getStatus() == "A")
                chkWithdrawn.Checked = true;

            if (aMember.withPending())
                chkWithdrawn.Enabled = false;


            DataSet ds = County.getCounties();
            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                cboCounty.Items.Add(ds.Tables[0].Rows[x][0] + " - " + ds.Tables[0].Rows[x][1]);
                if (ds.Tables[0].Rows[x][0].ToString() == aMember.getCounty())
                    cboCounty.SelectedIndex = x;
            } // end for 

            gpbMember.Visible = true;
            gpbMember.Enabled = true;
            grdSearchMember.DataSource = null;
            btnSelectMember.Enabled = false;
            txtSearchMember.ReadOnly = true;
            btnSearchMember.Enabled = false;
            btnUpdate.Enabled = true;
            btnUpdate.Visible = true;
            txtForename.Focus();
            chkWithdrawn.Visible = true;

            lbl_memberid.Visible = true;
            txtMemberID.Visible = true; 
        } // end select member 

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // validation
 
            if (txtForename.TextLength < 2 || txtForename.Text.All(char.IsDigit))
            {
                MessageBox.Show("A forename must be entered");
                txtForename.Focus();
                return;
            }

            if (txtSurname.TextLength < 2 || txtSurname.Text.All(char.IsDigit))
            {
                MessageBox.Show("A surname must be entered");
                txtSurname.Focus();
                return;
            }

            if (txtStreet.Text == "")
            {
                MessageBox.Show("A street must be entered");
                txtStreet.Focus();
                return;
            }

            if (txtTown.Text.Length < 2 || txtTown.Text.All(char.IsDigit))
            {
                MessageBox.Show("A town must be entered");
                txtTown.Focus();
                return;
            }

            if (!Utilities.isEircode(txtEircode.Text))
            {
                MessageBox.Show("An Eircode must be entered");
                txtEircode.Focus();
                return;
            }

            if (cboCounty.SelectedIndex == -1)
            {
                MessageBox.Show("A county must be selected");
                cboCounty.Focus();
                return;
            }

            if (!Utilities.isPhone(txtPhone.Text))
            {
                MessageBox.Show("A valid phone must be entered");
                txtPhone.Focus();
                txtPhone.Focus();
                return;
            }

            if (!Utilities.isEmail(txtEmail.Text))
            {
                MessageBox.Show("A valid email must be entered");
                txtEmail.Focus();
                return;
            }



            // save member 
            Member aMember = new Member();
            aMember.getMember(Convert.ToInt32(txtMemberID.Text));

            aMember.setForename(txtForename.Text.Trim());
            aMember.setSurname(txtSurname.Text.Trim());
            aMember.setStreet(txtStreet.Text.Trim());
            aMember.setTown(txtTown.Text.Trim());
            aMember.setEircode(txtEircode.Text);
            aMember.setCounty(cboCounty.Text.Substring(0, 2)  );
            aMember.setPhone(txtPhone.Text);
            aMember.setEmail(txtEmail.Text);
            aMember.setDOB(String.Format("{0:dd-MMM-yyyy}", dtpDOB.Value));

            if (chkWithdrawn.Checked == true)
                aMember.setStatus("A");
            else
                aMember.setStatus("U");

            try
            {  
            aMember.updateMember();
            }
            catch (OracleException erro)
            {
                MessageBox.Show("Error with the Database. \nCode: " + erro.ErrorCode +
                    "\nMessage: " + erro.Message);
                return;
            } // end catch 

            MessageBox.Show("Member updates successfully");

            // clear form 
            resetForm();

        } // end btn update 

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        } // end btn back 

 
        private void resetForm()
        {
            txtMemberID.Clear();
            txtForename.Clear();
            txtSurname.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            cboCounty.SelectedIndex = 0;
            cboCounty.SelectedIndex = -1;
            txtEircode.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            dtpDOB.Value = DateTime.Today;
            btnBack.Focus();
            gpbMember.Visible = false;
            txtSearchMember.ReadOnly = false;
            txtSearchMember.Clear();
            txtMemberID.Visible = false;
            lbl_memberid.Visible = false;
            chkWithdrawn.Visible = false;
            btnUpdate.Visible = false;
            grdSearchMember.Visible = false;
            btnSearchMember.Visible = true;
            btnSearchMember.Enabled = true;
        } // end reset form 



    } // end class 
}
