namespace Parmakiziokuyucuyoklamasistemi
{
    partial class form_ArduinoHaberlesmesi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KayitGir = new System.Windows.Forms.Button();
            this.KayitSil = new System.Windows.Forms.Button();
            this.GelenVeri = new System.Windows.Forms.TextBox();
            this.GidenVeri = new System.Windows.Forms.TextBox();
            this.Temizle = new System.Windows.Forms.Button();
            this.Gonder = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port ";
            // 
            // KayitGir
            // 
            this.KayitGir.BackColor = System.Drawing.Color.White;
            this.KayitGir.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitGir.Location = new System.Drawing.Point(12, 41);
            this.KayitGir.Name = "KayitGir";
            this.KayitGir.Size = new System.Drawing.Size(75, 23);
            this.KayitGir.TabIndex = 2;
            this.KayitGir.Text = "KayıtGir";
            this.KayitGir.UseVisualStyleBackColor = false;
            this.KayitGir.Click += new System.EventHandler(this.KayitGir_Click);
            // 
            // KayitSil
            // 
            this.KayitSil.BackColor = System.Drawing.Color.White;
            this.KayitSil.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitSil.Location = new System.Drawing.Point(93, 41);
            this.KayitSil.Name = "KayitSil";
            this.KayitSil.Size = new System.Drawing.Size(75, 23);
            this.KayitSil.TabIndex = 3;
            this.KayitSil.Text = "KayıtSil";
            this.KayitSil.UseVisualStyleBackColor = false;
            this.KayitSil.Click += new System.EventHandler(this.KayitSil_Click);
            // 
            // GelenVeri
            // 
            this.GelenVeri.BackColor = System.Drawing.Color.White;
            this.GelenVeri.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GelenVeri.Location = new System.Drawing.Point(174, 14);
            this.GelenVeri.Multiline = true;
            this.GelenVeri.Name = "GelenVeri";
            this.GelenVeri.ReadOnly = true;
            this.GelenVeri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GelenVeri.Size = new System.Drawing.Size(251, 161);
            this.GelenVeri.TabIndex = 4;
            // 
            // GidenVeri
            // 
            this.GidenVeri.Location = new System.Drawing.Point(12, 83);
            this.GidenVeri.Name = "GidenVeri";
            this.GidenVeri.Size = new System.Drawing.Size(156, 20);
            this.GidenVeri.TabIndex = 5;
            // 
            // Temizle
            // 
            this.Temizle.BackColor = System.Drawing.Color.White;
            this.Temizle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temizle.Location = new System.Drawing.Point(93, 152);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(75, 23);
            this.Temizle.TabIndex = 6;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = false;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Gonder
            // 
            this.Gonder.BackColor = System.Drawing.Color.White;
            this.Gonder.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gonder.Location = new System.Drawing.Point(12, 109);
            this.Gonder.Name = "Gonder";
            this.Gonder.Size = new System.Drawing.Size(75, 23);
            this.Gonder.TabIndex = 7;
            this.Gonder.Text = "Gönder";
            this.Gonder.UseVisualStyleBackColor = false;
            this.Gonder.Click += new System.EventHandler(this.Gonder_Click);
            // 
            // form_ArduinoHaberlesmesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 190);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KayitGir);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.Gonder);
            this.Controls.Add(this.GidenVeri);
            this.Controls.Add(this.KayitSil);
            this.Controls.Add(this.GelenVeri);
            this.Name = "form_ArduinoHaberlesmesi";
            this.Text = "Arduino Haberleşmesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KayitGir;
        private System.Windows.Forms.Button KayitSil;
        private System.Windows.Forms.TextBox GelenVeri;
        private System.Windows.Forms.TextBox GidenVeri;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button Gonder;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

