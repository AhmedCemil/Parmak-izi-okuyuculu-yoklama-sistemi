
namespace Parmakiziokuyucuyoklamasistemi
{
    partial class form_OgretimGorevlisi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_OgretimGorevlisi = new System.Windows.Forms.ComboBox();
            this.label_Dersler = new System.Windows.Forms.Label();
            this.cBox_Dersler = new System.Windows.Forms.ComboBox();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.liste_Yoklama = new System.Windows.Forms.ListView();
            this.DersAdı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Saat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ÖgrenciNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ÖgrenciAdı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ÖgrenciSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Öğretim Görevlisi :";
            // 
            // cBox_OgretimGorevlisi
            // 
            this.cBox_OgretimGorevlisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_OgretimGorevlisi.FormattingEnabled = true;
            this.cBox_OgretimGorevlisi.Location = new System.Drawing.Point(155, 6);
            this.cBox_OgretimGorevlisi.Name = "cBox_OgretimGorevlisi";
            this.cBox_OgretimGorevlisi.Size = new System.Drawing.Size(219, 24);
            this.cBox_OgretimGorevlisi.TabIndex = 6;
            this.cBox_OgretimGorevlisi.SelectedIndexChanged += new System.EventHandler(this.cBox_OgretimGorevlisi_SelectedIndexChanged);
            // 
            // label_Dersler
            // 
            this.label_Dersler.AutoSize = true;
            this.label_Dersler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Dersler.Location = new System.Drawing.Point(12, 43);
            this.label_Dersler.Name = "label_Dersler";
            this.label_Dersler.Size = new System.Drawing.Size(69, 19);
            this.label_Dersler.TabIndex = 5;
            this.label_Dersler.Text = "Dersler :";
            // 
            // cBox_Dersler
            // 
            this.cBox_Dersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_Dersler.FormattingEnabled = true;
            this.cBox_Dersler.Location = new System.Drawing.Point(155, 40);
            this.cBox_Dersler.Name = "cBox_Dersler";
            this.cBox_Dersler.Size = new System.Drawing.Size(219, 24);
            this.cBox_Dersler.TabIndex = 4;
            this.cBox_Dersler.SelectedIndexChanged += new System.EventHandler(this.cBox_Dersler_SelectedIndexChanged);
            // 
            // btn_Listele
            // 
            this.btn_Listele.BackColor = System.Drawing.Color.White;
            this.btn_Listele.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Listele.Location = new System.Drawing.Point(537, 41);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(75, 23);
            this.btn_Listele.TabIndex = 9;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = false;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // liste_Yoklama
            // 
            this.liste_Yoklama.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DersAdı,
            this.Tarih,
            this.Saat,
            this.ÖgrenciNo,
            this.ÖgrenciAdı,
            this.ÖgrenciSoyad});
            this.liste_Yoklama.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.liste_Yoklama.HideSelection = false;
            this.liste_Yoklama.Location = new System.Drawing.Point(16, 70);
            this.liste_Yoklama.Name = "liste_Yoklama";
            this.liste_Yoklama.Size = new System.Drawing.Size(595, 368);
            this.liste_Yoklama.TabIndex = 10;
            this.liste_Yoklama.UseCompatibleStateImageBehavior = false;
            this.liste_Yoklama.View = System.Windows.Forms.View.Details;
            this.liste_Yoklama.SelectedIndexChanged += new System.EventHandler(this.liste_Yoklama_SelectedIndexChanged);
            // 
            // DersAdı
            // 
            this.DersAdı.Text = "DersAdı";
            this.DersAdı.Width = 184;
            // 
            // Tarih
            // 
            this.Tarih.Text = "Tarih";
            this.Tarih.Width = 80;
            // 
            // Saat
            // 
            this.Saat.Text = "Saat";
            // 
            // ÖgrenciNo
            // 
            this.ÖgrenciNo.Text = "ÖgrenciNo";
            this.ÖgrenciNo.Width = 90;
            // 
            // ÖgrenciAdı
            // 
            this.ÖgrenciAdı.Text = "ÖgrenciAdı";
            this.ÖgrenciAdı.Width = 25;
            // 
            // ÖgrenciSoyad
            // 
            this.ÖgrenciSoyad.Text = "ÖgrenciSoyad";
            this.ÖgrenciSoyad.Width = 94;
            // 
            // form_OgretimGorevlisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 451);
            this.Controls.Add(this.liste_Yoklama);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBox_OgretimGorevlisi);
            this.Controls.Add(this.label_Dersler);
            this.Controls.Add(this.cBox_Dersler);
            this.Name = "form_OgretimGorevlisi";
            this.Text = "Öğretim Görevlisi";
            this.Load += new System.EventHandler(this.form_OgretimGorevlisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox_OgretimGorevlisi;
        private System.Windows.Forms.Label label_Dersler;
        private System.Windows.Forms.ComboBox cBox_Dersler;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.ListView liste_Yoklama;
        private System.Windows.Forms.ColumnHeader DersAdı;
        private System.Windows.Forms.ColumnHeader Tarih;
        private System.Windows.Forms.ColumnHeader Saat;
        private System.Windows.Forms.ColumnHeader ÖgrenciNo;
        private System.Windows.Forms.ColumnHeader ÖgrenciAdı;
        private System.Windows.Forms.ColumnHeader ÖgrenciSoyad;
    }
}