using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Görev_Hatırlatıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer analog_timer = new Timer();
        int WIDTH = 300, HEIGHT = 300, secHAND = 140, minHAND = 110, hrHAND = 80;
        //center
        int cx, cy;
        Bitmap bmp;
        Graphics g;
        DateTime analog;
        List<string> liste = new List<string>();
        String sound_path="";

        private void Form1_Load(object sender, EventArgs e)
        {
            path.Text = "";

            //create bitmap
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            //center
            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            //timer
            analog_timer.Interval = 1000;
            analog_timer.Tick += new EventHandler(this.analog_timer_Tick);
            analog_timer.Start();

            dijital_timer.Start();

            //get time
            analog = DateTime.Now;
        }

        private void takvim_DateSelected(object sender, DateRangeEventArgs e)
        {
            tarih.Text = takvim.SelectionRange.Start.ToString();
        }
        
        private void tarih_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DateTime temp = Convert.ToDateTime(tarih.Text);
                    takvim.SetDate(temp);
                }catch(Exception hata)
                {
                    MessageBox.Show("Girdiğiniz format uyumsuz!","Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(konu.Text!="" && tarih.Text != "")
            {
                liste.Add(konu.Text);
                gorevler.Items.Add(tarih.Text);
                gorev_kontrol.Start();
                tarih.Text = "";
                konu.Text = "";
            }
            else
            {
                MessageBox.Show("Tarih ve Konu boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ses_sec.ShowDialog() == DialogResult.OK)
            {
                sound_path = ses_sec.FileName;
                path.Text = "Uyarı Sesi :"+ses_sec.SafeFileName;
            }
            else
            {
                sound_path = "";
                path.Text = "";
            }
        }

        private void gorev_kontrol_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < gorevler.Items.Count; i++)
            {
                String date = gorevler.Items[i].ToString();
                DateTime temp = Convert.ToDateTime(date);
                if(DateTime.Now.Year == temp.Year && DateTime.Now.Month == temp.Month && DateTime.Now.Day == temp.Day && 
                    DateTime.Now.Hour == temp.Hour && DateTime.Now.Minute == temp.Minute)
                {
                    String konu = liste[i];
                    if (sound_path != "")
                    {
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(sound_path);
                        player.Play();
                    }
                    gorevler.Items.RemoveAt(i);
                    liste.RemoveAt(i);
                    MessageBox.Show(konu, "Görev Zamanı Geldi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        private void dijital_Tick(object sender, EventArgs e)
        {
            dijital_zaman.Text = ": " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void analog_timer_Tick(object sender, EventArgs e)
        {

            //create graphics
            g = Graphics.FromImage(bmp);

            analog = analog.AddSeconds(1);

            int ss = analog.Second;
            int mm = analog.Minute;
            int hh = analog.Hour;

            int[] handCoord = new int[2];

            //clear
            g.Clear(Color.WhiteSmoke);

            //draw circle
            g.DrawEllipse(new Pen(Color.Black, 2f), 0, 0, WIDTH, HEIGHT);

            //draw figure
            g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(284, 140));
            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 278));
            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            //second hand
            handCoord = msCoord(ss, secHAND);
            g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //minute hand
            handCoord = msCoord(mm, minHAND);
            g.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //hour hand
            handCoord = hrCoord(hh % 12, mm, hrHAND);
            g.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

            //load bmp in picturebox1
            pictureBox1.Image = bmp;

            //disp time
            analog_zaman.Text = ": "+ hh + ":" + mm + ":" + ss;

            //dispose
            g.Dispose();
        }
        
        //coord for minute and second hand
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6;   //each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        //coord for hour hand
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            //each hour makes 30 degree
            //each min makes 0.5 degree
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }
    }
}