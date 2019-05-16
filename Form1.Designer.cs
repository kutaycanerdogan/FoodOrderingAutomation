namespace HamburgerciProje
{
    partial class Form1
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
            this.btnMenuEkle = new System.Windows.Forms.Button();
            this.btnEkstraEkle = new System.Windows.Forms.Button();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMenuEkle
            // 
            this.btnMenuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuEkle.Location = new System.Drawing.Point(51, 31);
            this.btnMenuEkle.Name = "btnMenuEkle";
            this.btnMenuEkle.Size = new System.Drawing.Size(196, 89);
            this.btnMenuEkle.TabIndex = 0;
            this.btnMenuEkle.Text = "Menü Ekle";
            this.btnMenuEkle.UseVisualStyleBackColor = true;
            this.btnMenuEkle.Click += new System.EventHandler(this.btnMenuEkle_Click);
            // 
            // btnEkstraEkle
            // 
            this.btnEkstraEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkstraEkle.Location = new System.Drawing.Point(51, 126);
            this.btnEkstraEkle.Name = "btnEkstraEkle";
            this.btnEkstraEkle.Size = new System.Drawing.Size(196, 89);
            this.btnEkstraEkle.TabIndex = 1;
            this.btnEkstraEkle.Text = "Ekstra Ekle";
            this.btnEkstraEkle.UseVisualStyleBackColor = true;
            this.btnEkstraEkle.Click += new System.EventHandler(this.btnEkstraEkle_Click);
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisVer.Location = new System.Drawing.Point(51, 221);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(196, 89);
            this.btnSiparisVer.TabIndex = 2;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 339);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.btnEkstraEkle);
            this.Controls.Add(this.btnMenuEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuEkle;
        private System.Windows.Forms.Button btnEkstraEkle;
        private System.Windows.Forms.Button btnSiparisVer;
    }
}