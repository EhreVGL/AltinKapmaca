namespace AltinKapmaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.hamle_max_har_mik_listbox = new System.Windows.Forms.ListBox();
            this.bas_altin_mik_listbox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gizlialtin_oran_listbox = new System.Windows.Forms.ListBox();
            this.altin_oran_listbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sutun_sayisi_txtbox = new System.Windows.Forms.TextBox();
            this.satir_sayisi_txtbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cikis = new System.Windows.Forms.Button();
            this.ayar = new System.Windows.Forms.Button();
            this.basla = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ayar_kaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.oyuncu1_hamle_listbox = new System.Windows.Forms.ListBox();
            this.oyuncu1_hedef_listbox = new System.Windows.Forms.ListBox();
            this.oyuncu2_hedef_listbox = new System.Windows.Forms.ListBox();
            this.oyuncu3_hedef_listbox = new System.Windows.Forms.ListBox();
            this.oyuncu4_hedef_listbox = new System.Windows.Forms.ListBox();
            this.oyuncu2_hamle_listbox = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.oyuncu3_hamle_listbox = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.oyuncu4_hamle_listbox = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cikis);
            this.panel1.Controls.Add(this.ayar);
            this.panel1.Controls.Add(this.basla);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(873, 475);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.oyuncu4_hamle_listbox);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.oyuncu3_hamle_listbox);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.oyuncu2_hamle_listbox);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.oyuncu4_hedef_listbox);
            this.panel2.Controls.Add(this.oyuncu3_hedef_listbox);
            this.panel2.Controls.Add(this.oyuncu2_hedef_listbox);
            this.panel2.Controls.Add(this.oyuncu1_hedef_listbox);
            this.panel2.Controls.Add(this.oyuncu1_hamle_listbox);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.hamle_max_har_mik_listbox);
            this.panel2.Controls.Add(this.bas_altin_mik_listbox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.gizlialtin_oran_listbox);
            this.panel2.Controls.Add(this.altin_oran_listbox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.sutun_sayisi_txtbox);
            this.panel2.Controls.Add(this.satir_sayisi_txtbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ayar_kaydet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(873, 475);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(47, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(218, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hamle Max Hareket Miktarı:";
            // 
            // hamle_max_har_mik_listbox
            // 
            this.hamle_max_har_mik_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hamle_max_har_mik_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hamle_max_har_mik_listbox.FormattingEnabled = true;
            this.hamle_max_har_mik_listbox.ItemHeight = 20;
            this.hamle_max_har_mik_listbox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.hamle_max_har_mik_listbox.Location = new System.Drawing.Point(283, 355);
            this.hamle_max_har_mik_listbox.Name = "hamle_max_har_mik_listbox";
            this.hamle_max_har_mik_listbox.Size = new System.Drawing.Size(120, 24);
            this.hamle_max_har_mik_listbox.TabIndex = 17;
            // 
            // bas_altin_mik_listbox
            // 
            this.bas_altin_mik_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bas_altin_mik_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bas_altin_mik_listbox.FormattingEnabled = true;
            this.bas_altin_mik_listbox.ItemHeight = 20;
            this.bas_altin_mik_listbox.Items.AddRange(new object[] {
            "100",
            "200",
            "300"});
            this.bas_altin_mik_listbox.Location = new System.Drawing.Point(283, 323);
            this.bas_altin_mik_listbox.Name = "bas_altin_mik_listbox";
            this.bas_altin_mik_listbox.Size = new System.Drawing.Size(120, 24);
            this.bas_altin_mik_listbox.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Goldenrod;
            this.label9.Location = new System.Drawing.Point(47, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 19);
            this.label9.TabIndex = 14;
            this.label9.Text = "Başlangıç Altın Miktarı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Goldenrod;
            this.label7.Location = new System.Drawing.Point(44, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 37);
            this.label7.TabIndex = 13;
            this.label7.Text = "Miktar";
            // 
            // gizlialtin_oran_listbox
            // 
            this.gizlialtin_oran_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gizlialtin_oran_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gizlialtin_oran_listbox.FormattingEnabled = true;
            this.gizlialtin_oran_listbox.ItemHeight = 20;
            this.gizlialtin_oran_listbox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.gizlialtin_oran_listbox.Location = new System.Drawing.Point(283, 231);
            this.gizlialtin_oran_listbox.Name = "gizlialtin_oran_listbox";
            this.gizlialtin_oran_listbox.Size = new System.Drawing.Size(120, 24);
            this.gizlialtin_oran_listbox.TabIndex = 12;
            // 
            // altin_oran_listbox
            // 
            this.altin_oran_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.altin_oran_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altin_oran_listbox.FormattingEnabled = true;
            this.altin_oran_listbox.ItemHeight = 20;
            this.altin_oran_listbox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.altin_oran_listbox.Location = new System.Drawing.Point(283, 199);
            this.altin_oran_listbox.Name = "altin_oran_listbox";
            this.altin_oran_listbox.Size = new System.Drawing.Size(120, 24);
            this.altin_oran_listbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(47, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gizli Altın Oranı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Goldenrod;
            this.label6.Location = new System.Drawing.Point(47, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Altın Oranı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(44, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Altın Sayısı";
            // 
            // sutun_sayisi_txtbox
            // 
            this.sutun_sayisi_txtbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sutun_sayisi_txtbox.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sutun_sayisi_txtbox.Location = new System.Drawing.Point(283, 105);
            this.sutun_sayisi_txtbox.Name = "sutun_sayisi_txtbox";
            this.sutun_sayisi_txtbox.Size = new System.Drawing.Size(100, 26);
            this.sutun_sayisi_txtbox.TabIndex = 7;
            this.sutun_sayisi_txtbox.Text = "20";
            this.sutun_sayisi_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // satir_sayisi_txtbox
            // 
            this.satir_sayisi_txtbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.satir_sayisi_txtbox.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satir_sayisi_txtbox.Location = new System.Drawing.Point(283, 73);
            this.satir_sayisi_txtbox.Name = "satir_sayisi_txtbox";
            this.satir_sayisi_txtbox.Size = new System.Drawing.Size(100, 26);
            this.satir_sayisi_txtbox.TabIndex = 6;
            this.satir_sayisi_txtbox.Text = "20";
            this.satir_sayisi_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(44, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sütun Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Satır Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(44, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oyun Masası";
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.PaleVioletRed;
            this.cikis.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cikis.Location = new System.Drawing.Point(678, 317);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(183, 49);
            this.cikis.TabIndex = 2;
            this.cikis.Text = "ÇIKIŞ";
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // ayar
            // 
            this.ayar.BackColor = System.Drawing.Color.BurlyWood;
            this.ayar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ayar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ayar.Location = new System.Drawing.Point(678, 242);
            this.ayar.Name = "ayar";
            this.ayar.Size = new System.Drawing.Size(183, 49);
            this.ayar.TabIndex = 1;
            this.ayar.Text = "AYARLAR";
            this.ayar.UseVisualStyleBackColor = false;
            this.ayar.Click += new System.EventHandler(this.ayar_Click);
            // 
            // basla
            // 
            this.basla.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.basla.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basla.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.basla.Location = new System.Drawing.Point(678, 169);
            this.basla.Name = "basla";
            this.basla.Size = new System.Drawing.Size(183, 49);
            this.basla.TabIndex = 0;
            this.basla.Text = "BAŞLA";
            this.basla.UseVisualStyleBackColor = false;
            this.basla.Click += new System.EventHandler(this.basla_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(873, 475);
            this.panel3.TabIndex = 8;
            this.panel3.Visible = false;
            // 
            // ayar_kaydet
            // 
            this.ayar_kaydet.BackColor = System.Drawing.Color.BurlyWood;
            this.ayar_kaydet.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ayar_kaydet.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ayar_kaydet.Location = new System.Drawing.Point(593, 372);
            this.ayar_kaydet.Name = "ayar_kaydet";
            this.ayar_kaydet.Size = new System.Drawing.Size(183, 49);
            this.ayar_kaydet.TabIndex = 2;
            this.ayar_kaydet.Text = "KAYDET";
            this.ayar_kaydet.UseVisualStyleBackColor = false;
            this.ayar_kaydet.Click += new System.EventHandler(this.ayar_kaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(873, 475);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Goldenrod;
            this.label10.Location = new System.Drawing.Point(503, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 37);
            this.label10.TabIndex = 18;
            this.label10.Text = "Maliyet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Goldenrod;
            this.label11.Location = new System.Drawing.Point(506, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(200, 19);
            this.label11.TabIndex = 19;
            this.label11.Text = "Oyuncu-1 Hamle Maliyeti:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Goldenrod;
            this.label12.Location = new System.Drawing.Point(506, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Oyuncu-1 Hedef Maliyeti:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Goldenrod;
            this.label13.Location = new System.Drawing.Point(506, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 19);
            this.label13.TabIndex = 21;
            this.label13.Text = "Oyuncu-2 Hedef Maliyeti:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Goldenrod;
            this.label14.Location = new System.Drawing.Point(506, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "Oyuncu-3 Hedef Maliyeti:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Goldenrod;
            this.label15.Location = new System.Drawing.Point(506, 304);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 19);
            this.label15.TabIndex = 23;
            this.label15.Text = "Oyuncu-4 Hedef Maliyeti:";
            // 
            // oyuncu1_hamle_listbox
            // 
            this.oyuncu1_hamle_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oyuncu1_hamle_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncu1_hamle_listbox.FormattingEnabled = true;
            this.oyuncu1_hamle_listbox.ItemHeight = 20;
            this.oyuncu1_hamle_listbox.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.oyuncu1_hamle_listbox.Location = new System.Drawing.Point(711, 71);
            this.oyuncu1_hamle_listbox.Name = "oyuncu1_hamle_listbox";
            this.oyuncu1_hamle_listbox.Size = new System.Drawing.Size(120, 24);
            this.oyuncu1_hamle_listbox.TabIndex = 24;
            // 
            // oyuncu1_hedef_listbox
            // 
            this.oyuncu1_hedef_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oyuncu1_hedef_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncu1_hedef_listbox.FormattingEnabled = true;
            this.oyuncu1_hedef_listbox.ItemHeight = 20;
            this.oyuncu1_hedef_listbox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.oyuncu1_hedef_listbox.Location = new System.Drawing.Point(711, 212);
            this.oyuncu1_hedef_listbox.Name = "oyuncu1_hedef_listbox";
            this.oyuncu1_hedef_listbox.Size = new System.Drawing.Size(120, 24);
            this.oyuncu1_hedef_listbox.TabIndex = 25;
            // 
            // oyuncu2_hedef_listbox
            // 
            this.oyuncu2_hedef_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oyuncu2_hedef_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncu2_hedef_listbox.FormattingEnabled = true;
            this.oyuncu2_hedef_listbox.ItemHeight = 20;
            this.oyuncu2_hedef_listbox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.oyuncu2_hedef_listbox.Location = new System.Drawing.Point(711, 243);
            this.oyuncu2_hedef_listbox.Name = "oyuncu2_hedef_listbox";
            this.oyuncu2_hedef_listbox.Size = new System.Drawing.Size(120, 24);
            this.oyuncu2_hedef_listbox.TabIndex = 26;
            // 
            // oyuncu3_hedef_listbox
            // 
            this.oyuncu3_hedef_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oyuncu3_hedef_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncu3_hedef_listbox.FormattingEnabled = true;
            this.oyuncu3_hedef_listbox.ItemHeight = 20;
            this.oyuncu3_hedef_listbox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.oyuncu3_hedef_listbox.Location = new System.Drawing.Point(711, 273);
            this.oyuncu3_hedef_listbox.Name = "oyuncu3_hedef_listbox";
            this.oyuncu3_hedef_listbox.Size = new System.Drawing.Size(120, 24);
            this.oyuncu3_hedef_listbox.TabIndex = 27;
            // 
            // oyuncu4_hedef_listbox
            // 
            this.oyuncu4_hedef_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oyuncu4_hedef_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncu4_hedef_listbox.FormattingEnabled = true;
            this.oyuncu4_hedef_listbox.ItemHeight = 20;
            this.oyuncu4_hedef_listbox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.oyuncu4_hedef_listbox.Location = new System.Drawing.Point(711, 303);
            this.oyuncu4_hedef_listbox.Name = "oyuncu4_hedef_listbox";
            this.oyuncu4_hedef_listbox.Size = new System.Drawing.Size(120, 24);
            this.oyuncu4_hedef_listbox.TabIndex = 28;
            // 
            // oyuncu2_hamle_listbox
            // 
            this.oyuncu2_hamle_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oyuncu2_hamle_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncu2_hamle_listbox.FormattingEnabled = true;
            this.oyuncu2_hamle_listbox.ItemHeight = 20;
            this.oyuncu2_hamle_listbox.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.oyuncu2_hamle_listbox.Location = new System.Drawing.Point(711, 102);
            this.oyuncu2_hamle_listbox.Name = "oyuncu2_hamle_listbox";
            this.oyuncu2_hamle_listbox.Size = new System.Drawing.Size(120, 24);
            this.oyuncu2_hamle_listbox.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Goldenrod;
            this.label16.Location = new System.Drawing.Point(506, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(200, 19);
            this.label16.TabIndex = 29;
            this.label16.Text = "Oyuncu-2 Hamle Maliyeti:";
            // 
            // oyuncu3_hamle_listbox
            // 
            this.oyuncu3_hamle_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oyuncu3_hamle_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncu3_hamle_listbox.FormattingEnabled = true;
            this.oyuncu3_hamle_listbox.ItemHeight = 20;
            this.oyuncu3_hamle_listbox.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.oyuncu3_hamle_listbox.Location = new System.Drawing.Point(711, 132);
            this.oyuncu3_hamle_listbox.Name = "oyuncu3_hamle_listbox";
            this.oyuncu3_hamle_listbox.Size = new System.Drawing.Size(120, 24);
            this.oyuncu3_hamle_listbox.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Goldenrod;
            this.label17.Location = new System.Drawing.Point(506, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 19);
            this.label17.TabIndex = 31;
            this.label17.Text = "Oyuncu-3 Hamle Maliyeti:";
            // 
            // oyuncu4_hamle_listbox
            // 
            this.oyuncu4_hamle_listbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.oyuncu4_hamle_listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuncu4_hamle_listbox.FormattingEnabled = true;
            this.oyuncu4_hamle_listbox.ItemHeight = 20;
            this.oyuncu4_hamle_listbox.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.oyuncu4_hamle_listbox.Location = new System.Drawing.Point(711, 162);
            this.oyuncu4_hamle_listbox.Name = "oyuncu4_hamle_listbox";
            this.oyuncu4_hamle_listbox.Size = new System.Drawing.Size(120, 24);
            this.oyuncu4_hamle_listbox.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Goldenrod;
            this.label18.Location = new System.Drawing.Point(506, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(200, 19);
            this.label18.TabIndex = 33;
            this.label18.Text = "Oyuncu-4 Hamle Maliyeti:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 475);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button ayar;
        private System.Windows.Forms.Button basla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ayar_kaydet;
        private System.Windows.Forms.TextBox sutun_sayisi_txtbox;
        private System.Windows.Forms.TextBox satir_sayisi_txtbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox altin_oran_listbox;
        private System.Windows.Forms.ListBox gizlialtin_oran_listbox;
        private System.Windows.Forms.ListBox hamle_max_har_mik_listbox;
        private System.Windows.Forms.ListBox bas_altin_mik_listbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox oyuncu4_hamle_listbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox oyuncu3_hamle_listbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox oyuncu2_hamle_listbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox oyuncu4_hedef_listbox;
        private System.Windows.Forms.ListBox oyuncu3_hedef_listbox;
        private System.Windows.Forms.ListBox oyuncu2_hedef_listbox;
        private System.Windows.Forms.ListBox oyuncu1_hedef_listbox;
        private System.Windows.Forms.ListBox oyuncu1_hamle_listbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}

