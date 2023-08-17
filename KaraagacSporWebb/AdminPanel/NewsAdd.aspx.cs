using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccesLayer;
using System.IO;
namespace KaraagacSporWebb.AdminPanel
{
    public partial class NewsAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }




        protected void btn_newssAdd_Click1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_title.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(tb_description.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(tb_content.Text.Trim()))
                    {
                        News n = new News();
                        n.NewsTitle = tb_title.Text;
                        n.NewsDescription = tb_description.Text;
                        n.NewsContent = tb_content.Text;
                        n.NewsDate = DateTime.Now;
                        if (fu_cardImg.HasFile)
                        {
                            FileInfo cardImg = new FileInfo(fu_cardImg.FileName);
                            string connect = cardImg.Extension;
                            string name = Guid.NewGuid().ToString();
                            n.NewsCardImg = name + connect;
                            fu_cardImg.SaveAs(Server.MapPath("Assets/Img/" + name + connect));

                            if (fu_ContentImg.HasFile)
                            {
                                FileInfo contentImg = new FileInfo(fu_ContentImg.FileName);
                                string img2connect = contentImg.Extension;
                                string img2name = Guid.NewGuid().ToString();
                                n.NewsContentImg = img2name + img2connect;
                                fu_ContentImg.SaveAs(Server.MapPath("Assets/Img/" + img2name + img2connect));

                                if (dm.NewsAdd(n))
                                {
                                    tb_title.Text = " ";
                                    tb_content.Text = " ";
                                    tb_description.Text = " ";
                                    pnl_succes.Visible = true;
                                    pnl_error.Visible = false;
                                }
                                else
                                {
                                    pnl_error.Visible = true;
                                    lbl_eror.Text = "Eklenirken Bir Hata Oluştu";
                                }


                            }
                            else
                            {
                                pnl_error.Visible = true;
                                lbl_eror.Text = "Lütfen İçerik Resmi ekleyiniz";
                            }
                        }
                        else
                        {
                            pnl_error.Visible = true;
                            lbl_eror.Text = "Lütfen Kart Resmi ekleyiniz";
                        }

                    }
                    else
                    {
                        pnl_error.Visible = true;
                        lbl_eror.Text = "Lütfen İçerik ekleyiniz";
                    }
                }
                else
                {
                    pnl_error.Visible = true;
                    lbl_eror.Text = "Lütfen özet ekleyiniz";
                }
            }
            else
            {
                pnl_error.Visible = true;
                lbl_eror.Text = "Lütfen Başlık ekleyiniz";
            }
        }
    }
}