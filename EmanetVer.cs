using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class EmanetVer : Form
    {
        // Merkezi bağlantı dizesi
        string connString = @"Server=.\SQLEXPRESS; Database=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";

        public EmanetVer()
        {
            InitializeComponent();
        }

        private void EmanetVer_Load(object sender, EventArgs e)
        {
            VerileriYukle();

            // Tarih ayarı: Geçmiş tarih seçilemesin
            dtp_IadeTarihi.MinDate = DateTime.Now;
            // Varsayılan iade süresini 15 gün sonraya kur
            dtp_IadeTarihi.Value = DateTime.Now.AddDays(15);
        }

        private void VerileriYukle()
        {
            using (SqlConnection baglanti = new SqlConnection(connString))
            {
                try
                {
                    baglanti.Open();

                    // 1. Üyeleri Çek (İsim ve Soyisim birleştirilmiş)
                    string uyeSorgu = "SELECT MemberID, FirstName + ' ' + LastName AS FullName FROM Members";
                    SqlDataAdapter daUye = new SqlDataAdapter(uyeSorgu, baglanti);
                    DataTable dtUye = new DataTable();
                    daUye.Fill(dtUye);

                    cmb_Uye.DataSource = dtUye;
                    cmb_Uye.DisplayMember = "FullName";
                    cmb_Uye.ValueMember = "MemberID";
                    cmb_Uye.SelectedIndex = -1; // Boş başlasın

                    // 2. Sadece Mevcut (IsAvailable=1) Kitapları Çek
                    // Önemli: Eğer kitap zaten birindeyse listede görünmemeli
                    string kitapSorgu = "SELECT BookID, Title FROM Books WHERE IsAvailable = 1";
                    SqlDataAdapter daKitap = new SqlDataAdapter(kitapSorgu, baglanti);
                    DataTable dtKitap = new DataTable();
                    daKitap.Fill(dtKitap);

                    cmb_Kitap.DataSource = dtKitap;
                    cmb_Kitap.DisplayMember = "Title";
                    cmb_Kitap.ValueMember = "BookID";
                    cmb_Kitap.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_EmanetVer_Click(object sender, EventArgs e)
        {
            // Seçim Kontrolü
            if (cmb_Uye.SelectedIndex == -1 || cmb_Kitap.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen listeden bir üye ve bir kitap seçiniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int secilenUyeID = (int)cmb_Uye.SelectedValue;
            int secilenKitapID = (int)cmb_Kitap.SelectedValue;

            using (SqlConnection baglanti = new SqlConnection(connString))
            {
                baglanti.Open();
                // Veritabanı tutarlılığı için Transaction başlatıyoruz
                SqlTransaction islem = baglanti.BeginTransaction();

                try
                {
                    // 1. Emanet işlemini Transactions tablosuna kaydet
                    // ActualReturnDate kolonunu NULL bırakıyoruz çünkü kitap henüz geri gelmedi
                    string sorguEmanet = @"INSERT INTO Transactions (BookID, MemberID, BorrowDate, ReturnDate, ActualReturnDate) 
                                         VALUES (@bid, @mid, GETDATE(), @rdate, NULL)";

                    SqlCommand cmdEmanet = new SqlCommand(sorguEmanet, baglanti, islem);
                    cmdEmanet.Parameters.AddWithValue("@bid", secilenKitapID);
                    cmdEmanet.Parameters.AddWithValue("@mid", secilenUyeID);
                    cmdEmanet.Parameters.AddWithValue("@rdate", dtp_IadeTarihi.Value);
                    cmdEmanet.ExecuteNonQuery();

                    // 2. Kitabın durumunu "Emanette" (0) olarak güncelle
                    string sorguKitapDurum = "UPDATE Books SET IsAvailable = 0 WHERE BookID = @bid";
                    SqlCommand cmdKitap = new SqlCommand(sorguKitapDurum, baglanti, islem);
                    cmdKitap.Parameters.AddWithValue("@bid", secilenKitapID);
                    cmdKitap.ExecuteNonQuery();

                    // İki işlem de başarılıysa onayla
                    islem.Commit();

                    MessageBox.Show("Kitap başarıyla ödünç verildi.\nİade Tarihi: " + dtp_IadeTarihi.Value.ToShortDateString(),
                                    "İşlem Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Listeleri tazele (Kitap artık listeden düşecek çünkü IsAvailable=0 oldu)
                    VerileriYukle();
                }
                catch (Exception ex)
                {
                    // Hata olursa hiçbir tabloyu güncelleme, her şeyi geri al
                    islem.Rollback();
                    MessageBox.Show("Ödünç verme işlemi başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}