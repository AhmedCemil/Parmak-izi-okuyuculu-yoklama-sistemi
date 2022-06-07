
namespace Parmakiziokuyucuyoklamasistemi
{
    partial class form_Yoklama
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
            this.cBox_Dersler = new System.Windows.Forms.ComboBox();
            this.label_Dersler = new System.Windows.Forms.Label();
            this.label_OG = new System.Windows.Forms.Label();
            this.cBox_OgretimGorevlisi = new System.Windows.Forms.ComboBox();
            this.btn_OG_Giris = new System.Windows.Forms.Button();
            this.label_OG_Giris = new System.Windows.Forms.Label();
            this.btn_YoklamayiAl = new System.Windows.Forms.Button();
            this.btn_ArduinoHaberlesmesi = new System.Windows.Forms.Button();
            this.btn_YoklamaAlmayiDurdur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBox_Dersler
            // 
            this.cBox_Dersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_Dersler.FormattingEnabled = true;
            this.cBox_Dersler.Location = new System.Drawing.Point(155, 43);
            this.cBox_Dersler.Name = "cBox_Dersler";
            this.cBox_Dersler.Size = new System.Drawing.Size(219, 24);
            this.cBox_Dersler.TabIndex = 0;
            this.cBox_Dersler.SelectedIndexChanged += new System.EventHandler(this.cBox_Dersler_SelectedIndexChanged);
            // 
            // label_Dersler
            // 
            this.label_Dersler.AutoSize = true;
            this.label_Dersler.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Dersler.Location = new System.Drawing.Point(12, 46);
            this.label_Dersler.Name = "label_Dersler";
            this.label_Dersler.Size = new System.Drawing.Size(69, 19);
            this.label_Dersler.TabIndex = 1;
            this.label_Dersler.Text = "Dersler :";
            // 
            // label_OG
            // 
            this.label_OG.AutoSize = true;
            this.label_OG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_OG.Location = new System.Drawing.Point(12, 12);
            this.label_OG.Name = "label_OG";
            this.label_OG.Size = new System.Drawing.Size(138, 19);
            this.label_OG.TabIndex = 3;
            this.label_OG.Text = "Öğretim Görevlisi :";
            // 
            // cBox_OgretimGorevlisi
            // 
            this.cBox_OgretimGorevlisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBox_OgretimGorevlisi.FormattingEnabled = true;
            this.cBox_OgretimGorevlisi.Location = new System.Drawing.Point(155, 9);
            this.cBox_OgretimGorevlisi.Name = "cBox_OgretimGorevlisi";
            this.cBox_OgretimGorevlisi.Size = new System.Drawing.Size(219, 24);
            this.cBox_OgretimGorevlisi.TabIndex = 2;
            this.cBox_OgretimGorevlisi.SelectedIndexChanged += new System.EventHandler(this.cBox_OgretimGorevlisi_SelectedIndexChanged);
            // 
            // btn_OG_Giris
            // 
            this.btn_OG_Giris.BackColor = System.Drawing.Color.White;
            this.btn_OG_Giris.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OG_Giris.Location = new System.Drawing.Point(155, 77);
            this.btn_OG_Giris.Name = "btn_OG_Giris";
            this.btn_OG_Giris.Size = new System.Drawing.Size(75, 23);
            this.btn_OG_Giris.TabIndex = 4;
            this.btn_OG_Giris.Text = "Giriş";
            this.btn_OG_Giris.UseVisualStyleBackColor = false;
            this.btn_OG_Giris.Click += new System.EventHandler(this.btn_OG_Giris_Click);
            // 
            // label_OG_Giris
            // 
            this.label_OG_Giris.AutoSize = true;
            this.label_OG_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_OG_Giris.Location = new System.Drawing.Point(236, 77);
            this.label_OG_Giris.Name = "label_OG_Giris";
            this.label_OG_Giris.Size = new System.Drawing.Size(0, 17);
            this.label_OG_Giris.TabIndex = 5;
            // 
            // btn_YoklamayiAl
            // 
            this.btn_YoklamayiAl.BackColor = System.Drawing.Color.IndianRed;
            this.btn_YoklamayiAl.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YoklamayiAl.Location = new System.Drawing.Point(12, 110);
            this.btn_YoklamayiAl.Name = "btn_YoklamayiAl";
            this.btn_YoklamayiAl.Size = new System.Drawing.Size(90, 37);
            this.btn_YoklamayiAl.TabIndex = 6;
            this.btn_YoklamayiAl.Text = "Yoklamayı al";
            this.btn_YoklamayiAl.UseVisualStyleBackColor = false;
            this.btn_YoklamayiAl.Click += new System.EventHandler(this.btn_YoklamayiAl_Click);
            // 
            // btn_ArduinoHaberlesmesi
            // 
            this.btn_ArduinoHaberlesmesi.BackColor = System.Drawing.Color.White;
            this.btn_ArduinoHaberlesmesi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ArduinoHaberlesmesi.Location = new System.Drawing.Point(380, 9);
            this.btn_ArduinoHaberlesmesi.Name = "btn_ArduinoHaberlesmesi";
            this.btn_ArduinoHaberlesmesi.Size = new System.Drawing.Size(159, 49);
            this.btn_ArduinoHaberlesmesi.TabIndex = 8;
            this.btn_ArduinoHaberlesmesi.Text = "Parmak izi okuyucu ile bağlantı kurmak için basınız";
            this.btn_ArduinoHaberlesmesi.UseVisualStyleBackColor = false;
            this.btn_ArduinoHaberlesmesi.Click += new System.EventHandler(this.btn_ArduinoHaberlesmesi_Click);
            // 
            // btn_YoklamaAlmayiDurdur
            // 
            this.btn_YoklamaAlmayiDurdur.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_YoklamaAlmayiDurdur.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_YoklamaAlmayiDurdur.Location = new System.Drawing.Point(121, 110);
            this.btn_YoklamaAlmayiDurdur.Name = "btn_YoklamaAlmayiDurdur";
            this.btn_YoklamaAlmayiDurdur.Size = new System.Drawing.Size(142, 37);
            this.btn_YoklamaAlmayiDurdur.TabIndex = 9;
            this.btn_YoklamaAlmayiDurdur.Text = "Yoklama Almayı Durdur";
            this.btn_YoklamaAlmayiDurdur.UseVisualStyleBackColor = false;
            this.btn_YoklamaAlmayiDurdur.Click += new System.EventHandler(this.btn_YoklamaAlmayiDurdur_Click);
            // 
            // form_Yoklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 159);
            this.Controls.Add(this.btn_YoklamaAlmayiDurdur);
            this.Controls.Add(this.btn_ArduinoHaberlesmesi);
            this.Controls.Add(this.btn_YoklamayiAl);
            this.Controls.Add(this.label_OG_Giris);
            this.Controls.Add(this.btn_OG_Giris);
            this.Controls.Add(this.label_OG);
            this.Controls.Add(this.cBox_OgretimGorevlisi);
            this.Controls.Add(this.label_Dersler);
            this.Controls.Add(this.cBox_Dersler);
            this.Name = "form_Yoklama";
            this.Text = "Yoklama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBox_Dersler;
        private System.Windows.Forms.Label label_Dersler;
        private System.Windows.Forms.Label label_OG;
        private System.Windows.Forms.ComboBox cBox_OgretimGorevlisi;
        private System.Windows.Forms.Button btn_OG_Giris;
        private System.Windows.Forms.Label label_OG_Giris;
        private System.Windows.Forms.Button btn_YoklamayiAl;
        private System.Windows.Forms.Button btn_ArduinoHaberlesmesi;
        private System.Windows.Forms.Button btn_YoklamaAlmayiDurdur;
    }
}