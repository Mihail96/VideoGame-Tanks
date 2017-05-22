using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGame_Tanks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Player1.Body = P1;
            Player2.Body = P2;
            Projectile projectile1 = new Projectile(Projectile1, 1, 10, 10);
            Projectile projectile2 = new Projectile(Projectile2, 1, 10, 10);
            Player1.Projectile = projectile1;
            Player2.Projectile = projectile2;
            air.Body = WhiteB;
            Wall wall = new Wall(DzidHG);
            Walls[0] = wall;
            wall.Body = DzidVG;
            Walls[1] = wall;
            wall.Body = DzidVL;
            Walls[2] = wall;
            wall.Body = DzidVR;
            Walls[3] = wall;
            wall.Body = DzidVD;
            Walls[4] = wall;
            wall.Body = DzidHD;
            Walls[5] = wall;
        }
        Entity[,] Pos = new Entity[34, 18];
        Player Player1 = new Player(null, null, 1, 2, 12);
        Player Player2 = new Player(null, null, 1, 31, 5);
        Air air = new Air();
        Wall[] Walls = new Wall[6];
        bool GameOver;

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void Refresh()
        {
            //Pozicija na Praznite mesta
            for (int x = 0; x < 34; x++)
            {
                for (int y = 0; y < 18; y++)
                {
                    Pos[x, y] = air;
                }
            }

            //Pozicija na Players
            Pos[2, 12] = Player1;
            Player1.X = 2;
            Player1.Y = 12;
            Pos[31, 5] = Player2;
            Player2.X = 31;
            Player2.Y = 5;
            Player1.Body.Visible = true;
            Player2.Body.Visible = true;
            Player1.Projectile.Body.Visible = false;
            Player2.Projectile.Body.Visible = false;

            //Pozicija na Objektite
            int ScreenX = Screen.PrimaryScreen.Bounds.Width + 8;
            int ScreenY = Screen.PrimaryScreen.Bounds.Height - 30;
            //Pozicija na formata
            Location = new Point(0, 0);
            Size = new Size(ScreenX, ScreenY);
            //Pozicija na Kopcinja
            //Pozicija na kopcinja na Player 1
            //Gore
            P1U.Left = (int)Math.Floor((0.025 * ScreenX));
            P1U.Top = (int)Math.Floor(0.030 * ScreenY);
            P1U.Width = (int)Math.Floor(0.039 * ScreenX);
            P1U.Height = (int)Math.Floor(0.069 * ScreenY);
            //Desno
            P1R.Left = (int)Math.Floor(0.046 * ScreenX);
            P1R.Top = (int)Math.Floor(0.104 * ScreenY);
            P1R.Width = (int)Math.Floor(0.039 * ScreenX);
            P1R.Height = (int)Math.Floor(0.069 * ScreenY);
            //Dole
            P1D.Left = (int)Math.Floor(0.025 * ScreenX);
            P1D.Top = (int)Math.Floor(0.178 * ScreenY);
            P1D.Width = (int)Math.Floor(0.039 * ScreenX);
            P1D.Height = (int)Math.Floor(0.069 * ScreenY);
            //Levo
            P1L.Left = (int)Math.Floor(0.004 * ScreenX);
            P1L.Top = (int)Math.Floor(0.104 * ScreenY);
            P1L.Width = (int)Math.Floor(0.039 * ScreenX);
            P1L.Height = (int)Math.Floor(0.069 * ScreenY);
            //Fire!
            P1F.Left = (int)Math.Floor(0.013 * ScreenX);
            P1F.Top = (int)Math.Floor(0.274 * ScreenY);
            P1F.Width = (int)Math.Floor(0.064 * ScreenX);
            P1F.Height = (int)Math.Floor(0.097 * ScreenY);
            //Pozicija na kopcinja na Player 2
            //Gore
            P2U.Left = (int)Math.Floor(0.938 * ScreenX);
            P2U.Top = (int)Math.Floor(0.030 * ScreenY);
            P2U.Width = (int)Math.Floor(0.039 * ScreenX);
            P2U.Height = (int)Math.Floor(0.069 * ScreenY);
            //Desno
            P2R.Left = (int)Math.Floor(0.958 * ScreenX);
            P2R.Top = (int)Math.Floor(0.104 * ScreenY);
            P2R.Width = (int)Math.Floor(0.039 * ScreenX);
            P2R.Height = (int)Math.Floor(0.069 * ScreenY);
            //Dole
            P2D.Left = (int)Math.Floor(0.938 * ScreenX);
            P2D.Top = (int)Math.Floor(0.178 * ScreenY);
            P2D.Width = (int)Math.Floor(0.039 * ScreenX);
            P2D.Height = (int)Math.Floor(0.069 * ScreenY);
            //Levo
            P2L.Left = (int)Math.Floor(0.917 * ScreenX);
            P2L.Top = (int)Math.Floor(0.104 * ScreenY);
            P2L.Width = (int)Math.Floor(0.039 * ScreenX);
            P2L.Height = (int)Math.Floor(0.069 * ScreenY);
            //Fire!
            P2F.Left = (int)Math.Floor(0.925 * ScreenX);
            P2F.Top = (int)Math.Floor(0.274 * ScreenY);
            P2F.Width = (int)Math.Floor(0.064 * ScreenX);
            P2F.Height = (int)Math.Floor(0.097 * ScreenY);
            //Pozicija na WhiteBoard
            WhiteB.Left = (int)Math.Floor(0.092 * ScreenX);
            WhiteB.Top = (int)Math.Floor(0.007 * ScreenY);
            WhiteB.Width = (int)Math.Floor(0.8155 * ScreenX);
            WhiteB.Height = (int)Math.Floor(0.716 * ScreenY);

            //Pozicija na Playeri
            //Pozicija na Player 1
            P1.Left = WhiteB.Left + (Player1.X-1)*(WhiteB.Width / 32);//(int)Math.Floor(0.117 * ScreenX)
            P1.Top = WhiteB.Top + (Player1.Y-1)*(WhiteB.Height / 16);//(int)Math.Floor(0.506 * ScreenY)
            P1.Width = WhiteB.Width / 32;// (int)Math.Floor(0.026 * ScreenX);
            P1.Height = WhiteB.Height / 16;//(int)Math.Floor(0.045 * ScreenY)
            //Pozicija na Player 2
            P2.Left = WhiteB.Left + (Player2.X - 1) * (WhiteB.Width / 32);//(int)Math.Floor(0.858 * ScreenX)
            P2.Top = WhiteB.Top + (Player2.Y - 1) * (WhiteB.Height / 16); //0.186 || (int)Math.Floor(0.186 * ScreenY)
            P2.Width = WhiteB.Width / 32;//(int)Math.Floor(0.026 * ScreenX)
            P2.Height = WhiteB.Height / 16;//(int)Math.Floor(0.045 * ScreenY)
            //Pozicija na Dzidovi
            //Pozicija na Vertikalen Shape Gore
            DzidVG.Left = (int)Math.Floor(0.49999 * ScreenX);
            DzidVG.Top = (int)Math.Floor(0.007 * ScreenY);
            DzidVG.Width = WhiteB.Width / 32;//(int)Math.Floor(0.026 * ScreenX)
            DzidVG.Height = WhiteB.Height / 16*5;//(int)Math.Floor(0.268 * ScreenY)
            //Pozicija na Vertikalen Shape Dole
            DzidHG.Left = (int)Math.Floor(0.49999 * ScreenX);
            DzidHG.Top = (int)Math.Floor(0.499 * ScreenY);
            DzidHG.Width = WhiteB.Width / 32;//(int)Math.Floor(0.026 * ScreenX)
            DzidHG.Height = WhiteB.Height / 16 * 5;//(int)Math.Floor(0.267 * ScreenY)
            //Pozicija na Horizontalen Shape Gore
            DzidHD.Left = (int)Math.Floor(0.449 * ScreenX);
            DzidHD.Top = (int)Math.Floor(0.231 * ScreenY);
            DzidHD.Width = WhiteB.Width / 32 * 5;//(int)Math.Floor(0.126 * ScreenX)
            DzidHD.Height = WhiteB.Height / 16;//(int)Math.Floor(0.045 * ScreenY)
            //Pozicija na Horizontalen Shape Dole
            DzidVD.Left = (int)Math.Floor(0.449 * ScreenX);
            DzidVD.Top = (int)Math.Floor(0.455 * ScreenY);
            DzidVD.Width = WhiteB.Width / 32 * 5;//(int)Math.Floor(0.126 * ScreenX)
            DzidVD.Height = WhiteB.Height / 16;//(int)Math.Floor(0.045 * ScreenY)
            //Pozicija na vertikalen Shape Levo
            DzidVL.Left = (int)Math.Floor(0.372 * ScreenX);
            DzidVL.Top = (int)Math.Floor(0.1859 * ScreenY);
            DzidVL.Width = WhiteB.Width / 32;//(int)Math.Floor(0.026 * ScreenX)
            DzidVL.Height = WhiteB.Height / 16 * 8;//(int)Math.Floor(0.371 * ScreenY)
            //Pozicija na Vertikalen Shape Desno
            DzidVR.Left = (int)Math.Floor(0.6268 * ScreenX);
            DzidVR.Top = (int)Math.Floor(0.1859 * ScreenY);
            DzidVR.Width = WhiteB.Width / 32;//(int)Math.Floor(0.026 * ScreenX)
            DzidVR.Height = WhiteB.Height / 16 * 8;//(int)Math.Floor(0.371 * ScreenY)
            //Pozicija na Informacionite Labeli
            //Pozicija na label za informacija na pobeda
            InfoWin.Left = (int)Math.Floor(0.383 * ScreenX);
            InfoWin.Top = (int)Math.Floor(0.800 * ScreenY);
            InfoWin.Width = (int)Math.Floor(0.263 * ScreenX);
            InfoWin.Height = (int)Math.Floor(0.067 * ScreenY);
            InfoWin.Text = "";
            GameOver = false;
            //Pozicija na kopce za Reset
            ResetBtn.Left = (int)Math.Floor(0.117 * ScreenX);
            ResetBtn.Top = (int)Math.Floor(0.778 * ScreenY);
            ResetBtn.Width = (int)Math.Floor(0.121 * ScreenX);
            ResetBtn.Height = (int)Math.Floor(0.126 * ScreenY);
            //Pozicija na Kopce za Exit
            ExitBtn.Left = (int)Math.Floor(0.763 * ScreenX);
            ExitBtn.Top = (int)Math.Floor(0.778 * ScreenY);
            ExitBtn.Width = (int)Math.Floor(0.121 * ScreenX);
            ExitBtn.Height = (int)Math.Floor(0.126 * ScreenY);
            //Pozicija na Score za Player 1
            SP1.Left = (int)Math.Floor(0.288 * ScreenX);
            SP1.Top = (int)Math.Floor(0.800 * ScreenY);
            SP1.Width = (int)Math.Floor(0.051 * ScreenX);
            SP1.Height = (int)Math.Floor(0.067 * ScreenY);
            //Pozicija na score za Player 2
            SP2.Left = (int)Math.Floor(0.683 * ScreenX);
            SP2.Top = (int)Math.Floor(0.800 * ScreenY);
            SP2.Width = (int)Math.Floor(0.051 * ScreenX);
            SP2.Height = (int)Math.Floor(0.067 * ScreenY);
            //Pozicija na Switch To Keyboard Button
            Keyboard.Left = ScreenX;//0.450
            Keyboard.Top = ScreenY;//0.755
            Keyboard.Width = ScreenX;//0.127
            Keyboard.Height = ScreenY;//0.038

            //Pozicija na Dzidovite

            Pos[17, 0] = Walls[1];
            Pos[17, 1] = Walls[1];
            Pos[17, 2] = Walls[1];
            Pos[17, 3] = Walls[1];
            Pos[17, 4] = Walls[1];
            Pos[17, 5] = Walls[1];
            Pos[17, 6] = Walls[1];

            Pos[16, 6] = Walls[0];
            Pos[15, 6] = Walls[0];
            Pos[18, 6] = Walls[0];
            Pos[19, 6] = Walls[0];

            Pos[15, 11] = Walls[5];
            Pos[16, 11] = Walls[5];
            Pos[17, 11] = Walls[5];
            Pos[18, 11] = Walls[5];
            Pos[19, 11] = Walls[5];

            Pos[12, 5] = Walls[2];
            Pos[12, 6] = Walls[2];
            Pos[12, 7] = Walls[2];
            Pos[12, 8] = Walls[2];
            Pos[12, 9] = Walls[2];
            Pos[12, 10] = Walls[2];
            Pos[12, 11] = Walls[2];
            Pos[12, 12] = Walls[2];

            Pos[22, 5] = Walls[3];
            Pos[22, 6] = Walls[3];
            Pos[22, 7] = Walls[3];
            Pos[22, 8] = Walls[3];
            Pos[22, 9] = Walls[3];
            Pos[22, 10] = Walls[3];
            Pos[22, 11] = Walls[3];
            Pos[22, 12] = Walls[3];

            Pos[17, 11] = Walls[1];
            Pos[17, 12] = Walls[1];
            Pos[17, 13] = Walls[1];
            Pos[17, 14] = Walls[1];
            Pos[17, 15] = Walls[1];
            Pos[17, 16] = Walls[1];

            WhiteB.SendToBack();
            Keyboard.Select();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Refresh();
            Keyboard.Select();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void P1U_Click(object sender, EventArgs e)
        {
            Player1.moveUp(Pos, air);
            Keyboard.Select();
        }

        private void P1D_Click(object sender, EventArgs e)
        {
            Player1.moveDown(Pos, air);
        }

        private void P1L_Click(object sender, EventArgs e)
        {
            Player1.moveLeft(Pos, air);
            Keyboard.Select();
        }

        private void P1R_Click(object sender, EventArgs e)
        {
            Player1.moveRight(Pos, air);
            Keyboard.Select();
        }

        private void P2U_Click(object sender, EventArgs e)
        {
            Player2.moveUp(Pos, air);
            Keyboard.Select();
        }

        private void P2D_Click(object sender, EventArgs e)
        {
            Player2.moveDown(Pos, air);
            Keyboard.Select();
        }

        private void P2L_Click(object sender, EventArgs e)
        {
            Player2.moveLeft(Pos, air);
            Keyboard.Select();
        }

        private void P2R_Click(object sender, EventArgs e)
        {
            Player2.moveRight(Pos, air);
            Keyboard.Select();
        }

        private void Keyboard_Click(object sender, EventArgs e)
        {

        }

        private void Keyboard_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'w':
                    Player1.moveUp(Pos, air);
                    break;
                case 's':
                    Player1.moveDown(Pos, air);
                    break;
                case 'a':
                    Player1.moveLeft(Pos, air);
                    break;
                case 'd':
                    Player1.moveRight(Pos, air);
                    break;
                case 'e':
                    if(Player1.Body.Visible)
                    Player1.Fire(Pos, air, TimerP1);
                    if (!Player1.Body.Visible)
                    {
                        RedWon();
                    }
                    if (!Player2.Body.Visible)
                    {
                        BlueWon();
                    }
                    break;
                case 'q':
                    if (Player1.Body.Visible)
                        Player1.Fire(Pos, air, TimerP1);
                    if (!Player1.Body.Visible)
                    {
                        RedWon();
                    }
                    if (!Player2.Body.Visible)
                    {
                        BlueWon();
                    }
                    break;
                case 'i':
                    Player2.moveUp(Pos, air);
                    break;
                case 'k':
                    Player2.moveDown(Pos, air);
                    break;
                case 'j':
                    Player2.moveLeft(Pos, air);
                    break;
                case 'l':
                    Player2.moveRight(Pos, air);
                    break;
                case 'o':
                    if(Player2.Body.Visible)
                    Player2.Fire(Pos, air, TimerP2);
                    if (!Player1.Body.Visible)
                    {
                        RedWon();
                    }
                    if (!Player2.Body.Visible)
                    {
                        BlueWon();
                    }
                    break;
                case 'u':
                    if (Player2.Body.Visible)
                        Player2.Fire(Pos, air, TimerP2);
                    if (!Player1.Body.Visible)
                    {
                        RedWon();
                    }
                    if (!Player2.Body.Visible)
                    {
                        BlueWon();
                    }
                    break;
            }
        }

        private void P1F_Click(object sender, EventArgs e)
        {
            Player1.Fire(Pos, air, TimerP1);
            Keyboard.Select();
            if (!Player1.Body.Visible)
            {
                RedWon();
            }
            if (!Player2.Body.Visible)
            {
                BlueWon();
            }
        }

        private void P2F_Click(object sender, EventArgs e)
        {
            Player2.Fire(Pos, air, TimerP2);
            Keyboard.Select();
            if (!Player1.Body.Visible)
            {
                RedWon();
            }
            if (!Player2.Body.Visible)
            {
                BlueWon();
            }
        }

        private void TimerP1_Tick(object sender, EventArgs e)
        {
            if (Player1.Projectile.Body.Visible)
            {
                Player1.Projectile.Move(Pos, air);
            }
            else
            {
                if (!Player1.Body.Visible)
                {
                    RedWon();
                }
                if (!Player2.Body.Visible)
                {
                    BlueWon();
                }
                TimerP1.Enabled = false;
                Player1.Projectile.Body.Visible = false;
                Pos[Player1.Projectile.X, Player1.Projectile.Y] = air;
            }
        }

        private void TimerP2_Tick(object sender, EventArgs e)
        {
            if (Player2.Projectile.Body.Visible)
            {
                Player2.Projectile.Move(Pos, air);
            }
            else
            {
                if (!Player1.Body.Visible)
                {
                    RedWon();
                }
                if (!Player2.Body.Visible)
                {
                    BlueWon();
                }
                TimerP2.Enabled = false;
                Player2.Projectile.Body.Visible = false;
                Pos[Player2.Projectile.X, Player2.Projectile.Y] = air;
            }
        }

        void BlueWon()
        {
            if (!GameOver)
            {
                InfoWin.Text = "The blue player won!";
                SP1.Text = (int.Parse(SP1.Text) + 1).ToString();
                GameOver = true;
            }
        }

        void RedWon()
        {
            if (!GameOver)
            {
                InfoWin.Text = "The red player won!";
                SP2.Text = (int.Parse(SP2.Text) + 1).ToString();
                GameOver = true;
            }
        }

        private void P1_VisibleChanged(object sender, EventArgs e)
        { 
        }

        private void P2_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}
