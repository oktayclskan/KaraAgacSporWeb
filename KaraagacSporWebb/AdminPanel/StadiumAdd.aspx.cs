using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KaraagacSporWebb.AdminPanel
{
    public partial class StadiumAdd : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_StadiumAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(tb_City.Text.Trim()))
                {
                    if (!string.IsNullOrEmpty(tb_Discrit.Text.Trim()))
                    {
                        Stadium s = new Stadium();
                        s.StadiumName = tb_name.Text;
                        s.StadiumCity = tb_City.Text;
                        s.StadiumDistrict = tb_Discrit.Text;
                        s.Status = true;
                        if (dm.StadiumAdd(s))
                        {
                            tb_name.Text = " ";
                            tb_City.Text = " ";
                            tb_Discrit.Text = " ";
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
                        lbl_eror.Text = "Lütfen Stadyum bulunduğu İlçe ekleyiniz";
                    }
                }
                else
                {
                    pnl_error.Visible = true;
                    lbl_eror.Text = "Lütfen Stadyum Bulunduğu Şehir ekleyiniz";
                }
            }
            else
            {
                pnl_error.Visible = true;
                lbl_eror.Text = "Lütfen Stadyum Adı ekleyiniz";
            }
        }
    }
}