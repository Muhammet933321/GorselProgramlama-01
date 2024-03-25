using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlama_01
{
    public partial class GirisEkraniForm : Form
    {
        public GirisEkraniForm()
        {
            InitializeComponent();
        }

        private void UyeEkle_Click(object sender, EventArgs e)
        {
            UyeEklemeForm Form = new UyeEklemeForm();
            Form.Show();
        }

        private void KitapEkleBtn_Click(object sender, EventArgs e)
        {
            KitapEklemeForm form = new KitapEklemeForm();
            form.Show();
        }

        private void EmanetEkleBtn_Click(object sender, EventArgs e)
        {
            EmanetIslemleriForm form = new EmanetIslemleriForm();
            form.Show();
        }
    }
}
