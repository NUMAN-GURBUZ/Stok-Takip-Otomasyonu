namespace StokTakipOtomasyonu
{
    partial class frmÜrünListeleme1
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
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barkodnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mıktarıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alısfıyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satısfıyatıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarıhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stokTakıpDataSet = new StokTakipOtomasyonu.StokTakıpDataSet();
            this.Tarıhtxt = new System.Windows.Forms.TextBox();
            this.urunTableAdapter = new StokTakipOtomasyonu.StokTakıpDataSetTableAdapters.urunTableAdapter();
            this.stokTakıpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakıpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakıpDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(105, 545);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(140, 26);
            this.btnMarkaGuncelle.TabIndex = 67;
            this.btnMarkaGuncelle.Text = "Marka Güncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 66;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Kategori";
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(105, 503);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(140, 24);
            this.comboMarka.TabIndex = 64;
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(105, 459);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(140, 24);
            this.comboKategori.TabIndex = 63;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 62;
            this.label1.Text = "Barkod No ya Göre Ara";
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.Location = new System.Drawing.Point(515, 67);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(133, 23);
            this.txtBarkodNoAra.TabIndex = 61;
            this.txtBarkodNoAra.TextChanged += new System.EventHandler(this.txtBarkodNoAra_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(884, 504);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 60;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(145, 395);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(100, 28);
            this.btnGüncelle.TabIndex = 46;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 59;
            this.label8.Text = "SatışFiyatı";
            // 
            // SatışFiyatıtxt
            // 
            this.SatışFiyatıtxt.Location = new System.Drawing.Point(145, 308);
            this.SatışFiyatıtxt.Name = "SatışFiyatıtxt";
            this.SatışFiyatıtxt.Size = new System.Drawing.Size(100, 23);
            this.SatışFiyatıtxt.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "AlışFiyatı";
            // 
            // BarkodNotxt
            // 
            this.BarkodNotxt.Location = new System.Drawing.Point(145, 73);
            this.BarkodNotxt.Name = "BarkodNotxt";
            this.BarkodNotxt.Size = new System.Drawing.Size(100, 23);
            this.BarkodNotxt.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "Miktarı";
            // 
            // AlışFiyatıtxt
            // 
            this.AlışFiyatıtxt.Location = new System.Drawing.Point(145, 269);
            this.AlışFiyatıtxt.Name = "AlışFiyatıtxt";
            this.AlışFiyatıtxt.Size = new System.Drawing.Size(100, 23);
            this.AlışFiyatıtxt.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(63, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "ÜrünAdı";
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Location = new System.Drawing.Point(145, 111);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.Size = new System.Drawing.Size(100, 23);
            this.Kategoritxt.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 55;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 109);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 17);
            this.label13.TabIndex = 54;
            this.label13.Text = "Kategori";
            // 
            // Miktarıtxt
            // 
            this.Miktarıtxt.Location = new System.Drawing.Point(145, 233);
            this.Miktarıtxt.Name = "Miktarıtxt";
            this.Miktarıtxt.Size = new System.Drawing.Size(100, 23);
            this.Miktarıtxt.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 53;
            this.label14.Text = "barkodno";
            // 
            // Markatxt
            // 
            this.Markatxt.Location = new System.Drawing.Point(145, 153);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.Size = new System.Drawing.Size(100, 23);
            this.Markatxt.TabIndex = 48;
            // 
            // UrunAdıtxt
            // 
            this.UrunAdıtxt.Location = new System.Drawing.Point(145, 198);
            this.UrunAdıtxt.Name = "UrunAdıtxt";
            this.UrunAdıtxt.Size = new System.Drawing.Size(100, 23);
            this.UrunAdıtxt.TabIndex = 49;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(300, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 339);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // barkodnoDataGridViewTextBoxColumn
            // 
            this.barkodnoDataGridViewTextBoxColumn.DataPropertyName = "barkodno";
            this.barkodnoDataGridViewTextBoxColumn.HeaderText = "barkodno";
            this.barkodnoDataGridViewTextBoxColumn.Name = "barkodnoDataGridViewTextBoxColumn";
            this.barkodnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.barkodnoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.barkodnoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            this.kategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunadıDataGridViewTextBoxColumn
            // 
            this.urunadıDataGridViewTextBoxColumn.DataPropertyName = "urunadı";
            this.urunadıDataGridViewTextBoxColumn.HeaderText = "urunadı";
            this.urunadıDataGridViewTextBoxColumn.Name = "urunadıDataGridViewTextBoxColumn";
            this.urunadıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mıktarıDataGridViewTextBoxColumn
            // 
            this.mıktarıDataGridViewTextBoxColumn.DataPropertyName = "mıktarı";
            this.mıktarıDataGridViewTextBoxColumn.HeaderText = "mıktarı";
            this.mıktarıDataGridViewTextBoxColumn.Name = "mıktarıDataGridViewTextBoxColumn";
            this.mıktarıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alısfıyatıDataGridViewTextBoxColumn
            // 
            this.alısfıyatıDataGridViewTextBoxColumn.DataPropertyName = "alısfıyatı";
            this.alısfıyatıDataGridViewTextBoxColumn.HeaderText = "alısfıyatı";
            this.alısfıyatıDataGridViewTextBoxColumn.Name = "alısfıyatıDataGridViewTextBoxColumn";
            this.alısfıyatıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // satısfıyatıDataGridViewTextBoxColumn
            // 
            this.satısfıyatıDataGridViewTextBoxColumn.DataPropertyName = "satısfıyatı";
            this.satısfıyatıDataGridViewTextBoxColumn.HeaderText = "satısfıyatı";
            this.satısfıyatıDataGridViewTextBoxColumn.Name = "satısfıyatıDataGridViewTextBoxColumn";
            this.satısfıyatıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarıhDataGridViewTextBoxColumn
            // 
            this.tarıhDataGridViewTextBoxColumn.DataPropertyName = "tarıh";
            this.tarıhDataGridViewTextBoxColumn.HeaderText = "tarıh";
            this.tarıhDataGridViewTextBoxColumn.Name = "tarıhDataGridViewTextBoxColumn";
            this.tarıhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "urun";
            this.urunBindingSource.DataSource = this.stokTakıpDataSet;
            // 
            // stokTakıpDataSet
            // 
            this.stokTakıpDataSet.DataSetName = "StokTakıpDataSet";
            this.stokTakıpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Tarıhtxt
            // 
            this.Tarıhtxt.Location = new System.Drawing.Point(145, 348);
            this.Tarıhtxt.Name = "Tarıhtxt";
            this.Tarıhtxt.Size = new System.Drawing.Size(100, 23);
            this.Tarıhtxt.TabIndex = 68;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // stokTakıpDataSetBindingSource
            // 
            this.stokTakıpDataSetBindingSource.DataSource = this.stokTakıpDataSet;
            this.stokTakıpDataSetBindingSource.Position = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "Tarih";
            // 
            // frmÜrünListeleme1
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 638);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tarıhtxt);
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
            this.Name = "frmÜrünListeleme1";
            this.Text = "frmÜrünListeleme1";
            this.Load += new System.EventHandler(this.frmÜrünListeleme1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakıpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokTakıpDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarkaGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarkodNoAra;
        private System.Windows.Forms.Button btnSil;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private StokTakıpDataSet stokTakıpDataSet;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private StokTakıpDataSetTableAdapters.urunTableAdapter urunTableAdapter;
        private System.Windows.Forms.TextBox Tarıhtxt;
        private System.Windows.Forms.BindingSource stokTakıpDataSetBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn barkodnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mıktarıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alısfıyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satısfıyatıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarıhDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
    }
}