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
    public partial class frmCatalogueBook : Form
    {
        //frm_Main_Menu parent1;
        frmMainMenu parent;

        public frmCatalogueBook()
        {
            InitializeComponent();
        }
        /*
        public frmCatalogueBook(frm_Main_Menu Parent)
        {
            InitializeComponent();
            parent1 = Parent;
        } // end constructor 
        */
        public frmCatalogueBook(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        } // end constructor 


        private void frmCatalogueBook_Load(object sender, EventArgs e)
        {

            DataSet ds = Genre.getGenre();

            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                cboGenre.Items.Add(ds.Tables[0].Rows[x][0] + " - " + ds.Tables[0].Rows[x][1]);
            } // end for 

        } // end load form

        private void btnCatalogue_Click(object sender, EventArgs e)
        {

            // validation 
            if (txtTitle.Text == "")
            {
                MessageBox.Show("A title must be entered");
                txtTitle.Focus();
                return;
            }

            if (txtAuthor.Text == "")
            {
                MessageBox.Show("An author must be entered");
                txtAuthor.Focus();
                return;
            }

            if (txtPublisher.Text == "")
            {
                MessageBox.Show("A publisher must be entered");
                txtPublisher.Focus();
                return;
            }

            if (txtYear.Text == "" || !txtYear.Text.All(char.IsDigit) || Convert.ToInt32(txtYear.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("A year must be entered");
                txtYear.Focus();
                return;
            }

            if (txtEdition.Text == "")
            {
                MessageBox.Show("An edition must be entered");
                txtEdition.Focus();
                return;
            }

            if (cboGenre.SelectedIndex == -1)
            {
                MessageBox.Show("A genre must selected");
                cboGenre.Focus();
                return;
            }

            if (!Utilities.isISBN(txtISBN.Text))
            {
                MessageBox.Show("An ISBN must be entered");
                txtISBN.Focus();
                return;
            }

                //save data in Books File
            Book aBook = new Book(Convert.ToInt32(Book.getNextID()), txtTitle.Text, txtAuthor.Text, txtPublisher.Text, txtYear.Text,
                txtEdition.Text, cboGenre.Text.Substring(0, 2), txtISBN.Text, "A");

            try
            {
                aBook.addBook();
            } 
            catch (OracleException erro)
            {
                MessageBox.Show("Error with the Database. \nCode: " + erro.ErrorCode +
                    "\nMessage: " + erro.Message);
                return;
            } // end catch 

            MessageBox.Show("Book Added successfuly.");

            // clear form
            resetForm();
        } // end catalogue button 

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    

        private void resetForm()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtEdition.Clear();
            txtYear.Clear();
            cboGenre.SelectedIndex = 0;
            cboGenre.SelectedIndex = -1;
            txtISBN.Clear();
            btnBack.Focus();

        } // end reset form


    } // end class 
}
