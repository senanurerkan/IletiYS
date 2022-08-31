
namespace IletiYS
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOturumAc = new System.Windows.Forms.Button();
            this.bttnKaydol = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.radioBttnKullanici = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(252, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 95);
            this.label2.TabIndex = 18;
            this.label2.Text = "İLETİ YÖNETİM SİSTEMİNE \r\nHOŞ GELDİNİZ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(88, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(403, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Zaten hesabın var mı? O zaman oturum aç...";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOturumAc
            // 
            this.btnOturumAc.Location = new System.Drawing.Point(363, 511);
            this.btnOturumAc.Name = "btnOturumAc";
            this.btnOturumAc.Size = new System.Drawing.Size(128, 30);
            this.btnOturumAc.TabIndex = 16;
            this.btnOturumAc.Text = "OTURUM AÇ";
            this.btnOturumAc.UseVisualStyleBackColor = true;
            this.btnOturumAc.Click += new System.EventHandler(this.btnOturumAç_Click);
            // 
            // bttnKaydol
            // 
            this.bttnKaydol.Location = new System.Drawing.Point(391, 405);
            this.bttnKaydol.Name = "bttnKaydol";
            this.bttnKaydol.Size = new System.Drawing.Size(100, 30);
            this.bttnKaydol.TabIndex = 15;
            this.bttnKaydol.Text = "KAYDOL";
            this.bttnKaydol.UseVisualStyleBackColor = true;
            this.bttnKaydol.Click += new System.EventHandler(this.bttnKaydol_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.txtKullaniciAdi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.radioBttnKullanici, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtSifreTekrar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSoyad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSifre, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(75, 174);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 200);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(160, 104);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(254, 22);
            this.txtKullaniciAdi.TabIndex = 20;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // radioBttnKullanici
            // 
            this.radioBttnKullanici.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioBttnKullanici.AutoSize = true;
            this.radioBttnKullanici.Location = new System.Drawing.Point(160, 72);
            this.radioBttnKullanici.Name = "radioBttnKullanici";
            this.radioBttnKullanici.Size = new System.Drawing.Size(81, 21);
            this.radioBttnKullanici.TabIndex = 21;
            this.radioBttnKullanici.TabStop = true;
            this.radioBttnKullanici.Text = "Kullanıcı";
            this.radioBttnKullanici.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Kullanıcı Adı:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Şifre Tekrar:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAd.Location = new System.Drawing.Point(160, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(254, 22);
            this.txtAd.TabIndex = 5;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSifreTekrar.Location = new System.Drawing.Point(160, 171);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.PasswordChar = '*';
            this.txtSifreTekrar.Size = new System.Drawing.Size(254, 22);
            this.txtSifreTekrar.TabIndex = 9;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSoyad.Location = new System.Drawing.Point(160, 38);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(254, 22);
            this.txtSoyad.TabIndex = 6;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Yetki:";
            // 
            // txtSifre
            // 
            this.txtSifre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSifre.Location = new System.Drawing.Point(160, 137);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(254, 22);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, -42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOturumAc);
            this.Controls.Add(this.bttnKaydol);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOturumAc;
        private System.Windows.Forms.Button bttnKaydol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.RadioButton radioBttnKullanici;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

