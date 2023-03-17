namespace WindowsFormsTodoUygulamasi
{
    partial class TodoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_baslik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_aciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_onem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ozet = new System.Windows.Forms.TextBox();
            this.cmb_durum = new System.Windows.Forms.ComboBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Başlık";
            // 
            // txt_baslik
            // 
            this.txt_baslik.Location = new System.Drawing.Point(128, 31);
            this.txt_baslik.Name = "txt_baslik";
            this.txt_baslik.Size = new System.Drawing.Size(225, 20);
            this.txt_baslik.TabIndex = 0;
            this.txt_baslik.Enter += new System.EventHandler(this.txt_baslik_Enter);
            this.txt_baslik.Leave += new System.EventHandler(this.txt_baslik_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Açıklama";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(128, 128);
            this.txt_aciklama.Multiline = true;
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(225, 89);
            this.txt_aciklama.TabIndex = 2;
            this.txt_aciklama.Enter += new System.EventHandler(this.txt_baslik_Enter);
            this.txt_aciklama.Leave += new System.EventHandler(this.txt_baslik_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Önem Derecesi";
            // 
            // txt_onem
            // 
            this.txt_onem.Location = new System.Drawing.Point(128, 223);
            this.txt_onem.Name = "txt_onem";
            this.txt_onem.Size = new System.Drawing.Size(225, 20);
            this.txt_onem.TabIndex = 3;
            this.txt_onem.Enter += new System.EventHandler(this.txt_baslik_Enter);
            this.txt_onem.Leave += new System.EventHandler(this.txt_baslik_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Durumu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Özet Bilgi";
            // 
            // txt_ozet
            // 
            this.txt_ozet.Location = new System.Drawing.Point(128, 57);
            this.txt_ozet.Multiline = true;
            this.txt_ozet.Name = "txt_ozet";
            this.txt_ozet.Size = new System.Drawing.Size(225, 65);
            this.txt_ozet.TabIndex = 1;
            this.txt_ozet.Enter += new System.EventHandler(this.txt_baslik_Enter);
            this.txt_ozet.Leave += new System.EventHandler(this.txt_baslik_Leave);
            // 
            // cmb_durum
            // 
            this.cmb_durum.FormattingEnabled = true;
            this.cmb_durum.Items.AddRange(new object[] {
            "Beklemede",
            "Tamamlandı",
            "Tamamlanamadı",
            "İptal edildi",
            "Ertelendi"});
            this.cmb_durum.Location = new System.Drawing.Point(128, 248);
            this.cmb_durum.Name = "cmb_durum";
            this.cmb_durum.Size = new System.Drawing.Size(225, 21);
            this.cmb_durum.TabIndex = 4;
            this.cmb_durum.Enter += new System.EventHandler(this.cmb_durum_Enter);
            this.cmb_durum.Leave += new System.EventHandler(this.cmb_durum_Leave);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(128, 298);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(225, 35);
            this.btn_kaydet.TabIndex = 5;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // TodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 371);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.cmb_durum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_onem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ozet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_aciklama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_baslik);
            this.Controls.Add(this.label1);
            this.Name = "TodoForm";
            this.Text = "TodoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_baslik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_aciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_onem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ozet;
        private System.Windows.Forms.ComboBox cmb_durum;
        private System.Windows.Forms.Button btn_kaydet;
    }
}