using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AIM_PROJESİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        
        int health = 5;
        int score = 0;
        int time = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            label4.Text = Convert.ToString(time);

            if (time == 0)
            {
                timer1.Stop();
                MessageBox.Show($"Süre bitti! Skorunm nuz: {score}");
                Application.Restart();
            }
        }

            


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
            score++;
            
            Random random = new Random();
            int location_X = random.Next(50,1180);
            int location_Y = random.Next(80, 630);
            pictureBox1.Location = new Point(location_X, location_Y);
            label6.Text = Convert.ToString(score);
            panel1.Enabled = true;

            if(score > 10 && score%2==0 && score <=30)
            {
                pictureBox2.Visible = true;
          
                int location_zX = random.Next(50, 1180);
                int location_zY = random.Next(80, 630);
                pictureBox2.Location = new Point(location_zX, location_zY);

                location_X = random.Next(50, 1180);
                location_Y = random.Next(80, 630);
                pictureBox1.Location = new Point(location_X, location_Y);
            }
            else if(score > 10 && score % 2 == 1 && score <= 30) { 
                pictureBox2.Visible = false;

            }
            else if(score>30)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
            }
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            health--;
            label5.Text = Convert.ToString(health);

            if(health == 0)
            {
                timer1.Stop();
                MessageBox.Show($"Hiç canınız kalmadı! Skorunuz: {score}");
                Application.Restart();

            }

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            health--;
            label5.Text = Convert.ToString(health);
        }

        
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            
            score--;
            label6.Text = Convert.ToString(score);

        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {   
            
            score++;
            label6.Text = Convert.ToString(score);

            Random random = new Random();
            int location_X = random.Next(70, 1060);
            int location_Y = random.Next(120, 590);

            int value = random.Next(1, 3);
            if (value == 1)
            {
                int GreenLocationY = random.Next(-50, -10);
                int GreenLocationX = random.Next(-50, 100);
                pictureBox4.Location = new Point(location_X + GreenLocationX, location_Y + GreenLocationY);

            }
            else if (value == 2)
            {
                int GreenLocationY = random.Next(10, 50);
                int GreenLocationX = random.Next(-50, 100); 
                pictureBox4.Location = new Point(location_X + GreenLocationX, location_Y + GreenLocationY);

            }

            pictureBox3.Location = new Point(location_X, location_Y);
        }

    }
}
