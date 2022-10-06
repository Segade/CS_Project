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
    public partial class frmLoanBook : Form
    {
         
        //frm_Main_Menu parent1;
        frmMainMenu parent;

        public frmLoanBook()
        {
            InitializeComponent();
        }
        /*
        public frmLoanBook(frm_Main_Menu Parent)
        {
            InitializeComponent();
            parent1 = Parent;
        } // end constructor
        */
        public frmLoanBook(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        } // end constructor

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            
            if (lstBooks.Items.Count == 0)
            {
                MessageBox.Show("No book has been added to the list");
                txtSearchBook.Focus();
                return;
            } // end if count 

            String myID = Loan.getNextID().ToString("000000");
 
            DateTime currentDate = DateTime.Today;
            DateTime dueDate = DateTime.Today.AddDays(14);

            int loanID = Loan.getNextID();
            Loan aLoan = new Loan(loanID, Convert.ToInt32(txtMemberID.Text), String.Format("{0:dd-MMM-yyyy}", currentDate), String.Format("{0:dd-MMM-yyyy}", dueDate) );

            try
            {  
            aLoan.addLoan();
            }
            catch (OracleException erro)
            {
                MessageBox.Show("Error with the Database. \nCode: " + erro.ErrorCode +
            "\nMessage: " + erro.Message);
                return;
            } // end catch 
            lstBooks.SelectedIndex = 0;
            for (int x = 0; x < lstBooks.Items.Count; x++)
            { 
                String bookID = lstBooks.Items[x].ToString();
 
                LoanBook aLoanBook = new LoanBook(loanID, Convert.ToInt32(bookID.Substring(0, 6)), String.Format("{0:dd-MMM-yyyy}", DateTime.Today), "P");

                try
                {  
                aLoanBook.addLoanBook();
                Book.changeStatus(Convert.ToInt32(bookID.Substring(0, 6)), "B");
                    //lstBooks.SelectedIndex++;
                }
                catch (OracleException erro)
                {
                    MessageBox.Show("Error with the Database. \nCode: " + erro.ErrorCode +
                        "\nMessage: " + erro.Message);
                    return;
                } // end catch 

            } // end for

            //Member.changeStatus(Convert.ToInt32(txtMemberID.Text), 'B');

            MessageBox.Show("Loan processed succesfully");

            resetForm();
        } // end borrow button 

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
        if (txtSearchMember.Text.Trim() == "")
        {
            MessageBox.Show("Enter a surname");
                txtSearchMember.Focus();
            return;
        }

        DataSet ds = Member.findMember(txtSearchMember.Text);

        if (ds.Tables[0].Rows.Count == 0)
            MessageBox.Show("no member found");

        else
        {
            grdSearchMember.DataSource = ds.Tables[0];
            grdSearchMember.Visible = true;
            grdSearchMember.Focus();

            btnSelectMember.Enabled = true;
            btnSelectMember.Visible = true;

        } // end if 

        } // end search member button 



        private void btnSelectMember_Click(object sender, EventArgs e)
        {

            String myID = grdSearchMember.Rows[grdSearchMember.CurrentCell.RowIndex].Cells[0].Value.ToString();

            Member aMember = new Member();
            aMember.getMember(Convert.ToInt32(myID));

            txtMemberID.Text = aMember.getMemberID().ToString("000000");
            txtForename.Text = aMember.getForename();
            txtSurname.Text = aMember.getSurname();
            txtStreet.Text = aMember.getStreet();
            txtPhone.Text = aMember.getPhone();
            txtEmail.Text = aMember.getEmail();
            dtpDOB.Value = Convert.ToDateTime(   aMember.getDOB());
            dtpDOB.MaxDate = Convert.ToDateTime( aMember.getDOB());
            dtpDOB.MinDate = Convert.ToDateTime( aMember.getDOB());

            gpbMember.Visible = true;
            grdSearchMember.DataSource = null;
            btnSelectMember.Enabled = false;
            txtSearchMember.ReadOnly = true;
            btnSearchMember.Enabled = false;

            txtSearchBook.Visible = true;
            btnSearchBook.Visible = true;
            txtSearchBook.Focus();

        } // end select member button 

        private void grdSearchMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        } // end grid search member click

     

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            if (lstBooks.Items.Count < 3)
            {
                String myBook = txtBookID.Text + " - " + txtTitle.Text;

                if (lstBooks.Items.IndexOf(myBook) < 0)
                {
                    lstBooks.Items.Add(myBook);

                }
                else
                {  // if book is added to list
                    MessageBox.Show("This book is already added to the list");
                } // end if book is added to list
            }
            else
            {
                MessageBox.Show("You cannot add more than 3 books");
            } // end if  count < 4

            grdSearchBook.DataSource = null;

            gpbBook.Visible = false;
            lstBooks.Enabled = true;
            btnAddBook.Enabled = false;
 
            btnSelectBook.Enabled = false;
            txtSearchBook.Text = "";
            txtSearchBook.Focus();
        } //end btn add book

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLoanBook_Load(object sender, EventArgs e)
        {

            dtpDOB.Value = new DateTime(1981, 10, 21);
            /*
            gpbMember.Visible = false;
            gpbBook.Visible = false;
             btnAddBook.Visible = false;
            btnBorrowBook.Visible = false;
            */
        } // end form load

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;

        }

        private void grdSearchMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("hello");
            int myID = Convert.ToInt32(grdSearchMember.Rows[grdSearchMember.CurrentCell.RowIndex].Cells[0].Value);
            Member aMember = new Member();
            aMember.getMember(myID);


            //            int id = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            txtMemberID.Text = aMember.getMemberID().ToString("000000");
            txtForename.Text = aMember.getForename();
            txtSurname.Text = aMember.getSurname();
            txtStreet.Text = aMember.getStreet();
            txtPhone.Text = aMember.getPhone();
            txtEmail.Text = aMember.getEmail();
            txtSearchBook.Focus();
        } // click on the grid view

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lstBooks.SelectedIndex >= 0)
            {
                lstBooks.Items.RemoveAt(lstBooks.SelectedIndex);

            } // end if selected index 


        } // end delete button 

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            
            if (txtSearchBook.Text.Trim() == "")
            {
                MessageBox.Show("Enter a book title");
                txtSearchBook.Focus();
                return;
            }

            DataSet ds = Book.findBook(txtSearchBook.Text);

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("no book found");
                return;
            }

            grdSearchBook.DataSource = ds.Tables[0];
            grdSearchBook.Visible = true;
            grdSearchBook.Focus();

            btnSelectBook.Visible = true;
            btnSelectBook.Enabled = true;

            lstBooks.Visible = true;
        } // end btn search book 

        private void btnSelectBook_Click(object sender, EventArgs e)
        {

            Book aBook = new Book();

            string myID = grdSearchBook.Rows[grdSearchBook.CurrentCell.RowIndex].Cells[0].Value.ToString();

            aBook.getBook(Convert.ToInt32(myID));

            txtBookID.Text = aBook.getBookID().ToString("000000");

            txtTitle.Text = aBook.getTitle();
            txtAuthor.Text = aBook.getAuthor();
            txtISBN.Text = aBook.getISBN();

            gpbBook.Visible = true;

            lstBooks.Visible = true;

            btnDelete.Enabled = true;
            btnDelete.Visible = true;

            btnAddBook.Enabled = true;
            btnAddBook.Visible = true;
            btnAddBook.Focus();

            btnBorrowBook.Enabled = true;
            btnBorrowBook.Visible = true;
        } // end btn select book 

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetForm()
        {

            txtSearchMember.ReadOnly = false;
            txtSearchMember.Clear();
            btnSearchMember.Enabled = true;
            btnSearchMember.Visible = true;
            gpbMember.Visible = false;
            gpbBook.Visible = false;

            grdSearchBook.Visible = false;
            btnSelectBook.Enabled = false;
            btnSelectBook.Visible = false;

            grdSearchMember.Visible = false;
            btnSelectMember.Enabled = false;
            btnSelectMember.Visible = false;

            txtSearchBook.Visible = false;
            btnSearchBook.Visible = false;
            lstBooks.Visible = false;
            lstBooks.Items.Clear();
            btnDelete.Enabled = false;
            btnDelete.Visible = false;

            btnBorrowBook.Enabled = false;
            btnBorrowBook.Visible = false; btnBack.Focus();

        } // end reset form 

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } // end class
}
   
