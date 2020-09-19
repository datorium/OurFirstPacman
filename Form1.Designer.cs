namespace OurFirstPacman
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.Hero = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.Black;
            this.ButtonStart.Font = new System.Drawing.Font("Snap ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonStart.Location = new System.Drawing.Point(95, 213);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(400, 181);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "START GAME";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // Hero
            // 
            this.Hero.BackColor = System.Drawing.Color.Yellow;
            this.Hero.Location = new System.Drawing.Point(95, 56);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(81, 80);
            this.Hero.TabIndex = 1;
            this.Hero.TabStop = false;
            this.Hero.Visible = false;
            // 
            // Enemy
            // 
            this.Enemy.BackColor = System.Drawing.Color.Blue;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 478);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Hero);
            this.Controls.Add(this.ButtonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox Enemy;
        private System.Windows.Forms.PictureBox Food;
    }
}

