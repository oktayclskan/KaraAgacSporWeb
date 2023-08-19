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

        #region AdminLogin

        public Admin AdminLogin(string mail, string adminPaswword)
        {
            try
            {
                cmd.CommandText = "SELECT Count(*) From Admins Where Mail=@mail AND AdminPassword=@adminPaswword ";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mail", mail);
                cmd.Parameters.AddWithValue("@adminPaswword", adminPaswword);
                con.Open();
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                if (num > 0)
                {
                    cmd.CommandText = "SELECT * From Admins WHERE Mail=@mail AND AdminPassword=@adminPassword";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@adminPaswword", adminPaswword);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Admin a = new Admin();

                    while (reader.Read())
                    {
                        a.ID = reader.GetInt32(0);
                        a.Name = reader.GetString(1);
                        a.Surname = reader.GetString(2);
                        a.Mail = reader.GetString(3);
                        a.Password = reader.GetString(4);
                    }
                    return a;
                }
                else
                {
                    return null;
                }
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

        #endregion

        #region Matches
        //public List<Matches> MatchesList()
        //{
        //    List<Matches> matches = new List<Matches>();
        //    try
        //    {
        //        cmd.CommandText = " Select M.ID,s.Name,M.MyTeam,op.Name,M.MyTeamScore,OpposingTeamScore,M.StadiumOwner,M.ImgOne,M.ImgTwo,M.ImgThree,M.ImgFour,M.ImgFive,M.MatchDateTime From Matches AS M Join Stadiums AS s ON M.StadiumID = s.ID Join OpposingTeam op ON M.OpposingTeamID = op.ID  ";
        //        cmd.Parameters.Clear();
        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {

        //            Matches m = new Matches();
        //            m.ID = reader.GetInt32(0);
        //            m.StadiumName = reader.GetString(1);
        //            m.MyTeam = reader.GetString(2);
        //            m.OppossingTeamName = reader.GetString(3);
        //            m.MyTeamScore = reader.GetInt32(4);
        //            m.OpposingTeamScore = reader.GetInt32(5);
        //            m.StadiumOwner = reader.GetBoolean(6);
        //            m.StadiumOwnerStr = reader.GetBoolean(6) ? "<label style='color:green'>Ev Sahini</label>" : "<label style='color:red'>Deplasman</label>";
        //            m.ImgOne = reader.GetString(7);
        //            m.ImgTwo = reader.GetString(8);
        //            m.ImgThree = reader.GetString(9);
        //            m.ImgFour = reader.GetString(10);
        //            m.ImgFive = reader.GetString(11);
        //            m.MatchDateTime = reader.GetDateTime(12);
        //            matches.Add(m);
        //        }
        //        return matches;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }

        //}

        public List<Matches> MatchesList()
        {
            List<Matches> matches = new List<Matches>();
            try
            {
                cmd.CommandText = "Select m.ID, s.Name,ot.Name,m.MyTeamScore,m.OpposingTeamScore,ot.Logo,m.StadiumOwner,m.MatchDateTime\r\nFrom Matches as m\r\nJoin Stadiums AS s On s.ID=m.StadiumID\r\njoin OpposingTeam AS ot On ot.ID=m.OpposingTeamID\r\n";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Matches m = new Matches();
                    m.ID = reader.GetInt32(0);
                    m.StadiumName=reader.GetString(1);
                    m.OpposingTeamName = reader.GetString(2);
                    m.MyTeamScore = reader.GetInt32(3);
                    m.OpposingTeamScore= reader.GetInt32(4);
                    m.OppesingTeamLogo= reader.GetString(5);
                    m.StadiumOwner=reader.GetBoolean(6);
                    m.StadiumOwnerStr=reader.GetBoolean(6) ? "<label style='color:green'>Ev Sahini</label>" : "<label style='color:red'>Deplasman</label>";
                    m.MatchDateTime = reader.GetDateTime(7);
                    m.MatchDateTimeStr = reader.GetDateTime(7).ToShortDateString();
                    matches.Add(m);
                }
                return matches;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public bool MatchAdd(Matches m)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Matches (StadiumID,OpposingTeamID,MyTeamScore,OpposingTeamScore,StadiumOwner,MatchDateTime) Values(@stadiumID,@opposingTeamID,@myTeamScore,@opposingTeamScore,@stadiumOwner,@matchDateTime)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@stadiumID",m.StadiumID);
                cmd.Parameters.AddWithValue("@opposingTeamID", m.OpposingTeamID);
                cmd.Parameters.AddWithValue("@myTeamScore", m.MyTeamScore);
                cmd.Parameters.AddWithValue("@opposingTeamScore", m.OpposingTeamScore);
                cmd.Parameters.AddWithValue("@stadiumOwner", m.StadiumOwner);
                cmd.Parameters.AddWithValue("@matchDateTime", m.MatchDateTime);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { con.Close(); }
        }
        public bool MatchDlt(int id)
        {
            try
            {
                cmd.CommandText = "Delete Matches Where ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
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

        #region Players
        public List<Players> PlayerList()
        {
            List<Players> players = new List<Players>();
            try
            {
                cmd.CommandText = "Select * From Players";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Players p = new Players();
                    p.ID = reader.GetInt32(0);
                    p.PlayerName = reader.GetString(1);
                    p.PlayerSurname = reader.GetString(2);
                    p.PlayerDateOfBirth = reader.GetDateTime(3);
                    p.PlayerDateOfBirthStr = reader.GetDateTime(3).ToShortDateString();
                    p.PlayerUniformNumber = reader.GetString(4);
                    p.PlayerPosition = reader.GetString(5);
                    p.PlayerFirstEleven = reader.GetBoolean(6);
                    p.PlayerFirstElevenStr = reader.GetBoolean(6) ? "<label style='color:green'>İlk 11'de</label>" : "<label style='color:red'>İlk 11'değil</label>";
                    p.PlayerStatusPlayer = reader.GetBoolean(7);
                    p.PlayerStatusPlayerStr = reader.GetBoolean(7) ? "<label style='color:green'>Aktif</label>" : "<label style='color:red'>Pasif</label>";
                    p.PlayerImg = reader.GetString(8);
                    players.Add(p);
                }
                return players;
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
        public Players PlayerGet(int id)
        {
            try
            {
                cmd.CommandText = "Select Id,Name,Surname,DateOfBirth,UniformNumber,Position,FirstEleven,StatusPlayer,Img From Players Where ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Players p = new Players();
                while (reader.Read())
                {
                    p.ID = reader.GetInt32(0);
                    p.PlayerName = reader.GetString(1);
                    p.PlayerSurname = reader.GetString(2);
                    p.PlayerDateOfBirth = reader.GetDateTime(3);
                    p.PlayerUniformNumber = reader.GetString(4);
                    p.PlayerPosition = reader.GetString(5);
                    p.PlayerFirstEleven = reader.GetBoolean(6);
                    p.PlayerStatusPlayer = reader.GetBoolean(7);
                    p.PlayerImg = reader.GetString(8);
                }
                return p;
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
        public bool PlayerUpdate(Players p)
        {
            try
            {
                cmd.CommandText = "Update Players Set Name=@name,Surname=@surname,DateOfBirth=@dateOfBirth,UniformNumber=@uniformNumber,Position=@position,FirstEleven=@firstEleven,StatusPlayer=@statusPlayer,Img=@img Where ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", p.ID);
                cmd.Parameters.AddWithValue("@name", p.PlayerName);
                cmd.Parameters.AddWithValue("@surname", p.PlayerSurname);
                cmd.Parameters.AddWithValue("@dateOfBirth", p.PlayerDateOfBirth);
                cmd.Parameters.AddWithValue("@uniformNumber", p.PlayerUniformNumber);
                cmd.Parameters.AddWithValue("@position", p.PlayerPosition);
                cmd.Parameters.AddWithValue("@firstEleven", p.PlayerFirstEleven);
                cmd.Parameters.AddWithValue("@statusPlayer", p.PlayerStatusPlayer);
                cmd.Parameters.AddWithValue("@img", p.PlayerImg);
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
        public bool PlayerAdd(Players p)
        {
            try
            {
                cmd.CommandText = "Insert Into Players (Name,Surname,DateOfBirth,UniformNumber,Position,FirstEleven,StatusPlayer,Img) Values(@name,@surname,@dateOfBirth,@uniformNumber,@position,@firstEleven,@statusPlayer,@img)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", p.PlayerName);
                cmd.Parameters.AddWithValue("@surname", p.PlayerSurname);
                cmd.Parameters.AddWithValue("@dateOfBirth", p.PlayerDateOfBirth);
                cmd.Parameters.AddWithValue("@uniformNumber", p.PlayerUniformNumber);
                cmd.Parameters.AddWithValue("@position", p.PlayerPosition);
                cmd.Parameters.AddWithValue("@firstEleven", p.PlayerFirstEleven);
                cmd.Parameters.AddWithValue("@statusPlayer", p.PlayerStatusPlayer);
                cmd.Parameters.AddWithValue("@img", p.PlayerImg);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public bool PlayerDlt(int id)
        {
            try
            {
                cmd.CommandText = "Delete Players Where ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
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

        #region News
        public List<News> NewsList()
        {
            List<News> news = new List<News>();
            try
            {
                cmd.CommandText = "Select * From News";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    News n = new News();
                    n.ID = reader.GetInt32(0);
                    n.NewsTitle = reader.GetString(1);
                    n.NewsDescription = reader.GetString(2);
                    n.NewsContent = reader.GetString(3);
                    n.NewsDate = reader.GetDateTime(4);
                    n.NewsDateStr = reader.GetDateTime(4).ToShortDateString();
                    n.NewsCardImg = reader.GetString(5);
                    n.NewsContentImg = reader.GetString(6);
                    news.Add(n);
                }
                return news;
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
        public News NewsGet(int id)
        {
            try
            {
                cmd.CommandText = "Select ID,Title,DescriptionNews,Content,CardImg,ContentImg From News Where ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                News n = new News();
                while (reader.Read())
                {
                    n.ID = reader.GetInt32(0);
                    n.NewsTitle = reader.GetString(1);
                    n.NewsDescription = reader.GetString(2);
                    n.NewsContent = reader.GetString(3);
                    n.NewsCardImg = reader.GetString(4);
                    n.NewsContentImg = reader.GetString(5);
                }
                return n;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public bool NewsAdd(News n)
        {
            try
            {
                cmd.CommandText = "INSERT INTO News (Title,DescriptionNews,Content,NewsDate,CardImg,ContentImg) VALUES (@title,@descripton,@content,@newsDate,@cardImg,@contentImg)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@title",n.NewsTitle);
                cmd.Parameters.AddWithValue("@descripton", n.NewsDescription);
                cmd.Parameters.AddWithValue("@content", n.NewsContent);
                cmd.Parameters.AddWithValue("@newsDate", n.NewsDate);
                cmd.Parameters.AddWithValue("@cardImg", n.NewsCardImg);
                cmd.Parameters.AddWithValue("@contentImg", n.NewsContentImg);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
          
        }
        public bool NewsDlt(int id)
        {
            try
            {
                cmd.CommandText = "Delete News Where ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
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
        public bool NewsUpdate(News n)
        {
            try
            {
                cmd.CommandText = "Update News Set Title=@title,DescriptionNews=@description,Content=@content,CardImg=@cardImg,ContentImg=@contentImg WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",n.ID);
                cmd.Parameters.AddWithValue("@title",n.NewsTitle);
                cmd.Parameters.AddWithValue("@description", n.NewsDescription);
                cmd.Parameters.AddWithValue("@content", n.NewsContent);
                cmd.Parameters.AddWithValue("@cardImg", n.NewsCardImg);
                cmd.Parameters.AddWithValue("@contentImg", n.NewsContentImg);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region MatchDetail

        #endregion

        #region OpposingTeam
       
        #endregion

        #region Stadium
        public List<Stadium> StadiumList()
        {
            List<Stadium> stadiums = new List<Stadium>();
            try
            {
                cmd.CommandText = ("Select * From Stadiums");
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Stadium st = new Stadium();
                    st.ID = reader.GetInt32(0);
                    st.StadiumName = reader.GetString(1);
                    st.StadiumCity = reader.GetString(2);
                    st.StadiumDistrict = reader.GetString(3);
                    stadiums.Add(st);
                }
                return stadiums;
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
        public List<OpposingTeam> OpposingTeamList()
        {
            List<OpposingTeam> opposingTeams = new List<OpposingTeam>();
            try
            {
                cmd.CommandText = ("Select * From OpposingTeam");
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OpposingTeam ot= new OpposingTeam();
                    ot.ID = reader.GetInt32(0);
                    ot.Name  = reader.GetString(1);
                    ot.logo = reader.GetString(2);
                    opposingTeams.Add(ot);
                }
                return opposingTeams;
            }
            catch 
            {
                return null;
            }
            finally { con.Close(); }
        }
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
                cmd.Parameters.AddWithValue("@id", id);
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
                cmd.Parameters.AddWithValue("@id", id);
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
                cmd.Parameters.AddWithValue("@id", a.ID);
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
        public bool AboutUsAdd(About a)
        {
            try
            {
                cmd.CommandText = "INSERT INTO AboutUs (Title,Content,Img,Img2,Img3) VALUES(@title,@content,@img,@img2,@img3)";
                cmd.Parameters.Clear();
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
        public List<Card> CardList()
        {
            List<Card> cards = new List<Card>();
            try
            {
                cmd.CommandText = "Select * From Card";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Card c = new Card();
                    c.ID = reader.GetInt32(0);
                    c.CardName = reader.GetString(1);
                    cards.Add(c);
                }
                return cards;
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
        #endregion
    }
}
