using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace obs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.derslerTableAdapter1.Fill(this.obsDataSet2.Dersler);
            this.notlarTableAdapter.Fill(this.obsDataSet.Notlar);
            this.ogrencilerTableAdapter.Fill(this.obsDataSet.Ogrenciler);
            this.derslerTableAdapter.Fill(this.obsDataSet.Dersler);

            LoadOgrenciData();
            LoadDersData();   
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                textBoxAd.Text = row.Cells["Ad"].Value.ToString();
                textBoxSoyad.Text = row.Cells["Soyad"].Value.ToString();
                textBoxBolum.Text = row.Cells["Bolum"].Value.ToString();
                numericUpDownSinif.Value = Convert.ToDecimal(row.Cells["Sinif"].Value);
                dateTimePickerDogumTarihi.Value = Convert.ToDateTime(row.Cells["DogumTarihi"].Value);
            }
        }

        private void ButtonOgrenciEkle_Click(object sender, EventArgs e)
        {
            string ad = textBoxAd.Text;
            string soyad = textBoxSoyad.Text;
            string bolum = textBoxBolum.Text;
            int sinif = (int)numericUpDownSinif.Value;
            DateTime dogumTarihi = dateTimePickerDogumTarihi.Value;

            string connectionString = "Data Source=DESKTOP-8FACNE8;Initial Catalog=obs;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Ogrenciler (Ad, Soyad, Bolum, Sinif, DogumTarihi) VALUES (@Ad, @Soyad, @Bolum, @Sinif, @DogumTarihi)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Ad", ad);
                    cmd.Parameters.AddWithValue("@Soyad", soyad);
                    cmd.Parameters.AddWithValue("@Bolum", bolum);
                    cmd.Parameters.AddWithValue("@Sinif", sinif);
                    cmd.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadOgrenciData();
        }

        private void ButtonOgrenciSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ogrenciID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);



                string connectionString = "Data Source=DESKTOP-8FACNE8;Initial Catalog=obs;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Ogrenciler WHERE OgrenciID = @OgrenciID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Öğrenci başarıyla silindi.");
                    }
                }

                LoadOgrenciData();
            }
        }

        private void ButtonOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ogrenciID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                string ad = textBoxAd.Text;
                string soyad = textBoxSoyad.Text;
                string bolum = textBoxBolum.Text;
                int sinif = (int)numericUpDownSinif.Value;
                DateTime dogumTarihi = dateTimePickerDogumTarihi.Value;

                string connectionString = "Data Source=DESKTOP-8FACNE8;Initial Catalog=obs;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Ogrenciler SET Ad = @Ad, Soyad = @Soyad, Bolum = @Bolum, Sinif = @Sinif, DogumTarihi = @DogumTarihi WHERE OgrenciID = @OgrenciID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ad", ad);
                        cmd.Parameters.AddWithValue("@Soyad", soyad);
                        cmd.Parameters.AddWithValue("@Bolum", bolum);
                        cmd.Parameters.AddWithValue("@Sinif", sinif);
                        cmd.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                        cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadOgrenciData();
            }
        }

        private void LoadOgrenciData()
        {
            string connectionString = "Data Source=DESKTOP-8FACNE8;Initial Catalog=obs;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Ogrenciler";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void ButtonDersEkle_Click(object sender, EventArgs e)
        {
            string dersAdi = textBoxDersAdi.Text;
            int kredi = (int)numericUpDownKredi.Value;

            string connectionString = "Data Source=DESKTOP-8FACNE8;Initial Catalog=obs;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Dersler (DersAdi, Kredi) VALUES (@DersAdi, @Kredi)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DersAdi", dersAdi);
                    cmd.Parameters.AddWithValue("@Kredi", kredi);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadDersData();
        }

        private void LoadDersData()
        {
            string connectionString = "Data Source=DESKTOP-8FACNE8;Initial Catalog=obs;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DersID, DersAdi, Kredi FROM Dersler";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
        }

        private void ButtonDersSil_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int dersID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);


                string connectionString = "Data Source=DESKTOP-8FACNE8;Initial Catalog=obs;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Dersler WHERE DersID = @DersID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DersID", dersID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Ders başarıyla silindi.");
                    }
                }

                LoadDersData();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir ders seçin.");
            }

        }

private void ButtonNotEkle_Click(object sender, EventArgs e)
        {
            int ogrenciID = int.Parse(textBoxOgrenciID.Text);
            int dersID = int.Parse(textboxDersID.Text);
            int notu = int.Parse(textBoxNotu.Text);

            string connectionString = "Data Source=DESKTOP-8FACNE8;Initial Catalog=obs;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Notlar (OgrenciID, DersID, NOTU) VALUES (@OgrenciID, @DersID, @NOTU)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                    cmd.Parameters.AddWithValue("@DersID", dersID);
                    cmd.Parameters.AddWithValue("@NOTU", notu);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Not başarıyla eklendi.");
                }
            }

            LoadNotlarData();
        }

        private void ButtonNotSil_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int notID = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);

                string connectionString = "Data Source=DESKTOP-8FACNE8;Initial Catalog=obs;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Notlar WHERE NotID = @NotID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NotID", notID);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Not başarıyla silindi.");
                    }
                }

                LoadNotlarData();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir not seçin.");
            }
        }

        private void LoadNotlarData()
        {
            string connectionString = "Data Source=DESKTOP-8FACNE8;Initial Catalog=obs;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT NotID, OgrenciID, DersID, NOTU FROM Notlar";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView3.DataSource = dt;
            }
        }

    }
}

