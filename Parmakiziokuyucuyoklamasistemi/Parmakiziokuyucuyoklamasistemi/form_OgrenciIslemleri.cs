using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parmakiziokuyucuyoklamasistemi
{
    public partial class form_OgrenciIslemleri : Form
    {
        public form_OgrenciIslemleri()
        {
            InitializeComponent();
        }

        SQL Sql = new SQL();

        private void btn_OgrenciListesiAl_Click(object sender, EventArgs e)
        {
            liste_OgrenciListesi.Items.Clear();
            string komut_Ogrenci = "SELECT * FROM [Parmak İzi Yoklama Sistemi].dbo.Ögrenci";
            DataTable tablo_Ogrenci = Sql.Tablo(komut_Ogrenci);
            string komut_Parmakizi; DataTable tablo_Parmakizi;

            for (int i = 0; i < tablo_Ogrenci.Rows.Count; i++)
            {
                komut_Parmakizi = "SELECT Fp_id FROM [Parmak İzi Yoklama Sistemi].dbo.Parmakİzi WHERE Parmakİzi_id = " + Int16.Parse(tablo_Ogrenci.Rows[i]["Parmakİzi_id"].ToString());
                tablo_Parmakizi = Sql.Tablo(komut_Parmakizi);
                string[] Satir = {  tablo_Ogrenci.Rows[i]["ÖgrenciNo"].ToString(),
                                    tablo_Ogrenci.Rows[i]["ÖgrenciAdı"].ToString(),
                                    tablo_Ogrenci.Rows[i]["ÖgrenciSoyad"].ToString(),
                                    tablo_Parmakizi.Rows[0]["Fp_id"].ToString(),
                                    };
                ListViewItem listItem = new ListViewItem(Satir);
                liste_OgrenciListesi.Items.Add(listItem);
            }
        }
    }
}
