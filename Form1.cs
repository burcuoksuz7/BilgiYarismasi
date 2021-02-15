using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiYarısması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btnA_Click(object sender, EventArgs e)
        {
           

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSıradaki.Enabled = true;

            label2.Text = btnA.Text;
            if(label1.Text==label2.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
           
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSıradaki.Enabled = true;

            label2.Text = btnB.Text;
                if (label1.Text == label2.Text)
                {
                    dogru++;
                    label5.Text = dogru.ToString();
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                    yanlis++;
                    label6.Text = yanlis.ToString();
                    pictureBox2.Visible = true;
                }
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSıradaki.Enabled = true;

            label2.Text = btnC.Text;
                if (label1.Text == label2.Text)
                {
                    dogru++;
                    label5.Text = dogru.ToString();
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                    yanlis++;
                    label6.Text = yanlis.ToString();
                    pictureBox2.Visible = true;
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSıradaki.Enabled = true;

            label2.Text = btnD.Text;
                if (label1.Text == label2.Text)
                {
                    dogru++;
                    label5.Text = dogru.ToString();
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                    yanlis++;
                    label6.Text = yanlis.ToString();
                    pictureBox2.Visible = true;
                }
            
        }

        private void btnSıradaki_Click(object sender, EventArgs e)
        {

            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSıradaki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //sonraki butonuna her basıldığında soru no 1-1 artsın
            soruno++;
            label4.Text = soruno.ToString();

            if (soruno==1)
            {
                richTextBox1.Text = "  Fatih Sultan Mehmet’in babası kimdir?";
                btnA.Text = "I. Mehmet";
                btnB.Text = "II. Murat";
                btnC.Text = "Yıldırım Beyazıt";
                btnD.Text = "I. Murat";
                label1.Text = "II. Murat";

             

            }
            if(soruno==2) 
            {
                richTextBox1.Text = "'Magna Carta' hangi ülkenin kralıyla yapılmış bir sözleşmedir?";

                btnA.Text = "İngiltere";
                btnB.Text = "Fransa";
                btnC.Text = "İspanya";
                btnD.Text = "İtalya";
                label1.Text = "İngiltere";
            }

            if (soruno==3)
            {
                richTextBox1.Text = "Hangisi periyodik tabloda bulunan bir element değildir?";
                btnA.Text = "Azot";
                btnB.Text = "Berilyum";
                btnC.Text = "Oksijen";
                btnD.Text = "Su";
                label1.Text = "Su";
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Hangisi tarihteki Türk devletlerinden biri değildir?";
                btnA.Text = "Emevi Devleti";
                btnB.Text = "Hun İmparatorluğu";
                btnC.Text = "Avar Kağanlığı";
                btnD.Text = "Hazar Devleti";
                label1.Text = "Emevi Devleti";
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Kıbrıs Barış harekatı hangi tarihte gerçekleşmiştir?";
                btnA.Text = "1970";
                btnB.Text = "1971";
                btnC.Text = "1972";
                btnD.Text = "1974";
                label1.Text = "1974";
            }

            if (soruno == 6)
            {
                richTextBox1.Text = "Tarihçilerin Kutbu olarak bilinen dünyaca ünlü tarihçimiz kimdir?";
                btnA.Text = "Halil İnalcık";
                btnB.Text = "Mehmet Fuat Köprülü";
                btnC.Text = "Orhan Seyfi";
                btnD.Text = "İlber Ortaylı";
                label1.Text = "Halil İnalcık";
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "Fransız İhtilali kaç yılında gerçekleşmiştir?";
                btnA.Text = "1768-1787";
                btnB.Text = "1876-1889";
                btnC.Text = "1789-1799";
                btnD.Text = "1783-1785";
                label1.Text = "1789-1799";
            }

            if (soruno == 8)
            {
                richTextBox1.Text = " Kuyucaklı Yusuf adlı eser kime aittir?";
                btnA.Text = "Yusuf Atılgan";
                btnB.Text = "Yaşar Kemal";
                btnC.Text = "Orhan Seyfi";
                btnD.Text = "Sabahattin Ali";
                label1.Text = "Sabahattin Ali";
            }

            if (soruno == 9)
            {
                richTextBox1.Text = "İstiklal Marşı hangi yıl yazılmıştır?";
                btnA.Text = "1919";
                btnB.Text = "1920";
                btnC.Text = "1921";
                btnD.Text = "1923";
                label1.Text = "1921";
            }

            if (soruno == 10)
            {
                richTextBox1.Text = "Türk Silahlı Kuvvetlerinde hangi rütbe daha yüksektir?";
                btnA.Text = "Tümgeneral";
                btnB.Text = "Tuğgeneral";
                btnC.Text = "Yarbay";
                btnD.Text = "Korgeneral";
                label1.Text = "Korgeneral";
                btnSıradaki.Text = ("SONUÇLAR");

           
                  
            }
            if (soruno == 11)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSıradaki.Enabled = false;
                MessageBox.Show("DOĞRU SAYISI: " + dogru + "\n" + "YANLIŞ SAYISI: " + yanlis);

            }

        }

    }
}
