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


namespace Not_kayıt_sistemi
{
    public partial class FrmÖğretmenDetay : Form
    {
        public FrmÖğretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-G59PNFR;Initial Catalog=Dböğrencinot;Integrated Security=True");
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmÖğretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dböğrencinotDataSet.tblders' table. You can move, or remove it, as needed.
            this.tbldersTableAdapter.Fill(this.dböğrencinotDataSet.tblders);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblders (OGRNUMARA,OGRAD,OGRSOYAD) values (@P1,@P2,@P3)",baglanti);
            komut.Parameters.AddWithValue("@P1", MskNumara.Text);
            komut.Parameters.AddWithValue("@P2", txtad.Text);
            komut.Parameters.AddWithValue("@P3", txtsoyad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("öğrenci sisteme eklendi");
            this.tbldersTableAdapter.Fill(this.dböğrencinotDataSet.tblders);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;

            MskNumara.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            txtsınav1.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            txtsınav2.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            txtsınav3.Text = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(txtsınav1.Text);
            s2 = Convert.ToDouble(txtsınav2.Text);
            s3=Convert.ToDouble(txtsınav3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblortalama.Text = ortalama.ToString("0.00");

            if(ortalama>=50)
            {
                durum = "true";
            }
            else
            {
                durum = "false";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update tblders set OGRS1=@P1, OGRS2=@P2, OGRS3=@P3,Ortalama=@P4,Durum=@P5 WHERE OGRNUMARA=@P6 " ,baglanti);
            komut.Parameters.AddWithValue("@P1", txtsınav1.Text);
            komut.Parameters.AddWithValue("@P2", txtsınav2.Text);
            komut.Parameters.AddWithValue("@P3", txtsınav3.Text);
            komut.Parameters.AddWithValue("@P4", decimal.Parse(lblortalama.Text));
            komut.Parameters.AddWithValue("@P5", durum );
            komut.Parameters.AddWithValue("@P6", MskNumara.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("öğrenci notları güncellendi");
            this.tbldersTableAdapter.Fill(this.dböğrencinotDataSet.tblders);

           


        }

    }
}
