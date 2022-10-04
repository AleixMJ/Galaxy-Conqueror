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

            if (e.KeyCode == Keys.Space)
            {
                ShootBullet();
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
            fighter.Top = 0;
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
            energy.Top = randNum.Next(10, this.ClientSize.Height - energy.Height);
            energy.Tag = "energy";
            this.Controls.Add(energy);
            energy.BringToFront();
            player.BringToFront();
        }


        private void RestartGame()
        {

        }
    }
}
