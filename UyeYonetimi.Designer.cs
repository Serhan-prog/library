namespace Library_Management_System
{
    partial class UyeYonetimi
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
            txt_Email = new TextBox();
            txt_Telefon = new TextBox();
            txt_Soyad = new TextBox();
            txt_Ad = new TextBox();
            btn_UyeListele = new Button();
            btn_UyeSil = new Button();
            btn_UyeEkle = new Button();
            dgv_Uyeler = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Uyeler).BeginInit();
            SuspendLayout();
            // 
            // txt_Email
            // 
            txt_Email.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Email.Location = new Point(80, 150);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(145, 29);
            txt_Email.TabIndex = 9;
            // 
            // txt_Telefon
            // 
            txt_Telefon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Telefon.Location = new Point(80, 115);
            txt_Telefon.Name = "txt_Telefon";
            txt_Telefon.Size = new Size(145, 29);
            txt_Telefon.TabIndex = 8;
            // 
            // txt_Soyad
            // 
            txt_Soyad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Soyad.Location = new Point(80, 80);
            txt_Soyad.Name = "txt_Soyad";
            txt_Soyad.Size = new Size(145, 29);
            txt_Soyad.TabIndex = 7;
            // 
            // txt_Ad
            // 
            txt_Ad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Ad.Location = new Point(80, 45);
            txt_Ad.Name = "txt_Ad";
            txt_Ad.Size = new Size(145, 29);
            txt_Ad.TabIndex = 6;
            // 
            // btn_UyeListele
            // 
            btn_UyeListele.Cursor = Cursors.Hand;
            btn_UyeListele.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_UyeListele.Location = new Point(548, 103);
            btn_UyeListele.Name = "btn_UyeListele";
            btn_UyeListele.Size = new Size(105, 50);
            btn_UyeListele.TabIndex = 10;
            btn_UyeListele.Text = "LİSTELE";
            btn_UyeListele.UseVisualStyleBackColor = true;
            btn_UyeListele.Click += btn_UyeListele_Click;
            // 
            // btn_UyeSil
            // 
            btn_UyeSil.Cursor = Cursors.Hand;
            btn_UyeSil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_UyeSil.Location = new Point(437, 103);
            btn_UyeSil.Name = "btn_UyeSil";
            btn_UyeSil.Size = new Size(105, 50);
            btn_UyeSil.TabIndex = 11;
            btn_UyeSil.Text = "SİL";
            btn_UyeSil.UseVisualStyleBackColor = true;
            btn_UyeSil.Click += btn_UyeSil_Click;
            // 
            // btn_UyeEkle
            // 
            btn_UyeEkle.Cursor = Cursors.Hand;
            btn_UyeEkle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_UyeEkle.Location = new Point(326, 103);
            btn_UyeEkle.Name = "btn_UyeEkle";
            btn_UyeEkle.Size = new Size(105, 50);
            btn_UyeEkle.TabIndex = 12;
            btn_UyeEkle.Text = "EKLE";
            btn_UyeEkle.UseVisualStyleBackColor = true;
            btn_UyeEkle.Click += btn_UyeEkle_Click;
            // 
            // dgv_Uyeler
            // 
            dgv_Uyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Uyeler.Location = new Point(0, 247);
            dgv_Uyeler.Name = "dgv_Uyeler";
            dgv_Uyeler.Size = new Size(801, 203);
            dgv_Uyeler.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(42, 49);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 14;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(19, 84);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 14;
            label2.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(11, 119);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 14;
            label3.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(24, 154);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 14;
            label4.Text = "Email:";
            // 
            // UyeYonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgv_Uyeler);
            Controls.Add(btn_UyeListele);
            Controls.Add(btn_UyeSil);
            Controls.Add(btn_UyeEkle);
            Controls.Add(txt_Email);
            Controls.Add(txt_Telefon);
            Controls.Add(txt_Soyad);
            Controls.Add(txt_Ad);
            Name = "UyeYonetimi";
            Text = "UyeYonetimi";
            Load += UyeYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Uyeler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Email;
        private TextBox txt_Telefon;
        private TextBox txt_Soyad;
        private TextBox txt_Ad;
        private Button btn_UyeListele;
        private Button btn_UyeSil;
        private Button btn_UyeEkle;
        private DataGridView dgv_Uyeler;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}