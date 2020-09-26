using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OurFirstPacman
{
    public partial class Form1 : Form
    {
        private int score = 0;
        private int step = 2;
        private int horHeroVelocity = 0;
        private int verHeroVelocity = 0;

        private int enemyHorVelocity = 0;
        private int enemyVerVelocity = 0;

        private string heroDirection = "right";
        private int heroImageCount = 1;
        private int foodImageCount = 1;

        private bool heroIsPredator = false;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timerHero.Start();

            this.BackColor = Color.Blue;
            Hero.BackColor = Color.Transparent;
            Hero.SizeMode = PictureBoxSizeMode.StretchImage;

            Food.BackColor = Color.Transparent;
            Food.SizeMode = PictureBoxSizeMode.StretchImage;
            Food.Image = (Image)Properties.Resources.ResourceManager.GetObject("food_1");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                horHeroVelocity = -step;
                verHeroVelocity = 0;
                heroDirection = "left";
            }
            else if(e.KeyCode == Keys.D)
            {
                horHeroVelocity = step;
                verHeroVelocity = 0;
                heroDirection = "right";
            }
            else if(e.KeyCode == Keys.W)
            {
                horHeroVelocity = 0;
                verHeroVelocity = -step;
                heroDirection = "up";
            }
            else if(e.KeyCode == Keys.S)
            {
                horHeroVelocity = 0;
                verHeroVelocity = step;
                heroDirection = "down";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hero.Left += horHeroVelocity;
            Hero.Top += verHeroVelocity;
            HeroBorderCollision();
            HeroEnemyCollision();
            HeroFoodCollision();
        }

        private void HeroFoodCollision()
        {
            string foodName;
            if (Hero.Bounds.IntersectsWith(Food.Bounds))
            {
                Food.Left = rand.Next(0, 401);
                Food.Top = rand.Next(0, 401);
                foodName = "food_" + foodImageCount;
                Food.Image = (Image)Properties.Resources.ResourceManager.GetObject(foodName);

                foodImageCount++;
                if(foodImageCount > 4)
                {
                    foodImageCount = 1;
                }

                UpdateScore(100);
            }
        }

        private void HeroBorderCollision()
        {
            if(Hero.Left + Hero.Width < 0)
            {
                Hero.Left = ClientRectangle.Width;
            }
            if(Hero.Left > ClientRectangle.Width)
            {
                Hero.Left = 0 - Hero.Width;
            }
            if(Hero.Top + Hero.Height < 0)
            {
                Hero.Top = ClientRectangle.Height;
            }
            if(Hero.Top > ClientRectangle.Height)
            {
                Hero.Top = 0 - Hero.Height;
            }
        }

        private void HeroEnemyCollision()
        {
            if (Hero.Bounds.IntersectsWith(Enemy.Bounds))
            {
                if (heroIsPredator)
                {
                    Enemy.Dispose();
                    UpdateScore(500);
                }
                else
                {
                    GameOver();
                }
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            MessageBox.Show("Game Over!");
        }

        private void UpdateScore(int scoreChange)
        {
            score += scoreChange;
            ScoreLabel.Text = "Score: " + score;
        }


        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Hero.Visible = true;
            Enemy.Visible = true;
            Food.Visible = true;

            ButtonStart.Visible = false;
            this.Focus();
        }

        private void timerHero_Tick(object sender, EventArgs e)
        {
            string imageName;
            imageName = "pacman_" + heroDirection + "_" + heroImageCount;
            Hero.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            heroImageCount += 1;
            if(heroImageCount > 4)
            {
                heroImageCount = 1;
            }
        }
    }
}
