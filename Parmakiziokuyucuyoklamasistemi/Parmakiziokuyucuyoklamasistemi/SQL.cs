using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Parmakiziokuyucuyoklamasistemi
{
    class SQL
    {
        SqlConnection baglanti = new SqlConnection("Data Source=AHMED;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public DataTable Tablo(string komutString)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = komutString;
            komut.Connection = baglanti;
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            adap.Fill(tablo);

            return tablo;
        }

        public bool conOpen()
        {
            if (baglanti.State.ToString() != "Open") baglanti.Open();
            else MessageBox.Show("Bağlantı zaten açık");
            if (baglanti.State.ToString() == "Open") return true;
            else return false;
        }

        public bool conClose()
        {
            baglanti.Close();
            if (baglanti.State.ToString() == "Closed") return true;
            else return false;
        }

        public bool conCheck()
        {
            if (baglanti.State.ToString() == "Open") return true;
            else return false;
        }

        public void Add(string komutString)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = komutString;
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();
        }
    }
}