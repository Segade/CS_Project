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
    public partial class frmReturnBook : Form
    {
        //frm_Main_Menu parent1;
        frmMainMenu parent;
        const double PENALTY = 1.5;
         
        int  loanID;

        public frmReturnBook()
        {
            InitializeComponent();
        }
/*
        public frmReturnBook(frm_Main_Menu Parent)
        {
            InitializeComponent();
            parent1 = Parent;
        } // end construcctor 
        */
        public frmReturnBook(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        } // end construcctor 



        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            if (txtSearchBook.Text.Trim() == "")
            {
                MessageBox.Show("Enter a book title");
                txtSearchBook.Clear();
                txtSearchBook.Focus();
                return;
            }

                DataSet ds = LoanBook.findLoanBook(txtSearchBook.Text);
 
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("no book found");
                txtSearchBook.Clear();
                txtSearchBook.Focus();
                return;
            }

            grdSearchBook.DataSource = ds.Tables[0];
            grdSearchBook.Visible = true;
            grdSearchBook.Focus();

            btnSelectBook.Visible = true;
            btnSelectBook.Enabled = true;

        } // end btn search book 

        private void btnSelectBook_Click(object sender, EventArgs e)
        {
            
            // display book details 
            string myID = grdSearchBook.Rows[grdSearchBook.CurrentCell.RowIndex].Cells[0].Value.ToString();

            Book aBook = new Book();
            aBook.getBook(Convert.ToInt32(myID));

            txtBookID.Text = aBook.getBookID().ToString("000000");

            txtTitle.Text = aBook.getTitle();
            txtAuthor.Text = aBook.getAuthor();
            txtISBN.Text = aBook.getISBN();

            gpbBook.Visible = true;

            // display member details 
            Member aMember = new Member();

            myID = grdSearchBook.Rows[grdSearchBook.CurrentCell.RowIndex].Cells[2].Value.ToString();

            aMember.getMember(Convert.ToInt32(myID));

            txtMemberID.Text = aMember.getMemberID().ToString("000000");
            txtForename.Text = aMember.getForename();
            txtSurname.Text = aMember.getSurname();
            txtStreet.Text = aMember.getStreet();
            txtPhone.Text = aMember.getPhone();
            txtEmail.Text = aMember.getEmail();
            dtpDOB.Value = Convert.ToDateTime( aMember.getDOB());
            dtpDOB.MaxDate = Convert.ToDateTime( aMember.getDOB());
            dtpDOB.MinDate = Convert.ToDateTime( aMember.getDOB());

            gpbMember.Visible = true;

            // retrieve  loan details 
              loanID = Convert.ToInt32(grdSearchBook.Rows[grdSearchBook.CurrentCell.RowIndex].Cells[5].Value);

            Loan aLoan = new Loan();
            aLoan.getLoan(loanID);
            DateTime due_date = Convert.ToDateTime( aLoan.getDueDate());
            DateTime current_date = DateTime.Today.AddDays(44) ;
            TimeSpan diff = current_date - due_date;

            btnReturnBook.Focus();

            if (Convert.ToInt32(diff.Days) > 14)
            {
                double fine_amount = PENALTY * Convert.ToInt32(diff.Days);
                 txtFineAmount.Text = fine_amount.ToString();
                gpbFine.Visible = true;
                /*
                MessageBox.Show("The current day is: " + current_date.ToString() +
                "\nthe due date is :" + due_date +
                "\nThe difference is: " + diff.Days.ToString() +
                "\nThe fine amount is : " + fine_amount
                );
                */
                txtFineAmount.Focus();
            } // end if diff 

            btnReturnBook.Visible = true;

        } // end slect book 

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
if (txtFineAmount.Text != "")
if (cboApplyFine.SelectedIndex == -1)
            {
                MessageBox.Show("Select if the fine is applied");
                    cboApplyFine.Focus();
                return;
            } // end if no apply selected 

            if ( cboApplyFine.Text == "Yes")
            {
                Fine aFine = new Fine(Fine.getNextID(), loanID, Convert.ToInt32(txtBookID.Text), Convert.ToDouble(txtFineAmount.Text) , String.Format("{0:dd-MMM-yyyy}", DateTime.Today), "D");
try
                {  
                aFine.addFine();
                }
                catch (OracleException erro)
                {
                    MessageBox.Show("Error with the Database. \nCode: " + erro.ErrorCode +
                        "\nMessage: " + erro.Message);
                    return;
                } // end catch 

            } // end if apply fine 
            try
            {
                Book.changeStatus(Convert.ToInt32(txtBookID.Text), "A");
                LoanBook.changeStatus(loanID, Convert.ToInt32(txtBookID.Text), "F");
            } catch(OracleException erro)
            {
                MessageBox.Show("Error with the Database. \nCode: " + erro.ErrorCode +
                    "\nMessage: " + erro.Message);
                return;
            } // end catch 
            
                MessageBox.Show("The book has been returned successfully");

            // clear form 
            resetForm();
        } // end btn return book

        private void btnBack_Click(object sender, EventArgs e)
        {
                this.Close();
            parent.Visible = true;

        } // end btn back


        private void resetForm()
        {
            gpbBook.Visible = false;
            gpbMember.Visible = false;
            gpbFine.Visible = false;
            cboApplyFine.SelectedIndex = 0;
            cboApplyFine.SelectedIndex = -1;

            grdSearchBook.DataSource = null;
            grdSearchBook.Visible = false;
            btnSelectBook.Enabled = false;
            btnSelectBook.Visible = false;
            btnReturnBook.Visible = false;
 
            txtSearchBook.Clear();
            btnBack.Focus();
        }//            end reset form 

        private void grdSearchBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    } // end class 
}
