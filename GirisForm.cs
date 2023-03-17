using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTodoUygulamasi
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void txt_kulad_Enter(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            T.BackColor = Color.Yellow;
        }

        private void txt_kulad_Leave(object sender, EventArgs e)
        {
            TextBox T = sender as TextBox;
            T.BackColor = Color.White;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_kulad.Text) && !string.IsNullOrEmpty(txt_sifre.Text))
            {
                kullanici k = database.kullanicilar.FirstOrDefault(i => i.KullaniciAd == txt_kulad.Text && i.Sifre == txt_sifre.Text);

                if(k!=null)
                {  
                    Form f = Application.OpenForms["AnaForm"];
                    Panel p =(Panel)f.Controls["panel1"];
                    GroupBox g1 = (GroupBox)p.Controls["grp_islemler"];
                    g1.Enabled = true;            

                    this.Close(); 
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre hatalı","Hatalı kullanıcı",MessageBoxButtons.OK,MessageBoxIcon.Error);   
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
