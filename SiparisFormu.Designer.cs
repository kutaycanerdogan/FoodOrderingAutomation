namespace HamburgerciProje
{
    partial class SiparisFormu
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
            this.btnOdeme = new System.Windows.Forms.Button();
            this.btnSiparisFormuAnaMenuyeDon = new System.Windows.Forms.Button();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.flwLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.gbBoyut = new System.Windows.Forms.GroupBox();
            this.rbBuyuk = new System.Windows.Forms.RadioButton();
            this.rbOrta = new System.Windows.Forms.RadioButton();
            this.rbKucuk = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbMenuler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiparisEkleSiparisVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            this.gbBoyut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(270, 423);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(197, 22);
            this.btnOdeme.TabIndex = 40;
            this.btnOdeme.Text = "Ödeme";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // btnSiparisFormuAnaMenuyeDon
            // 
            this.btnSiparisFormuAnaMenuyeDon.Location = new System.Drawing.Point(473, 423);
            this.btnSiparisFormuAnaMenuyeDon.Name = "btnSiparisFormuAnaMenuyeDon";
            this.btnSiparisFormuAnaMenuyeDon.Size = new System.Drawing.Size(209, 22);
            this.btnSiparisFormuAnaMenuyeDon.TabIndex = 36;
            this.btnSiparisFormuAnaMenuyeDon.Text = "Ana Menüye Dön";
            this.btnSiparisFormuAnaMenuyeDon.UseVisualStyleBackColor = true;
            this.btnSiparisFormuAnaMenuyeDon.Click += new System.EventHandler(this.btnSiparisFormuAnaMenuyeDon_Click);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(444, 246);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(0, 20);
            this.lblTutar.TabIndex = 39;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(473, 350);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(209, 22);
            this.btnTemizle.TabIndex = 41;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(284, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Toplam Tutar:";
            // 
            // lstSiparis
            // 
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.Location = new System.Drawing.Point(288, 12);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(394, 199);
            this.lstSiparis.TabIndex = 37;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(60, 385);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(190, 20);
            this.nmrAdet.TabIndex = 35;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(18, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Adet:";
            // 
            // flwLayout
            // 
            this.flwLayout.CausesValidation = false;
            this.flwLayout.Location = new System.Drawing.Point(23, 226);
            this.flwLayout.Name = "flwLayout";
            this.flwLayout.Size = new System.Drawing.Size(225, 146);
            this.flwLayout.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Ekstra Malezemeler";
            // 
            // gbBoyut
            // 
            this.gbBoyut.Controls.Add(this.rbBuyuk);
            this.gbBoyut.Controls.Add(this.rbOrta);
            this.gbBoyut.Controls.Add(this.rbKucuk);
            this.gbBoyut.Location = new System.Drawing.Point(21, 128);
            this.gbBoyut.Name = "gbBoyut";
            this.gbBoyut.Size = new System.Drawing.Size(224, 64);
            this.gbBoyut.TabIndex = 31;
            this.gbBoyut.TabStop = false;
            this.gbBoyut.Text = "Boyut Seçin";
            // 
            // rbBuyuk
            // 
            this.rbBuyuk.AutoSize = true;
            this.rbBuyuk.Location = new System.Drawing.Point(169, 29);
            this.rbBuyuk.Name = "rbBuyuk";
            this.rbBuyuk.Size = new System.Drawing.Size(55, 17);
            this.rbBuyuk.TabIndex = 6;
            this.rbBuyuk.TabStop = true;
            this.rbBuyuk.Text = "Büyük";
            this.rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            this.rbOrta.AutoSize = true;
            this.rbOrta.Location = new System.Drawing.Point(93, 29);
            this.rbOrta.Name = "rbOrta";
            this.rbOrta.Size = new System.Drawing.Size(45, 17);
            this.rbOrta.TabIndex = 5;
            this.rbOrta.TabStop = true;
            this.rbOrta.Text = "Orta";
            this.rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbKucuk
            // 
            this.rbKucuk.AutoSize = true;
            this.rbKucuk.Checked = true;
            this.rbKucuk.Location = new System.Drawing.Point(6, 29);
            this.rbKucuk.Name = "rbKucuk";
            this.rbKucuk.Size = new System.Drawing.Size(56, 17);
            this.rbKucuk.TabIndex = 4;
            this.rbKucuk.TabStop = true;
            this.rbKucuk.Text = "Küçük";
            this.rbKucuk.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 50);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // cbMenuler
            // 
            this.cbMenuler.FormattingEnabled = true;
            this.cbMenuler.Location = new System.Drawing.Point(21, 100);
            this.cbMenuler.Name = "cbMenuler";
            this.cbMenuler.Size = new System.Drawing.Size(224, 21);
            this.cbMenuler.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Menü Seçin";
            // 
            // btnSiparisEkleSiparisVer
            // 
            this.btnSiparisEkleSiparisVer.Location = new System.Drawing.Point(270, 350);
            this.btnSiparisEkleSiparisVer.Name = "btnSiparisEkleSiparisVer";
            this.btnSiparisEkleSiparisVer.Size = new System.Drawing.Size(197, 22);
            this.btnSiparisEkleSiparisVer.TabIndex = 42;
            this.btnSiparisEkleSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisEkleSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisEkleSiparisVer.Click += new System.EventHandler(this.btnSiparisEkleSiparisVer_Click);
            // 
            // SiparisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 457);
            this.Controls.Add(this.btnSiparisEkleSiparisVer);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.btnSiparisFormuAnaMenuyeDon);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flwLayout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbBoyut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbMenuler);
            this.Controls.Add(this.label1);
            this.Name = "SiparisFormu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            this.gbBoyut.ResumeLayout(false);
            this.gbBoyut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Button btnSiparisFormuAnaMenuyeDon;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSiparis;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flwLayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBoyut;
        private System.Windows.Forms.RadioButton rbBuyuk;
        private System.Windows.Forms.RadioButton rbOrta;
        private System.Windows.Forms.RadioButton rbKucuk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbMenuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiparisEkleSiparisVer;
    }
}

