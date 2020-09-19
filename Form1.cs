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
        private int step = 2;
        private int horVelocity = 0;
        private int verVelocity = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {
                horVelocity = -step;
                verVelocity = 0;
            }
            else if(e.KeyCode == Keys.D)
            {
                horVelocity = step;
                verVelocity = 0;
            }
            else if(e.KeyCode == Keys.W)
            {
                horVelocity = 0;
                verVelocity = -step;
            }
            else if(e.KeyCode == Keys.S)
            {
                horVelocity = 0;
                verVelocity = step;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hero.Left += horVelocity;
            Hero.Top += verVelocity;
            HeroBorderCollision();
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

    }
}
