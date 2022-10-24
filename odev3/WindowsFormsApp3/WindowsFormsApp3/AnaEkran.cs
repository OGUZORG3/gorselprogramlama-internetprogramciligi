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
    public partial class AnaEkran : Form
    {

        public AnaEkran()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkrani kitapEklemeEkrani = new KitapEklemeEkrani(this);
            kitapEklemeEkrani.Show();

        }
        public void kitapEkle(string kitapAdi, string yazarAdi)
        {
            listBox1.Items.Add("Kitap Adı: " + kitapAdi + " Yazar Adı: " + yazarAdi);

        }
        public string bolme()
        {   
            string kelimeler = listBox1.SelectedItem.ToString();
            string[] bolunmus = kelimeler.Split(' ');
            string kitaptutucu = bolunmus[2];
            return kitaptutucu;
        }
        public string bolmeiki()
        {
            string kelimeler = listBox1.SelectedItem.ToString();
            string[] bolunmus = kelimeler.Split(' ');
            string yazartutucu = bolunmus[5];
            return yazartutucu;
        }
        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UyeEkleme uyeEkleme = new UyeEkleme(this);
            uyeEkleme.Show();
        }
        public void uyeEkle(string ad, string soyad, string tcno)
        {
            listBox2.Items.Add("AD:" + ad + " SOYAD:" + soyad + " TC:" + (Convert.ToString(tcno)));

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.One;
            button1.Enabled = true;
            button2.Enabled = true;
        }


        private void AnaEkran_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          DialogResult secenek =  MessageBox.Show("Değişiklikleri kaydetmek istiyor musunuz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);

            }
        }

        private void secimkaldır(object sender, EventArgs e)
        {
            for (int x = 0; x < listBox1.Items.Count; x++)
            {
                listBox1.SetSelected(x, false);
                button1.Enabled = false;
                button2.Enabled = false;
            }
            for (int x = 0; x < listBox2.Items.Count; x++)
            {
                listBox2.SetSelected(x, false);
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectionMode = SelectionMode.One;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Duzenle duzenle = new Duzenle(this);
           duzenle.Show();   
        }
        public void guncelle(string a,string b)
        {
            int secili = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(secili);
            listBox1.Items.Insert(secili, "Kitap Adı: " + a + " Yazar Adı: " + b);
        }
    }
}
