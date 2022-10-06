using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LibrarySYS
{
    class Payment
    {
        private int transID;
        private int fineID;
        private double amount;
        private string pay_date;

        public Payment()
        {
            this.transID = 0;
            this.fineID = 0;
            this.amount = 0.00;
            this.pay_date = "";
        } // end empty constructor 

        public Payment(int transID, int fineID, double amount, string pay_date)
        {
            this.transID = transID;
            this.fineID = fineID;
            this.amount = amount;
            this.pay_date = pay_date;
        } // end constructor 


        public static int getNextID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT MAX(TransID) FROM Payments";
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

         
        public static double getTotalAmount(int fineID)
        {
            double total = 0;

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT SUM(Amount) FROM Payments WHERE FineID = " + fineID;

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            if (dr.IsDBNull(0))
                total = 0;
            else 
                 total = dr.GetDouble(0);

            return total;
        } // end find payment 

public void addPayment()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "INSERT INTO Payments VALUES (" +
                this.transID + ", " + this.fineID + ", " + this.amount +
                ", '" + this.pay_date + "')";

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

        } // end add payment 


        public static DataSet getYearlyRevenue(String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT EXTRACT(MONTH FROM Pay_date), SUM(Amount) FROM Payments WHERE Pay_date LIKE '%" +
                Year + "' GROUP BY EXTRACT(MONTH FROM Pay_date)";

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "RA");

            conn.Close();

            return ds;
        } // end get yearly reveneu 


    } // end class 
}
