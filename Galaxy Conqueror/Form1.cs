using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Galaxy_Conqueror
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, goUp, goDown, gameOver;
        int playerHealth = 100;
        int speed = 10;
        int playerEnergy = 100;
        int fighterSpeed = 3;
        int score;        
        Random randNum = new Random();

        List<PictureBox> fightersList = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 0)
            {
                healthBar.Value = playerHealth;
            }
            else 
            {
                gameOver = true;
                GameTimer.Stop();
            }

            txtScore.Text = "Score: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left  + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 75)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "energy")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        energyBar.Value = 100;
                        playerEnergy = 100;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "fighter")
                {
                    x.Top += 2;
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "fighter")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            fightersList.Remove(((PictureBox)x));


                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && playerEnergy > 0)
            {
                playerEnergy--;
                energyBar.Value --;
                ShootBullet();

                if (playerEnergy < 1)
                {
                    DropEnergy();
                }
            }
        }

        private void ShootBullet()
        {
            Bullet shootBullet = new Bullet();
            shootBullet.bulletLeft = player.Left + (player.Width /2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeFighters() 
        {
            PictureBox fighter = new PictureBox();
            fighter.Tag = "fighter";
            fighter.Image = Properties.Resources.Kla_ed___Fighter___Base;
            fighter.Left = randNum.Next(10, this.ClientSize.Width - fighter.Width);
            fighter.Top = -50;
            fighter.SizeMode = PictureBoxSizeMode.AutoSize;
            fightersList.Add(fighter);
            this.Controls.Add(fighter);
            player.BringToFront();
        }

        private void DropEnergy()
        {
            PictureBox energy = new PictureBox();
            energy.Image = Properties.Resources.energy;
            energy.SizeMode = PictureBoxSizeMode.AutoSize;
            energy.Left = randNum.Next(10, this.ClientSize.Width - energy.Width);
            energy.Top = randNum.Next(60, this.ClientSize.Height - energy.Height);
            energy.Tag = "energy";
            this.Controls.Add(energy);
            energy.BringToFront();
            player.BringToFront();
        }


        private void RestartGame()
        {
            player.Image = Properties.Resources.Main_Ship___Base___Full_health;

            foreach (PictureBox i in fightersList)
            {
                this.Controls.Remove(i);
            }

            fightersList.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeFighters();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;

            playerHealth = 100;
            playerEnergy = 100;
            score = 0;

            GameTimer.Start();

        }
    }
}
