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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Mobil> dataMobil = MobilDB.readMobil();
            foreach (Mobil mobil in dataMobil)
            //for(int i = 0; i<5; i++)
            {
                //coll.InnerHtml = "tes";
                //coll.InnerHtml = coll.InnerHtml + "<h1>Tes</h1>";
                coll.InnerHtml += $"<div class=\"rounded p-4 cardd text-white mb-3\"><div class=\"row\"><div class=\"col-8\">Model :  <span>{mobil.model}</span><br />Jumlah silinder : <span>{mobil.jumlah_silinder}</span><br />Harga : <span>Mulai Rp {mobil.harga} Juta</span><br />Dimensi : <span>{mobil.dimensi}</span><br />Sistem penggerak roda : <span>{mobil.sistem_penggerak}</span><br />Kapasitas tangki BBM : <span>{mobil.kapasitas_tangki} L</span><br />Mesin : <span>{mobil.mesin}</span><br />Daya kuda : <span>{mobil.daya} HP</span><br /></div><div class=\"col-4\"><div class=\"row\"><img width=\"300\" src=\"{mobil.imgUrl}\" alt=\"tes\" class=\"rounded mx-auto\" /><div class=\"col text-center mt-3\"><a href=\"Ubah?id={mobil.id}\" runat=\"server\" class=\"btn btn-primary mr-2\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-pen-fill\" viewBox=\"0 0 16 16\"><path d=\"m13.498.795.149-.149a1.207 1.207 0 1 1 1.707 1.708l-.149.148a1.5 1.5 0 0 1-.059 2.059L4.854 14.854a.5.5 0 0 1-.233.131l-4 1a.5.5 0 0 1-.606-.606l1-4a.5.5 0 0 1 .131-.232l9.642-9.642a.5.5 0 0 0-.642.056L6.854 4.854a.5.5 0 1 1-.708-.708L9.44.854A1.5 1.5 0 0 1 11.5.796a1.5 1.5 0 0 1 1.998-.001z\" /></svg></a><a href=\"Delete?id={mobil.id}\" class=\"btn btn-danger\"><svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"currentColor\" class=\"bi bi-trash-fill\" viewBox=\"0 0 16 16\"><path d=\"M2.5 1a1 1 0 0 0-1 1v1a1 1 0 0 0 1 1H3v9a2 2 0 0 0 2 2h6a2 2 0 0 0 2-2V4h.5a1 1 0 0 0 1-1V2a1 1 0 0 0-1-1H10a1 1 0 0 0-1-1H7a1 1 0 0 0-1 1H2.5zm3 4a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 .5-.5zM8 5a.5.5 0 0 1 .5.5v7a.5.5 0 0 1-1 0v-7A.5.5 0 0 1 8 5zm3 .5v7a.5.5 0 0 1-1 0v-7a.5.5 0 0 1 1 0z\" /></svg></a></div></div></div></div></div>";
            }
        }
    }
}