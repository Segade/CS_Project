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
    public partial class frmAddMember : Form
    {
        //frm_Main_Menu parent1;
        frmMainMenu parent;

        public frmAddMember()
        {
            InitializeComponent();
        }
        /*
        public frmAddMember(frm_Main_Menu Parent)
        {
            InitializeComponent();
            parent1 = Parent;
        } // end constructor 
        */
        public frmAddMember(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        } // end constructor 



        private void frmAddMember_Load(object sender, EventArgs e)
        {
            dtpDOB.MaxDate = DateTime.Today;            

            DataSet ds = County.getCounties();

            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                cboCounty.Items.Add(ds.Tables[0].Rows[x][0] + " - " + ds.Tables[0].Rows[x][1]);
            } // end for 


        } // end load form 

        private void btnAdd_Click(object sender, EventArgs e)
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


            // process to save the member

            String dob = String.Format("{0:dd-MMM-yyyy}", dtpDOB.Value);
 
            Member aMember = new Member(Member.getNextID(), txtForename.Text, txtSurname.Text,
                txtStreet.Text, txtTown.Text, cboCounty.Text.Substring(0, 2), txtEircode.Text,
               txtPhone.Text, txtEmail.Text, dob, "A");

            try
            {
                aMember.addMember();
            } 
            catch (OracleException erro)
            {
                MessageBox.Show("Error with the Database. \nCode: " + erro.ErrorCode +
                    "\nMessage: " + erro.Message);
                return;
            } // end catch 

            MessageBox.Show("Member addedd successfuly.");


            // clear form
            resetForm();
        } // end add button

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

         
        private void resetForm()
        {
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

        } // end reset form 


    } // end class 
}
