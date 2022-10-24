using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class KitapEklemeEkrani : Form
    {
        AnaEkran  anaEkran;

        public KitapEklemeEkrani(AnaEkran parametre)
        {
            InitializeComponent();
            anaEkran = parametre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.kitapEkle(textBox1.Text,textBox2.Text);
        }
    }
}
