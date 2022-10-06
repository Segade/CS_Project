using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LibrarySYS
{
    class Loan
    {
        private int loanID;
        private int memberID;
        private String borrow_date;
        private string due_date;

        public Loan()
        {
            this.loanID = 0;
            this.memberID = 0;
            this.borrow_date = "";
            this.due_date = "";
        } // end empty constructor 


        public Loan(int loanID, int memberID, String borrow_date, String due_date)
        {
            this.loanID = loanID;
            this.memberID = memberID;
            this.borrow_date = borrow_date;
            this.due_date = due_date;
        } // end constructor

        public int getLoanID()
        {
            return this.loanID;
        } // end get loan id

        public int getMemberID()
        {
            return this.memberID;
        } // end get member id

        public String getBorrowDate()
        {
            return this.borrow_date;
        } // end get borrow date 

        public String getDueDate()
        {
            return this.due_date;
        } // end get due date


        public static int getNextID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT MAX(LoanID) FROM Loans";
            OracleCommand cmd = new OracleCommand(sql, conn);
            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            int nextId;

            dr.Read();

            if (dr.IsDBNull(0))
                nextId = 1;
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            conn.Close();

            return nextId;
        } // end get next id 


        public void addLoan()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            
            String sql = "INSERT INTO Loans VALUES (" +
                this.loanID + ", " + this.memberID + ", '" + this.borrow_date + "', '" + this.due_date + "')";

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

        } // end add loan

        public void getLoan(int loanID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT * FROM Loans WHERE LoanID = " + loanID;
                         
            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
 
            this.loanID = dr.GetInt32(0);
            this.memberID = dr.GetInt32(1);
            this.borrow_date = String.Format("{0:dd-MMM-yyyy}", dr.GetDateTime(2));
            this.due_date = String.Format("{0:dd-MMM-yyyy}", dr.GetDateTime(3));

            conn.Close();

        } // end get loan 



    } // end class
}
