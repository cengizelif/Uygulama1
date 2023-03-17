using System;
using System.Windows.Forms;

namespace WindowsFormsTodoUygulamasi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();


            GirisForm girisForm = new GirisForm();
            girisForm.MdiParent = this;
            girisForm.StartPosition = FormStartPosition.CenterScreen;
            girisForm.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_zaman.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            TodoForm todoForm;
            if (Application.OpenForms["TodoForm"]!=null)
            {
                todoForm =(TodoForm)Application.OpenForms["TodoForm"];
                todoForm.Focus();
            }
            else
            {
               todoForm = new TodoForm();
               todoForm.MdiParent = this;
               todoForm.StartPosition = FormStartPosition.CenterScreen;
               todoForm.Show();
            }
          
            
        }

        private void btn_liste_Click(object sender, EventArgs e)
        {
            KayitListesi kl;

            if (Application.OpenForms["KayitListesi"]!=null)
            {
                kl = (KayitListesi)Application.OpenForms["KayitListesi"];
                kl.Focus();
            }
            else
            {
                kl = new KayitListesi();
                kl.MdiParent = this;
                kl.StartPosition = FormStartPosition.CenterScreen;  
                kl.Show();
            }
            
        }
    }
}
