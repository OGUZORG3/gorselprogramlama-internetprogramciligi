using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            double vize=0, final=0, sonuc;
            try 
            {
                vize = Convert.ToDouble(numericUpDown1.Value);
            final = Convert.ToDouble(numericUpDown2.Value);
                sonuc = (vize * 0.4) + final * 0.6;
                
                label3.Text = sonuc.ToString();
             if(sonuc<50)
                {
                    label4.Text = "kaldınız FF";
                }
             else if(50<=sonuc &&sonuc <=60)
                {
                    label4.Text = "gectiniz FD";
                }
                else if (60 <= sonuc && sonuc <= 64)
                {
                    label4.Text = "gectiniz DD";
                }
                else if (65 <= sonuc && sonuc <= 69)
                {
                    label4.Text = "gectiniz DC";
                }
                else if (70 <= sonuc && sonuc <= 74)
                {
                    label4.Text = "gectiniz CC";
                }
                else if (75 <= sonuc && sonuc <= 79)
                {
                    label4.Text = "gectiniz CB";
                }
                else if (80 <= sonuc && sonuc <= 84)
                {
                    label4.Text = "gectiniz BB";
                }
                else if (85 <= sonuc && sonuc <= 89)
                {
                    label4.Text = "gectiniz BA";
                }
                else if (90 <= sonuc && sonuc <= 100)
                {
                    label4.Text = "gectiniz AA";
                }
            }
            catch(Exception ex )
            {                                
                if(numericUpDown1.Text!=""&& numericUpDown2.Text != "")
                { 
                MessageBox.Show("lütfen gecerli bir değer girin");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
        }

     
    }
}
