using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CProje
{
    public partial class kasabilgilerics : Form
    {

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=proje01;user=root");
        
        public kasabilgilerics()
        {
            InitializeComponent();
        }

        private void txtpcmodel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void listele()
        {
            MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM tbl_personeller  ORDER BY sicilno", baglanti);
            DataTable dt = new DataTable();
            dt.Clear();
            adaptor.Fill(dt); // tabloyu doldur
            adaptor.Dispose(); // adaptörü kapat
            baglanti.Close();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            {
                Int32 satir;
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand();
                // Insert Into SQL ile tablomuza formdaki
                // verileri yine parametreli şekilde dönderiyoruz    
                komut.CommandText = "UPDATE tbl_personeller SET demirbasno=@pdemirbasno, isletimsistemi=@pisletimsistemi," +
                    " islemcimarkamodel=@pislemcimarkamodel, ram=@pram,diskkapasitesi=@pdiskkapasitesi,ekrankartı=@pekrankartı,model=@pmodel,hız=@phız,cekirdek=@pcekirdek,boyut=@pboyut " +
                    " WHERE  sicilno = @psicilno";
                // @ işareti ile başlayan kısım parametreli değişkenleri
                // ifade ediyor
                komut.Parameters.AddWithValue("@pdemirbasno", txtkasademirbasnumarasi.Text);
                komut.Parameters.AddWithValue("@psicilno", txtcalisansicilnumarasi.Text);
                komut.Parameters.AddWithValue("@pisletimsistemi", txtisletimsistemi.Text);
                komut.Parameters.AddWithValue("@pislemcimarkamodel", txtistemcimarkavemodeli.Text);
                komut.Parameters.AddWithValue("@pram", txtram.Text);
                komut.Parameters.AddWithValue("@pdiskkapasitesi", txtsabitdiskkapasitesi.Text);
                komut.Parameters.AddWithValue("@pekrankartı", txtekrankartı.Text);
                komut.Parameters.AddWithValue("@pmodel", txtpcmodel.Text);
                komut.Parameters.AddWithValue("@phız", txtislemcihiz.Text);
                komut.Parameters.AddWithValue("@pcekirdek", txtcekirdeksayisi.Text);
                komut.Parameters.AddWithValue("@pboyut", txtmonitörboyutu.Text);
                komut.Connection = baglanti;
                satir = komut.ExecuteNonQuery();
                MessageBox.Show(satir + " satırda personel bilgisi değişti");
                komut.Dispose(); // komut nesnesini yoket
                baglanti.Close(); // bağlantıyı kapat
                listele(); //datagrid tazelensin



            //    Int32 satir;
            //    baglanti.Open();
            //    MySqlCommand komut = new MySqlCommand();
            ////    Insert Into SQL ile tablomuza formdaki verileri
            ////     parametreli(@) şekilde gönderiyoruz
            ////     parametreler SQL injection a karşı tedbir olarak uygulanır
            ////     Tırnak işaretleri ile uğraşılmak zorunda kalınmaz
            //    komut.CommandText = "UPDATE tbl_personeller  (demirbasno,sicilno,isletimsistemi,islemcimarkamodel,ram,diskkapasitesi,ekrankartı,model,hız,cekirdek,boyut)" +
            // "SET (@pdemirbasno,@psicilno,@pisletimsistemi,@pislemcimarkamodel,@pram,@pdiskkapasitesi,@pekrankartı,@pmodel,@phız,@pcekirdek,@pboyut)";
            ////     @ işareti ile başlayan kısım parametreli değişkenlere
            ////     değerler aktarıyor
            //    komut.Parameters.AddWithValue("@pdemirbasno", txtkasademirbasnumarasi.Text);
            //    komut.Parameters.AddWithValue("@psicilno", txtcalisansicilnumarasi.Text);
            //    komut.Parameters.AddWithValue("@pisletimsistemi", txtisletimsistemi.Text);
            //    komut.Parameters.AddWithValue("@pislemcimarkamodel", txtistemcimarkavemodeli.Text);
            //    komut.Parameters.AddWithValue("@pram", txtram.Text);
            //    komut.Parameters.AddWithValue("@pdiskkapasitesi", txtsabitdiskkapasitesi.Text);
            //    komut.Parameters.AddWithValue("@pekrankartı", txtekrankartı.Text);
            //    komut.Parameters.AddWithValue("@pmodel", txtpcmodel.Text);
            //    komut.Parameters.AddWithValue("@phız", txtislemcihiz.Text);
            //    komut.Parameters.AddWithValue("@pcekirdek", txtcekirdeksayisi.Text);
            //    komut.Parameters.AddWithValue("@pboyut", txtmonitörboyutu.Text);
            //    komut.Connection = baglanti;
            //    satir = komut.ExecuteNonQuery();
            //    MessageBox.Show(satir + "satır personel kasa bilgisi eklendi");
            //    komut.Dispose(); // komut nesnesini yoket
            //    baglanti.Close(); // bağlantıyı kapat
            //    listele(); //datagrid tazelensin
                }
            }

        private void btnkaydisil_Click(object sender, EventArgs e)
        {
            Int32 satir;
            DialogResult cevap;
            cevap = MessageBox.Show("Silmek istediğinizden emin misiniz bilgiler kalıcı olarak silinecektir", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                baglanti.Open();
                MySqlCommand komut = new MySqlCommand();
                // Yine parametreli şekilde göderiyoruz
                komut.CommandText = "DELETE FROM tbl_personeller WHERE sicilno=@psicilno";
                // @ işareti ile başlayan kısım parametreli değişkenleri ifade ediyor
                komut.Parameters.AddWithValue("@psicilno", txtcalisansicilnumarasi.Text);
                komut.Connection = baglanti;
                satir = komut.ExecuteNonQuery();
                MessageBox.Show(satir + " satır personele ait kasa bilgisi silindi");
                komut.Dispose();
                baglanti.Close();
                listele();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void kasabilgilerics_Load(object sender, EventArgs e)
        {

        }

        private void txtkasademirbasnumarasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtustsicilno_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtcalisansicilnumarasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcalisansicilnumarasi_TextChanged_1(object sender, EventArgs e)
        {

            if (txtcalisansicilnumarasi.Text == "") foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            baglanti.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_personeller WHERE sicilno LIKE '" + txtcalisansicilnumarasi.Text + "'", baglanti);
            MySqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                txtkasademirbasnumarasi.Text = read["demirbasno"].ToString();
                txtcalisansicilnumarasi.Text = read["sicilno"].ToString();
                txtisletimsistemi.Text = read["isletimsistemi"].ToString();
                txtistemcimarkavemodeli.Text = read["islemcimarkamodel"].ToString();
                txtram.Text = read["ram"].ToString();
                txtsabitdiskkapasitesi.Text = read["diskkapasitesi"].ToString();
                txtekrankartı.Text = read["ekrankartı"].ToString();
                txtpcmodel.Text = read["model"].ToString();
                txtislemcihiz.Text = read["hız"].ToString();
                txtcekirdeksayisi.Text = read["cekirdek"].ToString();
                txtmonitörboyutu.Text = read["boyut"].ToString();


            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
