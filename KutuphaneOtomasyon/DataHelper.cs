﻿using KutuphaneOtomasyon.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    internal class DataHelper
    {
        public static string conStr;
        public readonly SqlConnection connect;
        public DataHelper()
        {
            conStr = "Data Source=LAPTOP-VMEL2LCP\\SQLEXPRESS01;Initial Catalog=kutuphane;Integrated Security=True";
            connect = new SqlConnection(conStr);
        }
        public void UyeEkle(UyeIslemModel model)
        {
            SqlCommand ekle = new SqlCommand("INSERT INTO tblUyeler(Ad, Soyad, Meslek) VALUES (@Ad, @Soyad, @Meslek)", connect);
            connect.Open();
            ekle.Parameters.AddWithValue("Ad", model.Ad);
            ekle.Parameters.AddWithValue("Soyad", model.Soyad);
            ekle.Parameters.AddWithValue("Meslek", model.Meslek);
            ekle.ExecuteNonQuery();
            connect.Close();

        }

        public bool UyeSorgu(UyeIslemModel model)
        {
            connect.Open();
            SqlCommand sorgu = new SqlCommand($"SELECT * FROM tblUyeler WHERE Ad = '{model.Ad}' AND Soyad = '{model.Soyad}'", connect);
            SqlDataReader oku = sorgu.ExecuteReader();
            var result = oku.Read();
            connect.Close();
            if (result)
            {
                
                return false;
            }
            return true;
        }

        // TODO: ctrl R+R (Global Rename)
        // TODO: F12 (kaynağına git)
        public void KitapEkle(KitapIslemModel model)
        {
            SqlCommand ekle = new SqlCommand("INSERT INTO tblKitaplar(KitapAdi, Yazar, Tur, Sayfa) VALUES (@KitapAdi, @Yazar, @Tur, @Sayfa)", connect);
            connect.Open();
            ekle.Parameters.AddWithValue("KitapAdi", model.KitapAdi);
            ekle.Parameters.AddWithValue("Yazar", model.Yazar);
            ekle.Parameters.AddWithValue("Tur", model.Tur);
            ekle.Parameters.AddWithValue("Sayfa", model.Sayfa);
            ekle.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("İşleminiz Başarıyla Gerçekleşti.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public bool KitapVer(KitapVerModel model)
        {
            connect.Open();
            if (model.Uygunluk == 0)
            {
                MessageBox.Show("Kitap Emanet Verilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return; metodu ilgili scopeta kesen keyworddür. metot bişey dönmez ancak devam da etmez.
            }
            else if (model.Uygunluk == 1)
            {
                SqlCommand ekle = new SqlCommand("INSERT INTO tblTakip(UyeID, KitapID, AlimTarihi, TeslimTarihi) VALUES (@UyeID, @KitapID, @AlimTarihi, @TeslimTarihi)", connect);
                ekle.Parameters.AddWithValue("UyeID", model.UyeId);
                ekle.Parameters.AddWithValue("KitapID", model.KitapId);
                ekle.Parameters.AddWithValue("AlimTarihi", model.AlimTarihi);
                ekle.Parameters.AddWithValue("TeslimTarihi", model.TeslimTarihi);
                var result = ekle.ExecuteNonQuery();
                if (result == 1)
                {
                    ekle = new SqlCommand("UPDATE tblKitaplar SET Uygunluk=0 WHERE ID=@ID", connect);
                    ekle.Parameters.AddWithValue("ID", model.KitapId);
                    ekle.ExecuteNonQuery();
                    MessageBox.Show("İşleminiz Başarıyla Gerçekleşti.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                connect.Close();
                return true;
            }
            else
            {
                MessageBox.Show("İşleminiz Gerçekleşmedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connect.Close();
            return false;
        }

        public bool KitapTeslimAl(KitapTeslimAlModel model)
        {
            connect.Open();
            SqlCommand UpdateTeslim = new SqlCommand("UPDATE tblTakip SET GeldigiTarih=@GeldigiTarih, IslemSonucu=1 WHERE ID=@ID", connect);
            UpdateTeslim.Parameters.AddWithValue("ID", model.TakipId);
            UpdateTeslim.Parameters.AddWithValue("GeldigiTarih", model.GeldigiTarih);
            UpdateTeslim.ExecuteNonQuery();
            UpdateTeslim = new SqlCommand("UPDATE tblKitaplar SET Uygunluk=1 WHERE ID=@ID", connect);
            UpdateTeslim.Parameters.AddWithValue("ID", model.KitapId);
            var result = UpdateTeslim.ExecuteNonQuery();
            if (result>0)
            {
                if (model.CezaPuani > 0)
                {
                    UpdateTeslim = new SqlCommand("UPDATE tblUyeler SET CezaPuani=@CezaPuani WHERE ID=@ID", connect);
                    UpdateTeslim.Parameters.AddWithValue("ID", model.UyeId);
                    UpdateTeslim.Parameters.AddWithValue("CezaPuani", model.CezaPuani);
                    UpdateTeslim.ExecuteNonQuery();
                }
                connect.Close();
                return true;
            }
            connect.Close();
            return false;
        }

        public bool UyeCezaPuaniSifirla(int uyeId)
        {
            connect.Open();
            SqlCommand updateCezaPuani = new SqlCommand("UPDATE tblUyeler SET CezaPuani=0 WHERE ID=@ID", connect);
            updateCezaPuani.Parameters.AddWithValue("ID", uyeId);
            var result = updateCezaPuani.ExecuteNonQuery();
            connect.Close();
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool UyeSilme(UyeIslemModel model)
        {
            connect.Open();
            SqlCommand sil = new SqlCommand("DELETE FROM tblUyeler WHERE ID=@ID", connect);
            sil.Parameters.AddWithValue("ID", model.Id);
            var result = sil.ExecuteNonQuery();
            connect.Close();
            if(result > 0)
            {
                return true;
            }
            return false;
        }
        public bool KitapSilme(KitapIslemModel model)
        {
            SqlCommand sil = new SqlCommand("DELETE FROM tblKitaplar WHERE ID=@ID", connect);
            connect.Open();
            sil.Parameters.AddWithValue("ID", model.KitapId);
            var result = sil.ExecuteNonQuery();
            connect.Close();
            if( result > 0)
            {
                return true;
            }
            return false;

        }
        public bool UyeGuncelle(UyeIslemModel model)
        {
            SqlCommand guncelle = new SqlCommand("UPDATE tblUyeler SET Ad=@Ad, Soyad=@Soyad, Meslek=@Meslek WHERE ID=@ID", connect);
            connect.Open();
            guncelle.Parameters.AddWithValue("ID", model.Id);
            guncelle.Parameters.AddWithValue("Ad", model.Ad);
            guncelle.Parameters.AddWithValue("Soyad", model.Soyad);
            guncelle.Parameters.AddWithValue("Meslek", model.Meslek);
            guncelle.ExecuteNonQuery();
            connect.Close();
            return true;

        }
        public bool KitapGuncelle(KitapIslemModel model)
        {
            SqlCommand guncelle = new SqlCommand("UPDATE tblKitaplar SET KitapAdi = @KitapAdi, Yazar=@Yazar, Tur=@Tur, Sayfa = @Sayfa WHERE ID=@ID", connect);
            connect.Open();
            guncelle.Parameters.AddWithValue("ID", model.KitapId);
            guncelle.Parameters.AddWithValue("KitapAdi", model.KitapAdi);
            guncelle.Parameters.AddWithValue("Yazar", model.Yazar);
            guncelle.Parameters.AddWithValue("Tur", model.Tur);
            guncelle.Parameters.AddWithValue("Sayfa", model.Sayfa);
            guncelle.ExecuteNonQuery();
            connect.Close();
            return true;

        }
        public DataTable VeriAl(string sql)
        {
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();
            return dt;
        }



    }
}
