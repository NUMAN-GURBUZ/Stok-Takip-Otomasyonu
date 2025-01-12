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
    public partial class frmSatışListe : Form
    {
        public frmSatışListe()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-LKQECGP;Initial Catalog=StokTakıp;Integrated Security=True");
        DataSet daset = new DataSet();


        private void Satıslistele()
        {

            baglantı.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("SELECT *FROM satıs", baglantı);
            adtr.Fill(daset, "satıs");
            dataGridView1.DataSource = daset.Tables["satıs"];

            baglantı.Close();
        }

        private void frmSatışListe_Load(object sender, EventArgs e)
        {
            Satıslistele();
        }

    }
}
