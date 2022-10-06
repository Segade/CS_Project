using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySYS
{
    public partial class frmView : Form
    {
//        frm_Main_Menu parent1;
        frmMainMenu parent;

        public frmView()
        {
            InitializeComponent();
        } // end empty constructor 
        /*
        public frmView(frm_Main_Menu Parent)
        {
            InitializeComponent();
            parent1 = Parent;
        } // end  constructor 
        */

        public frmView(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        } // end  constructor 


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

        }  // end btn search member 

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
            dtpDOB.MaxDate = Convert.ToDateTime(aMember.getDOB());
            dtpDOB.MinDate = Convert.ToDateTime(aMember.getDOB());
            /*
            if (aMember.getStatus() == "A")
                chkWithdrawn.Checked = true;
            */
            DataSet ds = County.getCounties();
            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                if (ds.Tables[0].Rows[x][0].ToString() == aMember.getCounty())
                    cboCounty.Items.Add(ds.Tables[0].Rows[x][0] + " - " + ds.Tables[0].Rows[x][1]);
            }
            cboCounty.SelectedIndex = 0;
                           gpbMember.Visible = true;
            gpbMember.Enabled = true;
            grdSearchMember.DataSource = null;
            btnSelectMember.Enabled = false;
            txtSearchMember.ReadOnly = true;
            btnSearchMember.Enabled = false;
             txtForename.Focus();

            lbl_memberid.Visible = true;
            txtMemberID.Visible = true;
        } // end btn select member 

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        } // end btn back 

    } // end class 
}
