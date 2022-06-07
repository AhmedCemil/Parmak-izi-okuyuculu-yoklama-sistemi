
namespace Parmakiziokuyucuyoklamasistemi
{
    partial class form_OgrenciIslemleri
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
            this.btn_OgrenciListesiAl = new System.Windows.Forms.Button();
            this.liste_OgrenciListesi = new System.Windows.Forms.ListView();
            this.ÖgrenciNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ÖgrenciAdı = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ÖgrenciSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Parmakİzi_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_OgrenciListesiAl
            // 
            this.btn_OgrenciListesiAl.BackColor = System.Drawing.Color.White;
            this.btn_OgrenciListesiAl.Location = new System.Drawing.Point(14, 12);
            this.btn_OgrenciListesiAl.Name = "btn_OgrenciListesiAl";
            this.btn_OgrenciListesiAl.Size = new System.Drawing.Size(125, 23);
            this.btn_OgrenciListesiAl.TabIndex = 0;
            this.btn_OgrenciListesiAl.Text = "Öğrenci Listesini Al";
            this.btn_OgrenciListesiAl.UseVisualStyleBackColor = false;
            this.btn_OgrenciListesiAl.Click += new System.EventHandler(this.btn_OgrenciListesiAl_Click);
            // 
            // liste_OgrenciListesi
            // 
            this.liste_OgrenciListesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ÖgrenciNo,
            this.ÖgrenciAdı,
            this.ÖgrenciSoyad,
            this.Parmakİzi_id});
            this.liste_OgrenciListesi.HideSelection = false;
            this.liste_OgrenciListesi.Location = new System.Drawing.Point(14, 41);
            this.liste_OgrenciListesi.Name = "liste_OgrenciListesi";
            this.liste_OgrenciListesi.Size = new System.Drawing.Size(559, 388);
            this.liste_OgrenciListesi.TabIndex = 1;
            this.liste_OgrenciListesi.UseCompatibleStateImageBehavior = false;
            this.liste_OgrenciListesi.View = System.Windows.Forms.View.Details;
            // 
            // ÖgrenciNo
            // 
            this.ÖgrenciNo.Text = "ÖgrenciNo";
            this.ÖgrenciNo.Width = 123;
            // 
            // ÖgrenciAdı
            // 
            this.ÖgrenciAdı.Text = "ÖgrenciAdı";
            this.ÖgrenciAdı.Width = 118;
            // 
            // ÖgrenciSoyad
            // 
            this.ÖgrenciSoyad.Text = "ÖgrenciSoyad";
            this.ÖgrenciSoyad.Width = 122;
            // 
            // Parmakİzi_id
            // 
            this.Parmakİzi_id.Text = "Parmakİzi_id";
            this.Parmakİzi_id.Width = 77;
            // 
            // form_OgrenciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 446);
            this.Controls.Add(this.liste_OgrenciListesi);
            this.Controls.Add(this.btn_OgrenciListesiAl);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "form_OgrenciIslemleri";
            this.Text = "Öğrenci İşlemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OgrenciListesiAl;
        private System.Windows.Forms.ListView liste_OgrenciListesi;
        private System.Windows.Forms.ColumnHeader ÖgrenciNo;
        private System.Windows.Forms.ColumnHeader ÖgrenciAdı;
        private System.Windows.Forms.ColumnHeader ÖgrenciSoyad;
        private System.Windows.Forms.ColumnHeader Parmakİzi_id;
    }
}