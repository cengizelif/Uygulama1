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
    public partial class KayitListesi : Form
    {
        public KayitListesi()
        {
            InitializeComponent();
        }

        private void btn_tamamlandi_Click(object sender, EventArgs e)
        {
            dgv_todolist.DataSource = database.todoList.Where(i => i.Durum == "Tamamlandı").ToList();
            dgv_todolist.Columns[0].Visible = false;
        }

        private void KayitListesi_Load(object sender, EventArgs e)
        {
            dgv_todolist.DataSource = database.todoList;         
        }

        private void btn_beklemede_Click(object sender, EventArgs e)
        {
            dgv_todolist.DataSource = database.todoList.Where(i => i.Durum == "Beklemede").ToList();
            dgv_todolist.Columns[0].Visible = false;
            dgv_todolist.Columns["Baslik"].HeaderText = "Başlık";
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            dgv_todolist.DataSource = database.todoList.Where(i => i.Durum == "İptal edildi").ToList();
            dgv_todolist.Columns[0].Visible = false;
        }

        private void btn_ertelendi_Click(object sender, EventArgs e)
        {
            dgv_todolist.DataSource = database.todoList.Where(i => i.Durum == "Ertelendi").ToList();
            dgv_todolist.Columns[0].Visible = false;
        }
    }
}
