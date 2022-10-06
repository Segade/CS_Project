using System;
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
    public partial class frmPayFine : Form
    {
        //frm_Main_Menu parent1;
        frmMainMenu parent;
        int fineID;

        public frmPayFine()
        {
            InitializeComponent();
        } // end empty constructor 
        /*
        public frmPayFine(frm_Main_Menu Parent)
        {
            InitializeComponent();
            parent1 = Parent;
        } // end constructor 
        */
        public frmPayFine(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        } // end constructor 


        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            if (txtSearchMember.Text.Trim() == "")
            {
                MessageBox.Show("Enter a surname");
                txtSearchMember.Focus();
                return;
            }

            DataSet ds = Fine.findFine(txtSearchMember.Text);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No results found");
                txtSearchMember.Clear();
                txtSearchMember.Focus();
                return;
            }

            grdSearchMember.DataSource = ds.Tables[0];
            grdSearchMember.Visible = true;
            grdSearchMember.Focus();

            btnSelectMember.Enabled = true;
            btnSelectMember.Visible = true;

            txtSearchMember.Clear();
        } // end btn search member 

        private void btnSelectMember_Click(object sender, EventArgs e)
        {
             
            fineID = Convert.ToInt32(grdSearchMember.Rows[grdSearchMember.CurrentCell.RowIndex].Cells[6].Value);
            Fine aFine = new Fine();
             aFine.getFine(fineID);

            txtTotalAmount.Text = aFine.getAmount().ToString("0.00");

            double duePay = Convert.ToDouble(txtTotalAmount.Text) - Payment.getTotalAmount(fineID);

            txtDuePay.Text = duePay.ToString("0.00");
            txtToPay.Focus();
            gpbFine.Visible = true;
            btnPayFine.Visible = true;
            grdSearchMember.DataSource = null;

            txtTotalAmount.Focus();
            btnSelectMember.Enabled = false;
            btnSelectMember.Visible = false;
            btnSearchMember.Visible = false;
        } // end btn select member 

        private void btnPayFine_Click(object sender, EventArgs e)
        {
            if (!Utilities.isDouble(txtToPay.Text))
            {
                MessageBox.Show("A valid quantity must be entered");
                txtToPay.Text = "0.00";
                    txtToPay.Focus();
                return;
            }

                         if (Convert.ToDouble(txtToPay.Text) > Convert.ToDouble(txtDuePay.Text) )
                        {
                            MessageBox.Show("The amount to pay cannot be greater than  the due payment");
                            return;
                        } // end if to pay > due pay

            if (Convert.ToDouble(txtDuePay.Text) - Convert.ToDouble(txtToPay.Text) < 1 && Convert.ToDouble(txtDuePay.Text) - Convert.ToDouble(txtToPay.Text) > 0)
            {
                MessageBox.Show("The remainder cannot be less than 1 Euro");
                return;
            }

                         if (Convert.ToDouble(txtToPay.Text) < 1)
            {
                MessageBox.Show("The amount of money to pay must be 1 Euro at least");
                txtToPay.Focus();
                return;
            } // end if < 1

               Payment aPayment = new Payment(Payment.getNextID(), fineID, Convert.ToDouble(txtToPay.Text), String.Format("{0:dd-MMM-yyyy}", DateTime.Today));
            try
            {  
            aPayment.addPayment();
            }
            catch (OracleException erro)
            {
                MessageBox.Show("Error with the Database. \nCode: " + erro.ErrorCode +
                    "\nMessage: " + erro.Message);
            } // end catch 

            String texto = "Payment processed successfully";

            if (Convert.ToDouble(txtDuePay.Text) == Convert.ToDouble(txtToPay.Text))
            {
                Fine.changeStatus(fineID, "P");
                texto += "\nFine paid totally";
            }
                MessageBox.Show(texto);

            // clear form 
            resetForm();
         } // end btn pay fine 

        private void gpbFine_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        } // end btn back 

        private void resetForm()
        {

            txtToPay.Clear();
            txtTotalAmount.Clear();
            txtDuePay.Clear();
            grdSearchMember.Visible = false;
            gpbFine.Visible = false;
            btnPayFine.Visible = false;
            btnSearchMember.Visible = true;
            btnBack.Focus();
        } // end reset form 

    } // end class 
}
