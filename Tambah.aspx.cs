using PBO_Imanuel.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PBO_Imanuel
{
    public partial class Tambah : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insertData(object sender, EventArgs e)
        {
            Dictionary<string, dynamic> data = new Dictionary<string, dynamic>();
            data.Add("model", model.Text);
            data.Add("jumlah_silinder", silinder.Text);
            data.Add("harga", harga.Text);
            data.Add("dimensi", dimensi.Text);
            data.Add("sistem_penggerak", sistem.Text);
            data.Add("kapasitas_tangki", kapasitas.Text);
            data.Add("mesin", mesin.Text);
            data.Add("daya", daya.Text);
            data.Add("imgUrl", imageUrl.Text);

            var res = MobilDB.createMobil(data);
             
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