using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class KitapYonetimi : Form
    {
        // Merkezi Bağlantı Cümlesi
        string connectionString = @"Server=.\SQLEXPRESS; Database=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";

        public KitapYonetimi()
        {
            InitializeComponent();
        }

        private void KitapYonetimi_Load(object sender, EventArgs e)
        {
            KitaplariListele();
            DataGridGuzellestir();
        }

        // 1. LİSTELEME: Veritabanındaki kitapları DataGridView'a çeker
        private void KitaplariListele()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    // BookID'yi silme işlemleri için mutlaka çekiyoruz
                    string sorgu = "SELECT BookID, Title AS [Kitap Adı], Author AS [Yazar], ISBN, PageCount AS [Sayfa], IsAvailable AS [Mevcut mu] FROM Books";

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_Kitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridGuzellestir()
        {
            // Görünüm Ayarları
            dgv_Kitaplar.BorderStyle = BorderStyle.None;
            dgv_Kitaplar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_Kitaplar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Kitaplar.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv_Kitaplar.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Kitaplar.BackgroundColor = Color.White;

            // Başlık Tasarımı
            dgv_Kitaplar.EnableHeadersVisualStyles = false;
            dgv_Kitaplar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Kitaplar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv_Kitaplar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Kitaplar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv_Kitaplar.ColumnHeadersHeight = 35;

            // Etkileşim Ayarları
            dgv_Kitaplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Kitaplar.MultiSelect = false;
            dgv_Kitaplar.ReadOnly = true;
            dgv_Kitaplar.RowHeadersVisible = false;
            dgv_Kitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ID Kolonunu gizleyelim (Kullanıcı görmesin ama kod erişsin)
            if (dgv_Kitaplar.Columns["BookID"] != null)
                dgv_Kitaplar.Columns["BookID"].Visible = false;
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            // Validasyon: Alanlar boş mu?
            if (string.IsNullOrWhiteSpace(txt_Ad.Text) || string.IsNullOrWhiteSpace(txt_Yazar.Text))
            {
                MessageBox.Show("Lütfen Kitap Adı ve Yazar alanlarını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasyon: Sayfa sayısı gerçekten sayı mı?
            if (!int.TryParse(txt_Sayfa.Text, out int sayfaSayisi))
            {
                MessageBox.Show("Sayfa sayısı geçerli bir rakam olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    string sorgu = "INSERT INTO Books (Title, Author, ISBN, PageCount, IsAvailable) VALUES (@t, @a, @i, @p, 1)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@t", txt_Ad.Text.Trim());
                    komut.Parameters.AddWithValue("@a", txt_Yazar.Text.Trim());
                    komut.Parameters.AddWithValue("@i", txt_ISBN.Text.Trim());
                    komut.Parameters.AddWithValue("@p", sayfaSayisi);

                    baglanti.Open();
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kitap başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormuTemizle();
                    KitaplariListele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme hatası: " + ex.Message);
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_Kitaplar.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_Kitaplar.CurrentRow.Cells["BookID"].Value);
                string kitapAdi = dgv_Kitaplar.CurrentRow.Cells["Kitap Adı"].Value.ToString();

                DialogResult onay = MessageBox.Show($"'{kitapAdi}' isimli kitabı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (onay == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection baglanti = new SqlConnection(connectionString))
                        {
                            SqlCommand komut = new SqlCommand("DELETE FROM Books WHERE BookID=@id", baglanti);
                            komut.Parameters.AddWithValue("@id", id);

                            baglanti.Open();
                            komut.ExecuteNonQuery();

                            MessageBox.Show("Kitap başarıyla silindi.");
                            KitaplariListele();
                        }
                    }
                    catch (SqlException ex) when (ex.Number == 547)
                    {
                        // Eğer kitap emanet verilmişse ve Transactions tablosunda kaydı varsa silinemez
                        MessageBox.Show("Bu kitap kütüphane geçmişinde kayıtlı olduğu için silinemez. Önce ilgili emanet kayıtlarını temizlemelisiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme hatası: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz kitabı listeden seçin.");
            }
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            KitaplariListele();
        }

        private void FormuTemizle()
        {
            txt_Ad.Clear();
            txt_Yazar.Clear();
            txt_ISBN.Clear();
            txt_Sayfa.Clear();
            txt_Ad.Focus();
        }

        // Buraya Karışma
    }
}