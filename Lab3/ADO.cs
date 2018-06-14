using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.models;

namespace WindowsFormsApplication1
{
    class ADO
    {
        static string conStr = ConfigurationManager.ConnectionStrings["Con"].ConnectionString;

        public static List<Book> GetAllBooks()
        {
            List<Book> bookList = new List<Book>();
            string query = @"SELECT * FROM [Book]";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int bookCode = Convert.ToInt32(reader["BookCode"].ToString());
                    string title = reader["Title"].ToString();
                    string author = reader["Author"].ToString();
                    string publisher = reader["Publisher"].ToString();
                    Book book = new Book()
                    {
                        BookCode = bookCode,
                        Title = title,
                        Author = author,
                        Publisher = publisher
                    };
                    bookList.Add(book);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
            return bookList;
        }

        public static List<Copy> GetAllCopys()
        {
            List<Copy> copyList = new List<Copy>();
            //Load data from DB to Adapter
            //too lazy to write here
            return copyList;
        }

        public static void BindDataToGridView(DataGridView gridView, string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conStr);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataView dv = new DataView(ds.Tables[0]);
            gridView.DataSource = dv;
        }

    }
}
