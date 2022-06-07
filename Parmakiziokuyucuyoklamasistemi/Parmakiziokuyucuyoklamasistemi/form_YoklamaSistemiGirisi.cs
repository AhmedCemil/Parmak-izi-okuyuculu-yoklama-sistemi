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
    public partial class form_YoklamaSistemiGirisi : Form
    {
        public form_YoklamaSistemiGirisi()
        {
            InitializeComponent();
        }

        SQL Sql = new SQL();
        private form_OgrenciIslemleri form_oi = new form_OgrenciIslemleri();
        private form_OgretimGorevlisi form_og = new form_OgretimGorevlisi();
        private form_Yoklama form_yoklama = new form_Yoklama();

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            
        }

        private void pic_OgrenciIslemleri_Click(object sender, EventArgs e)
        {
            if (!form_oi.Visible) { form_oi = new form_OgrenciIslemleri(); form_oi.Show(); form_oi.Focus(); }
            else { form_oi.Focus(); MessageBox.Show("Pencere zaten açık"); }
        }

        private void pic_OgretimGorevlisi_Click(object sender, EventArgs e)
        {
            if (!form_og.Visible) { form_og = new form_OgretimGorevlisi(); form_og.Show(); form_og.Focus(); }
            else { form_og.Focus(); MessageBox.Show("Pencere zaten açık"); }
        }

        private void pic_YoklamaIslemleri_Click(object sender, EventArgs e)
        {
            if (!form_yoklama.Visible) { form_yoklama = new form_Yoklama(); form_yoklama.Show(); form_yoklama.Focus(); }
            else { form_yoklama.Focus(); MessageBox.Show("Pencere zaten açık"); }
        }

        private void pic_Cikis_Click(object sender, EventArgs e)
        {
            Sql.conClose();
            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
            {
                if (f.Name != "form_YoklamaSistemiGirisi")
                    f.Close();
            }
            Application.Exit();
        }
    }
}
