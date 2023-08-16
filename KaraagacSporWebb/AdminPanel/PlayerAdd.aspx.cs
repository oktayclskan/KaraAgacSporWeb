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
    public partial class PlayerAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void btn_PlayerAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(tb_surname.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(tb_dateOfBirth.ToString()))
                    {
                        if (!string.IsNullOrEmpty(tb_uniformNumber.Text.Trim()))
                        {
                            if (!string.IsNullOrEmpty(tb_position.Text.Trim()))
                            {
                                Players p = new Players();
                                p.PlayerName = tb_name.Text;
                                p.PlayerSurname = tb_surname.Text;
                                p.PlayerDateOfBirth = Convert.ToDateTime(tb_dateOfBirth.Text);
                                p.PlayerUniformNumber = tb_uniformNumber.Text;
                                p.PlayerPosition = tb_position.Text;
                                p.PlayerFirstEleven = cb_firstEleven.Checked;
                                p.PlayerStatusPlayer = cb_playerStatus.Checked;
                                if (fu_img.HasFile)
                                {
                                    FileInfo img1 = new FileInfo(fu_img.FileName);
                                    string connect = img1.Extension;
                                    string name = Guid.NewGuid().ToString();
                                    p.PlayerImg = name + connect;
                                    fu_img.SaveAs(Server.MapPath("Assets/Img/" + name + connect));
                                    if (dm.PlayerAdd(p))
                                    {
                                        tb_name.Text = " ";
                                        tb_surname.Text = " ";
                                        tb_dateOfBirth.Text = " ";
                                        tb_uniformNumber.Text = " ";
                                        tb_position.Text = " ";
                                        cb_firstEleven.Checked =false;
                                        cb_playerStatus.Checked =false;
                                        pnl_succes.Visible = true;
                                    }
                                    else
                                    {
                                        pnl_error.Visible = true;
                                        lbl_eror.Text = "Eklenirken Bir Hata Oluştu";
                                    }
                                }
                            }
                            else
                            {
                                pnl_error.Visible = true;
                                lbl_eror.Text = "Lütfen Mevki ekleyiniz";
                            }
                        }
                        else
                        {
                            pnl_error.Visible = true;
                            lbl_eror.Text = "Lütfen Forma Numarası ekleyiniz";
                        }
                    }
                    else
                    {
                        pnl_error.Visible = true;
                        lbl_eror.Text = "Lütfen Doğum Tarihi ekleyiniz";
                    }
                }
                else
                {
                    pnl_error.Visible = true;
                    lbl_eror.Text = "Lütfen Soyisim ekleyiniz";
                }
            }
            else
            {
                pnl_error.Visible = true;
                lbl_eror.Text = "Lütfen İsim ekleyiniz";
            }
        }
    }
}