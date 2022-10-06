using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LibrarySYS
{
    class Book
    {
        private int bookID;
        private string title;
        private string author;
        private string publisher;
        private string year;
        private string edition;
        private string genre;
        private string ISBN;
        private string status;

        public Book()
        {
            this.bookID = 0;
            this.title = "";
            this.author = "";
            this.publisher = "";
            this.year = "";
            this.edition = "";
            this.genre = "";
            this.ISBN = "";
                this.status = "";
        } // end empty constructor 


        public Book(int bookID, String title, String author,String publisher, String year, string edition, String genre, string ISBN, string status )
        {
            this.bookID = bookID;
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.year = year;
            this.edition = edition;
            this.genre = genre;
            this.ISBN = ISBN;
            this.status = status;

        } // end constructor

        public int getBookID()
        {
            return this.bookID;
        } // end get book id 

        public String getTitle()
        {
            return this.title;
        } // end get title


        public string getAuthor()
        {
            return this.author;
        } // end get author


        public string getPublisher()
        {
            return this.publisher;
        } // end get publisher 


        public string getYear()
        {
            return this.year;
        } // end get year 

        public string getEdition    ()
        {
            return this.edition;
        } // end get edition 

        public string getGenre()
        {
            return this.genre;
        } // end get genre 


        public String getISBN()
        {
            return this.ISBN;
        } // end get ISBN

        public string getStatus()
        {
            return this.status;
        } // end get status

        public static int getNextID()
        {

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT MAX(BookID) FROM Books";
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

public void addBook()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "INSERT INTO Books VALUES(" +
                this.bookID + ", '" + this.title + "', '" + this.author + "', '" + this.publisher + "', '" +
                this.year + "', '" + this.edition + "', '" + this.genre + "', '" +
                this.ISBN + "', '" + this.status + "')";
             
            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();    

            cmd.ExecuteNonQuery();

            conn.Close();   
        } // end add book


        public static DataSet findBook(String title)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT BookID, Title, ISBN FROM Books WHERE UPPER(Title) LIKE '" + title.ToUpper() + 
                "%' AND status = 'A'  ORDER BY BookID";
 
            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "Books");       //.Fill(object, reference/name)

            //Close connection
            conn.Close();

            return ds;
        } // end find book

        public static DataSet findAllBooks(String title)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT BookID, Title, ISBN FROM Books WHERE UPPER(Title) LIKE '" + title.ToUpper() +
                "%' ORDER BY BookID";

            OracleCommand cmd = new OracleCommand(sql, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, "Books");       //.Fill(object, reference/name)

            //Close connection
            conn.Close();

            return ds;
        } // end find book



        public void getBook(int id)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "SELECT * FROM Books WHERE BookID = " + id;

            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            this.bookID = dr.GetInt32(0);
            this.title = dr.GetString(1);
            this.author = dr.GetString(2);
            this.publisher = dr.GetString(3);
            this.year = dr.GetString(4);
            this.edition = dr.GetString(5);
            this.genre = dr.GetString(6);
            this.ISBN = dr.GetString(7);
            this.status = dr.GetString(8);

            conn.Close();
        } // end get book 

 
        public static void changeStatus(int bookID, string status)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sql = "UPDATE Books SET Status = '" + status + "' WHERE BookID = " + bookID;
 
            OracleCommand cmd = new OracleCommand(sql, conn);

            conn.Open();

            cmd.ExecuteNonQuery();

            conn.Close();
        } // end change status 


    } // end class
}
