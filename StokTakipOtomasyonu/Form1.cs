using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-LKQECGP;Initial Catalog=StokTakıp;Integrated Security=True");
        DataSet daset = new DataSet();

        private void sepetlistele()
        {

            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT * FROM sepet", baglantı);
            adtr.Fill(daset,"sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
           dataGridView1.Columns[1].Visible = false;
           dataGridView1.Columns[2].Visible = false;
            baglantı.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokTakıpDataSet.satıs' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.satısTableAdapter.Fill(this.stokTakıpDataSet.satıs);
            // TODO: Bu kod satırı 'stokTakıpDataSet.urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter.Fill(this.stokTakıpDataSet.urun);
            // TODO: Bu kod satırı 'stokTakıpDataSet.sepet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.sepetTableAdapter.Fill(this.stokTakıpDataSet.sepet);
            sepetlistele();
           
        }
       

        private void textTC_TextChanged(object sender, EventArgs e)
        {
            if  (textTC.Text=="")
            {
                textADSOYAD.Text = "";
                textTELEFON.Text = "";
            }
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from MusterıData where tc like '" + textTC.Text + "'",baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                textADSOYAD.Text=read["adsoyad"].ToString();
                textTELEFON.Text = read["telefon"].ToString();


            }
            baglantı.Close();
        }

       


         private void textBARKOD_TextChanged(object sender, EventArgs e)
         {
            Temizle();

            baglantı.Open();

            SqlCommand komut = new SqlCommand("SELECT * FROM urun WHERE barkodno LIKE '" + textBARKOD.Text + "'", baglantı);
            SqlDataReader read = komut.ExecuteReader();


           while (read.Read())
           {
             textÜRÜN.Text = read["urunadı"].ToString();
             textSATISFIYAT.Text = read["satısfıyatı"].ToString();


           }

           baglantı.Close();
         }

        private void Temizle()
        {
            if (textBARKOD.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item != textMİKTAR)
                    {
                        item.Text = "";
                    }
                }

            }
            baglantı.Close();
        }

        private void BtnSılme_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleMusteriEkleme_Click(object sender, EventArgs e)
        {

            FormMusteriEkleme ekle = new FormMusteriEkleme();
            ekle.ShowDialog();
        }

        private void simplemmusterıListeleme_Click(object sender, EventArgs e)
        {
            frmMusterıLıstele listele = new frmMusterıLıstele();
            listele.ShowDialog();
        }

        private void simpleUrunEkleme_Click(object sender, EventArgs e)
        {
            frmUrunEkle ekle = new frmUrunEkle();
            ekle.ShowDialog();
        }

        private void simpleUrunLısteleme_Click(object sender, EventArgs e)
        {
            frmÜrünListeleme1 frm = new frmÜrünListeleme1();
            frm.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from sepet", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (textBARKOD.Text==read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglantı.Close();


        }



       private void buttonEKLE_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum==true)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into sepet (tc,adsoyad,telefon,barkodno,urunadı,mıktarı,satısfıyatı,toplamfıyatı,tarıh)"+
                "values (@tc,@adsoyad,@telefon,@barkodno,@urunadı,@mıktarı,@satısfıyatı,@toplamfıyatı,@tarıh)", baglantı);
                komut.Parameters.AddWithValue("@tc", textTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", textADSOYAD.Text);
                komut.Parameters.AddWithValue("@telefon", textTELEFON.Text);
                komut.Parameters.AddWithValue("@barkodno", textBARKOD.Text);
                komut.Parameters.AddWithValue("@urunadı", textÜRÜN.Text);
                komut.Parameters.AddWithValue("@mıktarı", int.Parse(textMİKTAR.Text));
                komut.Parameters.AddWithValue("@satısfıyatı", double.Parse(textSATISFIYAT.Text));
                komut.Parameters.AddWithValue("@toplamfıyatı",  double.Parse(textTOPLAMFIYAT.Text));
                komut.Parameters.AddWithValue("@tarıh", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglantı.Close();
            }
            else
            {
                baglantı.Open();
                SqlCommand komut2 = new SqlCommand("update sepet set mıktarı=mıktarı+'"+ int.Parse(textMİKTAR.Text)+ "' where barkodno='" + textBARKOD.Text + "'", baglantı);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet set toplamfıyatı=mıktarı*satısfıyatı where barkodno='"+textBARKOD.Text+ "'", baglantı);
                komut3.ExecuteNonQuery();
                baglantı.Close();
            }
            textMİKTAR.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

            foreach (Control item in groupBox2.Controls)
            {
                if (item != textMİKTAR)
                {
                    item.Text = "";
                }
            }
        }


        private void textMİKTAR_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textTOPLAMFIYAT.Text = (double.Parse(textMİKTAR.Text) * double.Parse(textSATISFIYAT.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void textSATISFIYAT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textTOPLAMFIYAT.Text = (double.Parse(textMİKTAR.Text) * double.Parse(textSATISFIYAT.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void buttonSIL_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno= '" +dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString()+ "'" , baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            
            MessageBox.Show("Ürün sepetten silindi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void simpleSatısLısteleme_Click(object sender, EventArgs e)
        {
            frmSatışListe listeSatıs = new frmSatışListe();
            listeSatıs.ShowDialog();

        }


        private void hesapla()
        {

            try
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfıyatı) from sepet", baglantı);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglantı.Close();
            }
            catch (Exception)
            {

                 ;
            }
        }

        private void buttonSATISIPTAL_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from sepet", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("ürünler sepetten çıkartıldı");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        public FormMusteriEkleme FormMusteriEkleme
        {
            get => default(FormMusteriEkleme);
            set
            {
            }
        }

        public frmUrunEkle frmUrunEkle
        {
            get => default(frmUrunEkle);
            set
            {
            }
        }

        public frmMusterıLıstele frmMusterıLıstele
        {
            get => default(frmMusterıLıstele);
            set
            {
            }
        }

        public frmÜrünListeleme1 frmÜrünListeleme1
        {
            get => default(frmÜrünListeleme1);
            set
            {
            }
        }

        public frmKategori frmKategori
        {
            get => default(frmKategori);
            set
            {
            }
        }

        public frmMarka frmMarka
        {
            get => default(frmMarka);
            set
            {
            }
        }

        public StokTakıpDataSet StokTakıpDataSet
        {
            get => default(StokTakıpDataSet);
            set
            {
            }
        }

        private void lblGenelToplam_Click(object sender, EventArgs e)
        {

        }

        private void buttonSATISYAP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into satıs (tc,adsoyad,telefon,barkodno,urunadı,mıktarı,satısfıyatı,toplamfıyatı,tarıh)" +
                "values (@tc,@adsoyad,@telefon,@barkodno,@urunadı,@mıktarı,@satısfıyatı,@toplamfıyatı,@tarıh)", baglantı);
                komut.Parameters.AddWithValue("@tc", textTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", textADSOYAD.Text);
                komut.Parameters.AddWithValue("@telefon", textTELEFON.Text);
                komut.Parameters.AddWithValue("@barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                komut.Parameters.AddWithValue("@urunadı", dataGridView1.Rows[i].Cells["urunadı"].Value.ToString());
                komut.Parameters.AddWithValue("@mıktarı", int.Parse(dataGridView1.Rows[i].Cells["mıktarı"].Value.ToString()));
                komut.Parameters.AddWithValue("@satısfıyatı", double.Parse(dataGridView1.Rows[i].Cells["satısfıyatı"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfıyatı", double.Parse(dataGridView1.Rows[i].Cells["toplamfıyatı"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarıh", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                SqlCommand komut2 = new SqlCommand("update urun set mıktarı=mıktarı-'" + int.Parse(dataGridView1.Rows[i].Cells["mıktarı"].Value.ToString()) + "' where barkodno='" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "'", baglantı);
                komut2.ExecuteNonQuery();
                baglantı.Close();

            }
            baglantı.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglantı);
            komut3.ExecuteNonQuery();
            baglantı.Close();
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

        }
    }
}
