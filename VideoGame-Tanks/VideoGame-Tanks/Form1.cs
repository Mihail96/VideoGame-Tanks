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
        }
        System.Windows.Forms.Panel[ , ] Pos = new Panel[33, 17];
        int P1O = 1;
        int P2O = 1;

        private void Form1_Load(object sender, EventArgs e)
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
            WB.Left = (int)Math.Ceiling(0.092 * ScreenX);
            WB.Top = (int)Math.Ceiling(0.007 * ScreenY);
            WB.Width = (int)Math.Ceiling(0.817 * ScreenX);
            WB.Height = (int)Math.Ceiling(0.726 * ScreenY);
            WB.Text = "";

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
            DzidHR.Left = (int)Math.Ceiling(0.625 * ScreenX);
            DzidHR.Top = (int)Math.Ceiling(0.185 * ScreenY);
            DzidHR.Width = (int)Math.Ceiling(0.026 * ScreenX);
            DzidHR.Height = (int)Math.Ceiling(0.371 * ScreenY);
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
            //pozicija na Switch To Keyboard Label
            TT.Left = (int)Math.Ceiling(0.579 * ScreenX);
            TT.Top = (int)Math.Ceiling(0.745 * ScreenY);

            //Pozicija na Praznite mesta

            for (int x = 0; x < 33; x++)
            {
                for (int y = 0; y < 17; y++)
                {
                    Pos[x, y] = null;
                }
            }

        //Pozicija I Orientacija na Players

            P1O = 1;
            P2O = 1;
            Pos[2, 12] = P1;
            Pos[31, 5] = P2;

            //Pozicija na Dzidovite

            Pos[17, 0] = 2;
            Pos[17, 1] = 2;
            Pos[17, 2] = 2;
            Pos[17, 3] = 2;
            Pos[17, 4] = 2;
            Pos[17, 5] = 2;
            Pos[17, 6] = 2;

            Pos[16, 6] = 2;
            Pos[15, 6] = 2;
            Pos[18, 6] = 2;
            Pos[19, 6] = 2;

            Pos[15, 11] = 2;
            Pos[16, 11] = 2;
            Pos[17, 11] = 2;
            Pos[18, 11] = 2;
            Pos[19, 11] = 2;

            Pos[12, 5] = 2;
            Pos[12, 6] = 2;
            Pos[12, 7] = 2;
            Pos[12, 8] = 2;
            Pos[12, 9] = 2;
            Pos[12, 10] = 2;
            Pos[12, 11] = 2;
            Pos[12, 12] = 2;

            Pos[22, 5] = 2;
            Pos[22, 6] = 2;
            Pos[22, 7] = 2;
            Pos[22, 8] = 2;
            Pos[22, 9] = 2;
            Pos[22, 10] = 2;
            Pos[22, 11] = 2;
            Pos[22, 12] = 2;

            Pos[17, 11] = 2;
            Pos[17, 12] = 2;
            Pos[17, 13] = 2;
            Pos[17, 14] = 2;
            Pos[17, 15] = 2;
            Pos[17, 16] = 2;

            //Go smetase kako dzid ova e popravka od bug
            Pos[16, 16] = 0;
            Pos[12, 1] = 0;
            Pos[12, 2] = 0;
            Pos[12, 3] = 0;
            Pos[12, 4] = 0;

        //Davanje na Potrebnite Pocetni informacii
        P1X = 2;
        P1Y = 12;
        P2X = 31;
        P2Y = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
