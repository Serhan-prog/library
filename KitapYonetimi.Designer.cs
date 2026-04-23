namespace Library_Management_System
{
    partial class KitapYonetimi
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
            dgv_Kitaplar = new DataGridView();
            txt_Ad = new TextBox();
            txt_Yazar = new TextBox();
            txt_ISBN = new TextBox();
            btn_Ekle = new Button();
            txt_Sayfa = new TextBox();
            btn_Sil = new Button();
            btn_Listele = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Kitaplar).BeginInit();
            SuspendLayout();
            // 
            // dgv_Kitaplar
            // 
            dgv_Kitaplar.AllowUserToAddRows = false;
            dgv_Kitaplar.AllowUserToDeleteRows = false;
            dgv_Kitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Kitaplar.Location = new Point(0, 234);
            dgv_Kitaplar.Name = "dgv_Kitaplar";
            dgv_Kitaplar.ReadOnly = true;
            dgv_Kitaplar.Size = new Size(800, 215);
            dgv_Kitaplar.TabIndex = 0;
            // 
            // txt_Ad
            // 
            txt_Ad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Ad.Location = new Point(74, 38);
            txt_Ad.Name = "txt_Ad";
            txt_Ad.Size = new Size(145, 29);
            txt_Ad.TabIndex = 1;
            // 
            // txt_Yazar
            // 
            txt_Yazar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Yazar.Location = new Point(74, 73);
            txt_Yazar.Name = "txt_Yazar";
            txt_Yazar.Size = new Size(145, 29);
            txt_Yazar.TabIndex = 2;
            // 
            // txt_ISBN
            // 
            txt_ISBN.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_ISBN.Location = new Point(74, 108);
            txt_ISBN.Name = "txt_ISBN";
            txt_ISBN.Size = new Size(145, 29);
            txt_ISBN.TabIndex = 3;
            // 
            // btn_Ekle
            // 
            btn_Ekle.Cursor = Cursors.Hand;
            btn_Ekle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Ekle.Location = new Point(356, 72);
            btn_Ekle.Name = "btn_Ekle";
            btn_Ekle.Size = new Size(105, 50);
            btn_Ekle.TabIndex = 4;
            btn_Ekle.Text = "EKLE";
            btn_Ekle.UseVisualStyleBackColor = true;
            btn_Ekle.Click += btn_Ekle_Click;
            // 
            // txt_Sayfa
            // 
            txt_Sayfa.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txt_Sayfa.Location = new Point(74, 143);
            txt_Sayfa.Name = "txt_Sayfa";
            txt_Sayfa.Size = new Size(145, 29);
            txt_Sayfa.TabIndex = 5;
            // 
            // btn_Sil
            // 
            btn_Sil.Cursor = Cursors.Hand;
            btn_Sil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Sil.Location = new Point(467, 72);
            btn_Sil.Name = "btn_Sil";
            btn_Sil.Size = new Size(105, 50);
            btn_Sil.TabIndex = 4;
            btn_Sil.Text = "SİL";
            btn_Sil.UseVisualStyleBackColor = true;
            btn_Sil.Click += btn_Sil_Click;
            // 
            // btn_Listele
            // 
            btn_Listele.Cursor = Cursors.Hand;
            btn_Listele.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btn_Listele.Location = new Point(578, 72);
            btn_Listele.Name = "btn_Listele";
            btn_Listele.Size = new Size(105, 50);
            btn_Listele.TabIndex = 4;
            btn_Listele.Text = "LİSTELE";
            btn_Listele.UseVisualStyleBackColor = true;
            btn_Listele.Click += btn_Listele_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label4.Location = new Point(18, 147);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 15;
            label4.Text = "Sayfa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label3.Location = new Point(22, 112);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 16;
            label3.Text = "ISBN:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label2.Location = new Point(17, 77);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 17;
            label2.Text = "Yazar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            label1.Location = new Point(36, 42);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 18;
            label1.Text = "Ad:";
            // 
            // KitapYonetimi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Sayfa);
            Controls.Add(btn_Listele);
            Controls.Add(btn_Sil);
            Controls.Add(btn_Ekle);
            Controls.Add(txt_ISBN);
            Controls.Add(txt_Yazar);
            Controls.Add(txt_Ad);
            Controls.Add(dgv_Kitaplar);
            Name = "KitapYonetimi";
            Text = "KitapYonetimi";
            Load += KitapYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Kitaplar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Kitaplar;
        private TextBox txt_Ad;
        private TextBox txt_Yazar;
        private TextBox txt_ISBN;
        private Button btn_Ekle;
        private TextBox txt_Sayfa;
        private Button btn_Sil;
        private Button btn_Listele;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}