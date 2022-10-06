using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace LibrarySYS
{
    class Genre
    {

        private String code;
        private string name;

        public static DataSet getGenre()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT * FROM Genres ORDER BY name";

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "Genre");       //.Fill(object, reference/name)

            conn.Close();

            return ds;
        } // end get genre 


        public static DataSet getYearlyRevenue(String Year, String genre)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT EXTRACT(MONTH FROM LoanDate), COUNT(l.LoanID) " +
                "FROM Books b JOIN LoanBooks lb ON b.BookID = lb.BookID " +
                " JOIN Loans l ON lb.LoanID = l.LoanID " +
                "WHERE LoanDate LIKE '%" + Year + "' AND Genre = '" + genre + "'" +
                " GROUP BY EXTRACT(MONTH FROM LoanDate) ORDER BY EXTRACT(MONTH FROM LoanDate)"; 
 
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "RA");

            conn.Close();

            return ds;
        } // end get yearly revenue 


    } // end class 
}
