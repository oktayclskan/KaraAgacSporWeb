using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer
{
    public class DataModel
    {
        SqlConnection con; SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.ConStr);
            cmd = con.CreateCommand();
        }

        #region Matches

        #endregion

        #region Players

        #endregion

        #region News

        #endregion

        #region MatchDetail

        #endregion

        #region OpposingTeam

        #endregion

        #region Stadium

        #endregion

        #region AboutAs

        public List<About> AboutUsList()
        {
        List<About> content = new List<About>();

            try
            {
                cmd.CommandText = "Select * From AboutUs";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    About au = new About();
                    au.ID = reader.GetInt32(0);
                    au.Title = reader.GetString(1);
                    au.Content = reader.GetString(2);
                    au.Img = !reader.IsDBNull(3) ? reader.GetString(3) : " ";
                    au.Img2 = !reader.IsDBNull(4) ? reader.GetString(4) : " ";
                    au.Img3 = !reader.IsDBNull(5) ? reader.GetString(5) : " ";
                    content.Add(au);

                }
                return content;
            }
            catch 
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public About AboutUsGet(int id)
        {
            try
            {
                cmd.CommandText = "Select ID,Title,Content,Img,Img2,Img3 From AboutUs Where ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                About au = new About();
                while (reader.Read())
                {
                    au.ID = reader.GetInt32(0);
                    au.Title = reader.GetString(1);
                    au.Content = reader.GetString(2);
                    au.Img = reader.GetString(3);
                    au.Img2 = reader.GetString(4);
                    au.Img3 = reader.GetString(5);
                }
                return au;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public bool AboutUsDelete(int id)
        {
            try
            {
                cmd.CommandText = "Delete AboutUs Where ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",id);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally { con.Close(); }
        }
        public bool AbousUsUpdate(About a)
        {
            try
            {
                cmd.CommandText = "UPDATE AboutUs Set Title=@title, Content=@content, Img=@img, Img2=@img2, Img3=@img3 WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",a.ID);
                cmd.Parameters.AddWithValue("@title", a.Title);
                cmd.Parameters.AddWithValue("@content", a.Content);
                cmd.Parameters.AddWithValue("@img", a.Img);
                cmd.Parameters.AddWithValue("@img2", a.Img2);
                cmd.Parameters.AddWithValue("@img3", a.Img3);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                return false;
            }
            finally { con.Close(); }
        }


        #endregion

        #region Card

        #endregion
    }
}
