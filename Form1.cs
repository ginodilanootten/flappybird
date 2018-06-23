using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flippybird
{
    public partial class Form1 : Form
    {
        // Start core variable voor de game
        bool jumping = false;
        int pipeSpeed = 3;
        int gravity = 5;
        int Inscore = 0;
        private object pipetop3;

        // Einde core variable voor de game

        public Form1()
        {
            InitializeComponent();

            // Start text van de game
            endText1.Text = "Game over!";
            endText2.Text = "Doei.";
            gameDesigner.Text = "Game is ontwikkeld door Gino";
            endText1.Visible = false;
            endText2.Visible = false;
            // Einde text van de game
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            scoreText.Text = "" + Inscore;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            pipeBottom2.Left -= pipeSpeed;
            pipeTop2.Left -= pipeSpeed;
            pipeBottom3.Left -= pipeSpeed;
            pipeTop3.Left -= pipeSpeed;
            flappyBird.Top += gravity;
            ground1.Left -= pipeSpeed;
            ground2.Left -= pipeSpeed;

            if (flappyBird.Bounds.IntersectsWith(ground1.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop2.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom2.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeTop3.Bounds))
            {
                endGame();
            }
            else if (flappyBird.Bounds.IntersectsWith(pipeBottom3.Bounds))
            {
                endGame();
            }


            if (pipeBottom.Left < -80)
            {
                pipeBottom.Left = 1000;
                Inscore += 1;
            }
            else if (pipeTop.Left < -80)
            {
                pipeTop.Left = 1000;
            }
            if (pipeBottom2.Left < -80)
            {
                Inscore += 1; 
                pipeBottom2.Left = 1000;
            }
            else if (pipeTop2.Left < -80)
            {
                pipeTop2.Left = 1000;
                Inscore += 1;
            }
            if (pipeBottom3.Left < -80)
            {
                pipeBottom3.Left = 1000;
            }
            else if (pipeTop3.Left < -80)
            {
                pipeTop3.Left = 1000;
                Inscore += 1;
                pipeSpeed += 1;
            }
            // grond

            if (ground1.Left < -571)
            {
                ground1.Left = 565;
            }
            else if (ground2.Left < -571)
            {
                ground2.Left = 565;
            }

        }

        private void inGameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                jumping = true;
                gravity = -5;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                jumping = false;
                gravity = 5;
            }
        }

        private void endGame ()
        {
            gameTimer.Stop();
            endText1.Visible = true;
            endText2.Visible = true;
            gameDesigner.Visible = true;
        }
        private void endText1_Click(object sender, EventArgs e)
        {

        }

        private void endText2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        } 
    }
}
