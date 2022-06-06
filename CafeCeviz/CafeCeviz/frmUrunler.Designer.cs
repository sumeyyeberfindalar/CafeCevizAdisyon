namespace CafeCeviz
{
    partial class frmUrunler
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "KAHVELER"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "ÇAYLAR"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "SOĞUK KAHVELER"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "4",
            "SÜTLÜ TATLILAR"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "5",
            "PASTALAR"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "6",
            "BAKLAVALAR"}, -1);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "8",
            "KAHVALTILAR"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "9",
            "DONDURMALAR"}, -1);
            this.lvMenu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnDondurmalar9 = new System.Windows.Forms.Button();
            this.btnKahvaltılar8 = new System.Windows.Forms.Button();
            this.btnBaklavalar6 = new System.Windows.Forms.Button();
            this.btnPastalar5 = new System.Windows.Forms.Button();
            this.btnSutluTatlilar4 = new System.Windows.Forms.Button();
            this.btnSogukKahveler3 = new System.Windows.Forms.Button();
            this.btnCaylar2 = new System.Windows.Forms.Button();
            this.btnKahveler1 = new System.Windows.Forms.Button();
            this.lblUrunEkleme = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtKategoriId = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMenu
            // 
            this.lvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMenu.GridLines = true;
            this.lvMenu.HideSelection = false;
            this.lvMenu.Location = new System.Drawing.Point(901, 337);
            this.lvMenu.Name = "lvMenu";
            this.lvMenu.Size = new System.Drawing.Size(704, 389);
            this.lvMenu.TabIndex = 0;
            this.lvMenu.UseCompatibleStateImageBehavior = false;
            this.lvMenu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Fiyatı";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün No";
            this.columnHeader3.Width = 125;
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.Color.Transparent;
            this.gbMenu.Controls.Add(this.btnDondurmalar9);
            this.gbMenu.Controls.Add(this.btnKahvaltılar8);
            this.gbMenu.Controls.Add(this.btnBaklavalar6);
            this.gbMenu.Controls.Add(this.btnPastalar5);
            this.gbMenu.Controls.Add(this.btnSutluTatlilar4);
            this.gbMenu.Controls.Add(this.btnSogukKahveler3);
            this.gbMenu.Controls.Add(this.btnCaylar2);
            this.gbMenu.Controls.Add(this.btnKahveler1);
            this.gbMenu.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbMenu.ForeColor = System.Drawing.Color.Black;
            this.gbMenu.Location = new System.Drawing.Point(349, 352);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(510, 786);
            this.gbMenu.TabIndex = 1;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "MENÜ";
            // 
            // btnDondurmalar9
            // 
            this.btnDondurmalar9.BackgroundImage = global::CafeCeviz.Properties.Resources.ice_cream__3_;
            this.btnDondurmalar9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDondurmalar9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDondurmalar9.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDondurmalar9.Location = new System.Drawing.Point(276, 586);
            this.btnDondurmalar9.Name = "btnDondurmalar9";
            this.btnDondurmalar9.Size = new System.Drawing.Size(185, 148);
            this.btnDondurmalar9.TabIndex = 7;
            this.btnDondurmalar9.Text = "Dondurmalar";
            this.btnDondurmalar9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDondurmalar9.UseVisualStyleBackColor = true;
            this.btnDondurmalar9.Click += new System.EventHandler(this.btnDondurmalar9_Click);
            // 
            // btnKahvaltılar8
            // 
            this.btnKahvaltılar8.BackgroundImage = global::CafeCeviz.Properties.Resources.breakfast__2_;
            this.btnKahvaltılar8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKahvaltılar8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKahvaltılar8.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKahvaltılar8.ForeColor = System.Drawing.Color.Black;
            this.btnKahvaltılar8.Location = new System.Drawing.Point(61, 586);
            this.btnKahvaltılar8.Name = "btnKahvaltılar8";
            this.btnKahvaltılar8.Size = new System.Drawing.Size(185, 148);
            this.btnKahvaltılar8.TabIndex = 6;
            this.btnKahvaltılar8.Text = "Kahvaltılar";
            this.btnKahvaltılar8.UseVisualStyleBackColor = true;
            this.btnKahvaltılar8.Click += new System.EventHandler(this.btnKahvaltılar8_Click);
            // 
            // btnBaklavalar6
            // 
            this.btnBaklavalar6.BackgroundImage = global::CafeCeviz.Properties.Resources.icons8_baklava_64;
            this.btnBaklavalar6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBaklavalar6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaklavalar6.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaklavalar6.ForeColor = System.Drawing.Color.Black;
            this.btnBaklavalar6.Location = new System.Drawing.Point(276, 412);
            this.btnBaklavalar6.Name = "btnBaklavalar6";
            this.btnBaklavalar6.Size = new System.Drawing.Size(185, 148);
            this.btnBaklavalar6.TabIndex = 5;
            this.btnBaklavalar6.Text = "Baklavalar";
            this.btnBaklavalar6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBaklavalar6.UseVisualStyleBackColor = true;
            this.btnBaklavalar6.Click += new System.EventHandler(this.btnBaklavalar6_Click);
            // 
            // btnPastalar5
            // 
            this.btnPastalar5.BackgroundImage = global::CafeCeviz.Properties.Resources.cake_slice__1_;
            this.btnPastalar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPastalar5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPastalar5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPastalar5.Location = new System.Drawing.Point(61, 412);
            this.btnPastalar5.Name = "btnPastalar5";
            this.btnPastalar5.Size = new System.Drawing.Size(185, 148);
            this.btnPastalar5.TabIndex = 4;
            this.btnPastalar5.Text = "Pastalar";
            this.btnPastalar5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPastalar5.UseVisualStyleBackColor = true;
            this.btnPastalar5.Click += new System.EventHandler(this.btnPastalar5_Click);
            // 
            // btnSutluTatlilar4
            // 
            this.btnSutluTatlilar4.BackgroundImage = global::CafeCeviz.Properties.Resources.pudding__2_;
            this.btnSutluTatlilar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSutluTatlilar4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSutluTatlilar4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSutluTatlilar4.Location = new System.Drawing.Point(276, 237);
            this.btnSutluTatlilar4.Name = "btnSutluTatlilar4";
            this.btnSutluTatlilar4.Size = new System.Drawing.Size(185, 148);
            this.btnSutluTatlilar4.TabIndex = 3;
            this.btnSutluTatlilar4.Text = "Sütlü Tatlılar";
            this.btnSutluTatlilar4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSutluTatlilar4.UseVisualStyleBackColor = true;
            this.btnSutluTatlilar4.Click += new System.EventHandler(this.btnSutluTatlilar4_Click);
            // 
            // btnSogukKahveler3
            // 
            this.btnSogukKahveler3.BackgroundImage = global::CafeCeviz.Properties.Resources.frappe__2_;
            this.btnSogukKahveler3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSogukKahveler3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSogukKahveler3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSogukKahveler3.Location = new System.Drawing.Point(57, 237);
            this.btnSogukKahveler3.Name = "btnSogukKahveler3";
            this.btnSogukKahveler3.Size = new System.Drawing.Size(189, 148);
            this.btnSogukKahveler3.TabIndex = 2;
            this.btnSogukKahveler3.Text = "Soğuk\r\nKahveler";
            this.btnSogukKahveler3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSogukKahveler3.UseVisualStyleBackColor = true;
            this.btnSogukKahveler3.Click += new System.EventHandler(this.btnSogukKahveler3_Click);
            // 
            // btnCaylar2
            // 
            this.btnCaylar2.BackgroundImage = global::CafeCeviz.Properties.Resources.tea;
            this.btnCaylar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCaylar2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaylar2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCaylar2.Location = new System.Drawing.Point(276, 63);
            this.btnCaylar2.Name = "btnCaylar2";
            this.btnCaylar2.Size = new System.Drawing.Size(185, 141);
            this.btnCaylar2.TabIndex = 1;
            this.btnCaylar2.Text = "Çaylar";
            this.btnCaylar2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCaylar2.UseVisualStyleBackColor = true;
            this.btnCaylar2.Click += new System.EventHandler(this.btnCaylar2_Click);
            // 
            // btnKahveler1
            // 
            this.btnKahveler1.BackgroundImage = global::CafeCeviz.Properties.Resources.coffee;
            this.btnKahveler1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKahveler1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKahveler1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKahveler1.Location = new System.Drawing.Point(57, 63);
            this.btnKahveler1.Name = "btnKahveler1";
            this.btnKahveler1.Size = new System.Drawing.Size(189, 141);
            this.btnKahveler1.TabIndex = 0;
            this.btnKahveler1.Text = "Kahveler";
            this.btnKahveler1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnKahveler1.UseVisualStyleBackColor = true;
            this.btnKahveler1.Click += new System.EventHandler(this.btnKahveler1_Click);
            // 
            // lblUrunEkleme
            // 
            this.lblUrunEkleme.AutoSize = true;
            this.lblUrunEkleme.BackColor = System.Drawing.Color.Transparent;
            this.lblUrunEkleme.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunEkleme.ForeColor = System.Drawing.Color.Black;
            this.lblUrunEkleme.Location = new System.Drawing.Point(1731, 383);
            this.lblUrunEkleme.Name = "lblUrunEkleme";
            this.lblUrunEkleme.Size = new System.Drawing.Size(295, 50);
            this.lblUrunEkleme.TabIndex = 2;
            this.lblUrunEkleme.Text = "ÜRÜN EKLEME";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.listView1.Location = new System.Drawing.Point(917, 746);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(666, 392);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori ID";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kategori Adı";
            this.columnHeader5.Width = 250;
            // 
            // txtKategoriId
            // 
            this.txtKategoriId.Location = new System.Drawing.Point(1914, 470);
            this.txtKategoriId.Name = "txtKategoriId";
            this.txtKategoriId.Size = new System.Drawing.Size(183, 31);
            this.txtKategoriId.TabIndex = 5;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(1914, 528);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(183, 31);
            this.txtUrunAdi.TabIndex = 6;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(1914, 592);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(183, 31);
            this.txtAciklama.TabIndex = 7;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(1914, 657);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(183, 31);
            this.txtFiyat.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1673, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "KATEGORİ ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1711, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "ÜRÜN ADI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1709, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "AÇIKLAMA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1779, 650);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 38);
            this.label4.TabIndex = 12;
            this.label4.Text = "FİYAT:";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Salmon;
            this.btnCikis.BackgroundImage = global::CafeCeviz.Properties.Resources.log_out;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(1350, 1345);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(72, 64);
            this.btnCikis.TabIndex = 28;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGeriDon.BackgroundImage = global::CafeCeviz.Properties.Resources._return;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(1268, 1345);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(65, 64);
            this.btnGeriDon.TabIndex = 27;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CafeCeviz.Properties.Resources.plus__1_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1939, 746);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 71);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(2170, 1503);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.txtKategoriId);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUrunEkleme);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.lvMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUrunler";
            this.Text = "frmUrunler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            this.gbMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMenu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnDondurmalar9;
        private System.Windows.Forms.Button btnKahvaltılar8;
        private System.Windows.Forms.Button btnBaklavalar6;
        private System.Windows.Forms.Button btnPastalar5;
        private System.Windows.Forms.Button btnSutluTatlilar4;
        private System.Windows.Forms.Button btnSogukKahveler3;
        private System.Windows.Forms.Button btnCaylar2;
        private System.Windows.Forms.Button btnKahveler1;
        private System.Windows.Forms.Label lblUrunEkleme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtKategoriId;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
    }
}