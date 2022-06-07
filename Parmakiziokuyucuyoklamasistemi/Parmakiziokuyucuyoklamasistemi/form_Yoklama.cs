using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Parmakiziokuyucuyoklamasistemi
{
    public partial class form_Yoklama : Form
    {
        public form_Yoklama()
        {
            InitializeComponent();
        }

        Thread th_yoklamayial;
        SQL Sql = new SQL();
        private form_ArduinoHaberlesmesi form_ah = new form_ArduinoHaberlesmesi();
        private int OG_Parmakizi_id;
        private int Ders_id;
        private bool isThActivated;
        private int id, previous_id;
        private bool dersBulundu;
        private List<int> DersSatiri = new List<int>();

        private void Form2_Load(object sender, EventArgs e)
        {
            OGList();
            btn_OG_Giris.Enabled = false;
            btn_YoklamayiAl.Enabled = false;
            btn_YoklamaAlmayiDurdur.Enabled = false;
            id = 0; previous_id = 0;
        }

        private void OGList()
        {
            string komut_OG = "SELECT ÖgretimGörevlisiAdı, ÖgretimGörevlisiSoyadı, ÖgretimGörevlisiUnvanı FROM [Parmak İzi Yoklama Sistemi].[dbo].[ÖgretimGörevlisi]";
            DataTable tablo_OGTablosu = Sql.Tablo(komut_OG);

            for (int i = 0; i < tablo_OGTablosu.Rows.Count; i++)
            {
                cBox_OgretimGorevlisi.Items.Add(tablo_OGTablosu.Rows[i]["ÖgretimGörevlisiUnvanı"].ToString() + ' ' +
                                                tablo_OGTablosu.Rows[i]["ÖgretimGörevlisiAdı"].ToString()    + ' ' +
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
            OG_Parmakizi_id = Int16.Parse(tablo_OG.Rows[selectedOG]["Parmakizi_id"].ToString());

            for (int i = 0; i < tablo_Dersler.Rows.Count; i++)
            {
                if (tablo_Dersler.Rows[i]["ÖgretimGörevlisi_id"].ToString() == OG_id.ToString())
                {
                    cBox_Dersler.Items.Add(tablo_Dersler.Rows[i]["DersAdı"].ToString());
                    DersSatiri.Add(i);
                }
            }
        }

        private bool ZamanKontrolu()
        {
            string komut_DersProgrami = "SELECT Gün,Saat,Ders_id FROM [Parmak İzi Yoklama Sistemi].dbo.DersProgramı WHERE Ders_id = " + Ders_id;
            DataTable tablo_DersProgrami = Sql.Tablo(komut_DersProgrami);
            dersBulundu = false;
            for (int i = 0; i < tablo_DersProgrami.Rows.Count; i++)
            {
                if (Ders_id.ToString() == tablo_DersProgrami.Rows[i]["Ders_id"].ToString()) dersBulundu = true;
            }
            if (dersBulundu)
            {
                DateTime sqlTime = DateTime.ParseExact(tablo_DersProgrami.Rows[0]["Saat"].ToString(), "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                DateTime sqlTime2 = DateTime.ParseExact(tablo_DersProgrami.Rows[2]["Saat"].ToString(), "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                if (DateTime.Now.ToString("dddd") == tablo_DersProgrami.Rows[0]["Gün"].ToString())
                    if (TimeSpan.Compare(sqlTime.TimeOfDay, DateTime.Now.TimeOfDay) == -1 && TimeSpan.Compare(sqlTime2.TimeOfDay, DateTime.Now.TimeOfDay) >= 0)
                        return true;
                    else return false;
                else return false;
            }
            else
            {
                MessageBox.Show("Ders Programında bu ders bulunamadı.");
                return false;
            }
        }

        private void cBox_Dersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            string komut_Dersler = "SELECT Ders_id FROM [Parmak İzi Yoklama Sistemi].[dbo].[Dersler]";
            DataTable tablo_Dersler = Sql.Tablo(komut_Dersler);
            Ders_id = Int16.Parse(tablo_Dersler.Rows[DersSatiri[cBox_Dersler.SelectedIndex]]["Ders_id"].ToString());
            if (ZamanKontrolu())
            {
                btn_OG_Giris.Enabled = true;
                label_OG_Giris.Text = "Lütfen parmak izinizi okutunuz ve Giriş butonuna basınız.";
            }
            else MessageBox.Show("Seçilen ders zamanında değiliz. Lütfen şimdi verilecek dersi seçiniz.");
        }

        private void btn_OG_Giris_Click(object sender, EventArgs e)
        {
            if (cBox_OgretimGorevlisi.SelectedIndex != -1 && cBox_Dersler.SelectedIndex != -1)
            {
                if (form_ah.isSerialPortOpen())
                {
                    MessageBox.Show(OG_Parmakizi_id.ToString());
                    if (OG_Parmakizi_id == form_ah.receivedID)
                    {
                        label_OG_Giris.Text = "Giriş Başarılı";
                        btn_OG_Giris.Enabled = false;
                        btn_YoklamayiAl.Enabled = true;
                    }
                    else label_OG_Giris.Text = "Giriş başarısız.";
                }
                else MessageBox.Show("Lütfen arduino haberleşmesini sağlayın");
            }
            else MessageBox.Show("Lütfen öğretim görevlisini ve ona ait dersi seçiniz.");
        }

        private void btn_YoklamayiAl_Click(object sender, EventArgs e)
        {
            btn_YoklamayiAl.Enabled = false;
            string komut_Yoklama = "";
            th_yoklamayial = new Thread(() => YoklamayiAl(komut_Yoklama));
            isThActivated = true;
            btn_YoklamaAlmayiDurdur.Enabled = true;
            if (Sql.conOpen())
            {
                th_yoklamayial.Start();
            }
        }

        private void YoklamayiAl(string komut)
        {
            previous_id = OG_Parmakizi_id;
            while (Sql.conCheck())
            {
                id = form_ah.receivedID;
                if (id == -1) MessageBox.Show("Parmakizi eşleşmesi bulunamadı.");
                else if (id < 10 || id > 20)
                {
                    if (previous_id != id)
                    {
                        komut = "INSERT INTO [Parmak İzi Yoklama Sistemi].dbo.Yoklama (Ders_id, Tarih, Saat, Parmakİzi_id) VALUES(" + Ders_id + ",'" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + DateTime.Now.ToString("T") + "'," + id + ") ";
                        Sql.Add(komut); previous_id = id;
                    }
                }
            } th_yoklamayial.Abort(); btn_YoklamaAlmayiDurdur.Enabled = false;
        }

        private void btn_YoklamaAlmayiDurdur_Click(object sender, EventArgs e)
        {
            Sql.conClose(); btn_YoklamayiAl.Enabled = true;
        }

        private void btn_ArduinoHaberlesmesi_Click(object sender, EventArgs e)
        {
            if (!form_ah.Visible) { form_ah = new form_ArduinoHaberlesmesi(); form_ah.Show(); form_ah.Focus(); }
            else { form_ah.Focus(); MessageBox.Show("Pencere zaten açık"); }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_ah.Close(); if(isThActivated) if (th_yoklamayial.IsAlive) th_yoklamayial.Abort();
        }
    }
}