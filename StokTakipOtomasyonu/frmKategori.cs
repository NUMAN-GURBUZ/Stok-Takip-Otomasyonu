using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipOtomasyonu
{
    public partial class frmKategori : Form
    {
        public frmKategori()
        {
            InitializeComponent();
        }

        public StokTakıpDataSetTableAdapters.kategoribilgileriTableAdapter kategoribilgileriTableAdapter
        {
            get => default(StokTakıpDataSetTableAdapters.kategoribilgileriTableAdapter);
            set
            {
            }
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-LKQECGP;Initial Catalog=StokTakıp;Integrated Security=True");
        bool durum;
 private void kategorikontrol()
{
    durum = true; // Varsayılan olarak kategori eklenebilir.

    // Boşluk kontrolü
    if (string.IsNullOrWhiteSpace(textBox1.Text))
    {
        durum = false;
        MessageBox.Show("Kategori adı boş olamaz!", "Uyarı");
        return; // Daha fazla kontrol yapmaya gerek yok.
    }

    // Veritabanında kategori var mı kontrolü
    baglantı.Open();
    SqlCommand komut = new SqlCommand("select *from kategoribilgileri where kategori = @kategori", baglantı);
    komut.Parameters.AddWithValue("@kategori", textBox1.Text.Trim());
    SqlDataReader read = komut.ExecuteReader();
    if (read.HasRows) // Eğer veri varsa
    {
        durum = false;
        MessageBox.Show("Böyle bir kategori zaten var!", "Uyarı");
    }
    baglantı.Close();
}
        private void frmKategori_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            kategorikontrol();

            if (durum) // Kategori eklenebilir durumda ise
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO kategoribilgileri(kategori) VALUES (@kategori)", baglantı);
                komut.Parameters.AddWithValue("@kategori", textBox1.Text.Trim());
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Kategori başarıyla eklendi.", "Bilgi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori zaten var!", "Uyarı");
            }

            textBox1.Text = ""; // TextBox temizleniyor
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
