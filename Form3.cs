using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace IletiYS
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= personel.accdb");

        private void Form3_Load(object sender, EventArgs e)
        {
            markalari_goster();
            kullanicilari_goster();
            this.Text = "Yönetici Girişi";
        }
        int kullanici_id = 0;
        int marka_id = 0;
        void kullanici_ekle()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("insert into kullanicilar(ad,soyad,yetki,kullaniciadi,parola,parolatekrar) values(@ad,@soyad,@yetki,@kullaniciadi,@parola,@parolatekrar) ", baglantim);
                baglantim.Open();
                cmd.Parameters.Add("@ad", OleDbType.VarChar).Value = txtAd.Text;
                cmd.Parameters.Add("@soyad", OleDbType.VarChar).Value = txtSoyad.Text;
                string yetki = "";
                if (radiobutonkullanici.Checked)
                {
                    yetki = radiobutonkullanici.Text;
                }
                else if (radioButtonYönetici.Checked)
                {
                    yetki = radioButtonYönetici.Text;
                }
                cmd.Parameters.Add("@yetki", OleDbType.VarChar).Value = yetki;
                cmd.Parameters.Add("@kullaniciadi", OleDbType.VarChar).Value = txtKulanıcıAdı.Text;

                if (txtParola.Text != txtParolaTekrar.Text)
                {
                    MessageBox.Show("Parolanız ve parola tekrarınız uyuşmuyor.");
                    return;
                }
                else
                {
                    cmd.Parameters.Add("@parola", OleDbType.VarChar).Value = txtParola.Text;
                    cmd.Parameters.Add("@parolatekrar", OleDbType.VarChar).Value = txtParolaTekrar.Text;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                baglantim.Close();
            }
            kullanicilari_goster();
        }
        void kullanici_sil()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("delete from kullanicilar where kullanici_id = @kullanici_id ", baglantim);
                baglantim.Open();

                cmd.Parameters.Add("@id", OleDbType.Integer).Value = kullanici_id;
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                baglantim.Close();
            }
            kullanicilari_goster();
        }
        void kullanici_guncelle()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("update kullanicilar set ad=@ad,soyad=@soyad,yetki=@yetki,kullaniciadi=@kullaniciadi,parola=@parola,parolatekrar=@parolatekrar where id=@id ", baglantim);
                baglantim.Open();
                cmd.Parameters.Add("@ad", OleDbType.VarChar).Value = txtAd.Text;
                cmd.Parameters.Add("@soyad", OleDbType.VarChar).Value = txtSoyad.Text;
                string yetki = "";
                if (radiobutonkullanici.Checked)
                {
                    yetki = radiobutonkullanici.Text;
                }
                else if (radioButtonYönetici.Checked)
                {
                    yetki = radioButtonYönetici.Text;
                }
                cmd.Parameters.Add("@yetki", OleDbType.VarChar).Value = yetki;
                cmd.Parameters.Add("@kullaniciadi", OleDbType.VarChar).Value = txtKulanıcıAdı.Text;
                if (txtParola.Text != txtParolaTekrar.Text)
                {
                    MessageBox.Show("Parola ve parola tekrarınız uyuşmuyor.");
                    return;
                }
                else
                {
                    cmd.Parameters.Add("@parola", OleDbType.VarChar).Value = txtParola.Text;
                    cmd.Parameters.Add("@parolatekrar", OleDbType.VarChar).Value = txtParolaTekrar.Text;
                    cmd.Parameters.Add("@id", OleDbType.Integer).Value = kullanici_id;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                baglantim.Close();
            }
            kullanicilari_goster();
        }
        void marka_temizle()
        {
            marka_id = 0;
            txtHizmetSaglayici.Text = "";
            rdbtnSmsEvet.Checked = false;
            rdbtnSmsHayır.Checked = false;
            rdbtnMailHayır.Checked = false;
            rdbtnMailEvet.Checked = false;
        }  
        void kullanici_temizle()
        {
            kullanici_id = 0;
            txtAd.Text = "";
            txtSoyad.Text = "";
            radiobutonkullanici.Checked = false;
            radioButtonYönetici.Checked = false;
            txtKulanıcıAdı.Text = "";
            txtParola.Text = "";
            txtParolaTekrar.Text = "";
        }
        void marka_ekle()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("insert into markalar(marka,SMS,MAIL) values(@marka,@SMS,@MAIL) ", baglantim);
                baglantim.Open();
                cmd.Parameters.Add("@marka", OleDbType.VarChar).Value = txtHizmetSaglayici.Text;
                
                string sms_izni = "";
                if (rdbtnSmsEvet.Checked)
                {
                    sms_izni = rdbtnSmsEvet.Text;
                }
                else if (rdbtnSmsHayır.Checked)
                {
                    sms_izni = rdbtnSmsHayır.Text;
                }
                cmd.Parameters.Add("@SMS", OleDbType.VarChar).Value = sms_izni;
                string mailizin = "";
                if (rdbtnMailEvet.Checked)
                {
                    mailizin = rdbtnMailEvet.Text;
                }
                else if (rdbtnMailHayır.Checked)
                {
                    mailizin = rdbtnMailHayır.Text;
                }
                
                cmd.Parameters.Add("@MAIL", OleDbType.VarChar).Value = mailizin;
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                baglantim.Close();
            }
            markalari_goster();
        }
        void marka_sil()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("delete from markalar where id = @id ", baglantim);
                baglantim.Open();

                cmd.Parameters.Add("@id", OleDbType.Integer).Value = marka_id;
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                baglantim.Close();
            }
            markalari_goster();
        }
        void marka_guncelle()
        {
            try
            {
                OleDbCommand cmd = new OleDbCommand("update markalar set marka=@marka, SMS=@SMS, MAIL=@MAIL where id=@id ", baglantim);
                baglantim.Open();
                cmd.Parameters.Add("@marka", OleDbType.VarChar).Value = txtHizmetSaglayici.Text;

                string sms_izni = "";
                if (rdbtnSmsEvet.Checked)
                {
                    sms_izni = rdbtnSmsEvet.Text;
                }
                else if (rdbtnSmsHayır.Checked)
                {
                    sms_izni = rdbtnSmsHayır.Text;
                }
                else
                {
                    return;
                }
                string mail_izni = "";
                if (rdbtnMailEvet.Checked)
                {
                    mail_izni = rdbtnMailEvet.Text;
                }
                else if (rdbtnMailHayır.Checked)
                {
                    mail_izni = rdbtnMailHayır.Text;
                }
                else
                {
                    return;
                }
                cmd.Parameters.Add("@SMS", OleDbType.VarChar).Value = sms_izni;
                cmd.Parameters.Add("@MAIL", OleDbType.VarChar).Value = mail_izni;
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = marka_id;
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                throw ex;
            }
            finally
            {
                baglantim.Close();
            }
            markalari_goster();
        }
        private void kullanicilari_goster()
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter kullanicilari_listele = new OleDbDataAdapter("select id AS [ID], ad AS [ADI], soyad AS [SOYADI], yetki as [YETKİSİ], kullaniciadi AS [KULLANICI ADI], parola AS [PAROLA] from kullanicilar", baglantim);
                DataSet ds = new DataSet();
                kullanicilari_listele.Fill(ds);
                dgKullanicilar.DataSource = ds.Tables[0];
                baglantim.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "ILETİ YONETİM SİSTEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantim.Close();

            }
        }
        private void markalari_goster()
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter markaları_listele = new OleDbDataAdapter("select id AS [ID], marka AS [HİZMET SAĞLAYICI], SMS AS [SMS İZNİ], MAIL as [MAIL İZNİ] from markalar", baglantim);
                DataSet ds = new DataSet();
                markaları_listele.Fill(ds);
                dgHizmetSaglayici.DataSource = ds.Tables[0];
                baglantim.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "ILETİ YONETİM SİSTEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantim.Close();

            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            string kayit = "SELECT * from markalar where marka = @marka";
            OleDbCommand komut = new OleDbCommand(kayit, baglantim);
            komut.Parameters.AddWithValue("@marka", txtHizmetSaglayici.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgHizmetSaglayici.DataSource = dt;
            baglantim.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            string kayit = "SELECT * from kullanicilar where ad = @ad ";
            OleDbCommand komut = new OleDbCommand(kayit, baglantim);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgKullanicilar.DataSource = dt;
            baglantim.Close();    
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            txtAd.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            txtSoyad.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtKulanıcıAdı_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (kullanici_id == 0)
            {
                kullanici_ekle();
            }
            else
            {
                MessageBox.Show("Seçtiğiniz kullanıcı sistemimizde mevcut.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (kullanici_id > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili kullanıcıyı silmek istediğinizden emin misiniz?","Kullanıcı Sil",MessageBoxButtons.YesNo);
                if (dialogResult==DialogResult.Yes)
                {
                    kullanici_sil();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı seçiniz.");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (kullanici_id > 0)
            {
                kullanici_guncelle();
            }
            else
            {
                MessageBox.Show("Kullanıcı seçiniz.");
            }
        }

        private void dgKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                kullanici_id = Convert.ToInt32(dgKullanicilar.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select * from kullanicilar where id = @id", baglantim);
                    cmd.Parameters.Add("@id", OleDbType.Integer).Value = kullanici_id;
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    radiobutonkullanici.Checked = false;
                    radioButtonYönetici.Checked = false;

                    foreach (DataRow row in dt.Rows)
                    {
                        txtAd.Text = row["ad"].ToString();
                        txtSoyad.Text = row["soyad"].ToString();
                        string yetki = row["yetki"].ToString();
                        if (yetki == "Kullanıcı")
                        {
                            radiobutonkullanici.Checked = true;
                        }
                        else if (yetki == "Yönetici")
                        {
                            radioButtonYönetici.Checked = true;
                        }
                        txtKulanıcıAdı.Text = row["kullaniciadi"].ToString();
                        txtParola.Text = row["parola"].ToString();
                        txtParolaTekrar.Text = row["parolatekrar"].ToString();
                    }
                }
                catch (OleDbException ex)
                {
                    throw ex;
                }
            }
        }

        private void txtKulanıcıAdı_TextChanged(object sender, EventArgs e)
        {
            if (txtKulanıcıAdı.Text.Length < 8)
                errorProvider1.SetError(txtKulanıcıAdı, "Kullanıcı adı en az 8 karakter olmalı");
            else
                errorProvider1.Clear();
        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            string sifre = txtParola.Text;
            string duzeltilmis_sifre = "";
            duzeltilmis_sifre = sifre;
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("İ", "I");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("ı", "i");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("Ğ", "G");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("ğ", "g");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("Ö", "O");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("ö", "o");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("Ü", "U");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("ü", "u");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("Ş", "S");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("ş", "s");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("Ç", "C");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace("ç", "c");
            duzeltilmis_sifre = duzeltilmis_sifre.Replace(" ", "_");
            if (sifre != duzeltilmis_sifre)
            {
                sifre = duzeltilmis_sifre;
                txtParola.Text = sifre;
                MessageBox.Show("Paroladaki Türkçe karakterler İngilizce karakterlere dönüştürülmüştür.");
            }
            var m = Regex.Match(txtParola.Text, @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]))");
            if (!string.IsNullOrEmpty(txtParola.Text) && !m.Success)
            {
                errorProvider2.SetError(txtParola, "Şifreniz en az 1 büyük harf, 1 küçük harf ve bir rakam içermelidir. Şifreniz en az 6 haneli olmalıdır. ");
                return;
            }
            else
            {  
                errorProvider2.Clear();
            }
        }

        private void dgHizmetSaglayici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                marka_id = Convert.ToInt32(dgHizmetSaglayici.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    OleDbCommand cmd = new OleDbCommand("select * from markalar where id = @id", baglantim);
                    cmd.Parameters.Add("@id", OleDbType.Integer).Value = marka_id;

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    rdbtnSmsEvet.Checked = false;
                    rdbtnSmsHayır.Checked = false;
                    rdbtnMailEvet.Checked = false;
                    rdbtnMailHayır.Checked = false;

                    foreach (DataRow row in dt.Rows)
                    {
                        txtHizmetSaglayici.Text = row["marka"].ToString();
                        string sms_izni = row["SMS"].ToString();
                        if (sms_izni == "Evet")
                        {
                            rdbtnSmsEvet.Checked = true;
                        }
                        else if (sms_izni == "Hayır")
                        {
                            rdbtnSmsHayır.Checked = true;
                        }
                        string mail_izni = row["MAIL"].ToString();
                        if (mail_izni == "Evet")
                        {
                            rdbtnMailEvet.Checked = true;
                        }
                        else if (mail_izni == "Hayır")
                        {
                            rdbtnMailHayır.Checked = true;
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    throw ex;
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (marka_id == 0)
            {
                marka_ekle();
            }
            else
            {
                MessageBox.Show("Seçtiğiniz marka sistemimizde mevcut.");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (marka_id > 0)
            {
                marka_guncelle();
            }
            else
            {
                MessageBox.Show("Marka seçiniz.");
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (marka_id > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili hizmet sağlayıcıyı silmek istediğinizden emin misiniz?", "Hizmet Sağlayıcı Sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    marka_sil();
                }
                else
                {
                    MessageBox.Show("İşlem iptal edildi.");
                }
            }
            else
            {
                MessageBox.Show("Hizmet sağlayıcıyı seçiniz.");
            }
        }
        
        private void btnTemizleMarka_Click(object sender, EventArgs e)
        {
            marka_temizle();
        }

        private void btnFormTemizle_Click(object sender, EventArgs e)
        {
            kullanici_temizle();
        }

        private void dgHizmetSaglayici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
/* https://www.youtube.com/watch?v=LWohe5DpbXs&list=PLHdc9qzk6Ge17h57CJ3cCp25v8IcuXFf_&index=3 
  https://www.youtube.com/watch?v=Z-9cV6-m0Mc */