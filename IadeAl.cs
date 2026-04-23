using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class IadeAl : Form
    {
        // Connection string'i tek bir yerden yönetmek her zaman daha iyidir.
        private readonly string connString = @"Server=.\SQLEXPRESS; Database=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";

        public IadeAl()
        {
            InitializeComponent();
        }

        private void IadeAl_Load(object sender, EventArgs e)
        {
            EmanetListele();
            // TextBox araması için event bağlı değilse buradan bağlayabilirsin
            txt_Arama.TextChanged += txt_Arama_TextChanged;
        }

        private void EmanetListele()
        {
            using (SqlConnection baglanti = new SqlConnection(connString))
            {
                try
                {
                    // Sorguda AS [SütunAdı] kullanırken C# tarafında erişeceğimiz isimleri netleştiriyoruz
                    string sorgu = @"SELECT T.TransactionID, B.BookID, B.Title AS [Kitap], 
                                     M.FirstName + ' ' + M.LastName AS [Üye], 
                                     T.BorrowDate AS [Veriliş Tarihi], T.ReturnDate AS [Beklenen İade]
                                     FROM Transactions T
                                     JOIN Books B ON T.BookID = B.BookID
                                     JOIN Members M ON T.MemberID = M.MemberID
                                     WHERE T.ActualReturnDate IS NULL";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_Emanetler.DataSource = dt;

                    // Görsel Ayarlar
                    ArayuzDuzenle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Emanet listesi yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ArayuzDuzenle()
        {
            if (dgv_Emanetler.Columns.Count > 0)
            {
                // ID kolonlarını kullanıcıdan gizleyelim ama arka planda erişebilelim
                if (dgv_Emanetler.Columns.Contains("TransactionID")) dgv_Emanetler.Columns["TransactionID"].Visible = false;
                if (dgv_Emanetler.Columns.Contains("BookID")) dgv_Emanetler.Columns["BookID"].Visible = false;

                dgv_Emanetler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_Emanetler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv_Emanetler.MultiSelect = false; // Tek seferde tek iade
                dgv_Emanetler.ReadOnly = true;
                dgv_Emanetler.RowHeadersVisible = false;
            }
        }

        private void btn_IadeAl_Click(object sender, EventArgs e)
        {
            // Kullanıcı satır seçti mi kontrolü
            if (dgv_Emanetler.CurrentRow == null || dgv_Emanetler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen iade edilecek işlemi listeden seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hücre isimlerinin SQL sorgusundaki isimlerle (TransactionID, BookID) eşleştiğinden emin oluyoruz
            int transactionID = Convert.ToInt32(dgv_Emanetler.CurrentRow.Cells["TransactionID"].Value);
            int bookID = Convert.ToInt32(dgv_Emanetler.CurrentRow.Cells["BookID"].Value);
            string kitapAdi = dgv_Emanetler.CurrentRow.Cells["Kitap"].Value.ToString();

            DialogResult onay = MessageBox.Show($"'{kitapAdi}' isimli kitabı iade almak istediğinize emin misiniz?", "İade Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                using (SqlConnection baglanti = new SqlConnection(connString))
                {
                    baglanti.Open();
                    SqlTransaction islem = baglanti.BeginTransaction();

                    try
                    {
                        // 1. Transactions tablosunu güncelle (Gerçek İade Tarihi = Bugün)
                        string sorguIade = "UPDATE Transactions SET ActualReturnDate = GETDATE() WHERE TransactionID = @tid";
                        SqlCommand cmdIade = new SqlCommand(sorguIade, baglanti, islem);
                        cmdIade.Parameters.AddWithValue("@tid", transactionID);
                        cmdIade.ExecuteNonQuery();

                        // 2. Books tablosunu güncelle (Kitap artık rafta/mevcut)
                        string sorguKitap = "UPDATE Books SET IsAvailable = 1 WHERE BookID = @bid";
                        SqlCommand cmdKitap = new SqlCommand(sorguKitap, baglanti, islem);
                        cmdKitap.Parameters.AddWithValue("@bid", bookID);
                        cmdKitap.ExecuteNonQuery();

                        // İki işlem de sorunsuzsa commit et
                        islem.Commit();
                        MessageBox.Show("Kitap başarıyla iade alındı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        EmanetListele(); // Listeyi yenile (iade edilen kayıt listeden düşer)
                        txt_Arama.Clear(); // Aramayı temizle
                    }
                    catch (Exception ex)
                    {
                        islem.Rollback(); // Hata varsa işlemleri geri al
                        MessageBox.Show("İade işlemi sırasında teknik bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txt_Arama_TextChanged(object sender, EventArgs e)
        {
            // DataTable üzerinden güvenli filtreleme
            if (dgv_Emanetler.DataSource is DataTable dt)
            {
                try
                {
                    string filtreText = txt_Arama.Text.Replace("'", "''"); // SQL Injection koruması (basit düzey)
                    dt.DefaultView.RowFilter = string.Format("Kitap LIKE '%{0}%' OR Üye LIKE '%{0}%'", filtreText);
                }
                catch (Exception)
                {
                    // Filtreleme hatası (özel karakterler vb.) durumunda sessizce devam et
                }
            }
        }
    }
}