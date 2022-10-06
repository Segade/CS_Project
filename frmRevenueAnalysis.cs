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
    public partial class frmRevenueAnalysis : Form
    {
//        frm_Main_Menu parent1;
        frmMainMenu parent;

        public frmRevenueAnalysis()
        {
            InitializeComponent();
        } // end empty constructor 
        /*
        public frmRevenueAnalysis(frm_Main_Menu Parent)
        {
            InitializeComponent();
            parent1 = Parent;
        } // end  constructor 
        */

        public frmRevenueAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        } // end  constructor 


        private void frmRevenueAnalysis_Load(object sender, EventArgs e)
        {
            // load years 
            loadYears();

            // load grid 
            loadGrid();
        } // end form load 

        private void cboYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lblTitle.Text = "Revenue Analysis " + cboYears.Text;

            DataSet ds = Fine.getYearlyRevenue(cboYears.Text.Substring(2, 2));

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
            lblTitle.Visible = true;
            grdYearlyRev.Visible = true;

        } // end change cbo years 

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
    } // end btn back 

        private void loadYears()
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
            lblTitle.Text = "Revenue Analysis " + cboYears.Text;

        } // end load years 


        private void loadGrid()
        {

            grdYearlyRev.ColumnCount = 12;
            grdYearlyRev.RowCount = 1;

            for (int i = 0; i < 12; i++)
            {
                grdYearlyRev.Columns[i].Width = 90;
                grdYearlyRev.Columns[i].Name = Utilities.getMonth(i + 1);
                //add line of code to set amount displayed to zero
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

         

    } // end class 
}
