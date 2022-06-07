using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.SqlClient;

namespace Parmakiziokuyucuyoklamasistemi
{
    public partial class form_OgretimGorevlisi : Form
    {
        public form_OgretimGorevlisi()
        {
            InitializeComponent();
        }

        SQL Sql = new SQL();
        private int Ders_id;
        private string DersAdiString;
        private List<int> DersSatiri = new List<int>();

        private void form_OgretimGorevlisi_Load(object sender, EventArgs e)
        {
            OGList();
        }

        private void OGList()
        {
            string komut_OG = "SELECT ÖgretimGörevlisiAdı, ÖgretimGörevlisiSoyadı, ÖgretimGörevlisiUnvanı FROM [Parmak İzi Yoklama Sistemi].[dbo].[ÖgretimGörevlisi]";
            DataTable tablo_OGTablosu = Sql.Tablo(komut_OG);

            for (int i = 0; i < tablo_OGTablosu.Rows.Count; i++)
            {
                cBox_OgretimGorevlisi.Items.Add(tablo_OGTablosu.Rows[i]["ÖgretimGörevlisiUnvanı"].ToString() + ' ' +
                                                tablo_OGTablosu.Rows[i]["ÖgretimGörevlisiAdı"].ToString() + ' ' +
                                                tablo_OGTablosu.Rows[i]["ÖgretimGörevlisiSoyadı"].ToString());
            }
        }

        private void cBox_OgretimGorevlisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            DerslerList(cBox_OgretimGorevlisi.SelectedIndex);
        }

        private void DerslerList(int selectedOG)
        {
            string komut_OG = "SELECT * FROM [Parmak İzi Yoklama Sistemi].[dbo].[ÖgretimGörevlisi]";
            DataTable tablo_OG = Sql.Tablo(komut_OG);

            string komut_Dersler = "SELECT * FROM [Parmak İzi Yoklama Sistemi].[dbo].[Dersler]";
            DataTable tablo_Dersler = Sql.Tablo(komut_Dersler);

            cBox_Dersler.Text = ""; cBox_Dersler.Items.Clear(); DersSatiri.Clear();

            int OG_id = Int16.Parse(tablo_OG.Rows[selectedOG]["ÖgretimGörevlisi_id"].ToString());
            for (int i = 0; i < tablo_Dersler.Rows.Count; i++)
            {
                if (tablo_Dersler.Rows[i]["ÖgretimGörevlisi_id"].ToString() == OG_id.ToString())
                {
                    cBox_Dersler.Items.Add(tablo_Dersler.Rows[i]["DersAdı"].ToString());
                    DersSatiri.Add(i);
                }
            }
        }

        private void cBox_Dersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string komut_Dersler = "SELECT * FROM [Parmak İzi Yoklama Sistemi].[dbo].[Dersler]";
            DataTable tablo_Dersler = Sql.Tablo(komut_Dersler);
            for (int i = 0; i < tablo_Dersler.Rows.Count; i++)
            {
                if (tablo_Dersler.Rows[i]["DersAdı"].ToString() == cBox_Dersler.SelectedItem.ToString())
                {
                    Ders_id = Int16.Parse(tablo_Dersler.Rows[DersSatiri[cBox_Dersler.SelectedIndex]]["Ders_id"].ToString());
                }
            }
        }

        private void liste_Yoklama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            liste_Yoklama.Items.Clear();
            string komut_Yoklama = "SELECT * FROM [Parmak İzi Yoklama Sistemi].dbo.Yoklama";
            DataTable tablo_Yoklama = Sql.Tablo(komut_Yoklama);
            string komut_Dersler = "SELECT * FROM [Parmak İzi Yoklama Sistemi].dbo.Dersler";
            DataTable tablo_Dersler = Sql.Tablo(komut_Dersler);
            string komut_Ogrenci; DataTable tablo_Ogrenci;

            for (int i = 0; i < tablo_Dersler.Rows.Count; i++)
            {
                if (Ders_id.ToString() == tablo_Dersler.Rows[i]["Ders_id"].ToString()) DersAdiString = tablo_Dersler.Rows[i]["DersAdı"].ToString();
            }
            for (int i = 0; i < tablo_Yoklama.Rows.Count; i++)
            {
                if (Ders_id.ToString() == tablo_Yoklama.Rows[i]["Ders_id"].ToString())
                {
                    komut_Ogrenci = "SELECT ÖgrenciNo,ÖgrenciAdı,ÖgrenciSoyad FROM [Parmak İzi Yoklama Sistemi].dbo.Ögrenci WHERE Parmakİzi_id = " + Int16.Parse(tablo_Yoklama.Rows[i]["Parmakİzi_id"].ToString());
                    tablo_Ogrenci = Sql.Tablo(komut_Ogrenci);
                    string[] Satir = {  DersAdiString,
                                        tablo_Yoklama.Rows[i]["Tarih"].ToString(),
                                        tablo_Yoklama.Rows[i]["Saat"].ToString(),
                                        tablo_Ogrenci.Rows[0]["ÖgrenciNo"].ToString(),
                                        tablo_Ogrenci.Rows[0]["ÖgrenciAdı"].ToString(),
                                        tablo_Ogrenci.Rows[0]["ÖgrenciSoyad"].ToString()
                                     };
                    ListViewItem listItem = new ListViewItem(Satir);
                    liste_Yoklama.Items.Add(listItem);
                }
            }
        }
    }
}
