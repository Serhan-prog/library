namespace Library_Management_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            lbl_hosgeldiniz = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btn_giris = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lbl_hosgeldiniz
            // 
            lbl_hosgeldiniz.AutoSize = true;
            lbl_hosgeldiniz.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lbl_hosgeldiniz.Location = new Point(243, 58);
            lbl_hosgeldiniz.Name = "lbl_hosgeldiniz";
            lbl_hosgeldiniz.Size = new Size(335, 32);
            lbl_hosgeldiniz.TabIndex = 0;
            lbl_hosgeldiniz.Text = "Kütüphane Otomasyonu Giriş";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtKullaniciAdi.Location = new Point(363, 163);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(165, 27);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtSifre.Location = new Point(363, 198);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(165, 27);
            txtSifre.TabIndex = 2;
            // 
            // btn_giris
            // 
            btn_giris.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_giris.Location = new Point(433, 242);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(95, 32);
            btn_giris.TabIndex = 3;
            btn_giris.Text = "Giriş Yap";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(259, 166);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(300, 201);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 5;
            label3.Text = "Parola:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_giris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(lbl_hosgeldiniz);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_hosgeldiniz;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btn_giris;
        private Label label2;
        private Label label3;
    }
}
