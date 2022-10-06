using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LibrarySYS
{
    class County
    {

public static DataSet getCounties()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT * FROM Counties ORDER BY name";

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

                da.Fill(ds, "Counties"); 

            conn.Close();

            return ds;
        } // end get counties




    } // end class
}
