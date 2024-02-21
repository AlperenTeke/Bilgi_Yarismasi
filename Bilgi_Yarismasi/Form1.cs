using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogruSayi = 0, yanlisSayi = 0;

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (lbl_soruNo.Text == "1")
            {
                dogruSayi++;
                lbl_dogru.Text = dogruSayi.ToString();
            }
            else
            {
                yanlisSayi++;
                lbl_yanlis.Text = yanlisSayi.ToString();
            }
            btn_1.Enabled = btn_2.Enabled = btn_3.Enabled = btn_4.Enabled = false;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            yanlisSayi++;
            lbl_yanlis.Text = yanlisSayi.ToString();
            btn_1.Enabled = btn_2.Enabled = btn_3.Enabled = btn_4.Enabled = false;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (lbl_soruNo.Text == "2")
            {
                dogruSayi++;
                lbl_dogru.Text = dogruSayi.ToString();
            }
            else
            {
                yanlisSayi++;
                lbl_yanlis.Text = yanlisSayi.ToString();
            }
            btn_1.Enabled = btn_2.Enabled = btn_3.Enabled = btn_4.Enabled = false;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (lbl_soruNo.Text == "3")
            {
                dogruSayi++;
                lbl_dogru.Text = dogruSayi.ToString();
            }
            else
            {
                yanlisSayi++;
                lbl_yanlis.Text = yanlisSayi.ToString();
            }
            btn_1.Enabled = btn_2.Enabled = btn_3.Enabled = btn_4.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_1.Enabled = btn_2.Enabled = btn_3.Enabled = btn_4.Enabled = false;
            pictureBox1.Visible = pictureBox2.Visible = false;
            lbl_soruNo.Text = soruNo.ToString();
            richTextBox1.Text = "Başlamak İçin Sonraki Soruya Geçiniz. Bol Şans!";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            soruNo++;

            if (soruNo <= 3)
            {
                string[] sorular =
                {
            "Bilgisayar belleği (RAM), hangi tür bir bellek tipine örnektir?",
            "Bir bilgisayarın işletim sistemi nedir?",
            "Bilgisayar ağlarında bilgilerin iletimi için kullanılan kablosuz iletişim standartı hangisidir?"
        };

                lbl_soruNo.Text = soruNo.ToString();
                switch (soruNo)
                {
                    case 1:
                        //ROM, Cache, Flash, Hard Disk - A
                        richTextBox1.Text = sorular[0];
                        btn_1.Text = "ROM";
                        btn_2.Text = "Cache";
                        btn_3.Text = "Flash";
                        btn_4.Text = "Hard Disk";
                        break;
                    case 2:
                        //Microsoft Office, Adobe Photoshop, Windows, Google Chrome - C
                        richTextBox1.Text = sorular[1];
                        btn_1.Text = "Microsoft Office";
                        btn_2.Text = "Adobe Photoshop";
                        btn_3.Text = "Windows";
                        btn_4.Text = "Google Chrome";
                        break;
                    case 3:
                        //Ethernet, USB, Bluetooth, Wİ-Fİ - D
                        richTextBox1.Text = sorular[2];
                        btn_1.Text = "Ethernet";
                        btn_2.Text = "USB";
                        btn_3.Text = "Bluetooth";
                        btn_4.Text = "Wifi";
                        break;
                }
                btn_1.Enabled = btn_2.Enabled = btn_3.Enabled = btn_4.Enabled = true;
            }
            else if (soruNo == 4)
            {
                richTextBox1.Clear();
                btn_1.Enabled = btn_2.Enabled = btn_3.Enabled = btn_4.Enabled = false;
                btn_next.Text = "Sonuçları Görmek İçin Tıklayınız";
            }
            else
            {
                MessageBox.Show($"Dopru sayısı: {dogruSayi.ToString()} \n Yanlış Sayısı: {yanlisSayi.ToString()}","Sonuçlar",MessageBoxButtons.OK);
                Application.Exit();
            }
        }
    }
}
