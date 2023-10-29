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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                if (sayi % 2 == 0)
                {
                    MessageBox.Show("Girilen Sayı Çift Sayıdır");

                }
                else
                {
                    MessageBox.Show("Girilen Sayı Tek Sayıdır");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Yanliş Bir Değer Giridiniz.");
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int sayi = Convert.ToInt32(textBox1.Text);
                    if (sayi % 2 == 0)
                    {
                        MessageBox.Show("Girilen Sayı Çift Sayıdır");

                    }
                    else
                    {
                        MessageBox.Show("Girilen Sayı Tek Sayıdır");

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Yanliş Bir Değer Giridiniz.");
                }
            }
        }
    }
}
