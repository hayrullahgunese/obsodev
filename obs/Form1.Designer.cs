namespace obs
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxBolum;
        private System.Windows.Forms.NumericUpDown numericUpDownSinif;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogumTarihi;
        private System.Windows.Forms.Button ButtonOgrenciEkle;
        private System.Windows.Forms.Button ButtonOgrenciSil;
        private System.Windows.Forms.Button ButtonOgrenciGuncelle;

        
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.Label labelDogumTarihi;
        private System.Windows.Forms.Label labelBolum;
        private System.Windows.Forms.Label labelSinif;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notOrtalamasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obsDataSet = new obs.obsDataSet();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxBolum = new System.Windows.Forms.TextBox();
            this.numericUpDownSinif = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.ButtonOgrenciEkle = new System.Windows.Forms.Button();
            this.ButtonOgrenciSil = new System.Windows.Forms.Button();
            this.ButtonOgrenciGuncelle = new System.Windows.Forms.Button();
            this.labelAd = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.labelDogumTarihi = new System.Windows.Forms.Label();
            this.labelBolum = new System.Windows.Forms.Label();
            this.labelSinif = new System.Windows.Forms.Label();
            this.derslerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.derslerTableAdapter = new obs.obsDataSetTableAdapters.DerslerTableAdapter();
            this.labelDersAdi = new System.Windows.Forms.Label();
            this.labelKredi = new System.Windows.Forms.Label();
            this.textBoxDersAdi = new System.Windows.Forms.TextBox();
            this.buttonDersEkle = new System.Windows.Forms.Button();
            this.buttonDersSil = new System.Windows.Forms.Button();
            this.numericUpDownKredi = new System.Windows.Forms.NumericUpDown();
            this.ogrencilerTableAdapter = new obs.obsDataSetTableAdapters.OgrencilerTableAdapter();
            this.fKNotlarDersID3C69FB99BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notlarTableAdapter = new obs.obsDataSetTableAdapters.NotlarTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derslerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.obsDataSet2 = new obs.obsDataSet2();
            this.derslerTableAdapter1 = new obs.obsDataSet2TableAdapters.DerslerTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.notIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOgrenciID = new System.Windows.Forms.TextBox();
            this.textboxDersID = new System.Windows.Forms.TextBox();
            this.textBoxNotu = new System.Windows.Forms.TextBox();
            this.buttonNotEkle = new System.Windows.Forms.Button();
            this.buttonNotSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSinif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKredi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKNotlarDersID3C69FB99BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).BeginInit();
            this.SuspendLayout();
           
            
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn,
            this.sinifDataGridViewTextBoxColumn,
            this.notOrtalamasiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrencilerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 135);
            this.dataGridView1.TabIndex = 0;
            
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
             
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "Bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "Bolum";
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
             
            this.sinifDataGridViewTextBoxColumn.DataPropertyName = "Sinif";
            this.sinifDataGridViewTextBoxColumn.HeaderText = "Sinif";
            this.sinifDataGridViewTextBoxColumn.Name = "sinifDataGridViewTextBoxColumn";
            
            this.notOrtalamasiDataGridViewTextBoxColumn.DataPropertyName = "NotOrtalamasi";
            this.notOrtalamasiDataGridViewTextBoxColumn.HeaderText = "NotOrtalamasi";
            this.notOrtalamasiDataGridViewTextBoxColumn.Name = "notOrtalamasiDataGridViewTextBoxColumn";
                        this.ogrencilerBindingSource.DataMember = "Ogrenciler";
            this.ogrencilerBindingSource.DataSource = this.obsDataSet;
            
            this.obsDataSet.DataSetName = "obsDataSet";
            this.obsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            
            this.textBoxAd.Location = new System.Drawing.Point(100, 159);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(200, 20);
            this.textBoxAd.TabIndex = 2;
             
            
            this.textBoxSoyad.Location = new System.Drawing.Point(100, 189);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(200, 20);
            this.textBoxSoyad.TabIndex = 4;
           
            this.textBoxBolum.Location = new System.Drawing.Point(100, 249);
            this.textBoxBolum.Name = "textBoxBolum";
            this.textBoxBolum.Size = new System.Drawing.Size(200, 20);
            this.textBoxBolum.TabIndex = 8;
            
            this.numericUpDownSinif.Location = new System.Drawing.Point(100, 279);
            this.numericUpDownSinif.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownSinif.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSinif.Name = "numericUpDownSinif";
            this.numericUpDownSinif.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSinif.TabIndex = 10;
            this.numericUpDownSinif.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            
            this.dateTimePickerDogumTarihi.Location = new System.Drawing.Point(100, 219);
            this.dateTimePickerDogumTarihi.Name = "dateTimePickerDogumTarihi";
            this.dateTimePickerDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDogumTarihi.TabIndex = 6;
            
            this.ButtonOgrenciEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonOgrenciEkle.Location = new System.Drawing.Point(320, 159);
            this.ButtonOgrenciEkle.Name = "ButtonOgrenciEkle";
            this.ButtonOgrenciEkle.Size = new System.Drawing.Size(100, 23);
            this.ButtonOgrenciEkle.TabIndex = 11;
            this.ButtonOgrenciEkle.Text = "Öğrenci Ekle";
            this.ButtonOgrenciEkle.UseVisualStyleBackColor = false;
            this.ButtonOgrenciEkle.Click += new System.EventHandler(this.ButtonOgrenciEkle_Click);
            
            this.ButtonOgrenciSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonOgrenciSil.Location = new System.Drawing.Point(320, 189);
            this.ButtonOgrenciSil.Name = "ButtonOgrenciSil";
            this.ButtonOgrenciSil.Size = new System.Drawing.Size(100, 23);
            this.ButtonOgrenciSil.TabIndex = 12;
            this.ButtonOgrenciSil.Text = "Öğrenci Sil";
            this.ButtonOgrenciSil.UseVisualStyleBackColor = false;
            this.ButtonOgrenciSil.Click += new System.EventHandler(this.ButtonOgrenciSil_Click);
             
            this.ButtonOgrenciGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonOgrenciGuncelle.Location = new System.Drawing.Point(320, 219);
            this.ButtonOgrenciGuncelle.Name = "ButtonOgrenciGuncelle";
            this.ButtonOgrenciGuncelle.Size = new System.Drawing.Size(100, 23);
            this.ButtonOgrenciGuncelle.TabIndex = 13;
            this.ButtonOgrenciGuncelle.Text = "Öğrenci Güncelle";
            this.ButtonOgrenciGuncelle.UseVisualStyleBackColor = false;
            this.ButtonOgrenciGuncelle.Click += new System.EventHandler(this.ButtonOgrenciGuncelle_Click);
             
            this.labelAd.AutoSize = true;
            this.labelAd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAd.Location = new System.Drawing.Point(12, 159);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(23, 13);
            this.labelAd.TabIndex = 1;
            this.labelAd.Text = "Ad:";
            
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSoyad.Location = new System.Drawing.Point(12, 189);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(40, 13);
            this.labelSoyad.TabIndex = 3;
            this.labelSoyad.Text = "Soyad:";
             
            this.labelDogumTarihi.AutoSize = true;
            this.labelDogumTarihi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDogumTarihi.Location = new System.Drawing.Point(12, 219);
            this.labelDogumTarihi.Name = "labelDogumTarihi";
            this.labelDogumTarihi.Size = new System.Drawing.Size(73, 13);
            this.labelDogumTarihi.TabIndex = 5;
            this.labelDogumTarihi.Text = "Doğum Tarihi:";
            
            this.labelBolum.AutoSize = true;
            this.labelBolum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBolum.Location = new System.Drawing.Point(12, 249);
            this.labelBolum.Name = "labelBolum";
            this.labelBolum.Size = new System.Drawing.Size(39, 13);
            this.labelBolum.TabIndex = 7;
            this.labelBolum.Text = "Bölüm:";
            
            this.labelSinif.AutoSize = true;
            this.labelSinif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSinif.Location = new System.Drawing.Point(12, 279);
            this.labelSinif.Name = "labelSinif";
            this.labelSinif.Size = new System.Drawing.Size(30, 13);
            this.labelSinif.TabIndex = 9;
            this.labelSinif.Text = "Sınıf:";
            
            this.derslerBindingSource.DataMember = "Dersler";
            this.derslerBindingSource.DataSource = this.obsDataSet;
            
            this.derslerTableAdapter.ClearBeforeFill = true;
            
            this.labelDersAdi.AutoSize = true;
            this.labelDersAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDersAdi.Location = new System.Drawing.Point(12, 484);
            this.labelDersAdi.Name = "labelDersAdi";
            this.labelDersAdi.Size = new System.Drawing.Size(50, 13);
            this.labelDersAdi.TabIndex = 15;
            this.labelDersAdi.Text = "Ders Adı:";
            
            this.labelKredi.AutoSize = true;
            this.labelKredi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKredi.Location = new System.Drawing.Point(12, 515);
            this.labelKredi.Name = "labelKredi";
            this.labelKredi.Size = new System.Drawing.Size(34, 13);
            this.labelKredi.TabIndex = 16;
            this.labelKredi.Text = "Kredi:";
            
            this.textBoxDersAdi.Location = new System.Drawing.Point(100, 481);
            this.textBoxDersAdi.Name = "textBoxDersAdi";
            this.textBoxDersAdi.Size = new System.Drawing.Size(200, 20);
            this.textBoxDersAdi.TabIndex = 17;
            
            
            this.buttonDersEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDersEkle.Location = new System.Drawing.Point(320, 479);
            this.buttonDersEkle.Name = "buttonDersEkle";
            this.buttonDersEkle.Size = new System.Drawing.Size(100, 23);
            this.buttonDersEkle.TabIndex = 19;
            this.buttonDersEkle.Text = "Ders Ekle";
            this.buttonDersEkle.UseVisualStyleBackColor = false;
            this.buttonDersEkle.Click += new System.EventHandler(this.ButtonDersEkle_Click);
            
            this.buttonDersSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDersSil.Location = new System.Drawing.Point(320, 515);
            this.buttonDersSil.Name = "buttonDersSil";
            this.buttonDersSil.Size = new System.Drawing.Size(100, 23);
            this.buttonDersSil.TabIndex = 20;
            this.buttonDersSil.Text = "Ders Sil";
            this.buttonDersSil.UseVisualStyleBackColor = false;
            this.buttonDersSil.Click += new System.EventHandler(this.ButtonDersSil_Click);
            
            this.numericUpDownKredi.Location = new System.Drawing.Point(100, 518);
            this.numericUpDownKredi.Name = "numericUpDownKredi";
            this.numericUpDownKredi.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownKredi.TabIndex = 21;
            
            this.ogrencilerTableAdapter.ClearBeforeFill = true;
            
            this.fKNotlarDersID3C69FB99BindingSource.DataMember = "FK__Notlar__DersID__3C69FB99";
            this.fKNotlarDersID3C69FB99BindingSource.DataSource = this.derslerBindingSource;
            
           
            this.notlarTableAdapter.ClearBeforeFill = true;
            
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersIDDataGridViewTextBoxColumn,
            this.dersAdiDataGridViewTextBoxColumn,
            this.krediDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.derslerBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(15, 316);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(429, 151);
            this.dataGridView2.TabIndex = 22;
            
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            this.dersIDDataGridViewTextBoxColumn.ReadOnly = true;
             
            this.dersAdiDataGridViewTextBoxColumn.DataPropertyName = "DersAdi";
            this.dersAdiDataGridViewTextBoxColumn.HeaderText = "DersAdi";
            this.dersAdiDataGridViewTextBoxColumn.Name = "dersAdiDataGridViewTextBoxColumn";
             
            this.krediDataGridViewTextBoxColumn.DataPropertyName = "Kredi";
            this.krediDataGridViewTextBoxColumn.HeaderText = "Kredi";
            this.krediDataGridViewTextBoxColumn.Name = "krediDataGridViewTextBoxColumn";
            
            this.derslerBindingSource1.DataMember = "Dersler";
            this.derslerBindingSource1.DataSource = this.obsDataSet2;
             
            this.obsDataSet2.DataSetName = "obsDataSet2";
            this.obsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            
            this.derslerTableAdapter1.ClearBeforeFill = true;
             
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.notIDDataGridViewTextBoxColumn,
            this.ogrenciIDDataGridViewTextBoxColumn1,
            this.dersIDDataGridViewTextBoxColumn1,
            this.nOTUDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.notlarBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(583, 159);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(444, 151);
            this.dataGridView3.TabIndex = 23;
            
            this.notIDDataGridViewTextBoxColumn.DataPropertyName = "NotID";
            this.notIDDataGridViewTextBoxColumn.HeaderText = "NotID";
            this.notIDDataGridViewTextBoxColumn.Name = "notIDDataGridViewTextBoxColumn";
            this.notIDDataGridViewTextBoxColumn.ReadOnly = true;
             
            this.ogrenciIDDataGridViewTextBoxColumn1.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn1.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn1.Name = "ogrenciIDDataGridViewTextBoxColumn1";
             
            this.dersIDDataGridViewTextBoxColumn1.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn1.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn1.Name = "dersIDDataGridViewTextBoxColumn1";
            
            this.nOTUDataGridViewTextBoxColumn.DataPropertyName = "NOTU";
            this.nOTUDataGridViewTextBoxColumn.HeaderText = "NOTU";
            this.nOTUDataGridViewTextBoxColumn.Name = "nOTUDataGridViewTextBoxColumn";
            
            this.notlarBindingSource.DataMember = "Notlar";
            this.notlarBindingSource.DataSource = this.obsDataSet;
             
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(587, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "OgrenciID:";
             
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(587, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "DersID:";
            
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(587, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Notu:";
           
            this.textBoxOgrenciID.Location = new System.Drawing.Point(648, 333);
            this.textBoxOgrenciID.Name = "textBoxOgrenciID";
            this.textBoxOgrenciID.Size = new System.Drawing.Size(200, 20);
            this.textBoxOgrenciID.TabIndex = 27;
            
            this.textboxDersID.Location = new System.Drawing.Point(648, 363);
            this.textboxDersID.Name = "textboxDersID";
            this.textboxDersID.Size = new System.Drawing.Size(200, 20);
            this.textboxDersID.TabIndex = 28;
            
            this.textBoxNotu.Location = new System.Drawing.Point(648, 399);
            this.textBoxNotu.Name = "textBoxNotu";
            this.textBoxNotu.Size = new System.Drawing.Size(200, 20);
            this.textBoxNotu.TabIndex = 29;
            
            this.buttonNotEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNotEkle.Location = new System.Drawing.Point(854, 336);
            this.buttonNotEkle.Name = "buttonNotEkle";
            this.buttonNotEkle.Size = new System.Drawing.Size(100, 22);
            this.buttonNotEkle.TabIndex = 30;
            this.buttonNotEkle.Text = "Not Ekle";
            this.buttonNotEkle.UseVisualStyleBackColor = false;
            this.buttonNotEkle.Click += new System.EventHandler(this.ButtonNotEkle_Click);
             
            this.buttonNotSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNotSil.Location = new System.Drawing.Point(854, 361);
            this.buttonNotSil.Name = "buttonNotSil";
            this.buttonNotSil.Size = new System.Drawing.Size(100, 22);
            this.buttonNotSil.TabIndex = 31;
            this.buttonNotSil.Text = "Not Sil";
            this.buttonNotSil.UseVisualStyleBackColor = false;
            this.buttonNotSil.Click += new System.EventHandler(this.ButtonNotSil_Click);
            
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1056, 823);
            this.Controls.Add(this.buttonNotSil);
            this.Controls.Add(this.buttonNotEkle);
            this.Controls.Add(this.textBoxNotu);
            this.Controls.Add(this.textboxDersID);
            this.Controls.Add(this.textBoxOgrenciID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.numericUpDownKredi);
            this.Controls.Add(this.buttonDersSil);
            this.Controls.Add(this.buttonDersEkle);
            this.Controls.Add(this.textBoxDersAdi);
            this.Controls.Add(this.labelKredi);
            this.Controls.Add(this.labelDersAdi);
            this.Controls.Add(this.ButtonOgrenciGuncelle);
            this.Controls.Add(this.ButtonOgrenciSil);
            this.Controls.Add(this.ButtonOgrenciEkle);
            this.Controls.Add(this.numericUpDownSinif);
            this.Controls.Add(this.labelSinif);
            this.Controls.Add(this.textBoxBolum);
            this.Controls.Add(this.labelBolum);
            this.Controls.Add(this.dateTimePickerDogumTarihi);
            this.Controls.Add(this.labelDogumTarihi);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelAd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Öğrenci Bilgileri";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSinif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKredi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKNotlarDersID3C69FB99BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.derslerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private obsDataSet obsDataSet;
        private System.Windows.Forms.BindingSource derslerBindingSource;
        private obsDataSetTableAdapters.DerslerTableAdapter derslerTableAdapter;
        private System.Windows.Forms.Label labelDersAdi;
        private System.Windows.Forms.Label labelKredi;
        private System.Windows.Forms.TextBox textBoxDersAdi;
        private System.Windows.Forms.Button buttonDersEkle;
        private System.Windows.Forms.Button buttonDersSil;
        private System.Windows.Forms.NumericUpDown numericUpDownKredi;
        private System.Windows.Forms.BindingSource ogrencilerBindingSource;
        private obsDataSetTableAdapters.OgrencilerTableAdapter ogrencilerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notOrtalamasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKNotlarDersID3C69FB99BindingSource;
        private obsDataSetTableAdapters.NotlarTableAdapter notlarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private obsDataSet2 obsDataSet2;
        private System.Windows.Forms.BindingSource derslerBindingSource1;
        private obsDataSet2TableAdapters.DerslerTableAdapter derslerTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn notIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource notlarBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOgrenciID;
        private System.Windows.Forms.TextBox textboxDersID;
        private System.Windows.Forms.TextBox textBoxNotu;
        private System.Windows.Forms.Button buttonNotEkle;
        private System.Windows.Forms.Button buttonNotSil;
    }
}
