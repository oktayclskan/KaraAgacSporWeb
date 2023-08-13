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
    public partial class AboutUsAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_aboutUsAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_title.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(tb_content.Text.Trim()))
                {
                    About a = new About();
                    a.Title = tb_title.Text;
                    a.Content = tb_content.Text;
                    if (fu_img1.HasFile)
                    {
                        FileInfo img1 = new FileInfo(fu_img1.FileName);
                        string connect = img1.Extension;
                        string name = Guid.NewGuid().ToString();
                        a.Img = name + connect;
                        fu_img1.SaveAs(Server.MapPath("Assets/Img/" + name + connect));

                        if (fu_img2.HasFile)
                        {
                            FileInfo img2 = new FileInfo(fu_img2.FileName);
                            string img2connect = img2.Extension;
                            string img2name = Guid.NewGuid().ToString();
                            a.Img2 = img2name + img2connect;
                            fu_img2.SaveAs(Server.MapPath("Assets/Img/" + img2name + img2connect));



                            if (fu_img3.HasFile)
                            {
                                FileInfo img3 = new FileInfo(fu_img3.FileName);
                                string img3connect = img3.Extension;
                                string img3name = Guid.NewGuid().ToString();
                                a.Img3 = img3name + img3connect;
                                fu_img3.SaveAs(Server.MapPath("Assets/Img/" + img3name + img3connect));

                                if (dm.AboutUsAdd(a))
                                {
                                    tb_title.Text = " ";
                                    tb_content.Text = " ";
                                    pnl_succes.Visible = true;
                                }
                                else
                                {
                                    pnl_error.Visible = true;
                                    lbl_eror.Text = "Eklenirken Bir Hata Oluştu";
                                }
                            }
                        }
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
                lbl_eror.Text = "Lütfen Başlık ekleyiniz";
            }

        }
    }
}