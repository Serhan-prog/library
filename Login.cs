using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            // 1. Bağlantı adresi (Kurulumdaki sertifika hatasını aşmak için TrustServerCertificate ekledik)
            string connectionString = @"Server=.\SQLEXPRESS; Database=LibraryDB; Integrated Security=True; TrustServerCertificate=True;";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    // 2. Sorgu (SQL Injection riskine karşı parametreli sorgu kullanıyoruz)
                    string sorgu = "SELECT * FROM Users WHERE Username=@user AND Password=@pass";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@user", txtKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@pass", txtSifre.Text);

                    SqlDataReader oku = komut.ExecuteReader();

                    if (oku.Read())
                    {
                        // Giriş başarılı!
                        string adSoyad = oku["FullName"].ToString();
                        MessageBox.Show("Giriş Başarılı! Hoş geldin " + adSoyad, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 3. Dashboard Formuna Geçiş
                        Dashboard dashboard = new Dashboard(); // Form adın Dashboard ise
                        dashboard.Show();

                        // 4. Login formunu gizle
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bağlantı hatası: " + ex.Message);
                }
            }
        }
    }
}
