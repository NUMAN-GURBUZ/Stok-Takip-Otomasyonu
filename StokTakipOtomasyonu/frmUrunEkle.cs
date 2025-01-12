using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    public partial class frmUrunEkle : Form
    {
        public frmUrunEkle()
        {
            InitializeComponent();
        }

        public StokTakıpDataSetTableAdapters.urunTableAdapter urunTableAdapter
        {
            get => default(StokTakıpDataSetTableAdapters.urunTableAdapter);
            set
            {
            }
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-LKQECGP;Initial Catalog=StokTakıp;Integrated Security=True");

        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from urun", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString() || txtBarkodNo.Text=="")
                {
                    durum = false;
                }
            }
            baglantı.Close();
        }

            private void kategorigetir()
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("select  *from kategoribilgileri", baglantı);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboKategori.Items.Add(read["kategori"].ToString());
                }
                baglantı.Close();

            }

            private void frmUrunEkle_Load(object sender, EventArgs e)
            {
                kategorigetir();
            }

            private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
            {
                comboMarka.Items.Clear();
                comboMarka.Text = "";
                baglantı.Open();
                SqlCommand komut = new SqlCommand("select  kategori,marka from markabilgileri where kategori ='" + comboKategori.SelectedItem + "'", baglantı);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    comboMarka.Items.Add(read["marka"].ToString());
                }
                baglantı.Close();
            }

            private void btnYenıEkle_Click(object sender, EventArgs e)
            {

                barkodkontrol();
                if (durum == true)
                {
                    baglantı.Open();
                    SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadı,mıktarı,alısfıyatı,satısfıyatı,tarıh) values(@barkodno,@kategori,@marka,@urunadı,@mıktarı,@alısfıyatı,@satısfıyatı,@tarıh)", baglantı);
                    komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                    komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                    komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                    komut.Parameters.AddWithValue("@urunadı", txtUrunAdı.Text);
                    komut.Parameters.AddWithValue("@mıktarı", int.Parse(txtMıktarı.Text));
                    komut.Parameters.AddWithValue("@alısfıyatı", double.Parse(txtAlısFıyatı.Text));
                    komut.Parameters.AddWithValue("@satısfıyatı", double.Parse(txtSatısFiyatı.Text));
                    komut.Parameters.AddWithValue("@tarıh", DateTime.Now.ToString());
                    komut.ExecuteNonQuery();
                    baglantı.Close();
                    MessageBox.Show("ÜRÜN EKLENDİ");
                }
                else
                {
                    MessageBox.Show("Böyle Bir barkodno var");
                }


                comboMarka.Items.Clear();
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                    if (item is ComboBox)
                    {
                        item.Text = "";
                    }

                }
            }

            private void BarkodNotxt_TextChanged(object sender, EventArgs e)
            {
                if (BarkodNotxt.Text == "")
                {
                    lblMiktar.Text = "";
                    foreach (Control item in groupBox2.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                }

                baglantı.Open();

                SqlCommand komut = new SqlCommand("select *from urun where barkodno like '" + BarkodNotxt.Text + "'", baglantı);

                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    Kategoritxt.Text = read["kategori"].ToString();
                    Markatxt.Text = read["marka"].ToString();
                    UrunAdıtxt.Text = read["urunadı"].ToString();
                    lblMiktar.Text = read["mıktarı"].ToString();
                    AlışFiyatıtxt.Text = read["alısfıyatı"].ToString();
                    SatışFiyatıtxt.Text = read["satısfıyatı"].ToString();
                }
                baglantı.Close();
            }

            private void btnVarOlanaEkle_Click(object sender, EventArgs e)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("update urun set mıktarı=mıktarı+'" + int.Parse(Miktarıtxt.Text) + "' where barkodno='" + BarkodNotxt.Text + "'", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();

                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                MessageBox.Show("Var olan ürüne ekleme yapıldı");

            }
        }
    }
   