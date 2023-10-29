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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi1, sayi2, sayi3, enBuyuk, enKucuk;
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
                sayi3 = Convert.ToInt32(textBox3.Text);

                if (sayi1 > sayi2 && sayi1 > sayi3)
                    enBuyuk = sayi1;
                else if (sayi2 > sayi3 && sayi2 > sayi1)
                    enBuyuk = sayi2;
                else
                    enBuyuk = sayi3;


                if (sayi1 < sayi2 && sayi1 < sayi3)
                    enKucuk = sayi1;
                else if (sayi2 < sayi3 && sayi2 < sayi1)
                    enKucuk = sayi2;
                else
                    enKucuk = sayi3;


                textBox4.Text = enBuyuk.ToString();
                textBox5.Text = enKucuk.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Girdiğiniz Sayıları Kontrol Edin");
            }


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int sayi1, sayi2, sayi3, enBuyuk, enKucuk;
                    sayi1 = Convert.ToInt32(textBox1.Text);
                    sayi2 = Convert.ToInt32(textBox2.Text);
                    sayi3 = Convert.ToInt32(textBox3.Text);

                    if (sayi1 > sayi2 && sayi1 > sayi3)
                        enBuyuk = sayi1;
                    else if (sayi2 > sayi3 && sayi2 > sayi1)
                        enBuyuk = sayi2;
                    else
                        enBuyuk = sayi3;


                    if (sayi1 < sayi2 && sayi1 < sayi3)
                        enKucuk = sayi1;
                    else if (sayi2 < sayi3 && sayi2 < sayi1)
                        enKucuk = sayi2;
                    else
                        enKucuk = sayi3;


                    textBox4.Text = enBuyuk.ToString();
                    textBox5.Text = enKucuk.ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("Girdiğiniz Sayıları Kontrol Edin");
                }

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int sayi1, sayi2, sayi3, enBuyuk, enKucuk;
                    sayi1 = Convert.ToInt32(textBox1.Text);
                    sayi2 = Convert.ToInt32(textBox2.Text);
                    sayi3 = Convert.ToInt32(textBox3.Text);

                    // En Büyük Sayı Bulam 
                    if (sayi1 > sayi2 && sayi1 > sayi3)
                        enBuyuk = sayi1;
                    else if (sayi2 > sayi3 && sayi2 > sayi1)
                        enBuyuk = sayi2;
                    else
                        enBuyuk = sayi3;

                    // En Küçük Sayı Bulam 
                    if (sayi1 < sayi2 && sayi1 < sayi3)
                        enKucuk = sayi1;
                    else if (sayi2 < sayi3 && sayi2 < sayi1)
                        enKucuk = sayi2;
                    else
                        enKucuk = sayi3;

                    textBox4.Text = enBuyuk.ToString();
                    textBox5.Text = enKucuk.ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("Girdiğiniz Sayıları Kontrol Edin");
                }

            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int sayi1, sayi2, sayi3, enBuyuk, enKucuk;
                    sayi1 = Convert.ToInt32(textBox1.Text);
                    sayi2 = Convert.ToInt32(textBox2.Text);
                    sayi3 = Convert.ToInt32(textBox3.Text);
                    // En Büyük Sayı Bulam 
                    if (sayi1 > sayi2 && sayi1 > sayi3)
                        enBuyuk = sayi1;
                    else if (sayi2 > sayi3 && sayi2 > sayi1)
                        enBuyuk = sayi2;
                    else
                        enBuyuk = sayi3;

                    // En Küçük Sayı Bulam 
                    if (sayi1 < sayi2 && sayi1 < sayi3)
                        enKucuk = sayi1;
                    else if (sayi2 < sayi3 && sayi2 < sayi1)
                        enKucuk = sayi2;
                    else
                        enKucuk = sayi3;

                    textBox4.Text = enBuyuk.ToString();
                    textBox5.Text = enKucuk.ToString();
                }
                catch
                {
                    MessageBox.Show("Girdiğiniz Sayıları Kontrol Edin");
                }
            }
        }
    }
}
