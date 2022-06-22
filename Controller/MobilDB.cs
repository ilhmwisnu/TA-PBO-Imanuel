using Npgsql;
using PBO_Imanuel.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace PBO_Imanuel.Controller
{
    public class MobilDB
    {
        public static string createMobil(Dictionary<string, dynamic> data)
        {
            try
            {
                /* Insertion After Validations*/
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = $"INSERT INTO mobil (model, harga, dimensi, sistem_penggerak, kapasitas_tangki, mesin, daya, jumlah_silinder, img_url) VALUES('{data["model"]}' , {data["harga"]}, '{data["dimensi"]}', '{data["sistem_penggerak"]}', {data["kapasitas_tangki"]}, '{data["mesin"]}', {data["daya"]}, {data["jumlah_silinder"]}, '{data["imgUrl"]}');";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                    return "berhasil";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        public static List<Mobil> readMobil()
        {
            List<Mobil> listMobil = new List<Mobil>();

            try /* Select After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "Select * from mobil";
                    cmd.CommandType = CommandType.Text;

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string model = dt.Rows[i]["model"].ToString();
                        int harga = int.Parse(dt.Rows[i]["harga"].ToString());
                        string dimensi = dt.Rows[i]["dimensi"].ToString();
                        string sistem_penggerak = dt.Rows[i]["sistem_penggerak"].ToString();
                        int kapasitas_tangki = int.Parse(dt.Rows[i]["kapasitas_tangki"].ToString());
                        string mesin = dt.Rows[i]["mesin"].ToString();
                        int daya = int.Parse(dt.Rows[i]["daya"].ToString());
                        int jumlah_silinder = int.Parse(dt.Rows[i]["jumlah_silinder"].ToString());
                        string imgUrl = dt.Rows[i]["img_url"].ToString();
                        string id = dt.Rows[i]["id"].ToString();


                        Mobil mobil = new Mobil(model, harga, dimensi, sistem_penggerak, kapasitas_tangki, mesin, daya, jumlah_silinder, imgUrl, id);

                        listMobil.Add(mobil);
                    }

                    cmd.Dispose();
                    connection.Close();

                    //warning.Text = dt.Rows[0]["deadline"].ToString();
                }
            }
            catch (Exception ex)
            {

            }

            return listMobil;
        }

        public static Mobil getDataById(string id)
        {
            try /* Select After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = $"Select * from mobil where id = '{id}'";
                    cmd.CommandType = CommandType.Text;

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);



                    string model = dt.Rows[0]["model"].ToString();
                    int harga = int.Parse(dt.Rows[0]["harga"].ToString());
                    string dimensi = dt.Rows[0]["dimensi"].ToString();
                    string sistem_penggerak = dt.Rows[0]["sistem_penggerak"].ToString();
                    int kapasitas_tangki = int.Parse(dt.Rows[0]["kapasitas_tangki"].ToString());
                    string mesin = dt.Rows[0]["mesin"].ToString();
                    int daya = int.Parse(dt.Rows[0]["daya"].ToString());
                    int jumlah_silinder = int.Parse(dt.Rows[0]["jumlah_silinder"].ToString());
                    string imgUrl = dt.Rows[0]["img_url"].ToString();

                    Mobil mobil = new Mobil(model, harga, dimensi, sistem_penggerak, kapasitas_tangki, mesin, daya, jumlah_silinder, imgUrl, id);

                    cmd.Dispose();
                    connection.Close();

                    return mobil;
                }
            }
            catch (Exception ex)
            {
                return null;
            }


        }

        public static string updateMobil(string id, Dictionary<string, dynamic> data)
        {
            try /* Updation After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = $"UPDATE mobil SET model ='{data["model"]}', harga ={data["harga"]}, dimensi ='{data["dimensi"]}', sistem_penggerak ='{data["sistem_penggerak"]}', kapasitas_tangki ={data["kapasitas_tangki"]}, mesin ='{data["mesin"]}', daya ={data["daya"]}, jumlah_silinder ={data["jumlah_silinder"]}, img_url ='{data["img_url"]}' WHERE id = '{id}';";
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                }
                return "berhasil";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string deleteMobil(string id)
        {
            try /* Deletion After Validations*/
            {
                using (NpgsqlConnection connection = new NpgsqlConnection())
                {
                    connection.ConnectionString = ConfigurationManager.ConnectionStrings["stringku"].ToString();
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = $"Delete from mobil where id={id}";
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                }
                return "berhasil";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}