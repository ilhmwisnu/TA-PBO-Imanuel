using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PBO_Imanuel.Model
{
    public class Mobil
    {
        public string id;
        public string model;
        public int harga;
        public string dimensi;
        public string sistem_penggerak;
        public int kapasitas_tangki;
        public string mesin;
        public int daya;
        public int jumlah_silinder;
        public string imgUrl;

        public Mobil(string model, int harga, string dimensi, string sistem_penggerak, int kapasitas_tangki, string mesin, int daya, int jumlah_silinder, string imgUrl,string id)
        {
            this.id = id;
            this.model = model;
            this.harga = harga;
            this.dimensi = dimensi;
            this.sistem_penggerak = sistem_penggerak;
            this.kapasitas_tangki = kapasitas_tangki;
            this.mesin = mesin;
            this.daya = daya;
            this.jumlah_silinder = jumlah_silinder;
            this.imgUrl = imgUrl;
        }

    }
}