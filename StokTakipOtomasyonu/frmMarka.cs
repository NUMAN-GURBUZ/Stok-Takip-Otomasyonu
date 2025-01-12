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
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }

        public StokTakıpDataSetTableAdapters.markabilgileriTableAdapter markabilgileriTableAdapter
        {
            get => default(StokTakıpDataSetTableAdapters.markabilgileriTableAdapter);
            set
            {
            }
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-LKQECGP;Initial Catalog=StokTakıp;Integrated Security=True");

        bool durum;
        private void markakontrol()
        {
            durum = true;
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if ( comboBox1.Text == read["kategori"].ToString() && textBox1.Text == read["marka"].ToString() ||comboBox1.Text=="" || textBox1.Text == "")
                {
                    durum = false;
                }
            }
            baglantı.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum==true)
            {
                baglantı.Open();
                SqlCommand komut = new SqlCommand("insert into  markabilgileri(kategori,marka) values ('" + comboBox1.Text + "','" + textBox1.Text + "')", baglantı);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Marka eklendi");
            }
            else
            {
                MessageBox.Show("Böyle bir kategori ve marka var");
            }
            
            textBox1.Text = "";
            comboBox1.Text = "";
           
        }
    private void kategorigetir()
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("select  *from kategoribilgileri", baglantı);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboBox1.Items.Add(read["kategori"].ToString());
            }
            baglantı.Close();

        }
        private void frmMarka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }
    }
}
