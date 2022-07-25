using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        Random rnd=new Random();
        
        public Form1()
        {
            InitializeComponent();
            //TİMER BASLADIGI ZAMAN ATLAR RASGELE BİR SAYIYA GÖRE HAREKET EDECEK.
            //PİCTURE BOXIN SAĞININ KONUMU LABELİN SOLUNNUN KONUMUNA DEĞDİĞİ ZAMAN OYUN BİTECEK
            // OYUN BİTİŞİNDE 1,2,3 AT KAZANDI YAZISI EKRANDA GÖSTERİLECEK
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            SoundPlayer ses = new SoundPlayer();
            string dizin = Application.StartupPath + "//atYarisi.wav";
            ses.SoundLocation = dizin;
            ses.Play();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += rnd.Next(1, 25);
            pictureBox2.Left += rnd.Next(1, 25);
            pictureBox3.Left += rnd.Next(1, 25);
            //SoundPlayer ses = new SoundPlayer();
            //string dizin = Application.StartupPath + "//atYarisi.wav";
            //ses.SoundLocation = dizin;
            //ses.Play();
            if (pictureBox1.Right>=label1.Left)
            {
                timer1.Stop();
                //ses.Stop();
                DialogResult dr = MessageBox.Show("1. At yarısı kazandı tekrar oynamak istermisiniz?"," At Yarışı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr==DialogResult.Yes)
                {
                    pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = 0;
                    timer1.Start();
                }
                else
                {
                    Close();
                }
            }
            else if (pictureBox2.Right>=label1.Left)
            {
                timer1.Stop();
               // ses.Stop();
                DialogResult dr = MessageBox.Show("2. At yarısı kazandı tekrar oynamak istermisiniz?", " At Yarışı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = 0;
                    timer1.Start();
                }
                else
                {
                    Close();
                }
            }
            else if (pictureBox3.Right>=label1.Left)
            {
                timer1.Stop();
                //ses.Stop();
                DialogResult dr = MessageBox.Show("3. At yarısı kazandı tekrar oynamak istermisiniz?", " At Yarışı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pictureBox1.Left = pictureBox2.Left = pictureBox3.Left = 0;
                    timer1.Start();
                }
                else
                {
                    Close();
                }
            }
        }
    }
}
