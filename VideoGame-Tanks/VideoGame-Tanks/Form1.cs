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
        private Player Player1 { get; set; }
        private Player Player2 { get; set; }
        private Air air { get; set; }
        private Wall[] Walls { get; set; }
        public Form1()
        {
            InitializeComponent();
            Player Player1 = new Player(P1, 1, false, 2, 12);
            Player Player2 = new Player(P1, 1, false, 31, 5);
            Air air = new Air(WhiteB);
            Wall[] Walls = new Wall[6];
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
        Entity[,] Pos = new Entity[33, 17];

        private void Form1_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void Refresh()
        {
            //Pozicija na Objektite
            int ScreenX = Screen.PrimaryScreen.Bounds.Width + 8;
            int ScreenY = Screen.PrimaryScreen.Bounds.Height - 30;
            //Pozicija na formata
            Location = new Point(0, 0);
            Size = new Size(ScreenX, ScreenY);
            //Pozicija na Kopcinja
            //Pozicija na kopcinja na Player 1
            //Gore
            P1U.Left = (int)Math.Ceiling((0.025 * ScreenX));
            P1U.Top = (int)Math.Ceiling(0.030 * ScreenY);
            P1U.Width = (int)Math.Ceiling(0.039 * ScreenX);
            P1U.Height = (int)Math.Ceiling(0.069 * ScreenY);
            //Desno
            P1R.Left = (int)Math.Ceiling(0.046 * ScreenX);
            P1R.Top = (int)Math.Ceiling(0.104 * ScreenY);
            P1R.Width = (int)Math.Ceiling(0.039 * ScreenX);
            P1R.Height = (int)Math.Ceiling(0.069 * ScreenY);
            //Dole
            P1D.Left = (int)Math.Ceiling(0.025 * ScreenX);
            P1D.Top = (int)Math.Ceiling(0.178 * ScreenY);
            P1D.Width = (int)Math.Ceiling(0.039 * ScreenX);
            P1D.Height = (int)Math.Ceiling(0.069 * ScreenY);
            //Levo
            P1L.Left = (int)Math.Ceiling(0.004 * ScreenX);
            P1L.Top = (int)Math.Ceiling(0.104 * ScreenY);
            P1L.Width = (int)Math.Ceiling(0.039 * ScreenX);
            P1L.Height = (int)Math.Ceiling(0.069 * ScreenY);
            //Fire!
            P1F.Left = (int)Math.Ceiling(0.013 * ScreenX);
            P1F.Top = (int)Math.Ceiling(0.274 * ScreenY);
            P1F.Width = (int)Math.Ceiling(0.064 * ScreenX);
            P1F.Height = (int)Math.Ceiling(0.097 * ScreenY);
            //Pozicija na kopcinja na Player 2
            //Gore
            P2U.Left = (int)Math.Ceiling(0.938 * ScreenX);
            P2U.Top = (int)Math.Ceiling(0.030 * ScreenY);
            P2U.Width = (int)Math.Ceiling(0.039 * ScreenX);
            P2U.Height = (int)Math.Ceiling(0.069 * ScreenY);
            //Desno
            P2R.Left = (int)Math.Ceiling(0.958 * ScreenX);
            P2R.Top = (int)Math.Ceiling(0.104 * ScreenY);
            P2R.Width = (int)Math.Ceiling(0.039 * ScreenX);
            P2R.Height = (int)Math.Ceiling(0.069 * ScreenY);
            //Dole
            P2D.Left = (int)Math.Ceiling(0.938 * ScreenX);
            P2D.Top = (int)Math.Ceiling(0.178 * ScreenY);
            P2D.Width = (int)Math.Ceiling(0.039 * ScreenX);
            P2D.Height = (int)Math.Ceiling(0.069 * ScreenY);
            //Levo
            P2L.Left = (int)Math.Ceiling(0.917 * ScreenX);
            P2L.Top = (int)Math.Ceiling(0.104 * ScreenY);
            P2L.Width = (int)Math.Ceiling(0.039 * ScreenX);
            P2L.Height = (int)Math.Ceiling(0.069 * ScreenY);
            //Fire!
            P2F.Left = (int)Math.Ceiling(0.925 * ScreenX);
            P2F.Top = (int)Math.Ceiling(0.274 * ScreenY);
            P2F.Width = (int)Math.Ceiling(0.064 * ScreenX);
            P2F.Height = (int)Math.Ceiling(0.097 * ScreenY);
            //Pozicija na WhiteBoard
            WhiteB.Left = (int)Math.Ceiling(0.092 * ScreenX);
            WhiteB.Top = (int)Math.Ceiling(0.007 * ScreenY);
            WhiteB.Width = (int)Math.Ceiling(0.817 * ScreenX);
            WhiteB.Height = (int)Math.Ceiling(0.726 * ScreenY);

            //Pozicija na Playeri
            //Pozicija na Player 1
            P1.Left = (int)Math.Ceiling(0.117 * ScreenX);
            P1.Top = (int)Math.Ceiling(0.506 * ScreenY);
            P1.Width = (int)Math.Ceiling(0.026 * ScreenX);
            P1.Height = (int)Math.Ceiling(0.045 * ScreenY);
            //Pozicija na Player 2
            P2.Left = (int)Math.Ceiling(0.858 * ScreenX);
            P2.Top = (int)Math.Ceiling(0.186 * ScreenY);
            P2.Width = (int)Math.Ceiling(0.026 * ScreenX);
            P2.Height = (int)Math.Ceiling(0.045 * ScreenY);
            //Pozicija na Dzidovi
            //Pozicija na Vertikalen Shape Gore
            DzidVG.Left = (int)Math.Ceiling(0.500 * ScreenX);
            DzidVG.Top = (int)Math.Ceiling(0.007 * ScreenY);
            DzidVG.Width = (int)Math.Ceiling(0.026 * ScreenX);
            DzidVG.Height = (int)Math.Ceiling(0.268 * ScreenY);
            //Pozicija na Horizontalen Shape Gore
            DzidHG.Left = (int)Math.Ceiling(0.500 * ScreenX);
            DzidHG.Top = (int)Math.Ceiling(0.467 * ScreenY);
            DzidHG.Width = (int)Math.Ceiling(0.026 * ScreenX);
            DzidHG.Height = (int)Math.Ceiling(0.267 * ScreenY);
            //Pozicija na Horizontalen Shape Dole
            DzidHD.Left = (int)Math.Ceiling(0.450 * ScreenX);
            DzidHD.Top = (int)Math.Ceiling(0.230 * ScreenY);
            DzidHD.Width = (int)Math.Ceiling(0.126 * ScreenX);
            DzidHD.Height = (int)Math.Ceiling(0.045 * ScreenY);
            //Pozicija na Vertikalen Shape Dole
            DzidVD.Left = (int)Math.Ceiling(0.450 * ScreenX);
            DzidVD.Top = (int)Math.Ceiling(0.467 * ScreenY);
            DzidVD.Width = (int)Math.Ceiling(0.126 * ScreenX);
            DzidVD.Height = (int)Math.Ceiling(0.045 * ScreenY);
            //Pozicija na vertikalen Shape Levo
            DzidVL.Left = (int)Math.Ceiling(0.375 * ScreenX);
            DzidVL.Top = (int)Math.Ceiling(0.185 * ScreenY);
            DzidVL.Width = (int)Math.Ceiling(0.026 * ScreenX);
            DzidVL.Height = (int)Math.Ceiling(0.371 * ScreenY);
            //Pozicija na Vertikalen Shape Desno
            DzidVR.Left = (int)Math.Ceiling(0.625 * ScreenX);
            DzidVR.Top = (int)Math.Ceiling(0.185 * ScreenY);
            DzidVR.Width = (int)Math.Ceiling(0.026 * ScreenX);
            DzidVR.Height = (int)Math.Ceiling(0.371 * ScreenY);
            //Pozicija na Informacionite Labeli
            //Pozicija na label za informacija na pobeda
            InfoWin.Left = (int)Math.Ceiling(0.383 * ScreenX);
            InfoWin.Top = (int)Math.Ceiling(0.800 * ScreenY);
            InfoWin.Width = (int)Math.Ceiling(0.263 * ScreenX);
            InfoWin.Height = (int)Math.Ceiling(0.067 * ScreenY);
            //Pozicija na kopce za Reset
            ResetBtn.Left = (int)Math.Ceiling(0.117 * ScreenX);
            ResetBtn.Top = (int)Math.Ceiling(0.778 * ScreenY);
            ResetBtn.Width = (int)Math.Ceiling(0.121 * ScreenX);
            ResetBtn.Height = (int)Math.Ceiling(0.126 * ScreenY);
            //Pozicija na Kopce za Exit
            ExitBtn.Left = (int)Math.Ceiling(0.763 * ScreenX);
            ExitBtn.Top = (int)Math.Ceiling(0.778 * ScreenY);
            ExitBtn.Width = (int)Math.Ceiling(0.121 * ScreenX);
            ExitBtn.Height = (int)Math.Ceiling(0.126 * ScreenY);
            //Pozicija na Score za Player 1
            SP1.Left = (int)Math.Ceiling(0.288 * ScreenX);
            SP1.Top = (int)Math.Ceiling(0.800 * ScreenY);
            SP1.Width = (int)Math.Ceiling(0.051 * ScreenX);
            SP1.Height = (int)Math.Ceiling(0.067 * ScreenY);
            //Pozicija na score za Player 2
            SP2.Left = (int)Math.Ceiling(0.683 * ScreenX);
            SP2.Top = (int)Math.Ceiling(0.800 * ScreenY);
            SP2.Width = (int)Math.Ceiling(0.051 * ScreenX);
            SP2.Height = (int)Math.Ceiling(0.067 * ScreenY);
            //Pozicija na Switch To Keyboard Button
            Keyboard.Left = (int)Math.Ceiling(0.450 * ScreenX);
            Keyboard.Top = (int)Math.Ceiling(0.755 * ScreenY);
            Keyboard.Width = (int)Math.Ceiling(0.127 * ScreenX);
            Keyboard.Height = (int)Math.Ceiling(0.038 * ScreenY);
            Keyboard.Hide();
            //pozicija na Switch To Keyboard Label
            TT.Left = (int)Math.Ceiling(0.579 * ScreenX);
            TT.Top = (int)Math.Ceiling(0.745 * ScreenY);
            TT.Hide();

            //Pozicija na Praznite mesta

            for (int x = 0; x < 33; x++)
            {
                for (int y = 0; y < 17; y++)
                {
                    Pos[x, y] = air;
                }
            }

            //Pozicija I Orientacija na Players

            Pos[2, 12] = Player1;
            Pos[31, 5] = Player2;

            //Pozicija na Dzidovite

            for (int i = 0; i <= 7; i++)
                Pos[17, i] = Walls[1];

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

            //Go smetase kako dzid ova e popravka od bug
            Pos[16, 16] = air;
            Pos[12, 1] = air;
            Pos[12, 2] = air;
            Pos[12, 3] = air;
            Pos[12, 4] = air;

            air.Body.SendToBack();
            Keyboard.Select();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void P1U_Click(object sender, EventArgs e)
        {
            if (Pos[Player1.X, Player1.Y] is Air) && (Player1.Y - 1 > 0) && (Shape1.Visible = True) && (Label10.caption = '')
            {
                Shape1.Top:= Shape1.Top - Round(0.045 * Screen.Height);
                Pos[P1X][P1Y]:= 0;
                P1Y:= P1Y - 1;
                Pos[P1X][P1Y]:= 1;
                P1O:= 1;
            }
        }
    }
}
