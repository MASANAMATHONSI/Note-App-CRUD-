using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Note_App__CRUD_
{
    public class Datahandler
    {

        string conn = "Server=.;Initial Catalog = NoteApp; User ID = sa; Password=sa2025@1";

        public DataTable ViewAll()
        {
            string query = "SELECT * FROM Notes";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable SearchNotes(string searchTerm)
        {
            string query = "SELECT * FROM Notes WHERE Title LIKE @search";
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }


        public void AddNote(string title, string content)
        {
            string query = "INSERT INTO Notes (Title, Content) VALUES (@Title, @Content)";
            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Content", content);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void EditNote(int id, string title, string content)
        {
            string query = "UPDATE Notes SET Title = @Title, Content = @Content WHERE ID = @ID";

            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Title", title);
                cmd.Parameters.AddWithValue("@Content", content);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteNote(int id)
        {
            string query = "DELETE FROM Notes WHERE ID = @ID";

            using (SqlConnection con = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
