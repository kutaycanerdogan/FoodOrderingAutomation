namespace HamburgerciProje
{
    partial class MenuEkle
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtMenuAdi = new System.Windows.Forms.TextBox();
            this.nmrMenuFiyati = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMenuEkleAnaMenuyeDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(191, 122);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(256, 22);
            this.btnKaydet.TabIndex = 23;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtMenuAdi
            // 
            this.txtMenuAdi.Location = new System.Drawing.Point(191, 49);
            this.txtMenuAdi.Name = "txtMenuAdi";
            this.txtMenuAdi.Size = new System.Drawing.Size(256, 20);
            this.txtMenuAdi.TabIndex = 22;
            // 
            // nmrMenuFiyati
            // 
            this.nmrMenuFiyati.Location = new System.Drawing.Point(191, 83);
            this.nmrMenuFiyati.Name = "nmrMenuFiyati";
            this.nmrMenuFiyati.Size = new System.Drawing.Size(256, 20);
            this.nmrMenuFiyati.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(53, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Menü Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Menü Adı:";
            // 
            // btnMenuEkleAnaMenuyeDon
            // 
            this.btnMenuEkleAnaMenuyeDon.Location = new System.Drawing.Point(191, 150);
            this.btnMenuEkleAnaMenuyeDon.Name = "btnMenuEkleAnaMenuyeDon";
            this.btnMenuEkleAnaMenuyeDon.Size = new System.Drawing.Size(256, 22);
            this.btnMenuEkleAnaMenuyeDon.TabIndex = 24;
            this.btnMenuEkleAnaMenuyeDon.Text = "Ana Menüye Dön";
            this.btnMenuEkleAnaMenuyeDon.UseVisualStyleBackColor = true;
            this.btnMenuEkleAnaMenuyeDon.Click += new System.EventHandler(this.btnMenuEkleAnaMenuyeDon_Click);
            // 
            // MenuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 219);
            this.Controls.Add(this.btnMenuEkleAnaMenuyeDon);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtMenuAdi);
            this.Controls.Add(this.nmrMenuFiyati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "MenuEkle";
            this.Text = "MenuEkle";
            ((System.ComponentModel.ISupportInitialize)(this.nmrMenuFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtMenuAdi;
        private System.Windows.Forms.NumericUpDown nmrMenuFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMenuEkleAnaMenuyeDon;
    }
}