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
    public partial class Form5 : Form
    {
        public Form5()
        {

            InitializeComponent();
        }
        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source= personel.accdb");
        
        private void Form5_Load(object sender, EventArgs e)
        {
            kayit_load();
        }
        int secili_id = 0;
       
     
        void kayit_load()
        {
           
            /*OleDbDataAdapter da = new OleDbDataAdapter();
            baglantim = new OleDbConnection();
            da = new OleDbDataAdapter("select id,kullaniciadi AS [Kullanıcı Adı], markaadi AS [Marka Adı], mail_izin AS [Mail İzni], sms_izin AS [Sms İzni] from tablo_kayit", baglantim);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgOnaylıMesaj.DataSource = dt;

            dgOnaylıMesaj.Columns["id"].Visible = false;*/

            try
            {
              
                baglantim.Open(); 
                OleDbDataAdapter kayitlari_listele = new OleDbDataAdapter("select id AS [ID], kullaniciadi AS [Kullanıcı Adı], markaadi AS [Marka Adı], mail_izin AS [Mail İzin], sms_izin AS [Sms İzin] from tablo_kayit"  , baglantim);
                DataSet ds = new DataSet();
                kayitlari_listele.Fill(ds);
                dgOnaylıMesaj.DataSource = ds.Tables[0]; 
                baglantim.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "ILETİ YONETİM SİSTEMİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantim.Close();
            }
        }

        void guncelle()
        {
            try
            {
               
                OleDbCommand cmd = new OleDbCommand("update tablo_kayit set  markaadi = @markaadi, mail_izin = @mail_izin, sms_izin = @sms_izin where id = @id ", baglantim);
                baglantim.Open();
                cmd.Parameters.Add("@markaadi", OleDbType.VarChar).Value = txtmarka.Text;
                string sms_izin = "";
                if (rdbtnsmsevet.Checked)
                {
                    sms_izin = rdbtnsmsevet.Text;
                }
                else if (rdbtnsmshayir.Checked)
                {
                    sms_izin = rdbtnsmshayir.Text;
                }
                else
                {
                    return;
                }
                string mail_izin= "";
                if (rdbtnmailevet.Checked)
                {
                    mail_izin = rdbtnmailevet.Text;
                }
                else if (rdbtnmailhayir.Checked)
                {
                    mail_izin = rdbtnmailhayir.Text;
                }
                else
                {
                    return;
                }
                cmd.Parameters.Add("@sms_izin", OleDbType.VarChar).Value = sms_izin;
                cmd.Parameters.Add("@mail_izin", OleDbType.VarChar).Value = mail_izin;

                cmd.Parameters.Add("@id", OleDbType.Integer).Value = secili_id;
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                
            }
            finally
            {
                baglantim.Close();
            }
            kayit_load();
        }

        
        private void dgOnaylıMesaj_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                secili_id = Convert.ToInt32(dgOnaylıMesaj.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    
                    OleDbCommand cmd = new OleDbCommand("select * from tablo_kayit where id = @id", baglantim);
                    cmd.Parameters.Add("@id", OleDbType.Integer).Value = secili_id;

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    rdbtnsmsevet.Checked = false;
                    rdbtnsmshayir.Checked = false;
                    rdbtnmailevet.Checked = false;
                    rdbtnmailhayir.Checked = false;

                    foreach (DataRow row in dt.Rows)
                    {
                        txtmarka.Text = row["markaadi"].ToString();
                        
                        string sms_izni = row["sms_izin"].ToString();
                        if (sms_izni == "Evet")
                        {
                            rdbtnsmsevet.Checked = true;
                        }
                        else if (sms_izni == "Hayır")
                        {
                            rdbtnsmshayir.Checked = true;
                        }
                        string mail_izni = row["mail_izin"].ToString();
                        if (mail_izni == "Evet")
                        {
                            rdbtnmailevet.Checked = true;
                        }
                        else if (mail_izni == "Hayır")
                        {
                            rdbtnmailhayir.Checked = true;
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    throw ex;
                }
            }
        }

        private void btnizinguncelle_Click(object sender, EventArgs e)
        {
            if (secili_id > 0)
            {
                guncelle();
            }
            else
            {
                MessageBox.Show("Öğrenci seçiniz.");
            }
        }

        private void btnKayitSil_Click(object sender, EventArgs e)
        {
         
        }

        private void dgOnaylıMesaj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            baglantim.Open();
            string kayit = "SELECT id AS [ID], kullaniciadi AS [Kullanıcı Adı], markaadi AS [Marka Adı], mail_izin AS [Mail İzin], sms_izin AS [Sms İzin] from tablo_kayit where markaadi = @markaadi";
            OleDbCommand komut = new OleDbCommand(kayit, baglantim);
            komut.Parameters.AddWithValue("@markaadi", txtmarka.Text);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgOnaylıMesaj.DataSource = dt;
            baglantim.Close();
        }
    }
}
       
