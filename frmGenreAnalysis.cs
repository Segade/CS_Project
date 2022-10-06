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
    public partial class frmGenreAnalysis : Form
    {
        //frm_Main_Menu parent1;
        frmMainMenu parent;

        public frmGenreAnalysis()
        {
            InitializeComponent();
        } // end empty constructor
        /*
        public frmGenreAnalysis(frm_Main_Menu Parent)
        {
            InitializeComponent();
            parent1 = Parent;
        } // end  constructor
        */
        public frmGenreAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        } // end  constructor


        private void frmGenreAnalysis_Load(object sender, EventArgs e)
        {
            // load years 
            LoadYears();

            // load grid 
            LoadGrid();

            LoadGenres();

            } // end form load 

        private void LoadGrid()
        {
            grdYearlyRev.ColumnCount = 12;
            grdYearlyRev.RowCount = 1;

            for (int i = 0; i < 12; i++)
            {
                grdYearlyRev.Columns[i].Width = 90;
                grdYearlyRev.Columns[i].Name = Utilities.getMonth(i + 1);

                grdYearlyRev.CurrentCell = grdYearlyRev.Rows[0].Cells[i];
                grdYearlyRev.CurrentCell.Value = 0;

            }
            //set column header allignment and font
            foreach (DataGridViewColumn col in grdYearlyRev.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            grdYearlyRev.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        } // end load grid 

        private void LoadGenres()
        {
            DataSet ds = Genre.getGenre();

            for (int x = 0; x < ds.Tables[0].Rows.Count; x++)
            {
                cboGenres.Items.Add(ds.Tables[0].Rows[x][0] + " - " + ds.Tables[0].Rows[x][1]);
            } // end for 

        } // end load genres 

        private void btnGenerateRep_Click(object sender, EventArgs e)
        {
            if (cboYears.SelectedIndex == -1)
            {
                MessageBox.Show("A year must be selected");
                cboYears.Focus ();
                return;
            } 

            if (cboGenres.SelectedIndex == -1)
            {
                MessageBox.Show("A genre must be selected");
                cboGenres.Focus();
                return;
            } 

            lblTitle.Text = "Genre Analysis " + cboYears.Text;

            DataSet ds = Genre.getYearlyRevenue(cboYears.Text.Substring(2, 2), cboGenres.Text.Substring(0,2) );

            if (ds.Tables["RA"].Rows.Count == 0)
            {
                MessageBox.Show("No data found for year " + cboYears.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboYears.Focus();
                return;
            }

            //put the data in the datagrid
            double smallest = 999.99;
            int smallestMonth = 1;
            double largest = 0;
            int largestMonth = 1;
            grdYearlyRev.Rows[0].Cells[1].Style.ForeColor = Color.Red;

            for (int i = 0; i < ds.Tables["RA"].Rows.Count; i++)
            {
                int mon = Convert.ToInt32(ds.Tables[0].Rows[i][0]);
                grdYearlyRev.CurrentCell = grdYearlyRev.Rows[0].Cells[mon - 1];
                grdYearlyRev.CurrentCell.Value = ds.Tables["RA"].Rows[i][1].ToString();

                if (Convert.ToDouble(ds.Tables["RA"].Rows[i][1]) < smallest)
                {
                    grdYearlyRev.Rows[0].Cells[smallestMonth - 1].Style.ForeColor = Color.Black;
                    smallest = Convert.ToDouble(ds.Tables["RA"].Rows[i][1]);
                    smallestMonth = i + 1;
                    grdYearlyRev.Rows[0].Cells[smallestMonth - 1].Style.ForeColor = Color.Red;
                }

                if (Convert.ToDouble(ds.Tables["RA"].Rows[i][1]) > largest)
                {
                    grdYearlyRev.Rows[0].Cells[largestMonth - 1].Style.ForeColor = Color.Black;
                    largest = Convert.ToDouble(ds.Tables["RA"].Rows[i][1]);
                    largestMonth = i + 1;
                    grdYearlyRev.Rows[0].Cells[largestMonth - 1].Style.ForeColor = Color.Red;
                }

            }

            //show data

        } // end genereate report 

        private void LoadYears()
        {
            int year = DateTime.Today.Year;
            cboYears.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYears.Items.Clear();
            for (int i = 1; i < 5; i++)
            {
                cboYears.Items.Add(year.ToString());
                year--;
            } // end for 

            lblTitle.Font = new Font("Arial", 18, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Text = "Genre Analysis " + cboYears.Text;

        } // end load data 

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    } // end class 
}
