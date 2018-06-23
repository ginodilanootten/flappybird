namespace flippybird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ground1 = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.endText1 = new System.Windows.Forms.Label();
            this.endText2 = new System.Windows.Forms.Label();
            this.gameDesigner = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom2 = new System.Windows.Forms.PictureBox();
            this.pipeTop2 = new System.Windows.Forms.PictureBox();
            this.pipeTop3 = new System.Windows.Forms.PictureBox();
            this.pipeBottom3 = new System.Windows.Forms.PictureBox();
            this.ground2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).BeginInit();
            this.SuspendLayout();
            // 
            // ground1
            // 
            resources.ApplyResources(this.ground1, "ground1");
            this.ground1.Name = "ground1";
            this.ground1.TabStop = false;
            // 
            // pipeTop
            // 
            resources.ApplyResources(this.pipeTop, "pipeTop");
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pipeBottom, "pipeBottom");
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 15;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreText
            // 
            this.scoreText.BackColor = System.Drawing.Color.Chartreuse;
            resources.ApplyResources(this.scoreText, "scoreText");
            this.scoreText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreText.Name = "scoreText";
            // 
            // endText1
            // 
            resources.ApplyResources(this.endText1, "endText1");
            this.endText1.Name = "endText1";
            this.endText1.Click += new System.EventHandler(this.endText1_Click);
            // 
            // endText2
            // 
            resources.ApplyResources(this.endText2, "endText2");
            this.endText2.Name = "endText2";
            this.endText2.Click += new System.EventHandler(this.endText2_Click);
            // 
            // gameDesigner
            // 
            this.gameDesigner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.gameDesigner, "gameDesigner");
            this.gameDesigner.Name = "gameDesigner";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chartreuse;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.flappyBird, "flappyBird");
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.TabStop = false;
            // 
            // pipeBottom2
            // 
            this.pipeBottom2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pipeBottom2, "pipeBottom2");
            this.pipeBottom2.Name = "pipeBottom2";
            this.pipeBottom2.TabStop = false;
            // 
            // pipeTop2
            // 
            resources.ApplyResources(this.pipeTop2, "pipeTop2");
            this.pipeTop2.Name = "pipeTop2";
            this.pipeTop2.TabStop = false;
            // 
            // pipeTop3
            // 
            resources.ApplyResources(this.pipeTop3, "pipeTop3");
            this.pipeTop3.Name = "pipeTop3";
            this.pipeTop3.TabStop = false;
            // 
            // pipeBottom3
            // 
            this.pipeBottom3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pipeBottom3, "pipeBottom3");
            this.pipeBottom3.Name = "pipeBottom3";
            this.pipeBottom3.TabStop = false;
            // 
            // ground2
            // 
            resources.ApplyResources(this.ground2, "ground2");
            this.ground2.Name = "ground2";
            this.ground2.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ground2);
            this.Controls.Add(this.ground1);
            this.Controls.Add(this.gameDesigner);
            this.Controls.Add(this.endText2);
            this.Controls.Add(this.endText1);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom3);
            this.Controls.Add(this.pipeBottom2);
            this.Controls.Add(this.pipeTop3);
            this.Controls.Add(this.pipeTop2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inGameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ground1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ground1;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label endText1;
        private System.Windows.Forms.Label endText2;
        private System.Windows.Forms.Label gameDesigner;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom2;
        private System.Windows.Forms.PictureBox pipeTop2;
        private System.Windows.Forms.PictureBox pipeTop3;
        private System.Windows.Forms.PictureBox pipeBottom3;
        private System.Windows.Forms.PictureBox ground2;
    }
}

