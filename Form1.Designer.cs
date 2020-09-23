﻿namespace OurFirstPacman
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Hero = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonStart = new System.Windows.Forms.Button();
            this.timerHero = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            this.SuspendLayout();
            // 
            // Hero
            // 
            this.Hero.BackColor = System.Drawing.Color.Yellow;
            this.Hero.Location = new System.Drawing.Point(74, 56);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(80, 80);
            this.Hero.TabIndex = 1;
            this.Hero.TabStop = false;
            this.Hero.Visible = false;
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Enemy.Location = new System.Drawing.Point(238, 56);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(81, 80);
            this.Enemy.TabIndex = 2;
            this.Enemy.TabStop = false;
            this.Enemy.Visible = false;
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.Lime;
            this.Food.Location = new System.Drawing.Point(403, 56);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(81, 80);
            this.Food.TabIndex = 3;
            this.Food.TabStop = false;
            this.Food.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonStart.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonStart.Location = new System.Drawing.Point(158, 191);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(273, 139);
            this.ButtonStart.TabIndex = 4;
            this.ButtonStart.Text = "Start Game";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // timerHero
            // 
            this.timerHero.Tick += new System.EventHandler(this.timerHero_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 478);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Hero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox Food;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Timer timerHero;
    }
}

