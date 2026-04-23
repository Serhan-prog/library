using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class UyeYonetimi : Form
    {
        // Bağlantı cümlesini tek bir merkezden yönetiyoruz
        string connectionString = @"Server=.\SQLEXPRESS; Database=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";

        public UyeYonetimi()
        {
            InitializeComponent();
        }

        private void UyeYonetimi_Load(object sender, EventArgs e)
        {
            UyeListele();
            UyeDataGridGuzellestir();
        }

        private void UyeListele()
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    // MemberID'yi mutlaka çekiyoruz ki silme/güncelleme işlemlerinde hata almayalım
                    string sorgu = "SELECT MemberID, FirstName AS [Ad], LastName AS [Soyad], Phone AS [Telefon], Email FROM Members";
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgv_Uyeler.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Üye listesi yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UyeDataGridGuzellestir()
        {
            // Genel Görünüm
            dgv_Uyeler.BorderStyle = BorderStyle.None;
            dgv_Uyeler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv_Uyeler.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Uyeler.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgv_Uyeler.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Uyeler.BackgroundColor = Color.White;

            // Başlık (Header) Tasarımı
            dgv_Uyeler.EnableHeadersVisualStyles = false;
            dgv_Uyeler.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Uyeler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv_Uyeler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_Uyeler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv_Uyeler.ColumnHeadersHeight = 35;

            // Ayarlar
            dgv_Uyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Uyeler.MultiSelect = false;
            dgv_Uyeler.ReadOnly = true;
            dgv_Uyeler.RowHeadersVisible = false;
            dgv_Uyeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // MemberID kolonunu kullanıcıdan gizleyelim ama arka planda erişebilelim
            if (dgv_Uyeler.Columns["MemberID"] != null)
                dgv_Uyeler.Columns["MemberID"].Visible = false;
        }

        private void btn_UyeEkle_Click(object sender, EventArgs e)
        {
            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(txt_Ad.Text) || string.IsNullOrWhiteSpace(txt_Soyad.Text))
            {
                MessageBox.Show("Lütfen en azından Ad ve Soyad alanlarını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString))
                {
                    string sorgu = "INSERT INTO Members (FirstName, LastName, Phone, Email) VALUES (@ad, @soyad, @tel, @mail)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@ad", txt_Ad.Text.Trim());
                    komut.Parameters.AddWithValue("@soyad", txt_Soyad.Text.Trim());
                    komut.Parameters.AddWithValue("@tel", txt_Telefon.Text.Trim());
                    komut.Parameters.AddWithValue("@mail", txt_Email.Text.Trim());

                    baglanti.Open();
                    komut.ExecuteNonQuery();

                    MessageBox.Show("Üye kaydı başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormuTemizle();
                    UyeListele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata: " + ex.Message);
            }
        }

        private void btn_UyeSil_Click(object sender, EventArgs e)
        {
            if (dgv_Uyeler.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgv_Uyeler.CurrentRow.Cells["MemberID"].Value);

                DialogResult onay = MessageBox.Show("Seçili üyeyi silmek istediğinize emin misiniz? Bu işlem geri alınamaz.", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (onay == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection baglanti = new SqlConnection(connectionString))
                        {
                            SqlCommand komut = new SqlCommand("DELETE FROM Members WHERE MemberID=@id", baglanti);
                            komut.Parameters.AddWithValue("@id", id);

                            baglanti.Open();
                            komut.ExecuteNonQuery();
                            UyeListele();
                        }
                    }
                    catch (SqlException ex) when (ex.Number == 547) // Foreign Key hatası
                    {
                        MessageBox.Show("Bu üyenin üzerinde iade edilmemiş bir kitap veya geçmiş işlem kaydı bulunduğu için silinemez.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme hatası: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz üyeyi tablodan seçin.");
            }
        }

        private void btn_UyeListele_Click(object sender, EventArgs e)
        {
            UyeListele();
        }

        private void FormuTemizle()
        {
            txt_Ad.Clear();
            txt_Soyad.Clear();
            txt_Telefon.Clear();
            txt_Email.Clear();
            txt_Ad.Focus();
        }

        // Buraya Karışma
    }
}