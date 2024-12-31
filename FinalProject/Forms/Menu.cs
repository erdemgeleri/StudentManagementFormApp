using FinalProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            OgrenciIslemleri ogrenciIslemleri = new OgrenciIslemleri();
            this.Hide();
            ogrenciIslemleri.Show();
        }

        private void btnSinif_Click(object sender, EventArgs e)
        {
            SinifIslemleri sinifIslemleri = new SinifIslemleri();
            this.Hide();
            sinifIslemleri.Show();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            DersIslemleri dersIslemleri = new DersIslemleri();
            this.Hide();
            dersIslemleri.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
