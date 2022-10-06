using System;
//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LibrarySYS
{
    class Member
    {
        private int memberID;
        private String forename;
        private string surname;
        private String street;
        private String town;
        private String county;
        private String eircode;
        private string phone;
        private string email;
        //private DateTime dob;
        private string dob;
        private string status;

        public Member()
        {

        this.memberID = 0;
        this.forename = "";
        this.surname = "";
        this.street = "";
        this.town = "";
        this.county = "";
        this.eircode = "";
        this.phone = "";
        this.email = "";
            this.dob = "";
            this.status = "";

    } // end empty constructor 


        public Member(int productID, String forename, String surname,String street, string town, string county,string eircode, string phone, string email, String dob, string status)
        {

            this.memberID = productID;
            this.forename = forename;
            this.surname = surname;
            this.street = street;
            this.town = town;
            this.county = county;
            this.eircode = eircode;
            this.phone = phone;
            this.email = email;
             this.dob = dob;
            this.status = status;

        } // end construcctor 

public int getMemberID()
        {
            return this.memberID;
        } //  end get memberid 

        public string getForename()
        {
            return this.forename;
        } //   end get forename

        public void setForename(String forename)
        {
            this.forename = forename;
        } // end set forename 


        public string getSurname()
        {
            return this.surname;
        } // end get surname
    
        public void setSurname(String surname)
        {
            this.surname = surname;
        } // end set surname

        public string getStreet()
        {
            return this.street;
        } // end get street 
        
        public void setStreet(String street)
        {
            this.street = street;
        } // end set street 


        public string getTown()
        {
            return this.town;
        } //  end get town 

        public void setTown(String town)
        {
            this.town = town;
        } // end set town 


        public String getPhone()
        {
            return this.phone;
        } // end get phone

        public void setPhone(string phone)
        {
            this.phone = phone;
        } // end set phone 


        public string getEmail()
        {
            return this.email;
        } // end get email
        
        public void setEmail(string email)
        {
            this.email = email;
        } // end set email


        public string getCounty()
        {
            return this.county;
        } // end get county

        public void setCounty(String county)
        {
            this.county = county;
        }


        public string getEircode()
        {
            return this.eircode;
        } // end get eircode
         
        public void setEircode( string eircode)
        {
            this.eircode = eircode;
        } // end set eircode 


        public string getDOB()
        {
            return this.dob;
        } // end get DOB


        public void setDOB(string DOB)
        {
            this.dob = DOB;
        } // end set dob

public string getStatus()
        {
            return this.status;
        } // end get status 

        public void setStatus(string status)
        {
            this.status = status;
        } // end set status 



        public static int getNextID()
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT MAX(MemberID) FROM Members";
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


        public void addMember()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "INSERT INTO Members VALUES (" +
                 this.memberID + ",'" + this.forename + "' ,'" + this.surname + "' ,'" + this.street + "' ,'" +
this.town + "' ,'" + this.county + "' ,'" + this.eircode + "' ,'" +
this.phone + "' ,'" + this.email + "' ,'" + this.dob + "' ,'" + this.status + "')";

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        } // end add member 


        public static DataSet findMember(String surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT MemberID, Forename, Surname FROM Members WHERE UPPER(surname) LIKE '" + surname.ToUpper() + "%' AND status='A'ORDER BY MemberID";

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "Members"); 

            conn.Close();

            return ds;
        } // end find find member

        public static DataSet findAllMembers(String surname)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT MemberID, Forename, Surname FROM Members WHERE UPPER(surname) LIKE '" + surname.ToUpper() + "%' ORDER BY MemberID";

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "Members");

            conn.Close();

            return ds;

        } // end find all members 



        public void getMember(int MemId)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT * FROM Members WHERE MemberID = " + MemId;

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            this.memberID = dr.GetInt32(0);
            this.forename = dr.GetString(1);
            this.surname = dr.GetString(2);
            this.street = dr.GetString(3);
            this.town = dr.GetString(4);
            this.county = dr.GetString(5);
            this.eircode = dr.GetString(6);
            this.phone = dr.GetString(7);
            this.email = dr.GetString(8);
                          this.dob = String.Format("{0:dd-MMM-yyyy}", dr.GetDateTime(9));
             //this.dob = dr.GetDateTime(9);
            this.status = dr.GetString(10);

            conn.Close();
 
        } // end get member 
 

        public static void changeStatus(int memberID, String status)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "UPDATE Members SET Status = '" + status + "' WHERE MemberID = " + memberID;

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        } // end change status 

        public void updateMember()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "UPDATE Members SET Forename = '" + this.forename + "', Surname = '" + this.surname +
                "', Street = '" + this.street + "', Town = '" + this.town + "', County = '" + this.county + "', Eircode = '" + this.eircode +
                "', Phone = '" + this.phone + "', Email = '" + this.email +
                "', DOB = '" + this.dob + "', Status = '" + this.status + "'" +
                " WHERE MemberID =" + this.memberID;

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();

        } // end update member 

        public bool withPending()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT COUNT(*) FROM Loans l JOIN LoanBooks lb ON l.LoanID = lb.LoanID WHERE status = 'P' AND MemberID = " + this.memberID;
            String sql2 = "SELECT COUNT(*) FROM Fines f JOIN Loans l ON f.loanID = l.LoanID " +
                "WHERE Status = 'D' AND MemberID = " + this.memberID;

            OracleCommand cmd = new OracleCommand(sql, conn);
            OracleCommand cmd2 = new OracleCommand(sql2, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();
            OracleDataReader dr2 = cmd2.ExecuteReader();

            dr.Read();
            dr2.Read();

                             
  if (dr.GetInt32(0) == 0 && dr2.GetInt32(0) == 0 )
                return false;
            else
                return true;

            conn.Close();
        } // end is withdrawn 


    } // end class
}
