using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LibrarySYS
{
    class LoanBook
    {
         
        private int loanID;
        private int bookID;
        private String back_date;
        private string status;

        public LoanBook(int loanID, int bookID, string back_date, String status)
        {
            this.loanID = loanID;
            this.bookID = bookID;
            this.back_date = back_date;
            this.status = status;
        } // end constructor 



        public void addLoanBook()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "INSERT INTO LoanBooks VALUES (" +
                this.loanID + ", " + this.bookID + ", '" + this.back_date +
                "', '" + this.status + "')";

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();


        } // end add loan book


        public static DataSet findLoanBook(String title)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT b.BookID, Title, m.MemberID, Forename, Surname, l.LoanID " +
                "FROM LoanBooks lb JOIN Loans l ON lb.LoanID = l.LoanID " +
                "JOIN Books b ON lb.BookID = b.bookID " +
                "JOIN Members m ON l.MemberID = m.Memberid " +
                "WHERE UPPER(title) LIKE '" + title.ToUpper() + "%' " +
                " AND lb.status = 'P'  ORDER BY BookID";

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "Books");       //.Fill(object, reference/name)

            conn.Close();

            return ds;

        } // end find loan book

public static void changeStatus(int loanID, int bookID, string status)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "UPDATE LoanBooks SET Status = '" + status + "' WHERE LoanID = " + loanID + " AND BookID = " + bookID;

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

        } // end change status 


    } // end class
}
