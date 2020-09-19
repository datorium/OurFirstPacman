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
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Here we go!");
            Hero.Visible = true;
            Enemy.Visible = true;
            Food.Visible = true;
            ButtonStart.Visible = false;
            Hero.Top = 200;
            Hero.Left = 150;
        }
    }
}
