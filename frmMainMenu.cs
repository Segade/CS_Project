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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnu_catalagoue_book_Click(object sender, EventArgs e)
        {

        }

        private void mnu_wd_book_Click(object sender, EventArgs e)
        {

        }

        private void mnuCatalogueBook_Click(object sender, EventArgs e)
        {
            frmCatalogueBook myForm = new frmCatalogueBook(this);
            this.Hide();
            myForm.Show();
        }

        private void mnuDrawBook_Click(object sender, EventArgs e)
        {
            frmWithdrawBook myForm = new frmWithdrawBook(this);
            this.Hide();
            myForm.Show();
        }

        private void mnuAddMember_Click(object sender, EventArgs e)
        {
            frmAddMember myForm = new frmAddMember(this);
            this.Hide();
            myForm.Show();
        }

        private void mnuUpdateMember_Click(object sender, EventArgs e)
        {
            frmUpdateMember myForm = new frmUpdateMember(this);
            this.Hide();
            myForm.Show();
        }

        private void mnuViewMember_Click(object sender, EventArgs e)
        {
            frmView myform = new  frmView(this);
            this.Hide();
            myform.Show();
        }

        private void mnuLoanBook_Click(object sender, EventArgs e)
        {
            frmLoanBook myForm = new frmLoanBook(this);
            this.Hide();
            myForm.Show();
        }

        private void mnuReturnBook_Click(object sender, EventArgs e)
        {
            frmReturnBook myForm = new frmReturnBook(this);
            this.Hide();
            myForm.Show();
        }

        private void mnuPayFine_Click(object sender, EventArgs e)
        {
            frmPayFine myForm = new frmPayFine(this);
            this.Hide();
            myForm.Show();
        }

        private void mnuYearAnalysis_Click(object sender, EventArgs e)
        {
            frmRevenueAnalysis myForm = new frmRevenueAnalysis(this);
            this.Hide();
            myForm.Show();
        }

        private void mnuGenreAnalysis_Click(object sender, EventArgs e)
        {
            frmGenreAnalysis myForm = new frmGenreAnalysis(this);
            this.Hide();
            myForm.Show();
        }

        private void mnuLoan_Click(object sender, EventArgs e)
        {

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();

        }
    } // end class 
}
