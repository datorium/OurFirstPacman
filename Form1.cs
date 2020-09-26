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
        private int heroStep = 2;
        private int enemyStep = 1;
        private int heroHorVelocity = 0;
        private int heroVerVelocity = 0;

        private int enemyHorVelocity = 0;
        private int enemyVerVelocity = 0;
        private string enemyDirection = "down";

        private string heroDirection = "right";
        private int heroImageCount = 1;
        private int foodImageCount = 1;
        private int enemyImageCount = 1;

        private bool heroIsPredator = false;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            timerHero.Start();
            timerEnemy.Start();

            this.BackColor = Color.Blue;
            Hero.BackColor = Color.Transparent;
            Hero.SizeMode = PictureBoxSizeMode.StretchImage;

            Food.BackColor = Color.Transparent;
            Food.SizeMode = PictureBoxSizeMode.StretchImage;
            Food.Image = (Image)Properties.Resources.ResourceManager.GetObject("food_1");

            Enemy.BackColor = Color.Transparent;
            Enemy.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                heroHorVelocity = -heroStep;
                heroVerVelocity = 0;
                heroDirection = "left";
            }
            else if(e.KeyCode == Keys.D)
            {
                heroHorVelocity = heroStep;
                heroVerVelocity = 0;
                heroDirection = "right";
            }
            else if(e.KeyCode == Keys.W)
            {
                heroHorVelocity = 0;
                heroVerVelocity = -heroStep;
                heroDirection = "up";
            }
            else if(e.KeyCode == Keys.S)
            {
                heroHorVelocity = 0;
                heroVerVelocity = heroStep;
                heroDirection = "down";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveHero();
            MoveEnemy();
            EnemyBorderCollision();
            HeroBorderCollision();
            HeroEnemyCollision();
            HeroFoodCollision();
            HeroWallCollision();
        }

        private void MoveHero()
        {
            Hero.Left += heroHorVelocity;
            Hero.Top += heroVerVelocity;
        }

        private void MoveEnemy()
        {
            Enemy.Left += enemyHorVelocity;
            Enemy.Top += enemyVerVelocity;

            if (enemyDirection == "right")
            {
                enemyHorVelocity = enemyStep;
                enemyVerVelocity = 0;
            }
            else if (enemyDirection == "left")
            {
                enemyHorVelocity = -enemyStep;
                enemyVerVelocity = 0;
            }
            else if (enemyDirection == "down")
            {
                enemyVerVelocity = enemyStep;
                enemyHorVelocity = 0;
            }
            else if (enemyDirection == "up")
            {
                enemyVerVelocity = -enemyStep;
                enemyHorVelocity = 0;
            }
        }

        private void EnemyBorderCollision()
        {
            if (Enemy.Left + Enemy.Width < 0)
            {
                Enemy.Left = ClientRectangle.Width;
            }
            if (Enemy.Left > ClientRectangle.Width)
            {
                Enemy.Left = 0 - Enemy.Width;
            }
            if (Enemy.Top + Enemy.Height < 0)
            {
                Enemy.Top = ClientRectangle.Height;
            }
            if (Enemy.Top > ClientRectangle.Height)
            {
                Enemy.Top = 0 - Enemy.Height;
            }
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

                if(foodImageCount == 4)
                {
                    heroIsPredator = true;
                }
                else
                {
                    heroIsPredator = false;
                }

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

            foreach(Control c in Controls)
            {
                if((string)c.Tag == "wall")
                {
                    c.Visible = true;
                }
            }

            ButtonStart.Visible = false;
            this.Focus();
            timer1.Start();
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

        private void HeroWallCollision()
        {
            foreach(Control c in Controls)
            {
                if((string)c.Tag == "wall")
                {
                    if (c.Bounds.IntersectsWith(Hero.Bounds))
                    {
                        heroHorVelocity = 0;
                        heroVerVelocity = 0;
                    }
                }
            }
        }

        private void timerEnemy_Tick(object sender, EventArgs e)
        {
            string imageName;
            imageName = "enemy_" + enemyDirection + "_" + enemyImageCount;
            Enemy.Image = (Image)Properties.Resources.ResourceManager.GetObject(imageName);
            enemyImageCount += 1;
            if (enemyImageCount > 2)
            {
                enemyImageCount = 1;
            }

            if (Hero.Left - Enemy.Left > Hero.Top - Enemy.Top && Hero.Left - Enemy.Left > 0)
            {
                enemyDirection = "right";
            }
            else if (Hero.Left - Enemy.Left < Hero.Top - Enemy.Top && Hero.Left - Enemy.Left < 0)
            {
                enemyDirection = "left";
            }
            else if (Hero.Top - Enemy.Top > 0)
            {
                enemyDirection = "down";
            }
            else if (Hero.Top - Enemy.Top < 0)
            {
                enemyDirection = "up";
            }
        }
    }
}
