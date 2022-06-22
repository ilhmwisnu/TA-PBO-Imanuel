using PBO_Imanuel.Controller;
using PBO_Imanuel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBO_Imanuel
{
    public partial class Ubah : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            if (!Page.IsPostBack)
            {
                Mobil mobil = MobilDB.getDataById(id);

                model.Text = mobil.model;
                silinder.Text = mobil.jumlah_silinder.ToString();
                harga.Text = mobil.harga.ToString();
                dimensi.Text = mobil.dimensi;
                sistem.Text = mobil.dimensi;
                kapasitas.Text = mobil.kapasitas_tangki.ToString();
                mesin.Text = mobil.mesin;
                daya.Text = mobil.daya.ToString();
                imageUrl.Text = mobil.imgUrl;
            }

            
        }

        protected void updateData(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
            data.Add("model", model.Text);
            data.Add("jumlah_silinder", silinder.Text);
            data.Add("harga", harga.Text);
            data.Add("dimensi", dimensi.Text);
            data.Add("sistem_penggerak", sistem.Text);
            data.Add("kapasitas_tangki", kapasitas.Text);
            data.Add("mesin", mesin.Text);
            data.Add("daya", daya.Text);
            data.Add("img_url", imageUrl.Text);

            var res = MobilDB.updateMobil(id, data);

            if (res == "berhasil")
            {
                Response.Redirect("~/");
            }
            else
            {
                result.Text = res;
            }
        }
    }
}