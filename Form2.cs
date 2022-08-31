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

namespace IletiYS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=personel.accdb");
        public static string id, adi, soyadi, yetki;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (hak != 0)
            {
                baglantim.Open();
                OleDbCommand selectsorgu = new OleDbCommand("select * from kullanicilar", baglantim);
                OleDbDataReader kayitokuma = selectsorgu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    if (radiobutton1.Checked == true)
                    {
                        if (kayitokuma["kullaniciadi"].ToString() == textBox1.Text && kayitokuma["parola"].ToString() == textBox2.Text && kayitokuma["yetki"].ToString() == "Yönetici")
                        {
                            durum = true;
                            id = kayitokuma.GetValue(0).ToString();
                            adi = kayitokuma.GetValue(1).ToString();
                            soyadi = kayitokuma.GetValue(2).ToString();
                            yetki = kayitokuma.GetValue(3).ToString();
                            this.Hide();
                            Form3 form3 = new Form3();
                            form3.Show();
                            break;
                        }     
                    }
                    if (radiobutton2.Checked==true)
                    {
                        if (kayitokuma["kullaniciadi"].ToString() == textBox1.Text && kayitokuma["parola"].ToString() == textBox2.Text && kayitokuma["yetki"].ToString() == "Kullanıcı")
                        {
                            durum = true;
                            id = kayitokuma.GetValue(0).ToString();
                            adi = kayitokuma.GetValue(1).ToString();
                            soyadi = kayitokuma.GetValue(2).ToString();
                            yetki = kayitokuma.GetValue(3).ToString();
                            this.Hide();
                            Form4 form4 = new Form4();
                            form4.Show();
                            break;
                        }
                    }
                }
                if (durum == false)
                    hak--;
                baglantim.Close();
            }
            label6.Text = Convert.ToString(hak);
            if (string.IsNullOrEmpty(textBox1.Text) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz.");
            }
            if (hak==0)
            {
                btnGiris.Enabled = false;
                MessageBox.Show("Giriş hakkınız kalmadı. Lütfen daha sonra tekrar deneyiniz.","Ileti Yönetim Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            string isim = textBox1.Text;
        }
       
        int hak = 3; bool durum = false;
        private void Form2_Load(object sender, EventArgs e)
        {  
            radiobutton1.Checked = true;
            this.AcceptButton = btnGiris;
            this.Text = "Giriş Yapınız";
        }
    }
}
