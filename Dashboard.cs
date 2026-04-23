using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Dashboard : Form
    {
        // SQL Bağlantı Cümlesi
        string connString = @"Server=.\SQLEXPRESS; Database=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            VerileriGuncelle();
        }

        // Dashboard'daki tüm sayıları ve tabloyu yenileyen ana metod
        public void VerileriGuncelle()
        {
            using (SqlConnection baglanti = new SqlConnection(connString))
            {
                try
                {
                    baglanti.Open();

                    // 1. İstatistikleri Çek
                    lbl_KitapSayisi.Text = new SqlCommand("SELECT COUNT(*) FROM Books", baglanti).ExecuteScalar()?.ToString() ?? "0";
                    lbl_UyeSayisi.Text = new SqlCommand("SELECT COUNT(*) FROM Members", baglanti).ExecuteScalar()?.ToString() ?? "0";
                    lbl_EmanetSayisi.Text = new SqlCommand("SELECT COUNT(*) FROM Books WHERE IsAvailable = 0", baglanti).ExecuteScalar()?.ToString() ?? "0";

                    // 2. Gecikme Uyarısı (İade tarihi bugünden küçük olan ve henüz teslim edilmemiş kayıtlar)
                    string gecikmeSorgu = "SELECT COUNT(*) FROM Transactions WHERE ReturnDate < GETDATE() AND ActualReturnDate IS NULL";
                    int gecikenSayisi = (int)(new SqlCommand(gecikmeSorgu, baglanti).ExecuteScalar() ?? 0);

                    if (gecikenSayisi > 0)
                    {
                        lbl_Uyari.Text = $"⚠️ DİKKAT: İadesi geciken {gecikenSayisi} adet kitap bulunuyor!";
                        lbl_Uyari.Visible = true;
                        lbl_Uyari.ForeColor = Color.Red;
                    }
                    else
                    {
                        lbl_Uyari.Visible = false;
                    }

                    // 3. Son 5 İşlemi Listele
                    string sonIslemSorgu = @"SELECT TOP 5 
                                            B.Title AS [Kitap], 
                                            M.FirstName + ' ' + M.LastName AS [Üye], 
                                            T.BorrowDate AS [Veriliş Tarihi]
                                         FROM Transactions T
                                         JOIN Books B ON T.BookID = B.BookID
                                         JOIN Members M ON T.MemberID = M.MemberID
                                         ORDER BY T.TransactionID DESC";

                    SqlDataAdapter da = new SqlDataAdapter(sonIslemSorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_SonIslemler.DataSource = dt;

                    // Görsel Düzenleme
                    dgv_SonIslemler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv_SonIslemler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv_SonIslemler.RowHeadersVisible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Dashboard güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Kitaplar_Click(object sender, EventArgs e)
        {
            KitapYonetimi kitapEkranı = new KitapYonetimi();
            kitapEkranı.ShowDialog();
            VerileriGuncelle();
        }

        private void btn_Uyeler_Click(object sender, EventArgs e)
        {
            UyeYonetimi uyeEkranı = new UyeYonetimi();
            uyeEkranı.ShowDialog();
            VerileriGuncelle();
        }

        private void btn_EmanetVer_Click(object sender, EventArgs e)
        {
            EmanetVer emanetEkranı = new EmanetVer();
            emanetEkranı.ShowDialog();
            VerileriGuncelle();
        }

        private void btn_IadeAl_Click(object sender, EventArgs e)
        {
            IadeAl iadeEkranı = new IadeAl();
            iadeEkranı.ShowDialog();
            VerileriGuncelle(); // Kitap iade edildiğinde sayıları ve tabloyu tazeler
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Buraya Karışma
    }
}