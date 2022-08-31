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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=personel.accdb");
        public static string id, adi, soyadi, yetki;

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            txtAd.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {  
            txtSoyad.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text.Length < 8)
                errorProvider1.SetError(txtKullaniciAdi, "Kullanıcı adı en az 8 karakter olmalı");
            else
                errorProvider1.Clear();
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        } 
        public string StringReplace(string text)
        {
            
            return text;
        }
        public  void txtSifre_TextChanged(object sender, EventArgs e)
        {
            string sifre = txtSifre.Text;
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
            if (sifre !=duzeltilmis_sifre)
            {
                sifre = duzeltilmis_sifre;
                txtSifre.Text = sifre;
                MessageBox.Show("Paroladaki Türkçe karakterler İngilizce karakterlere dönüştürülmüştür.");
            }//.{6,}
            //var t = (TextBox)sender;
        }
        
        void ekle()
        {
            if (string.IsNullOrEmpty(txtAd.Text) ||
                   string.IsNullOrEmpty(txtSoyad.Text) ||
                   string.IsNullOrEmpty(txtKullaniciAdi.Text) ||
                   string.IsNullOrEmpty(txtSifre.Text) ||
                   string.IsNullOrEmpty(txtSifreTekrar.Text))
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.");
                return;
            }
            else if (txtSifre.Text != txtSifreTekrar.Text )
            {
                MessageBox.Show("Şifreler Uyuşmuyor!");
                return;
            }
            else if (radioBttnKullanici.Checked == false)
            {
                MessageBox.Show("Lütfen yetkinizi seçiniz!");
                return;
            }
            var m = Regex.Match(txtSifre.Text, @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]))");
            if (!string.IsNullOrEmpty(txtSifre.Text) && !m.Success)
            {
                errorProvider2.SetError(txtSifre, "Şifreniz en az 1 büyük harf, 1 küçük harf ve bir rakam içermelidir. Şifreniz en az 6 haneli olmalıdır. ");
                return;
            }
            else
            {
                MessageBox.Show("Kaydınız başarılıdır. Oturum açarak işleminize devam edebilirsiniz.");
                errorProvider2.Clear();
            }
       
            OleDbCommand cmd = new OleDbCommand();
            baglantim.Open();
            cmd.Connection = baglantim;
            cmd.CommandText = "insert into kullanicilar (ad, soyad, yetki, kullaniciadi, parola, parolatekrar) values (@ad, @soyad, @yetki, @kullaniciadi, @parola, @parolatekrar)";
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);

            string yetki = "";
            if (radioBttnKullanici.Checked==true)
            {
                yetki = "Kullanıcı";
            }
            cmd.Parameters.AddWithValue("@yetki", yetki);
            cmd.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@parola", txtSifre.Text);
            cmd.Parameters.AddWithValue("@parolatekrar", txtSifreTekrar.Text);
            cmd.ExecuteNonQuery();
            baglantim.Close();
            
        }//tabloya ekleyen kısım

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

        private void bttnKaydol_Click(object sender, EventArgs e)
        { 
            ekle();
        }
        private void btnOturumAç_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
            this.Text = "İleti Yönetim Sistemi";
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
    }
}

