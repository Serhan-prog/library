namespace Library_Management_System
{
    partial class Dashboard
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
            panel1 = new Panel();
            btn_Cikis = new Button();
            btn_IadeAl = new Button();
            btn_EmanetVer = new Button();
            btn_Uyeler = new Button();
            btn_Kitaplar = new Button();
            panel2 = new Panel();
            lbl_KitapSayisi = new Label();
            lbl_kitap_adet = new Label();
            panel3 = new Panel();
            lbl_UyeSayisi = new Label();
            lbl_uye_adet = new Label();
            panel4 = new Panel();
            lbl_emanet_adet = new Label();
            lbl_EmanetSayisi = new Label();
            lbl_Uyari = new Label();
            dgv_SonIslemler = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SonIslemler).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Cikis);
            panel1.Controls.Add(btn_IadeAl);
            panel1.Controls.Add(btn_EmanetVer);
            panel1.Controls.Add(btn_Uyeler);
            panel1.Controls.Add(btn_Kitaplar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // btn_Cikis
            // 
            btn_Cikis.Cursor = Cursors.Hand;
            btn_Cikis.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Cikis.Location = new Point(21, 178);
            btn_Cikis.Name = "btn_Cikis";
            btn_Cikis.Size = new Size(154, 32);
            btn_Cikis.TabIndex = 4;
            btn_Cikis.Text = "Güvenli Çıkış";
            btn_Cikis.UseVisualStyleBackColor = true;
            btn_Cikis.Click += btn_Cikis_Click;
            // 
            // btn_IadeAl
            // 
            btn_IadeAl.Cursor = Cursors.Hand;
            btn_IadeAl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_IadeAl.Location = new Point(21, 140);
            btn_IadeAl.Name = "btn_IadeAl";
            btn_IadeAl.Size = new Size(154, 32);
            btn_IadeAl.TabIndex = 3;
            btn_IadeAl.Text = "Kitap İade Al";
            btn_IadeAl.UseVisualStyleBackColor = true;
            btn_IadeAl.Click += btn_IadeAl_Click;
            // 
            // btn_EmanetVer
            // 
            btn_EmanetVer.Cursor = Cursors.Hand;
            btn_EmanetVer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_EmanetVer.Location = new Point(21, 102);
            btn_EmanetVer.Name = "btn_EmanetVer";
            btn_EmanetVer.Size = new Size(154, 32);
            btn_EmanetVer.TabIndex = 2;
            btn_EmanetVer.Text = "Kitap Ödünç Ver";
            btn_EmanetVer.UseVisualStyleBackColor = true;
            btn_EmanetVer.Click += btn_EmanetVer_Click;
            // 
            // btn_Uyeler
            // 
            btn_Uyeler.Cursor = Cursors.Hand;
            btn_Uyeler.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Uyeler.Location = new Point(21, 64);
            btn_Uyeler.Name = "btn_Uyeler";
            btn_Uyeler.Size = new Size(154, 32);
            btn_Uyeler.TabIndex = 1;
            btn_Uyeler.Text = "Üye İşlemleri";
            btn_Uyeler.UseVisualStyleBackColor = true;
            btn_Uyeler.Click += btn_Uyeler_Click;
            // 
            // btn_Kitaplar
            // 
            btn_Kitaplar.Cursor = Cursors.Hand;
            btn_Kitaplar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Kitaplar.Location = new Point(21, 26);
            btn_Kitaplar.Name = "btn_Kitaplar";
            btn_Kitaplar.Size = new Size(154, 32);
            btn_Kitaplar.TabIndex = 0;
            btn_Kitaplar.Text = "Kitap Yönetimi";
            btn_Kitaplar.UseVisualStyleBackColor = true;
            btn_Kitaplar.Click += btn_Kitaplar_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_KitapSayisi);
            panel2.Controls.Add(lbl_kitap_adet);
            panel2.Location = new Point(251, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 79);
            panel2.TabIndex = 1;
            // 
            // lbl_KitapSayisi
            // 
            lbl_KitapSayisi.AutoSize = true;
            lbl_KitapSayisi.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lbl_KitapSayisi.Location = new Point(29, 39);
            lbl_KitapSayisi.Name = "lbl_KitapSayisi";
            lbl_KitapSayisi.Size = new Size(18, 30);
            lbl_KitapSayisi.TabIndex = 0;
            lbl_KitapSayisi.Text = ".";
            // 
            // lbl_kitap_adet
            // 
            lbl_kitap_adet.AutoSize = true;
            lbl_kitap_adet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_kitap_adet.Location = new Point(3, 12);
            lbl_kitap_adet.Name = "lbl_kitap_adet";
            lbl_kitap_adet.Size = new Size(92, 21);
            lbl_kitap_adet.TabIndex = 1;
            lbl_kitap_adet.Text = "Kitap Sayısı";
            // 
            // panel3
            // 
            panel3.Controls.Add(lbl_UyeSayisi);
            panel3.Controls.Add(lbl_uye_adet);
            panel3.Location = new Point(407, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 79);
            panel3.TabIndex = 2;
            // 
            // lbl_UyeSayisi
            // 
            lbl_UyeSayisi.AutoSize = true;
            lbl_UyeSayisi.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lbl_UyeSayisi.Location = new Point(19, 39);
            lbl_UyeSayisi.Name = "lbl_UyeSayisi";
            lbl_UyeSayisi.Size = new Size(18, 30);
            lbl_UyeSayisi.TabIndex = 0;
            lbl_UyeSayisi.Text = ".";
            // 
            // lbl_uye_adet
            // 
            lbl_uye_adet.AutoSize = true;
            lbl_uye_adet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_uye_adet.Location = new Point(3, 12);
            lbl_uye_adet.Name = "lbl_uye_adet";
            lbl_uye_adet.Size = new Size(82, 21);
            lbl_uye_adet.TabIndex = 1;
            lbl_uye_adet.Text = "Üye Sayısı";
            // 
            // panel4
            // 
            panel4.Controls.Add(lbl_emanet_adet);
            panel4.Controls.Add(lbl_EmanetSayisi);
            panel4.Location = new Point(563, 14);
            panel4.Name = "panel4";
            panel4.Size = new Size(150, 79);
            panel4.TabIndex = 3;
            // 
            // lbl_emanet_adet
            // 
            lbl_emanet_adet.AutoSize = true;
            lbl_emanet_adet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbl_emanet_adet.Location = new Point(3, 12);
            lbl_emanet_adet.Name = "lbl_emanet_adet";
            lbl_emanet_adet.Size = new Size(108, 21);
            lbl_emanet_adet.TabIndex = 1;
            lbl_emanet_adet.Text = "Emanet Sayısı";
            // 
            // lbl_EmanetSayisi
            // 
            lbl_EmanetSayisi.AutoSize = true;
            lbl_EmanetSayisi.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            lbl_EmanetSayisi.Location = new Point(45, 39);
            lbl_EmanetSayisi.Name = "lbl_EmanetSayisi";
            lbl_EmanetSayisi.Size = new Size(18, 30);
            lbl_EmanetSayisi.TabIndex = 0;
            lbl_EmanetSayisi.Text = ".";
            // 
            // lbl_Uyari
            // 
            lbl_Uyari.AutoSize = true;
            lbl_Uyari.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_Uyari.Location = new Point(663, 177);
            lbl_Uyari.Name = "lbl_Uyari";
            lbl_Uyari.Size = new Size(63, 30);
            lbl_Uyari.TabIndex = 4;
            lbl_Uyari.Text = "Uyarı";
            // 
            // dgv_SonIslemler
            // 
            dgv_SonIslemler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SonIslemler.Location = new Point(206, 291);
            dgv_SonIslemler.Name = "dgv_SonIslemler";
            dgv_SonIslemler.Size = new Size(594, 159);
            dgv_SonIslemler.TabIndex = 5;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_SonIslemler);
            Controls.Add(lbl_Uyari);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Otomasyonu - Ana Menü";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SonIslemler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_Cikis;
        private Button btn_IadeAl;
        private Button btn_EmanetVer;
        private Button btn_Uyeler;
        private Button btn_Kitaplar;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lbl_KitapSayisi;
        private Label lbl_UyeSayisi;
        private Label lbl_EmanetSayisi;
        private Label lbl_Uyari;
        private DataGridView dgv_SonIslemler;
        private Label lbl_kitap_adet;
        private Label lbl_uye_adet;
        private Label lbl_emanet_adet;
    }
}