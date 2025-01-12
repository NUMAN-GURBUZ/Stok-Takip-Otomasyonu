using System;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    partial class frmUrünListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SatışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BarkodNotxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.AlışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Kategoritxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Miktarıtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Markatxt = new System.Windows.Forms.TextBox();
            this.UrunAdıtxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            this.stokTakıpDataSet = new StokTakipOtomasyonu.StokTakıpDataSet();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunTableAdapter = new StokTakipOtomasyonu.StokTakıpDataSetTableAdapters.urunTableAdapter();
            this.barkodnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mıktarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alısfıyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satısfıyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarıhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakıpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodnoDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.urunadıDataGridViewTextBoxColumn,
            this.mıktarıDataGridViewTextBoxColumn,
            this.alısfıyatıDataGridViewTextBoxColumn,
            this.satısfıyatıDataGridViewTextBoxColumn,
            this.tarıhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.urunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(283, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 339);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(118, 336);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(120, 36);
            this.btnGüncelle.TabIndex = 22;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "SatışFiyatı";
            // 
            // SatışFiyatıtxt
            // 
            this.SatışFiyatıtxt.Location = new System.Drawing.Point(138, 289);
            this.SatışFiyatıtxt.Name = "SatışFiyatıtxt";
            this.SatışFiyatıtxt.Size = new System.Drawing.Size(100, 22);
            this.SatışFiyatıtxt.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "AlışFiyatı";
            // 
            // BarkodNotxt
            // 
            this.BarkodNotxt.Location = new System.Drawing.Point(138, 54);
            this.BarkodNotxt.Name = "BarkodNotxt";
            this.BarkodNotxt.Size = new System.Drawing.Size(100, 22);
            this.BarkodNotxt.TabIndex = 21;
            this.BarkodNotxt.TextChanged += new System.EventHandler(this.BarkodNotxt_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Miktarı";
            // 
            // AlışFiyatıtxt
            // 
            this.AlışFiyatıtxt.Location = new System.Drawing.Point(138, 250);
            this.AlışFiyatıtxt.Name = "AlışFiyatıtxt";
            this.AlışFiyatıtxt.Size = new System.Drawing.Size(100, 22);
            this.AlışFiyatıtxt.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "ÜrünAdı";
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Location = new System.Drawing.Point(138, 92);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.ReadOnly = true;
            this.Kategoritxt.Size = new System.Drawing.Size(100, 22);
            this.Kategoritxt.TabIndex = 23;
            this.Kategoritxt.TextChanged += new System.EventHandler(this.Kategoritxt_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 31;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 17);
            this.label13.TabIndex = 30;
            this.label13.Text = "Kategori";
            // 
            // Miktarıtxt
            // 
            this.Miktarıtxt.Location = new System.Drawing.Point(138, 214);
            this.Miktarıtxt.Name = "Miktarıtxt";
            this.Miktarıtxt.Size = new System.Drawing.Size(100, 22);
            this.Miktarıtxt.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(44, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "BarkodNo";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Markatxt
            // 
            this.Markatxt.Location = new System.Drawing.Point(138, 134);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.ReadOnly = true;
            this.Markatxt.Size = new System.Drawing.Size(100, 22);
            this.Markatxt.TabIndex = 24;
            // 
            // UrunAdıtxt
            // 
            this.UrunAdıtxt.Location = new System.Drawing.Point(138, 179);
            this.UrunAdıtxt.Name = "UrunAdıtxt";
            this.UrunAdıtxt.Size = new System.Drawing.Size(100, 22);
            this.UrunAdıtxt.TabIndex = 25;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(727, 51);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 36;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.Location = new System.Drawing.Point(508, 48);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(133, 22);
            this.txtBarkodNoAra.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Barkod No ya Göre Ara";
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(98, 440);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(140, 24);
            this.comboKategori.TabIndex = 39;
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(98, 484);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(140, 24);
            this.comboMarka.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Kategori";
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(87, 526);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(151, 26);
            this.btnMarkaGuncelle.TabIndex = 43;
            this.btnMarkaGuncelle.Text = "Marka Güncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // stokTakıpDataSet
            // 
            this.stokTakıpDataSet.DataSetName = "StokTakıpDataSet";
            this.stokTakıpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "urun";
            this.urunBindingSource.DataSource = this.stokTakıpDataSet;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // barkodnoDataGridViewTextBoxColumn
            // 
            this.barkodnoDataGridViewTextBoxColumn.DataPropertyName = "barkodno";
            this.barkodnoDataGridViewTextBoxColumn.HeaderText = "barkodno";
            this.barkodnoDataGridViewTextBoxColumn.Name = "barkodnoDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // urunadıDataGridViewTextBoxColumn
            // 
            this.urunadıDataGridViewTextBoxColumn.DataPropertyName = "urunadı";
            this.urunadıDataGridViewTextBoxColumn.HeaderText = "urunadı";
            this.urunadıDataGridViewTextBoxColumn.Name = "urunadıDataGridViewTextBoxColumn";
            // 
            // mıktarıDataGridViewTextBoxColumn
            // 
            this.mıktarıDataGridViewTextBoxColumn.DataPropertyName = "mıktarı";
            this.mıktarıDataGridViewTextBoxColumn.HeaderText = "mıktarı";
            this.mıktarıDataGridViewTextBoxColumn.Name = "mıktarıDataGridViewTextBoxColumn";
            // 
            // alısfıyatıDataGridViewTextBoxColumn
            // 
            this.alısfıyatıDataGridViewTextBoxColumn.DataPropertyName = "alısfıyatı";
            this.alısfıyatıDataGridViewTextBoxColumn.HeaderText = "alısfıyatı";
            this.alısfıyatıDataGridViewTextBoxColumn.Name = "alısfıyatıDataGridViewTextBoxColumn";
            // 
            // satısfıyatıDataGridViewTextBoxColumn
            // 
            this.satısfıyatıDataGridViewTextBoxColumn.DataPropertyName = "satısfıyatı";
            this.satısfıyatıDataGridViewTextBoxColumn.HeaderText = "satısfıyatı";
            this.satısfıyatıDataGridViewTextBoxColumn.Name = "satısfıyatıDataGridViewTextBoxColumn";
            // 
            // tarıhDataGridViewTextBoxColumn
            // 
            this.tarıhDataGridViewTextBoxColumn.DataPropertyName = "tarıh";
            this.tarıhDataGridViewTextBoxColumn.HeaderText = "tarıh";
            this.tarıhDataGridViewTextBoxColumn.Name = "tarıhDataGridViewTextBoxColumn";
            // 
            // frmUrünListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 638);
            this.Controls.Add(this.btnMarkaGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SatışFiyatıtxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BarkodNotxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AlışFiyatıtxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Kategoritxt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Miktarıtxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Markatxt);
            this.Controls.Add(this.UrunAdıtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUrünListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmÜrünListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakıpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SatışFiyatıtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BarkodNotxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AlışFiyatıtxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Miktarıtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.TextBox UrunAdıtxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodNoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMarkaGuncelle;
        private StokTakıpDataSet stokTakıpDataSet;
        private BindingSource urunBindingSource;
        private StokTakıpDataSetTableAdapters.urunTableAdapter urunTableAdapter;
        private DataGridViewTextBoxColumn barkodnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urunadıDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mıktarıDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alısfıyatıDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn satısfıyatıDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tarıhDataGridViewTextBoxColumn;
    }
}