namespace CafeCeviz
{
    partial class frmMenu
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
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnRezervasyon = new System.Windows.Forms.Button();
            this.btnMasaSiparis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGeriDon.BackgroundImage = global::CafeCeviz.Properties.Resources._return;
            this.btnGeriDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeriDon.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDon.Location = new System.Drawing.Point(1259, 1031);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(100, 93);
            this.btnGeriDon.TabIndex = 28;
            this.btnGeriDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeriDon.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.Salmon;
            this.btnCikis.BackgroundImage = global::CafeCeviz.Properties.Resources.log_out;
            this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCikis.Location = new System.Drawing.Point(1365, 1031);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(92, 93);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.BackgroundImage = global::CafeCeviz.Properties.Resources.people__2_;
            this.btnMusteriler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMusteriler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMusteriler.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriler.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnMusteriler.Location = new System.Drawing.Point(1078, 265);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(437, 352);
            this.btnMusteriler.TabIndex = 3;
            this.btnMusteriler.Text = "PERSONEL EKLEME";
            this.btnMusteriler.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnRezervasyon
            // 
            this.btnRezervasyon.BackgroundImage = global::CafeCeviz.Properties.Resources.drinks_menu;
            this.btnRezervasyon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRezervasyon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervasyon.Location = new System.Drawing.Point(1534, 265);
            this.btnRezervasyon.Name = "btnRezervasyon";
            this.btnRezervasyon.Size = new System.Drawing.Size(437, 352);
            this.btnRezervasyon.TabIndex = 1;
            this.btnRezervasyon.UseVisualStyleBackColor = true;
            this.btnRezervasyon.Click += new System.EventHandler(this.btnRezervasyon_Click);
            // 
            // btnMasaSiparis
            // 
            this.btnMasaSiparis.BackgroundImage = global::CafeCeviz.Properties.Resources.side_table__1_;
            this.btnMasaSiparis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMasaSiparis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMasaSiparis.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaSiparis.ForeColor = System.Drawing.Color.LightSlateGray;
            this.btnMasaSiparis.Location = new System.Drawing.Point(597, 265);
            this.btnMasaSiparis.Name = "btnMasaSiparis";
            this.btnMasaSiparis.Size = new System.Drawing.Size(463, 352);
            this.btnMasaSiparis.TabIndex = 0;
            this.btnMasaSiparis.Text = " MASALAR";
            this.btnMasaSiparis.UseVisualStyleBackColor = true;
            this.btnMasaSiparis.Click += new System.EventHandler(this.btnMasaSiparis_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(1923, 1155);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.btnRezervasyon);
            this.Controls.Add(this.btnMasaSiparis);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMasaSiparis;
        private System.Windows.Forms.Button btnRezervasyon;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGeriDon;
    }
}