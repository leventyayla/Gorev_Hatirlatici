namespace Görev_Hatırlatıcı
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.analog_title = new System.Windows.Forms.Label();
            this.dijital_timer = new System.Windows.Forms.Timer(this.components);
            this.dijital_title = new System.Windows.Forms.Label();
            this.analog_zaman = new System.Windows.Forms.Label();
            this.dijital_zaman = new System.Windows.Forms.Label();
            this.takvim = new System.Windows.Forms.MonthCalendar();
            this.konu = new System.Windows.Forms.RichTextBox();
            this.gorevler = new System.Windows.Forms.ListBox();
            this.tarih = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gorev_kontrol = new System.Windows.Forms.Timer(this.components);
            this.ses_sec = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // analog_title
            // 
            this.analog_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.analog_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.analog_title.Location = new System.Drawing.Point(12, 324);
            this.analog_title.Name = "analog_title";
            this.analog_title.Size = new System.Drawing.Size(260, 25);
            this.analog_title.TabIndex = 1;
            this.analog_title.Text = "Analog Zaman";
            // 
            // dijital_timer
            // 
            this.dijital_timer.Tick += new System.EventHandler(this.dijital_Tick);
            // 
            // dijital_title
            // 
            this.dijital_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dijital_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dijital_title.Location = new System.Drawing.Point(12, 349);
            this.dijital_title.Name = "dijital_title";
            this.dijital_title.Size = new System.Drawing.Size(260, 25);
            this.dijital_title.TabIndex = 2;
            this.dijital_title.Text = "Dijital Zaman";
            // 
            // analog_zaman
            // 
            this.analog_zaman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.analog_zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.analog_zaman.Location = new System.Drawing.Point(138, 324);
            this.analog_zaman.Name = "analog_zaman";
            this.analog_zaman.Size = new System.Drawing.Size(314, 25);
            this.analog_zaman.TabIndex = 1;
            this.analog_zaman.Text = ": Timer bekleniyor...";
            // 
            // dijital_zaman
            // 
            this.dijital_zaman.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dijital_zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dijital_zaman.Location = new System.Drawing.Point(138, 349);
            this.dijital_zaman.Name = "dijital_zaman";
            this.dijital_zaman.Size = new System.Drawing.Size(314, 25);
            this.dijital_zaman.TabIndex = 2;
            this.dijital_zaman.Text = ": Timer bekleniyor...";
            // 
            // takvim
            // 
            this.takvim.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.takvim.Location = new System.Drawing.Point(324, 12);
            this.takvim.MaxSelectionCount = 1;
            this.takvim.Name = "takvim";
            this.takvim.TabIndex = 3;
            this.takvim.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.takvim_DateSelected);
            // 
            // konu
            // 
            this.konu.Location = new System.Drawing.Point(324, 259);
            this.konu.Name = "konu";
            this.konu.Size = new System.Drawing.Size(262, 115);
            this.konu.TabIndex = 5;
            this.konu.Text = "";
            // 
            // gorevler
            // 
            this.gorevler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gorevler.FormattingEnabled = true;
            this.gorevler.ItemHeight = 16;
            this.gorevler.Location = new System.Drawing.Point(589, 12);
            this.gorevler.Name = "gorevler";
            this.gorevler.Size = new System.Drawing.Size(241, 356);
            this.gorevler.TabIndex = 6;
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(324, 231);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(259, 22);
            this.tarih.TabIndex = 7;
            this.tarih.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tarih_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(704, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Bilgileri Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gorev_kontrol
            // 
            this.gorev_kontrol.Interval = 1000;
            this.gorev_kontrol.Tick += new System.EventHandler(this.gorev_kontrol_Tick);
            // 
            // ses_sec
            // 
            this.ses_sec.Filter = "Wav Ses|*.wav";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(589, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Uyarı Sesi Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // path
            // 
            this.path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.path.AutoSize = true;
            this.path.Location = new System.Drawing.Point(12, 407);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(107, 17);
            this.path.TabIndex = 10;
            this.path.Text = "Ses dosyası adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(842, 433);
            this.Controls.Add(this.path);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.gorevler);
            this.Controls.Add(this.konu);
            this.Controls.Add(this.takvim);
            this.Controls.Add(this.dijital_zaman);
            this.Controls.Add(this.dijital_title);
            this.Controls.Add(this.analog_zaman);
            this.Controls.Add(this.analog_title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(860, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Hatırlatıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label analog_title;
        private System.Windows.Forms.Timer dijital_timer;
        private System.Windows.Forms.Label dijital_title;
        private System.Windows.Forms.Label analog_zaman;
        private System.Windows.Forms.Label dijital_zaman;
        private System.Windows.Forms.MonthCalendar takvim;
        private System.Windows.Forms.RichTextBox konu;
        private System.Windows.Forms.ListBox gorevler;
        private System.Windows.Forms.TextBox tarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer gorev_kontrol;
        private System.Windows.Forms.OpenFileDialog ses_sec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label path;
    }
}

