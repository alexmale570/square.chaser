using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace square.chaser
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(165, 120, 40, 40);
        Rectangle player2 = new Rectangle(360, 120, 40, 40);
        Rectangle ball = new Rectangle(295, 195, 10, 10);
        Rectangle speedOrb = new Rectangle(170, 200, 10, 10);

        int player1Score = 0;
        int player2Score = 0;

        int player1Speed = 2;
        int player2Speed = 2;
        int ballSpot;
        int speedSpot;


        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftDown = false;
        bool rightDown = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush SolidBrush = new SolidBrush(Color.Orange);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

        Random ballLoca = new Random();
        Random speedMvmt = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {

            //move player 1 
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }
            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }
            if (aDown == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }
            if (dDown == true && player1.X < this.Height - player1.Height)
            {
                player1.X += player1Speed;
            }


            //move player 2 
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }
            if (leftDown == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }

            if (rightDown == true && player2.X < this.Height - player2.Height)
            {
                player2.X += player2Speed;
            }

            if (player1.IntersectsWith(ball))
            {
                ballSpot = ballLoca.Next(1, 11);
                p1Score.Text = $"{player1Score++}";
                //insert sound later

                if (ballSpot == 1)
                {
                    ball.X = 180;
                    ball.Y = 265;
                }
            }
            if (player2.IntersectsWith(ball))
            {
                ballSpot = ballLoca.Next(1, 11);
                p2Score.Text = $"{player2Score++}";
                //insert sound later

                if (ballSpot == 1)
                {
                    ball.X = 180;
                    ball.Y = 265;
                }
                else if (ballSpot == 2)
                {
                    ball.Y = 234;
                    ball.X = 123;
                }
                else if (ballSpot == 3)
                {
                    ball.Y = 269;
                    ball.X = 400;
                }
                else if (ballSpot == 4)
                {
                    ball.Y = 369;
                    ball.X = 193;
                }
                else if (ballSpot == 5)
                {
                    ball.Y = 394;
                    ball.X = 67;
                }
                else if (ballSpot == 6)
                {
                    ball.Y = 39;
                    ball.X = 169;
                }
                else if (ballSpot == 7)
                {
                    ball.Y = 294;
                    ball.X = 189;
                }
                else if (ballSpot == 8)
                {
                    ball.Y = 294;
                    ball.X = 189;
                }
                else if (ballSpot == 9)
                {
                    ball.Y = 278;
                    ball.X = 293;
                }
                else if (ballSpot == 10)
                {
                    ball.Y = 291;
                    ball.X = 193;
                }
            }
            if (player1.IntersectsWith(speedOrb))
            {
                player1Speed++;
                speedSpot = speedMvmt.Next(1, 11);
                p2Score.Text = $"{player2Score}";
                //insert sound later

                if (speedSpot == 1)
                {
                    speedOrb.X = 120;
                    speedOrb.Y = 215;
                }
                else if (speedSpot == 2)
                {
                    speedOrb.X = 157;
                    speedOrb.Y = 245;
                }
                else if (speedSpot == 3)
                {
                    speedOrb.X = 180;
                    speedOrb.Y = 345;
                }
                else if (speedSpot == 4)
                {
                    speedOrb.X = 190;
                    speedOrb.Y = 375;
                }
                else if (speedSpot == 5)
                {
                    speedOrb.X = 356;
                    speedOrb.Y = 299;
                }
                else if (speedSpot == 6)
                {
                    speedOrb.X = 367;
                    speedOrb.Y = 399;
                }
                else if (speedSpot == 7)
                {
                    speedOrb.X = 220;
                    speedOrb.Y = 295;
                }
                else if (speedSpot == 8)
                {
                    speedOrb.X = 128;
                    speedOrb.Y = 269;
                }
                else if (speedSpot == 9)
                {
                    speedOrb.X = 390;
                    speedOrb.Y = 325;
                }
                else if (speedSpot == 10)
                {
                    speedOrb.X = 356;
                    speedOrb.Y = 123;
                }
            }

            if (player2.IntersectsWith(speedOrb))
            {
                player2Speed++;
                speedSpot = speedMvmt.Next(1, 11);
                p2Score.Text = $"{player2Score}";
                //insert sound later

                if (speedSpot == 1)
                {
                    speedOrb.X = 120;
                    speedOrb.Y = 215;
                }
            }
            // check score and stop game if either player is at 3 
            if (player1Score == 8)
            {
                GameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1 Wins!!";
            }
            else if (player2Score == 8)
            {
                GameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";
            }

            Refresh();



        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(SolidBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, ball);
            e.Graphics.FillRectangle(yellowBrush, speedOrb);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
