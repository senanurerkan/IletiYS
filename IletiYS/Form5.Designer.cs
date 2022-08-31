
namespace IletiYS
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnmesajreddet = new System.Windows.Forms.Button();
            this.dgOnaylıMesaj = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnizinguncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnmailevet = new System.Windows.Forms.RadioButton();
            this.rdbtnmailhayir = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnsmsevet = new System.Windows.Forms.RadioButton();
            this.rdbtnsmshayir = new System.Windows.Forms.RadioButton();
            this.txtmarka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOnaylıMesaj)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(392, 26);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(95, 30);
            this.btnAra.TabIndex = 14;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(173, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Aşağıda daha önce ticari elektronik ileti izni verdiğiniz marka ve hizmet sağlayı" +
    "cılara ulaşabilirsiniz.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 71);
            this.label1.TabIndex = 12;
            this.label1.Text = "İZİNLERİM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnmesajreddet
            // 
            this.bttnmesajreddet.Location = new System.Drawing.Point(301, 549);
            this.bttnmesajreddet.Name = "bttnmesajreddet";
            this.bttnmesajreddet.Size = new System.Drawing.Size(100, 30);
            this.bttnmesajreddet.TabIndex = 10;
            this.bttnmesajreddet.Text = "REDDET";
            this.bttnmesajreddet.UseVisualStyleBackColor = true;
            // 
            // dgOnaylıMesaj
            // 
            this.dgOnaylıMesaj.AllowUserToAddRows = false;
            this.dgOnaylıMesaj.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgOnaylıMesaj.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgOnaylıMesaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOnaylıMesaj.Location = new System.Drawing.Point(6, 307);
            this.dgOnaylıMesaj.MultiSelect = false;
            this.dgOnaylıMesaj.Name = "dgOnaylıMesaj";
            this.dgOnaylıMesaj.ReadOnly = true;
            this.dgOnaylıMesaj.RowHeadersWidth = 51;
            this.dgOnaylıMesaj.RowTemplate.Height = 24;
            this.dgOnaylıMesaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOnaylıMesaj.Size = new System.Drawing.Size(1111, 441);
            this.dgOnaylıMesaj.TabIndex = 8;
            this.dgOnaylıMesaj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOnaylıMesaj_CellClick);
            this.dgOnaylıMesaj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOnaylıMesaj_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 158);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1131, 783);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnizinguncelle);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtmarka);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgOnaylıMesaj);
            this.tabPage1.Controls.Add(this.btnAra);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1123, 754);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İzinler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnizinguncelle
            // 
            this.btnizinguncelle.Location = new System.Drawing.Point(50, 240);
            this.btnizinguncelle.Name = "btnizinguncelle";
            this.btnizinguncelle.Size = new System.Drawing.Size(95, 30);
            this.btnizinguncelle.TabIndex = 35;
            this.btnizinguncelle.Text = "GÜNCELLE";
            this.btnizinguncelle.UseVisualStyleBackColor = true;
            this.btnizinguncelle.Click += new System.EventHandler(this.btnizinguncelle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnmailevet);
            this.groupBox2.Controls.Add(this.rdbtnmailhayir);
            this.groupBox2.Location = new System.Drawing.Point(20, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 69);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail İzni:";
            // 
            // rdbtnmailevet
            // 
            this.rdbtnmailevet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtnmailevet.AutoSize = true;
            this.rdbtnmailevet.Location = new System.Drawing.Point(6, 25);
            this.rdbtnmailevet.Name = "rdbtnmailevet";
            this.rdbtnmailevet.Size = new System.Drawing.Size(57, 21);
            this.rdbtnmailevet.TabIndex = 28;
            this.rdbtnmailevet.TabStop = true;
            this.rdbtnmailevet.Text = "Evet";
            this.rdbtnmailevet.UseVisualStyleBackColor = true;
            // 
            // rdbtnmailhayir
            // 
            this.rdbtnmailhayir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtnmailhayir.AutoSize = true;
            this.rdbtnmailhayir.Location = new System.Drawing.Point(171, 25);
            this.rdbtnmailhayir.Name = "rdbtnmailhayir";
            this.rdbtnmailhayir.Size = new System.Drawing.Size(62, 21);
            this.rdbtnmailhayir.TabIndex = 29;
            this.rdbtnmailhayir.TabStop = true;
            this.rdbtnmailhayir.Text = "Hayır";
            this.rdbtnmailhayir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnsmsevet);
            this.groupBox1.Controls.Add(this.rdbtnsmshayir);
            this.groupBox1.Location = new System.Drawing.Point(19, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 69);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sms İzni:";
            // 
            // rdbtnsmsevet
            // 
            this.rdbtnsmsevet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtnsmsevet.AutoSize = true;
            this.rdbtnsmsevet.Location = new System.Drawing.Point(6, 18);
            this.rdbtnsmsevet.Name = "rdbtnsmsevet";
            this.rdbtnsmsevet.Size = new System.Drawing.Size(57, 21);
            this.rdbtnsmsevet.TabIndex = 26;
            this.rdbtnsmsevet.TabStop = true;
            this.rdbtnsmsevet.Text = "Evet";
            this.rdbtnsmsevet.UseVisualStyleBackColor = true;
            // 
            // rdbtnsmshayir
            // 
            this.rdbtnsmshayir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdbtnsmshayir.AutoSize = true;
            this.rdbtnsmshayir.Location = new System.Drawing.Point(172, 18);
            this.rdbtnsmshayir.Name = "rdbtnsmshayir";
            this.rdbtnsmshayir.Size = new System.Drawing.Size(62, 21);
            this.rdbtnsmshayir.TabIndex = 27;
            this.rdbtnsmshayir.TabStop = true;
            this.rdbtnsmshayir.Text = "Hayır";
            this.rdbtnsmshayir.UseVisualStyleBackColor = true;
            // 
            // txtmarka
            // 
            this.txtmarka.Location = new System.Drawing.Point(174, 26);
            this.txtmarka.Name = "txtmarka";
            this.txtmarka.Size = new System.Drawing.Size(150, 22);
            this.txtmarka.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hizmet Sağlayıcı:";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 953);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnmesajreddet);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOnaylıMesaj)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnmesajreddet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtmarka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtnmailevet;
        private System.Windows.Forms.RadioButton rdbtnmailhayir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnsmsevet;
        private System.Windows.Forms.RadioButton rdbtnsmshayir;
        private System.Windows.Forms.Button btnizinguncelle;
        private System.Windows.Forms.DataGridView dgOnaylıMesaj;
    }
}