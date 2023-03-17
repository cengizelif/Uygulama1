namespace WindowsFormsTodoUygulamasi
{
    partial class AnaForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_islemler = new System.Windows.Forms.GroupBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_liste = new System.Windows.Forms.Button();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_zaman = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.grp_islemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grp_islemler);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 450);
            this.panel1.TabIndex = 1;
            // 
            // grp_islemler
            // 
            this.grp_islemler.Controls.Add(this.btn_cikis);
            this.grp_islemler.Controls.Add(this.btn_liste);
            this.grp_islemler.Controls.Add(this.btn_yeni);
            this.grp_islemler.Enabled = false;
            this.grp_islemler.Location = new System.Drawing.Point(19, 194);
            this.grp_islemler.Name = "grp_islemler";
            this.grp_islemler.Size = new System.Drawing.Size(135, 231);
            this.grp_islemler.TabIndex = 1;
            this.grp_islemler.TabStop = false;
            this.grp_islemler.Text = "İşlemler";
            // 
            // btn_cikis
            // 
            this.btn_cikis.Location = new System.Drawing.Point(20, 126);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(95, 34);
            this.btn_cikis.TabIndex = 0;
            this.btn_cikis.Text = "Uygulama Kapat";
            this.btn_cikis.UseVisualStyleBackColor = true;
            // 
            // btn_liste
            // 
            this.btn_liste.Location = new System.Drawing.Point(20, 86);
            this.btn_liste.Name = "btn_liste";
            this.btn_liste.Size = new System.Drawing.Size(95, 34);
            this.btn_liste.TabIndex = 0;
            this.btn_liste.Text = "Kayıt Listele";
            this.btn_liste.UseVisualStyleBackColor = true;
            this.btn_liste.Click += new System.EventHandler(this.btn_liste_Click);
            // 
            // btn_yeni
            // 
            this.btn_yeni.Location = new System.Drawing.Point(20, 46);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(95, 34);
            this.btn_yeni.TabIndex = 0;
            this.btn_yeni.Text = "Yeni Kayıt";
            this.btn_yeni.UseVisualStyleBackColor = true;
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsTodoUygulamasi.Properties.Resources.Umut_Pulat_Tulliana_2_Korganizer_todo_128;
            this.pictureBox1.Location = new System.Drawing.Point(19, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_zaman);
            this.panel2.Location = new System.Drawing.Point(605, 415);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 35);
            this.panel2.TabIndex = 2;
            // 
            // lbl_zaman
            // 
            this.lbl_zaman.AutoSize = true;
            this.lbl_zaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_zaman.Location = new System.Drawing.Point(9, 6);
            this.lbl_zaman.Name = "lbl_zaman";
            this.lbl_zaman.Size = new System.Drawing.Size(174, 20);
            this.lbl_zaman.TabIndex = 0;
            this.lbl_zaman.Text = "16.03.2023 09:12:00";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todo Uygulaması";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.panel1.ResumeLayout(false);
            this.grp_islemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grp_islemler;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_liste;
        private System.Windows.Forms.Button btn_yeni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_zaman;
        private System.Windows.Forms.Timer timer1;
    }
}

