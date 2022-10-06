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
    public partial class frmWithdrawBook : Form
    {
        //frm_Main_Menu parent1;
        frmMainMenu parent;
        public frmWithdrawBook()
        {
            InitializeComponent();
        } // end empty constructor 
        /*
        public frmWithdrawBook(frm_Main_Menu Parent)
        {
            InitializeComponent();
            parent1 = Parent;
        } // end constructor 
        */
        public frmWithdrawBook(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        } // end constructor 


        private void btnSearchBook_Click(object sender, EventArgs e)
        {

            if (txtSearchBook.Text.Trim() == "")
            {
                MessageBox.Show("Enter a book title");
                txtSearchBook.Focus();
                return;
            }

            DataSet ds = Book.findAllBooks(txtSearchBook.Text);

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

        } // end btn search book 

        private void btnSelectBook_Click(object sender, EventArgs e)
        {
            cboStatus.Items.Clear();
            Book aBook = new Book();

            string myID = grdSearchBook.Rows[grdSearchBook.CurrentCell.RowIndex].Cells[0].Value.ToString();

            aBook.getBook(Convert.ToInt32(myID));

            txtBookID.Text = aBook.getBookID().ToString("000000");

            txtTitle.Text = aBook.getTitle();
            txtAuthor.Text = aBook.getAuthor();
            txtISBN.Text = aBook.getISBN();
            txtPublisher.Text = aBook.getPublisher();
            txtEdition.Text = aBook.getEdition();
            txtYear.Text = aBook.getYear();

            DataSet ds = Genre.getGenre();
            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                if (ds.Tables[0].Rows[x][0].ToString() == aBook.getGenre())
                    cboGenre.Items.Add(ds.Tables[0].Rows[x][0] + " - " + ds.Tables[0].Rows[x][1]);
            }
            cboGenre.SelectedIndex = 0;

            if (aBook.getStatus() != "B")
            {
                cboStatus.Items.Add("A - Active");
                cboStatus.Items.Add("W - Withdrawn");
                btnChange.Enabled = true;

                if (aBook.getStatus() == "A")
                    cboStatus.SelectedIndex = 0;
                else
                    cboStatus.SelectedIndex = 1;

            }  else {
                cboStatus.Items.Add("B - Borrowed");
                cboStatus.SelectedIndex = 0;
            } // end if status = B

             lbl_withdrawn.Visible = true;
            cboStatus.Visible = true;

            gpbBook.Visible = true;
            gpbBook.Enabled = true;

            lbl_bookid.Visible = true;
            txtBookID.Visible = true;
            txtTitle.Focus();
            btnChange.Visible = true;
        } // end select book 

        private void btnChange_Click(object sender, EventArgs e)
        {

            try
            { 
            Book.changeStatus(Convert.ToInt32(txtBookID.Text), cboStatus.Text.Substring(0, 1));
        }
                catch (OracleException erro)
                {
                    MessageBox.Show("Error with the Database. \nCode: " + erro.ErrorCode +
                        "\nMessage: " + erro.Message);
                    return;
                } // end catch 

    MessageBox.Show("Status changed successfully");

            // clear form 
            resetForm();

        } // end btn change 

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        } // btn back 

        private void resetForm()
        {
            grdSearchBook.Visible = false;
            btnSelectBook.Visible = false;
            gpbBook.Visible = false;
            lbl_withdrawn.Visible = false;
            cboStatus.Visible = false;
            btnChange.Visible = false;
            txtSearchBook.Clear();
            txtBookID.Clear();
            txtBookID.Visible = false;
            lbl_bookid.Visible = false;
            cboStatus.Items.Clear();
        } // end reset form 

        private void lbl_withdrawn_Click(object sender, EventArgs e)
        {

        }
    } // end class 
}
