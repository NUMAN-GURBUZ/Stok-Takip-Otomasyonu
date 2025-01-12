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
    public partial class FormMusteriEkleme : Form
    {
        public FormMusteriEkleme()
        {
            InitializeComponent();
        }

         SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-LKQECGP;Initial Catalog=StokTakıp;Integrated Security=True");

        private void FormMusteriEkleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO MusterıData (tc,adsoyad,telefon,adres,emaıl)  values(@tc,@adsoyad,@telefon,@adres,@emaıl)" , baglantı);
            komut.Parameters.AddWithValue("@tc", txttc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txttelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtadres.Text);
            komut.Parameters.AddWithValue("@emaıl", txtemail.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("müşteri kaydı eklendi");

            foreach (Control item in  this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
