﻿namespace KutuphaneOtomasyon
{
    partial class frmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaSayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUyeIsmi = new System.Windows.Forms.TextBox();
            this.txtKitapIsmi = new System.Windows.Forms.TextBox();
            this.dgvUye = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meslek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CezaPuani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKitap = new System.Windows.Forms.DataGridView();
            this.KitapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uygunluk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpAlim = new System.Windows.Forms.DateTimePicker();
            this.btnKitapVer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmanetGun = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teslimİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYazarFiltre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTeslimTarih = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(104, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye İsmi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(98, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:";
            // 
            // txtUyeIsmi
            // 
            this.txtUyeIsmi.Location = new System.Drawing.Point(207, 78);
            this.txtUyeIsmi.Name = "txtUyeIsmi";
            this.txtUyeIsmi.Size = new System.Drawing.Size(304, 26);
            this.txtUyeIsmi.TabIndex = 2;
            this.txtUyeIsmi.TextChanged += new System.EventHandler(this.txtUyeIsmi_TextChanged);
            // 
            // txtKitapIsmi
            // 
            this.txtKitapIsmi.Location = new System.Drawing.Point(207, 417);
            this.txtKitapIsmi.Name = "txtKitapIsmi";
            this.txtKitapIsmi.Size = new System.Drawing.Size(304, 26);
            this.txtKitapIsmi.TabIndex = 3;
            this.txtKitapIsmi.TextChanged += new System.EventHandler(this.txtKitapIsmi_TextChanged);
            // 
            // dgvUye
            // 
            this.dgvUye.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUye.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvUye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUye.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Ad,
            this.Soyad,
            this.Meslek,
            this.CezaPuani});
            this.dgvUye.Location = new System.Drawing.Point(80, 122);
            this.dgvUye.Name = "dgvUye";
            this.dgvUye.RowHeadersWidth = 62;
            this.dgvUye.RowTemplate.Height = 28;
            this.dgvUye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUye.Size = new System.Drawing.Size(1389, 232);
            this.dgvUye.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "UyeID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Ad";
            this.Ad.HeaderText = "İsim";
            this.Ad.MinimumWidth = 8;
            this.Ad.Name = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.DataPropertyName = "Soyad";
            this.Soyad.HeaderText = "Soy İsim";
            this.Soyad.MinimumWidth = 8;
            this.Soyad.Name = "Soyad";
            // 
            // Meslek
            // 
            this.Meslek.DataPropertyName = "Meslek";
            this.Meslek.HeaderText = "Meslek";
            this.Meslek.MinimumWidth = 8;
            this.Meslek.Name = "Meslek";
            // 
            // CezaPuani
            // 
            this.CezaPuani.DataPropertyName = "CezaPuani";
            this.CezaPuani.HeaderText = "Ceza Puanı";
            this.CezaPuani.MinimumWidth = 8;
            this.CezaPuani.Name = "CezaPuani";
            // 
            // dgvKitap
            // 
            this.dgvKitap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitap.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvKitap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapID,
            this.KitapAdi,
            this.Yazar,
            this.Tur,
            this.Sayfa,
            this.Uygunluk});
            this.dgvKitap.Location = new System.Drawing.Point(80, 454);
            this.dgvKitap.Name = "dgvKitap";
            this.dgvKitap.RowHeadersWidth = 62;
            this.dgvKitap.RowTemplate.Height = 28;
            this.dgvKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitap.Size = new System.Drawing.Size(1389, 232);
            this.dgvKitap.TabIndex = 5;
            // 
            // KitapID
            // 
            this.KitapID.DataPropertyName = "ID";
            this.KitapID.HeaderText = "KitapID";
            this.KitapID.MinimumWidth = 8;
            this.KitapID.Name = "KitapID";
            this.KitapID.Visible = false;
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "Adı";
            this.KitapAdi.MinimumWidth = 8;
            this.KitapAdi.Name = "KitapAdi";
            // 
            // Yazar
            // 
            this.Yazar.DataPropertyName = "Yazar";
            this.Yazar.HeaderText = "Yazar";
            this.Yazar.MinimumWidth = 8;
            this.Yazar.Name = "Yazar";
            // 
            // Tur
            // 
            this.Tur.DataPropertyName = "Tur";
            this.Tur.HeaderText = "Tür";
            this.Tur.MinimumWidth = 8;
            this.Tur.Name = "Tur";
            // 
            // Sayfa
            // 
            this.Sayfa.DataPropertyName = "Sayfa";
            this.Sayfa.HeaderText = "Sayfa Sayısı";
            this.Sayfa.MinimumWidth = 8;
            this.Sayfa.Name = "Sayfa";
            // 
            // Uygunluk
            // 
            this.Uygunluk.DataPropertyName = "Uygunluk";
            this.Uygunluk.HeaderText = "Uygunluk";
            this.Uygunluk.MinimumWidth = 8;
            this.Uygunluk.Name = "Uygunluk";
            this.Uygunluk.Visible = false;
            // 
            // dtpAlim
            // 
            this.dtpAlim.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpAlim.Location = new System.Drawing.Point(207, 738);
            this.dtpAlim.Name = "dtpAlim";
            this.dtpAlim.Size = new System.Drawing.Size(304, 29);
            this.dtpAlim.TabIndex = 6;
            // 
            // btnKitapVer
            // 
            this.btnKitapVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKitapVer.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKitapVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapVer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapVer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKitapVer.Location = new System.Drawing.Point(1059, 732);
            this.btnKitapVer.Name = "btnKitapVer";
            this.btnKitapVer.Size = new System.Drawing.Size(410, 115);
            this.btnKitapVer.TabIndex = 8;
            this.btnKitapVer.Text = "Kitap Ver";
            this.btnKitapVer.UseVisualStyleBackColor = false;
            this.btnKitapVer.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 782);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Emanet Gün Sayısı:";
            // 
            // txtEmanetGun
            // 
            this.txtEmanetGun.Location = new System.Drawing.Point(207, 783);
            this.txtEmanetGun.Name = "txtEmanetGun";
            this.txtEmanetGun.Size = new System.Drawing.Size(304, 26);
            this.txtEmanetGun.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uyelerToolStripMenuItem,
            this.kitaplarToolStripMenuItem,
            this.teslimİşlemleriToolStripMenuItem,
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1562, 36);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(72, 32);
            this.dosyaToolStripMenuItem.Text = "Çıkış";
            this.dosyaToolStripMenuItem.Click += new System.EventHandler(this.dosyaToolStripMenuItem_Click);
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(103, 32);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            this.kitaplarToolStripMenuItem.Click += new System.EventHandler(this.kitaplarToolStripMenuItem_Click);
            // 
            // uyelerToolStripMenuItem
            // 
            this.uyelerToolStripMenuItem.Name = "uyelerToolStripMenuItem";
            this.uyelerToolStripMenuItem.Size = new System.Drawing.Size(89, 32);
            this.uyelerToolStripMenuItem.Text = "Üyeler";
            this.uyelerToolStripMenuItem.Click += new System.EventHandler(this.uyelerToolStripMenuItem_Click);
            // 
            // teslimİşlemleriToolStripMenuItem
            // 
            this.teslimİşlemleriToolStripMenuItem.Name = "teslimİşlemleriToolStripMenuItem";
            this.teslimİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(175, 32);
            this.teslimİşlemleriToolStripMenuItem.Text = "Teslim İşlemleri";
            this.teslimİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.teslimİşlemleriToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(132, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Yazar:";
            // 
            // txtYazarFiltre
            // 
            this.txtYazarFiltre.Location = new System.Drawing.Point(207, 380);
            this.txtYazarFiltre.Name = "txtYazarFiltre";
            this.txtYazarFiltre.Size = new System.Drawing.Size(304, 26);
            this.txtYazarFiltre.TabIndex = 14;
            this.txtYazarFiltre.TextChanged += new System.EventHandler(this.txtYazarFiltre_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(67, 822);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Teslim Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(81, 742);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Alım Tarihi:";
            // 
            // txtTeslimTarih
            // 
            this.txtTeslimTarih.Location = new System.Drawing.Point(207, 824);
            this.txtTeslimTarih.Name = "txtTeslimTarih";
            this.txtTeslimTarih.ReadOnly = true;
            this.txtTeslimTarih.Size = new System.Drawing.Size(304, 26);
            this.txtTeslimTarih.TabIndex = 18;
            this.txtTeslimTarih.TextChanged += new System.EventHandler(this.txtTeslimTarih_TextChanged);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1562, 928);
            this.Controls.Add(this.txtTeslimTarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYazarFiltre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmanetGun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKitapVer);
            this.Controls.Add(this.dtpAlim);
            this.Controls.Add(this.dgvKitap);
            this.Controls.Add(this.dgvUye);
            this.Controls.Add(this.txtKitapIsmi);
            this.Controls.Add(this.txtUyeIsmi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTakipIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUyeIsmi;
        private System.Windows.Forms.TextBox txtKitapIsmi;
        private System.Windows.Forms.DataGridView dgvUye;
        private System.Windows.Forms.DataGridView dgvKitap;
        private System.Windows.Forms.DateTimePicker dtpAlim;
        private System.Windows.Forms.Button btnKitapVer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmanetGun;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teslimİşlemleriToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYazarFiltre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTeslimTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meslek;
        private System.Windows.Forms.DataGridViewTextBoxColumn CezaPuani;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uygunluk;
    }
}