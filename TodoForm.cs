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
    public partial class TodoForm : Form
    {
        public TodoForm()
        {
            InitializeComponent();
        }

        private void txt_baslik_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txt_baslik_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void cmb_durum_Enter(object sender, EventArgs e)
        {
            cmb_durum.BackColor = Color.Yellow;
        }

        private void cmb_durum_Leave(object sender, EventArgs e)
        {
            cmb_durum.BackColor=Color.White;    
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
           int sonuc= database.KayitEkle(new TodoClass()
            {
                Id = Guid.NewGuid(),
                Baslik = txt_baslik.Text,
                Aciklama = txt_aciklama.Text,
                OzetBilgi = txt_ozet.Text,
                OnemDerecesi =int.Parse(txt_onem.Text),
                Durum=cmb_durum.SelectedItem.ToString(), 
                KayitTarihi=DateTime.Now
            }) ;
            if(sonuc==1)
            {
                MessageBox.Show("Kayıt ekleme işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
               DialogResult cvp= MessageBox.Show("Yeni Kayıt eklemek istermisiniz?", "Yeni Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(cvp==DialogResult.Yes)
                {
                    foreach (Control item in Controls)
                    {
                        if(item is TextBox)
                        {
                            item.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    KayitListesi kl;

                    if (Application.OpenForms["KayitListesi"] != null)
                    {
                        kl = (KayitListesi)Application.OpenForms["KayitListesi"];
                       DataGridView dgv=(DataGridView)((GroupBox)kl.Controls["grp_todolist"]).Controls["dgv_todolist"];
                        dgv.DataSource = null;
                        dgv.DataSource = database.todoList;
                        kl.Focus();
                    }
                    else
                    {
                        kl = new KayitListesi();
                        kl.MdiParent = Application.OpenForms["AnaForm"];
                        kl.StartPosition = FormStartPosition.CenterScreen;
                        kl.Show();
                    }

                    this.Close();
                   
                }
            }
            else
            {
                MessageBox.Show("Kayıt ekleme işleminde hata", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
