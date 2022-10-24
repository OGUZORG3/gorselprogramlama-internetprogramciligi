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
    public partial class UyeEkleme : Form
    {
        AnaEkran anaEkran;

        public UyeEkleme(AnaEkran parametre2)
        {
            InitializeComponent();
            anaEkran = parametre2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaEkran.uyeEkle(textBox1.Text,textBox2.Text,textBox3.Text);
        }
    }
}
