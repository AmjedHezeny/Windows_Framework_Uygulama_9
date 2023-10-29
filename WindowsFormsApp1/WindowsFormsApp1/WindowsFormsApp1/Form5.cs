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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        double sayi;
        int skor;

        private void button1_Click(object sender, EventArgs e)
        {
            skor = 100;
            label1.Text = "Skor : " + skor.ToString();
            button2.Enabled = true;
            Random rastgele = new Random();
            sayi = rastgele.Next(101);
            MessageBox.Show("Aklımdan Bir Sayı Tuttun.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int tahmin = Convert.ToInt32(textBox1.Text);
                if (tahmin < sayi)
                {
                    MessageBox.Show("Daha Büyük Bir Sayı Tahmin Ediniz ↑");
                    skor = skor - 10;
                }
                else if (tahmin > sayi)
                {
                    MessageBox.Show("Daha Küçük Bir Sayı Tahmin Ediniz ↓");
                    skor = skor - 10;
                }
                else
                {
                    MessageBox.Show("Tebrikler. :)");
                }

                if (skor == 0)
                {
                    MessageBox.Show("Üzgünüm Bulmadınız. :(");
                    button2.Enabled = false;
                }
                label1.Text = "Skor : " + skor.ToString();
                textBox1.Clear();
            }
            catch
            {
                MessageBox.Show("Girdiğiniz Sayıları Kontrol Edin");
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int tahmin = Convert.ToInt32(textBox1.Text);
                    if (tahmin < sayi)
                    {
                        MessageBox.Show("Daha Büyük Bir Sayı Tahmin Ediniz ↑");
                        skor = skor - 10;
                    }
                    else if (tahmin > sayi)
                    {
                        MessageBox.Show("Daha Küçük Bir Sayı Tahmin Ediniz ↓");
                        skor = skor - 10;
                    }
                    else
                    {
                        MessageBox.Show("Tebrikler. :)");
                    }

                    if (skor == 0)
                    {
                        MessageBox.Show("Üzgünüm Bulmadınız. :(");
                        button2.Enabled = false;
                    }
                    label1.Text = "Skor : " + skor.ToString();
                    textBox1.Clear();
                }
            }
            catch 
            {
                MessageBox.Show("Girdiğiniz Sayıları Kontrol Edin");
            }
        }
    }
}
