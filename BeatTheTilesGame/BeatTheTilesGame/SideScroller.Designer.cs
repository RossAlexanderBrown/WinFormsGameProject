namespace BeatTheTilesGame
{
    partial class SideScroller
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.platform = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.health2 = new System.Windows.Forms.PictureBox();
            this.health3 = new System.Windows.Forms.PictureBox();
            this.health1 = new System.Windows.Forms.PictureBox();
            this.healthLabel = new System.Windows.Forms.Label();
            this.sideScrollTimer = new System.Windows.Forms.Timer(this.components);
            this.initEnemy = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightEdge = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEdge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Firebrick;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(6053, 402);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "background";
            // 
            // platform
            // 
            this.platform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.platform.Location = new System.Drawing.Point(0, 352);
            this.platform.Name = "platform";
            this.platform.Size = new System.Drawing.Size(782, 50);
            this.platform.TabIndex = 3;
            this.platform.TabStop = false;
            this.platform.Tag = "platform";
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Purple;
            this.player.Location = new System.Drawing.Point(12, 296);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // health2
            // 
            this.health2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.health2.Location = new System.Drawing.Point(103, 9);
            this.health2.Name = "health2";
            this.health2.Size = new System.Drawing.Size(20, 20);
            this.health2.TabIndex = 13;
            this.health2.TabStop = false;
            this.health2.Tag = "health2";
            // 
            // health3
            // 
            this.health3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.health3.Location = new System.Drawing.Point(129, 9);
            this.health3.Name = "health3";
            this.health3.Size = new System.Drawing.Size(20, 20);
            this.health3.TabIndex = 12;
            this.health3.TabStop = false;
            this.health3.Tag = "health3";
            // 
            // health1
            // 
            this.health1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.health1.Location = new System.Drawing.Point(77, 9);
            this.health1.Name = "health1";
            this.health1.Size = new System.Drawing.Size(20, 20);
            this.health1.TabIndex = 11;
            this.health1.TabStop = false;
            this.health1.Tag = "health1";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.BackColor = System.Drawing.Color.Firebrick;
            this.healthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.healthLabel.ForeColor = System.Drawing.Color.White;
            this.healthLabel.Location = new System.Drawing.Point(12, 9);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(58, 20);
            this.healthLabel.TabIndex = 10;
            this.healthLabel.Text = "Health";
            // 
            // sideScrollTimer
            // 
            this.sideScrollTimer.Enabled = true;
            this.sideScrollTimer.Interval = 1;
            this.sideScrollTimer.Tag = "sideScrollTimer";
            this.sideScrollTimer.Tick += new System.EventHandler(this.sideScrollerTick);
            // 
            // initEnemy
            // 
            this.initEnemy.BackColor = System.Drawing.Color.Gold;
            this.initEnemy.Location = new System.Drawing.Point(730, 312);
            this.initEnemy.Name = "initEnemy";
            this.initEnemy.Size = new System.Drawing.Size(14, 34);
            this.initEnemy.TabIndex = 14;
            this.initEnemy.TabStop = false;
            this.initEnemy.Tag = "enemy";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 402);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "leftEdge";
            // 
            // rightEdge
            // 
            this.rightEdge.Location = new System.Drawing.Point(832, 0);
            this.rightEdge.Name = "rightEdge";
            this.rightEdge.Size = new System.Drawing.Size(0, 402);
            this.rightEdge.TabIndex = 16;
            this.rightEdge.TabStop = false;
            this.rightEdge.Tag = "rightFinish";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(782, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(0, 402);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "rightEdge";
            // 
            // SideScroller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.rightEdge);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.initEnemy);
            this.Controls.Add(this.health2);
            this.Controls.Add(this.health3);
            this.Controls.Add(this.health1);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.player);
            this.Controls.Add(this.platform);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SideScroller";
            this.Tag = "sideScroller";
            this.Text = "SideScroller";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightEdge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox platform;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox health2;
        private System.Windows.Forms.PictureBox health3;
        private System.Windows.Forms.PictureBox health1;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Timer sideScrollTimer;
        private System.Windows.Forms.PictureBox initEnemy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox rightEdge;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}