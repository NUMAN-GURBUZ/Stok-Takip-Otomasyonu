using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    public partial class frmUrünListele : Form
    {
        public frmUrünListele()
        { 
            InitializeComponent();

        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-LKQECGP;Initial Catalog=StokTakıp;Integrated Security=True");
        DataSet daset = new DataSet();

        private void frmÜrünListele_Load(object sender, EventArgs e)
        {
             
            ÜrünListele();
        }

        private void ÜrünListele()
        {
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM urun", baglantı);
            adtr.Fill(daset,"urun");
            
            dataGridView1.DataSource = daset.Tables["urun"];
            baglantı.Close();
          
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            UrunAdıtxt.Text = dataGridView1.CurrentRow.Cells["urunadı"].Value.ToString();
            Miktarıtxt.Text = dataGridView1.CurrentRow.Cells["mıktarı"].Value.ToString();
            AlışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["alısfıyatı"].Value.ToString();
            SatışFiyatıtxt.Text = dataGridView1.CurrentRow.Cells["satısfıyatı"].Value.ToString();
        }



        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("UPDATE urun set  urunadı=@urunadı , mıktarı=@mıktarı , alısfıyatı=@alısfıyatı , satısfıyatı=@satısfıyatı where barkodno=@barkodno", baglantı);
            komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
            komut.Parameters.AddWithValue("@urunadı", UrunAdıtxt.Text);
            komut.Parameters.AddWithValue("@mıktarı", Miktarıtxt.Text);
            komut.Parameters.AddWithValue("@alısfıyatı", AlışFiyatıtxt.Text);
            komut.Parameters.AddWithValue("@satısfıyatı", SatışFiyatıtxt.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Güncelleme yapıldı");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text ="";
                }
            }


        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text!="")
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("UPDATE urun SET kategori=@kategori,marka=@marka WHERE barkodno=@barkodno", baglantı);
                komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);

                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("güncelleme yapıldı");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kategoritxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}

