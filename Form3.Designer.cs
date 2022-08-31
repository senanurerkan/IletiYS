
namespace IletiYS
{
    partial class Form3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTemizleMarka = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnMailEvet = new System.Windows.Forms.RadioButton();
            this.rdbtnMailHayır = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnSmsEvet = new System.Windows.Forms.RadioButton();
            this.rdbtnSmsHayır = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.txtHizmetSaglayici = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgHizmetSaglayici = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFormTemizle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtParolaTekrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.radioButtonYönetici = new System.Windows.Forms.RadioButton();
            this.radiobutonkullanici = new System.Windows.Forms.RadioButton();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtKulanıcıAdı = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgKullanicilar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHizmetSaglayici)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 900);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTemizleMarka);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Controls.Add(this.btn4);
            this.tabPage1.Controls.Add(this.btn3);
            this.tabPage1.Controls.Add(this.btn2);
            this.tabPage1.Controls.Add(this.txtHizmetSaglayici);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgHizmetSaglayici);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1162, 871);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hizmet Sağlıyıcılar";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnTemizleMarka
            // 
            this.btnTemizleMarka.Location = new System.Drawing.Point(350, 258);
            this.btnTemizleMarka.Name = "btnTemizleMarka";
            this.btnTemizleMarka.Size = new System.Drawing.Size(100, 25);
            this.btnTemizleMarka.TabIndex = 33;
            this.btnTemizleMarka.Text = "Temizle";
            this.btnTemizleMarka.UseVisualStyleBackColor = true;
            this.btnTemizleMarka.Click += new System.EventHandler(this.btnTemizleMarka_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnMailEvet);
            this.groupBox2.Controls.Add(this.rdbtnMailHayır);
            this.groupBox2.Location = new System.Drawing.Point(10, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 69);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail İzni:";
            // 
            // rdbtnMailEvet
            // 
            this.rdbtnMailEvet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtnMailEvet.AutoSize = true;
            this.rdbtnMailEvet.Location = new System.Drawing.Point(6, 25);
            this.rdbtnMailEvet.Name = "rdbtnMailEvet";
            this.rdbtnMailEvet.Size = new System.Drawing.Size(57, 21);
            this.rdbtnMailEvet.TabIndex = 28;
            this.rdbtnMailEvet.TabStop = true;
            this.rdbtnMailEvet.Text = "Evet";
            this.rdbtnMailEvet.UseVisualStyleBackColor = true;
            // 
            // rdbtnMailHayır
            // 
            this.rdbtnMailHayır.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtnMailHayır.AutoSize = true;
            this.rdbtnMailHayır.Location = new System.Drawing.Point(171, 25);
            this.rdbtnMailHayır.Name = "rdbtnMailHayır";
            this.rdbtnMailHayır.Size = new System.Drawing.Size(62, 21);
            this.rdbtnMailHayır.TabIndex = 29;
            this.rdbtnMailHayır.TabStop = true;
            this.rdbtnMailHayır.Text = "Hayır";
            this.rdbtnMailHayır.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnSmsEvet);
            this.groupBox1.Controls.Add(this.rdbtnSmsHayır);
            this.groupBox1.Location = new System.Drawing.Point(9, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 69);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sms İzni:";
            // 
            // rdbtnSmsEvet
            // 
            this.rdbtnSmsEvet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtnSmsEvet.AutoSize = true;
            this.rdbtnSmsEvet.Location = new System.Drawing.Point(6, 18);
            this.rdbtnSmsEvet.Name = "rdbtnSmsEvet";
            this.rdbtnSmsEvet.Size = new System.Drawing.Size(57, 21);
            this.rdbtnSmsEvet.TabIndex = 26;
            this.rdbtnSmsEvet.TabStop = true;
            this.rdbtnSmsEvet.Text = "Evet";
            this.rdbtnSmsEvet.UseVisualStyleBackColor = true;
            // 
            // rdbtnSmsHayır
            // 
            this.rdbtnSmsHayır.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtnSmsHayır.AutoSize = true;
            this.rdbtnSmsHayır.Location = new System.Drawing.Point(172, 18);
            this.rdbtnSmsHayır.Name = "rdbtnSmsHayır";
            this.rdbtnSmsHayır.Size = new System.Drawing.Size(62, 21);
            this.rdbtnSmsHayır.TabIndex = 27;
            this.rdbtnSmsHayır.TabStop = true;
            this.rdbtnSmsHayır.Text = "Hayır";
            this.rdbtnSmsHayır.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(408, 34);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 30);
            this.btn1.TabIndex = 23;
            this.btn1.Text = "ARA";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(236, 258);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 25);
            this.btn4.TabIndex = 21;
            this.btn4.Text = "SİL";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(120, 258);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 25);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "GÜNCELLE";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(9, 258);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 25);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "KAYDET";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txtHizmetSaglayici
            // 
            this.txtHizmetSaglayici.Location = new System.Drawing.Point(164, 37);
            this.txtHizmetSaglayici.Name = "txtHizmetSaglayici";
            this.txtHizmetSaglayici.Size = new System.Drawing.Size(150, 22);
            this.txtHizmetSaglayici.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hizmet Sağlayıcı:";
            // 
            // dgHizmetSaglayici
            // 
            this.dgHizmetSaglayici.AllowUserToAddRows = false;
            this.dgHizmetSaglayici.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgHizmetSaglayici.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgHizmetSaglayici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHizmetSaglayici.Location = new System.Drawing.Point(6, 328);
            this.dgHizmetSaglayici.MultiSelect = false;
            this.dgHizmetSaglayici.Name = "dgHizmetSaglayici";
            this.dgHizmetSaglayici.ReadOnly = true;
            this.dgHizmetSaglayici.RowHeadersWidth = 51;
            this.dgHizmetSaglayici.RowTemplate.Height = 24;
            this.dgHizmetSaglayici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHizmetSaglayici.Size = new System.Drawing.Size(971, 537);
            this.dgHizmetSaglayici.TabIndex = 0;
            this.dgHizmetSaglayici.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHizmetSaglayici_CellClick);
            this.dgHizmetSaglayici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgHizmetSaglayici_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFormTemizle);
            this.tabPage2.Controls.Add(this.btnSil);
            this.tabPage2.Controls.Add(this.btnGuncelle);
            this.tabPage2.Controls.Add(this.btnKaydet);
            this.tabPage2.Controls.Add(this.txtParolaTekrar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnAra);
            this.tabPage2.Controls.Add(this.radioButtonYönetici);
            this.tabPage2.Controls.Add(this.radiobutonkullanici);
            this.tabPage2.Controls.Add(this.txtParola);
            this.tabPage2.Controls.Add(this.txtKulanıcıAdı);
            this.tabPage2.Controls.Add(this.txtSoyad);
            this.tabPage2.Controls.Add(this.txtAd);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dgKullanicilar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 871);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kullanıcılar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnFormTemizle
            // 
            this.btnFormTemizle.Location = new System.Drawing.Point(393, 360);
            this.btnFormTemizle.Name = "btnFormTemizle";
            this.btnFormTemizle.Size = new System.Drawing.Size(110, 25);
            this.btnFormTemizle.TabIndex = 18;
            this.btnFormTemizle.Text = "Formu Temizle";
            this.btnFormTemizle.UseVisualStyleBackColor = true;
            this.btnFormTemizle.Click += new System.EventHandler(this.btnFormTemizle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(270, 360);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 25);
            this.btnSil.TabIndex = 17;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(147, 360);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(90, 25);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(24, 360);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 25);
            this.btnKaydet.TabIndex = 15;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtParolaTekrar
            // 
            this.txtParolaTekrar.Location = new System.Drawing.Point(177, 281);
            this.txtParolaTekrar.Name = "txtParolaTekrar";
            this.txtParolaTekrar.Size = new System.Drawing.Size(180, 22);
            this.txtParolaTekrar.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "PAROLA TEKRAR:";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(461, 52);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(90, 25);
            this.btnAra.TabIndex = 12;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // radioButtonYönetici
            // 
            this.radioButtonYönetici.AutoSize = true;
            this.radioButtonYönetici.Location = new System.Drawing.Point(304, 128);
            this.radioButtonYönetici.Name = "radioButtonYönetici";
            this.radioButtonYönetici.Size = new System.Drawing.Size(79, 21);
            this.radioButtonYönetici.TabIndex = 11;
            this.radioButtonYönetici.TabStop = true;
            this.radioButtonYönetici.Text = "Yönetici";
            this.radioButtonYönetici.UseVisualStyleBackColor = true;
            // 
            // radiobutonkullanici
            // 
            this.radiobutonkullanici.AutoSize = true;
            this.radiobutonkullanici.Location = new System.Drawing.Point(177, 128);
            this.radiobutonkullanici.Name = "radiobutonkullanici";
            this.radiobutonkullanici.Size = new System.Drawing.Size(81, 21);
            this.radiobutonkullanici.TabIndex = 10;
            this.radiobutonkullanici.TabStop = true;
            this.radiobutonkullanici.Text = "Kullanıcı";
            this.radiobutonkullanici.UseVisualStyleBackColor = true;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(177, 229);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(180, 22);
            this.txtParola.TabIndex = 9;
            this.txtParola.TextChanged += new System.EventHandler(this.txtParola_TextChanged);
            // 
            // txtKulanıcıAdı
            // 
            this.txtKulanıcıAdı.Location = new System.Drawing.Point(177, 177);
            this.txtKulanıcıAdı.Name = "txtKulanıcıAdı";
            this.txtKulanıcıAdı.Size = new System.Drawing.Size(180, 22);
            this.txtKulanıcıAdı.TabIndex = 8;
            this.txtKulanıcıAdı.TextChanged += new System.EventHandler(this.txtKulanıcıAdı_TextChanged);
            this.txtKulanıcıAdı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKulanıcıAdı_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(177, 79);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(180, 22);
            this.txtSoyad.TabIndex = 7;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(177, 31);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(180, 22);
            this.txtAd.TabIndex = 6;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "PAROLA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "KULLANICI ADI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "YETKİ:";
            // 
            // dgKullanicilar
            // 
            this.dgKullanicilar.AllowUserToAddRows = false;
            this.dgKullanicilar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgKullanicilar.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKullanicilar.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgKullanicilar.Location = new System.Drawing.Point(6, 436);
            this.dgKullanicilar.MultiSelect = false;
            this.dgKullanicilar.Name = "dgKullanicilar";
            this.dgKullanicilar.ReadOnly = true;
            this.dgKullanicilar.RowHeadersWidth = 51;
            this.dgKullanicilar.RowTemplate.Height = 24;
            this.dgKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgKullanicilar.Size = new System.Drawing.Size(1150, 429);
            this.dgKullanicilar.TabIndex = 0;
            this.dgKullanicilar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKullanicilar_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "AD:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 933);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHizmetSaglayici)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgHizmetSaglayici;
        private System.Windows.Forms.TextBox txtHizmetSaglayici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgKullanicilar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParolaTekrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RadioButton radioButtonYönetici;
        private System.Windows.Forms.RadioButton radiobutonkullanici;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtKulanıcıAdı;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFormTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.RadioButton rdbtnSmsHayır;
        private System.Windows.Forms.RadioButton rdbtnSmsEvet;
        private System.Windows.Forms.RadioButton rdbtnMailHayır;
        private System.Windows.Forms.RadioButton rdbtnMailEvet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTemizleMarka;
    }
}