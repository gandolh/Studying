using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15._04._2021
{
    public partial class Form1 : Form
    {
        bool goUp, goDown, shot, gameOver;
        int score = 0;
        int speed = 8, UFOspeed =10;
        Random rand = new Random();
        int playerSpeed = 7;
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W) 
            { 
                goUp = true;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                goDown = true;
            if (e.KeyCode == Keys.Space && shot == false)
            {
                MakeBullet();
                shot = true;
            }
                
                
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
                goDown = false;

            if (shot == true)
                shot = false;

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }


        }

        private void RestartGame()
        {
            goUp = false;
            goDown = false;
            shot = false;
            gameOver = false;
            score = 0;
            speed = 8;
            UFOspeed = 10;
            playerSpeed = 7;
            index = 0;
            lblScore.Text = "Score: " + score;
            ChangeUFO();
            Player.Top = 55;
            GameTimer.Start();

        }
        private void GameOver()
        {
            GameTimer.Stop();
            lblScore.Text = "Score: " + score + "Game over.PRESS ENTER TO RETRY.";
            gameOver = true;
        }

        private void MakeBullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.BackColor = Color.Red;
            bullet.Height = 5;
            bullet.Width = 10;
            bullet.Left = Player.Left + Player.Width;
            bullet.Top = Player.Top + Player.Height/2;
            bullet.Tag = "bullet";
            this.Controls.Add(bullet);

        }

        private void ChangeUFO()
        {
            if (index > 3) index = 1;
            else index++;
            switch (index)
            {
                case 1:
                    UFO.Image = Properties.Resources.alien1;
                    break;
                case 2:
                    UFO.Image = Properties.Resources.alien2;
                    break;
                case 3:
                    UFO.Image = Properties.Resources.alien3;
                    break;
            }
            UFO.Left = 1000;
            UFO.Top = rand.Next(20,this.ClientSize.Height-UFO.Height);

        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            if (goUp == true && Player.Top > 0) 
                Player.Top -= playerSpeed;
            if (goDown == true && Player.Top + Player.Height < this.ClientSize.Height)
                Player.Top += playerSpeed;
            UFO.Left -= UFOspeed;
            if (UFO.Left + UFO.Width < 0) ChangeUFO();

            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string) x.Tag == "Pillar")
                {
                   // x.Left -= speed;
                    if (x.Left < -200)
                    {
                        x.Left = 1000;
                    }
                    if (Player.Bounds.IntersectsWith(x.Bounds)) GameOver();
                }
                if(x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;
                    if (x.Left > 900) removeBullet( (PictureBox) x );
                    if (UFO.Bounds.IntersectsWith(x.Bounds))
                    {
                        removeBullet((PictureBox)x);
                        score += 1;
                        ChangeUFO();
                    }
                }
            }

            if (Player.Bounds.IntersectsWith(UFO.Bounds)) GameOver();
            if(score > 10)
            {
                speed = 10;
                UFOspeed = 12;
            }
        }
        private void removeBullet(PictureBox bullet)
        {
            this.Controls.Remove(bullet);
            bullet.Dispose();
        }
    }
}
