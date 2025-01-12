using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    public partial class frmMusterıLıstele : Form
    {
        public frmMusterıLıstele()
        {
            InitializeComponent();
        }

        public StokTakıpDataSetTableAdapters.MusterıDataTableAdapter MusterıDataTableAdapter
        {
            get => default(StokTakıpDataSetTableAdapters.MusterıDataTableAdapter);
            set
            {
            }
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-LKQECGP;Initial Catalog=StokTakıp;Integrated Security=True");
        DataSet daset = new DataSet();

        private void frmMusterıLıstele_Load(object sender, EventArgs e)
        {
            KayıtGoster();

        }

        private void KayıtGoster()
        {
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from  MusterıData", baglantı);
            adtr.Fill(daset, "MusterıData");
            dataGridView1.DataSource = daset.Tables["MusterıData"];
            baglantı.Close();
        }

          private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txttc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtadsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txttelefon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtadres.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("UPDATE MusterıData SET adsoyad=@adsoyad,telefon=@telefon,adres=@adres,emaıl=@emaıl WHERE tc=@tc",baglantı);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@emaıl", txtemail.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();

            daset.Tables["MusterıData"].Clear();
 
            KayıtGoster();
            MessageBox.Show("Müşteri kaydı güncellendi!");

            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        
        private void btnSıl_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();

                // SQL sorgusunu parametreli olarak oluştur
                SqlCommand komut = new SqlCommand("delete from MusterıData where tc = @tc", baglantı);

                // Parametreyi ekle
                komut.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells["tc"].Value.ToString());

                // Sorguyu çalıştır
                komut.ExecuteNonQuery();

                baglantı.Close();

                // DataSet'i güncelle
                daset.Tables["MusterıData"].Clear();
                KayıtGoster();

                // Kullanıcıya bilgi ver
                MessageBox.Show("Kayıt silindi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt silindi");
            }
        }


        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from MusterıData where tc like '%" + txtTcAra.Text + "%'", baglantı);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
        }

      
    }
}
