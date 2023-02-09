
namespace _15._04._2021
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
            this.Player = new System.Windows.Forms.PictureBox();
            this.Pillar1 = new System.Windows.Forms.PictureBox();
            this.Pillar2 = new System.Windows.Forms.PictureBox();
            this.UFO = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFO)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::_15._04._2021.Properties.Resources.Halicopter;
            this.Player.Location = new System.Drawing.Point(55, 31);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(100, 54);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Pillar1
            // 
            this.Pillar1.BackColor = System.Drawing.Color.Transparent;
            this.Pillar1.Image = global::_15._04._2021.Properties.Resources.pillar;
            this.Pillar1.Location = new System.Drawing.Point(335, -6);
            this.Pillar1.Name = "Pillar1";
            this.Pillar1.Size = new System.Drawing.Size(56, 150);
            this.Pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pillar1.TabIndex = 1;
            this.Pillar1.TabStop = false;
            this.Pillar1.Tag = "Pillar";
            // 
            // Pillar2
            // 
            this.Pillar2.BackColor = System.Drawing.Color.Transparent;
            this.Pillar2.Image = global::_15._04._2021.Properties.Resources.pillar;
            this.Pillar2.Location = new System.Drawing.Point(495, 246);
            this.Pillar2.Name = "Pillar2";
            this.Pillar2.Size = new System.Drawing.Size(56, 150);
            this.Pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pillar2.TabIndex = 2;
            this.Pillar2.TabStop = false;
            this.Pillar2.Tag = "Pillar";
            // 
            // UFO
            // 
            this.UFO.BackColor = System.Drawing.Color.Transparent;
            this.UFO.Image = global::_15._04._2021.Properties.Resources.alien1;
            this.UFO.Location = new System.Drawing.Point(548, 93);
            this.UFO.Name = "UFO";
            this.UFO.Size = new System.Drawing.Size(68, 72);
            this.UFO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.UFO.TabIndex = 3;
            this.UFO.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(642, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(46, 17);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.UFO);
            this.Controls.Add(this.Pillar2);
            this.Controls.Add(this.Pillar1);
            this.Controls.Add(this.Player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UFO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Pillar1;
        private System.Windows.Forms.PictureBox Pillar2;
        private System.Windows.Forms.PictureBox UFO;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblScore;
    }
}

