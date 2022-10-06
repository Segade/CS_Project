using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LibrarySYS
{
    class Fine
    {
        private int fineID;
        private int loanID;
        private int bookID;
        private double amount;
        private string fine_date;
        private string status;


        public Fine()
        {
            this.fineID = 0;
            this.loanID = 0;
            this.bookID = 0;
            this.amount = 0;
            this.fine_date = "";
            this.status = "";
        } // end empty constructor 

    
        public Fine(int fineID, int loanID, int bookID, double amount, string fine_date, string status)
        {
            this.fineID = fineID;
            this.loanID = loanID;
            this.bookID = bookID;
            this.amount = amount;
            this.fine_date = fine_date;
            this.status = status;
        } // end constructor 

        public double getAmount()
        {
            return this.amount;
        } // end get amount 


    public static int getNextID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT MAX(FineID) FROM Fines";
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

        public void addFine()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "INSERT INTO Fines VALUES (" +
                this.fineID + ", " + this.loanID + ", " + this.bookID + ", " + this.amount + ", '" +
                 this.fine_date + "', '" + this.status + "')";
                
            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

        } // end add fine

        public static DataSet findFine(String surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT b.BookID, Title, m.MemberID, Forename, Surname, l.LoanID, FineID " +
                "FROM LoanBooks lb JOIN Loans l ON lb.LoanID = l.LoanID " +
                "JOIN Books b ON lb.BookID = b.bookID " +
                "JOIN Members m ON l.MemberID = m.Memberid " +
                "JOIN Fines f ON f.LoanID = lb.LoanID AND f.BookID = lb.BookID " +
                "WHERE UPPER(Surname) LIKE '" + surname.ToUpper() + "%' " +
                " AND f.status = 'D'  ORDER BY surname, Forename";

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "Books");       //.Fill(object, reference/name)

            conn.Close();

            return ds;
        } // end find fine 

        public void getFine(int fineID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT * FROM Fines WHERE FineID = " + fineID;

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            this.fineID = dr.GetInt32(0);
            this.loanID = dr.GetInt32(1);
            this.bookID = dr.GetInt32(2);
            this.amount = dr.GetDouble(3);
            this.fine_date = dr.GetString(4);
            this.status = dr.GetString(5);

        } // end get fine 
 
        public static void changeStatus(int fineID, String status)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "UPDATE Fines SET Status = '" + status + "' WHERE FineID = " + fineID;

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        } // end change status 


        public static DataSet getYearlyRevenue(String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT EXTRACT(MONTH FROM PayDate), SUM(Amount) FROM Payments WHERE PayDate LIKE '%" +
                Year + "' GROUP BY EXTRACT(MONTH FROM PayDate) ORDER BY EXTRACT(MONTH FROM PayDate)";

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "RA");

            conn.Close();

            return ds;

        } // end get yearly analysis 


    } // end class
}
