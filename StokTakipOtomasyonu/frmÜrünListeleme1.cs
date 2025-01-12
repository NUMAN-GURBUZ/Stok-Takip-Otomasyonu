using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using ComboBox = System.Windows.Forms.ComboBox;

namespace StokTakipOtomasyonu
{
    public partial class frmÜrünListeleme1 : DevExpress.XtraEditors.XtraForm
    {

       

        public frmÜrünListeleme1()
        {
            InitializeComponent();
        }


        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-LKQECGP;Initial Catalog=StokTakıp;Integrated Security=True");
        DataSet daset = new DataSet();

        private void kategorigetir()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select  * from kategoribilgileri", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglantı.Close();

        }


        private void frmÜrünListeleme1_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            kategorigetir();
        }

        private void ÜrünListele()
        {
           DataSet daset = new DataSet();
            baglantı.Open();

            SqlDataAdapter adtr = new SqlDataAdapter("select * from  urun ", baglantı);

            if (daset.Tables.Contains("urun"))
            {
                daset.Tables["urun"].Clear(); // Daha önce eklenmiş tablo varsa temizle
            }

            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglantı.Close();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            UrunAdıtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Miktarıtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            AlışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            SatışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Tarıhtxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }


        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {


                baglantı.Open();
                SqlCommand komut = new SqlCommand("update urun set urunadı=@urunadı, mıktarı=@mıktarı, alısfıyatı=@alısfıyatı, satısfıyatı=@satısfıyatı where barkodno=@barkodno", baglantı);
                komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                komut.Parameters.AddWithValue("@urunadı", UrunAdıtxt.Text);
                komut.Parameters.AddWithValue("@mıktarı", int.Parse(Miktarıtxt.Text));
                komut.Parameters.AddWithValue("@alısfıyatı", double.Parse(AlışFiyatıtxt.Text));
                komut.Parameters.AddWithValue("@satısfıyatı", double.Parse(SatışFiyatıtxt.Text));
                komut.ExecuteNonQuery();
                baglantı.Close();


                if (daset.Tables.Contains("urun"))
                {
                    daset.Tables["urun"].Clear();
                }

                ÜrünListele();
                MessageBox.Show("Güncelleme yapıldı");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

            

        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {

            if (BarkodNotxt.Text != "")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglantı);
                komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);

                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("güncelleme yapıldı");
                daset.Tables["urun"].Clear();
                ÜrünListele();
            }
            else
            {
                MessageBox.Show("Barkodno seçili değil");
            }


            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void frmÜrünListeleme1_Load_1(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokTakıpDataSet.urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter.Fill(this.stokTakıpDataSet.urun);

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


         private void btnSil_Click(object sender, EventArgs e)
         {
              baglantı.Open();
              SqlCommand komut = new SqlCommand("delete from urun where barkodno ='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglantı);
              komut.ExecuteNonQuery();
              baglantı.Close();
              daset.Tables["urun"].Clear(); 
              ÜrünListele();
              MessageBox.Show("Kayıt silindi");
          } 



        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun where barkodno like '%" + txtBarkodNoAra.Text + "%'", baglantı);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
        }

    }
}