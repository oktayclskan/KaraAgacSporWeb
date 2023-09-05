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
                cmd.CommandText = "Select m.ID, s.Name,ot.Name,ot.Logo,m.MyTeamScore,m.OpposingTeamScore,m.StadiumOwner,m.MatchDateTime\r\nFrom Matches AS m\r\njoin Stadiums AS s ON s.ID=m.StadiumID\r\njoin OpposingTeam AS ot ON ot.ID=m.OpposingTeamID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Matches m = new Matches();
                    m.ID = reader.GetInt32(0);
                    m.StadiumName = reader.GetString(1);
                    m.OpposingTeamName = reader.GetString(2);
                    m.OppesingTeamLogo = reader.GetString(3);
                    m.MyTeamScore = reader.GetInt32(4);
                    m.OpposingTeamScore = reader.GetInt32(5);
                    m.StadiumOwner = reader.GetBoolean(6);
                    m.StadiumOwnerStr = reader.GetBoolean(6) ? "<label style='color:green'>Ev Sahini</label>" : "<label style='color:red'>Deplasman</label>";
                    m.MatchDateTime = reader.GetDateTime(7);

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
        public List<Matches> MatchesListLast()
        {
            List<Matches> matches = new List<Matches>();
            try
            {
                cmd.CommandText = "SELECT m.ID, s.Name, ot.Name, ot.Logo, m.MyTeamScore, m.OpposingTeamScore, m.StadiumOwner, m.MatchDateTime\r\nFROM Matches AS m\r\nJOIN Stadiums AS s ON s.ID = m.StadiumID\r\nJOIN OpposingTeam AS ot ON ot.ID = m.OpposingTeamID\r\nWHERE m.MatchDateTime = (SELECT MAX(MatchDateTime) FROM Matches);";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Matches m = new Matches();
                    m.ID = reader.GetInt32(0);
                    m.StadiumName = reader.GetString(1);
                    m.OpposingTeamName = reader.GetString(2);
                    m.OppesingTeamLogo = reader.GetString(3);
                    m.MyTeamScore = reader.GetInt32(4);
                    m.OpposingTeamScore = reader.GetInt32(5);
                    m.StadiumOwner = reader.GetBoolean(6);
                    m.StadiumOwnerStr = reader.GetBoolean(6) ? "<label style='color:green'>Ev Sahini</label>" : "<label style='color:red'>Deplasman</label>";
                    m.MatchDateTime = reader.GetDateTime(7);

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
                cmd.Parameters.AddWithValue("@stadiumID", m.StadiumID);
                cmd.Parameters.AddWithValue("@opposingTeamID", m.OpposingTeamID);
                cmd.Parameters.AddWithValue("@myTeamScore", m.MyTeamScore);
                cmd.Parameters.AddWithValue("@opposingTeamScore", m.OpposingTeamScore);
                cmd.Parameters.AddWithValue("@stadiumOwner", m.StadiumOwner);
                cmd.Parameters.AddWithValue("@matchDateTime", m.MatchDateTimeStr);
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
        public bool MatchUpdate(Matches m)
        {
            try
            {
                cmd.CommandText = "Update Matches Set StadiumID=@stadiumID,OpposingTeamID=@opposingTeamID,MyTeamScore=@myTeamScore,OpposingTeamScore=@opposingTeamScore,StadiumOwner=@stadiumOwner,MatchDateTime=@matchDateTime WHERE ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", m.ID);
                cmd.Parameters.AddWithValue("@stadiumID", m.StadiumID);
                cmd.Parameters.AddWithValue("@opposingTeamID", m.OpposingTeamID);
                cmd.Parameters.AddWithValue("@myTeamScore", m.MyTeamScore);
                cmd.Parameters.AddWithValue("@opposingTeamScore", m.OpposingTeamScore);
                cmd.Parameters.AddWithValue("@stadiumOwner", m.StadiumOwner);
                cmd.Parameters.AddWithValue("@matchDateTime", m.MatchDateTime);
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
                cmd.Parameters.AddWithValue("@title", n.NewsTitle);
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
                cmd.Parameters.AddWithValue("@id", n.ID);
                cmd.Parameters.AddWithValue("@title", n.NewsTitle);
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
        //public List<MatchDetail> MatchDetailsList()
        //{
        //    List<MatchDetail>matchDetails = new List<MatchDetail>();
        //    try
        //    {
        //        cmd.CommandText = "Select m.OpposingTeamID,p.Name,md.Goal,md.GoalTime,c.Name,md.CardTime\r\nFrom MatchDetail AS md\r\njoin Matches AS m ON md.MatchID=m.ID\r\njoin Players AS p ON md.PlayerID=m.ID\r\njoin Cards AS c ON md.CardID=c.ID";
        //        cmd.Parameters.Clear();
        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            MatchDetail md = new MatchDetail();
        //            md.
        //        }
        //    }
        //    catch { return null; }
        //    finally { con.Close(); }
        //}

        public List<MatchDetail> MatchDetailsList()
        {
            List<MatchDetail> matchDetailsList = new List<MatchDetail>();
            try
            {
                cmd.CommandText = "Select md.ID,c.Name,p.Name,md.MyTeamGoal,md.MyTeamTime,md.OpposingTeamPlayerName,md.OpposingTeamGoal,md.OpposingTeamTime\r\nFrom MatchDetails AS md\r\njoin Cards AS c ON c.ID=md.CardID\r\njoin Players AS p ON p.ID=md.PlayerID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MatchDetail md = new MatchDetail();
                    md.ID = reader.GetInt32(0);
                    md.CardName = reader.GetString(1);
                    md.PlayerName = reader.GetString(2);
                    md.MyTeamGoal = reader.GetBoolean(3);
                    md.MyTeamGoalStr = reader.GetBoolean(3) ? "<label style='color:green'>1 Gol</label>" : "<label style='color:red'>--</label>";
                    md.MyTeamTime = reader.GetString(4);
                    md.OpposingTeamPlayerName = reader.GetString(5);
                    md.OpposingTeamGoal = reader.GetBoolean(6);
                    md.OpposingTeamGoalStr = reader.GetBoolean(6) ? "<label style='color:green'>1 Gol</label>" : "<label style='color:red'>--</label>";
                    md.OpposingTeamTime = reader.GetString(7);
                    matchDetailsList.Add(md);

                }
                return matchDetailsList;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        #endregion

        #region OpposingTeam
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
                    OpposingTeam ot = new OpposingTeam();
                    ot.ID = reader.GetInt32(0);
                    ot.Name = reader.GetString(1);
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
        public OpposingTeam OpposingTeamGet(int id)
        {
            try
            {
                cmd.CommandText = "Select ID,Name,Logo From OpposingTeam Where ID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                OpposingTeam ot = new OpposingTeam();
                while (reader.Read())
                {
                    ot.ID = reader.GetInt32(0);
                    ot.Name = reader.GetString(1);
                    ot.logo = reader.GetString(2);
                }
                return ot;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public bool OpposingTeamDl(int id)
        {
            try
            {
                cmd.CommandText = "Delete OpposingTeam Where ID=@id";
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
        public bool OpposingTeamAdd(OpposingTeam ot)
        {
            try
            {
                cmd.CommandText = "INSERT INTO OpposingTeam (Name,Logo) VALUES (@name,@logo)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", ot.Name);
                cmd.Parameters.AddWithValue("@logo", ot.logo);
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
        public bool OpposingTeamUpdate(OpposingTeam ot)
        {
            try
            {
                cmd.CommandText = "Update OpposingTeam Set Name=@name ,Logo=@logo WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", ot.ID);
                cmd.Parameters.AddWithValue("@name", ot.Name);
                cmd.Parameters.AddWithValue("@logo", ot.logo);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally { con.Close(); }
        }
        #endregion

        #region Stadium
        public List<Stadium> StadiumList()
        {
            List<Stadium> stadiums = new List<Stadium>();
            try
            {
                con.Open();
                cmd.CommandText = "Select * From Stadiums WHERE Status = 1";
                cmd.Parameters.Clear();
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
                reader.Close(); // Okuyucuyu kapat
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

        public bool StadyumSoftDlt(int id)
        {
            try
            {
                cmd.CommandText = "Update Stadiums Set Status=0 WHERE ID=@id";
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

        public bool StadiumAdd(Stadium s)
        {
            try
            {
                cmd.CommandText = "INSERT INTO Stadiums (Name,City,District,Status) VALUES (@name,@city,@district,1)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", s.StadiumName);
                cmd.Parameters.AddWithValue("@city", s.StadiumCity);
                cmd.Parameters.AddWithValue("@district", s.StadiumDistrict);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
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
                cmd.CommandText = "Select ID,Title,Content From AboutUs Where ID=@id";
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
                    ;
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
                cmd.CommandText = "UPDATE AboutUs Set Title=@title, Content=@content WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", a.ID);
                cmd.Parameters.AddWithValue("@title", a.Title);
                cmd.Parameters.AddWithValue("@content", a.Content);

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
                cmd.CommandText = "INSERT INTO AboutUs (Title,Content) VALUES(@title,@content,@img,@img2,@img3)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@title", a.Title);
                cmd.Parameters.AddWithValue("@content", a.Content);

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
        #region Fixture
        public List<PointFixture> PointFixtureList()
        {
            List<PointFixture> PointFixtures = new List<PointFixture>();
            try
            {
                cmd.CommandText = "SELECT pt.ID, ot.Name, pt.Win, pt.Draw, pt.Lose, pt.Point\r\nFROM PointFixture AS pt\r\nJOIN OpposingTeam AS ot ON pt.OpposingTeamID = ot.ID\r\nORDER BY pt.Point DESC";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    PointFixture c = new PointFixture();
                    c.ID = reader.GetInt32(0);
                    c.OpposingTeamName = reader.GetString(1);
                    c.Win = reader.GetInt32(2);
                    c.Draw = reader.GetInt32(3);
                    c.Lose = reader.GetInt32(4);
                    c.Point = reader.GetInt32(5);
                    PointFixtures.Add(c);
                }
                return PointFixtures;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public bool FixtureAdd(PointFixture pf)
        {
            try
            {
                cmd.CommandText = "INSERT INTO PointFixture(OpposingTeamID,Win,Draw,Lose,Point) VALUES(@opposing, @win, @draw, @lose, @point)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@opposing", pf.OpposingTeamID);
                cmd.Parameters.AddWithValue("@win", pf.Win);
                cmd.Parameters.AddWithValue("@draw", pf.Draw);
                cmd.Parameters.AddWithValue("@lose", pf.Lose);
                cmd.Parameters.AddWithValue("@point", pf.Point);
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
        public bool FixtureUpdate(PointFixture pf)
        {
            try
            {
                cmd.CommandText = "UPDATE PointFixture SET Win = @win, Draw = @draw, Lose = @lose, Point = @point WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", pf.ID);
                cmd.Parameters.AddWithValue("@win", pf.Win);
                cmd.Parameters.AddWithValue("@draw", pf.Draw);
                cmd.Parameters.AddWithValue("@lose", pf.Lose);
                cmd.Parameters.AddWithValue("@point", pf.Point);
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
        public PointFixture FixtureGet(int id)
        {
            try
            {
                PointFixture pf = new PointFixture();
                cmd.CommandText = "Select ID,OpposingTeamID,Win,Draw,Lose,Point From PointFixture  WHERE ID = @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pf.ID = reader.GetInt32(0);
                    pf.OpposingTeamID = reader.GetInt32(1);
                    pf.Win = reader.GetInt32(2);
                    pf.Draw = reader.GetInt32(3);
                    pf.Lose = reader.GetInt32(4);
                    pf.Point = reader.GetInt32(5);
                }
                return pf;
            }
            catch
            {
                return null;
            }
            finally { con.Close(); }
        }
        public bool FixtureDlt(int id)
        {
            try
            {
                cmd.CommandText = "Delete PointFixture Where ID=@id";
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
        #region Next Match

        public List<NextMatch> NextMatchList()
        {
            List<NextMatch> nextMatche = new List<NextMatch>();
            try
            {
                cmd.CommandText = "\r\nSELECT nm.ID, ot.Name, ot.Logo, s.Name, nm.Date\r\nFROM NextMatch AS nm\r\nJOIN OpposingTeam AS ot ON nm.OpposingTeamID = ot.ID\r\nJOIN Stadiums AS s ON nm.StadiumID = s.ID\r\nWHERE nm.Date = (\r\n    SELECT MIN(Date)\r\n    FROM NextMatch\r\n    WHERE Date >= GETDATE()\r\n); ";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NextMatch nm = new NextMatch();
                    nm.ID = reader.GetInt32(0);
                    nm.OpposingTeamName = reader.GetString(1);
                    nm.OpposingTeamLogo = reader.GetString(2);
                    nm.StadiumName = reader.GetString(3);
                    nm.Date = reader.GetDateTime(4);
                    nm.DateStr = reader.GetDateTime(4).ToLongDateString();
                    nm.DateShortStr = reader.GetDateTime(4).ToShortTimeString();
                    nextMatche.Add(nm);
                }
                return nextMatche;
            }
            catch { return null; }
            finally { con.Close(); }
        }
        public bool NextMatchAdd(NextMatch nm)
        {
            try
            {
                cmd.CommandText = "INSERT INTO NextMatch(OpposingTeamID,StadiumID,Date) VALUES(@opposing,@stadium,@date)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@opposing", nm.OpposingTeamID);
                cmd.Parameters.AddWithValue("@stadium", nm.StadiumID);
                cmd.Parameters.AddWithValue("@date", nm.Date);
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
        public bool NextMatchDlt(int id)
        {
            try
            {
                cmd.CommandText = "Delete NextMatch Where ID=@id";
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
    }
}
