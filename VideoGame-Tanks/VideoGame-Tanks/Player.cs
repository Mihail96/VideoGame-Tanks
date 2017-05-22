using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGame_Tanks
{
    class Player : Entity
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int orientation { get; set; }
        public Projectile Projectile { get; set; }

        public Player() { }
        public Player(Panel Body, Projectile Projectile, int orientation, int X, int Y):base(Body)
        {
            this.orientation = orientation;
            this.Projectile = Projectile;
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return "A Player";
        }

        public void moveUp(Entity[,] Pos, Air air)
        {
            if ((Pos[X, Y - 1] is Air) && (Y - 1 > 0) && (Body.Visible == true))
            {
                Body.Top = Body.Top - Body.Height;//(int)Math.Round(0.082 * Screen.PrimaryScreen.Bounds.Height - 30)
                Pos[X, Y] = air;
                Y = Y - 1;
                Pos[X, Y] = this;
                orientation = 1;
            }
        }

        public void moveDown(Entity[,] Pos, Air air)
        {
            if ((Pos[X, Y + 1] is Air) && (Y + 1 <= 16) && (Body.Visible == true))
            {
                Body.Top = Body.Top + Body.Height;//(int)Math.Round(0.082 * Screen.PrimaryScreen.Bounds.Height - 30)
                Pos[X, Y] = air;
                Y = Y + 1;
                Pos[X, Y] = this;
                orientation = 3;
            }
        }

        public void moveLeft(Entity[,] Pos, Air air)
        {
            if ((Pos[X - 1, Y] is Air) && (X - 1 > 0) && (Body.Visible == true))
            {
                Body.Left = Body.Left - Body.Width;//(int)Math.Round(0.020 * Screen.PrimaryScreen.Bounds.Width + 8)
                Pos[X, Y] = air;
                X = X - 1;
                Pos[X, Y] = this;
                orientation = 4;
            }
        }

        public void moveRight(Entity[,] Pos, Air air)
        {
            if ((Pos[X + 1, Y] is Air) && (X + 1 <= 32) && (Body.Visible == true))
            {
                Body.Left = Body.Left + Body.Width;//(int)Math.Round(0.020 * Screen.PrimaryScreen.Bounds.Width + 8)
                Pos[X, Y] = air;
                X = X + 1;
                Pos[X, Y] = this;
                orientation = 2;
            }
        }

        public void Fire(Entity[,] Pos, Air air, Timer Timer)
        {
            Console.WriteLine(X + " " + Y);
            Console.WriteLine(Pos[X, Y-1].ToString());
            if (!Projectile.Body.Visible)
            {
                switch (orientation)
                {
                    case 1:
                        if (Pos[X, Y - 1] is Projectile)
                        {
                            Pos[X, Y - 1].Body.Visible = false;
                            Pos[X, Y - 1] = air;
                        }
                        if (Pos[X, Y - 1] is Air && Y - 1 > 0)
                        {
                            Projectile.Body.Visible = true;
                            Projectile.Body.Left = Body.Left + Body.Width/3;//(int)Math.Round(0.004 * Screen.PrimaryScreen.Bounds.Width + 8);
                            Projectile.Body.Top = Body.Top - (int)Math.Floor(Body.Height/1.5);//(int)Math.Round(0.045 * Screen.PrimaryScreen.Bounds.Height - 30) + (int)Math.Round(0.019 * Screen.PrimaryScreen.Bounds.Height - 30)
                            Projectile.Body.Width = 15;
                            Projectile.Body.Height = 15;
                            Projectile.X = X;
                            Projectile.Y = Y - 1;
                            Pos[Projectile.X, Projectile.Y] = Projectile;
                            Projectile.orientation = orientation;
                            Timer.Enabled = true;
                        }
                        if (Pos[X, Y - 1] is Player)
                        {
                            Pos[X, Y - 1].Body.Visible = false;
                            Pos[X, Y - 1] = air;
                        }
                        break;
                    case 2:
                        if (Pos[X + 1, Y] is Projectile)
                        {
                            Pos[X + 1, Y].Body.Visible = false;
                            Pos[X + 1, Y] = air;
                        }
                        if (Pos[X + 1, Y] is Air && X + 1 <= 32)
                        {
                            Projectile.Body.Visible = true;
                            Projectile.Body.Left = Body.Left + (int)Math.Floor(Body.Width / 0.75);//(int)Math.Round(0.026 * Screen.PrimaryScreen.Bounds.Width + 8)
                            Projectile.Body.Top = Body.Top + Body.Height / 3;//(int)Math.Round(0.050 * Screen.PrimaryScreen.Bounds.Height - 30)
                            Projectile.Body.Width = 15;
                            Projectile.Body.Height = 15;
                            Projectile.X = X + 1;
                            Projectile.Y = Y;
                            Pos[Projectile.X, Projectile.Y] = Projectile;
                            Projectile.orientation = orientation;
                            Timer.Enabled = true;
                        }
                        if (Pos[X + 1, Y] is Player)
                        {
                            Pos[X + 1, Y].Body.Visible = false;
                            Pos[X + 1, Y] = air;
                        }
                        break;
                    case 3:
                        if (Pos[X, Y + 1] is Projectile)
                        {
                            Pos[X, Y + 1].Body.Visible = false;
                            Pos[X, Y + 1] = air;
                        }
                        if (Pos[X, Y + 1] is Air && Y + 1 <= 16)
                        {
                            Projectile.Body.Visible = true;
                            Projectile.Body.Left = Body.Left + Body.Width / 3;//(int)Math.Round(0.004 * Screen.PrimaryScreen.Bounds.Width + 8)
                            Projectile.Body.Top = Body.Top + (int)Math.Floor(Body.Height / 0.75);//(int)Math.Round(0.090 * Screen.PrimaryScreen.Bounds.Height - 30)
                            Projectile.Body.Width = 15;
                            Projectile.Body.Height = 15;
                            Projectile.X = X;
                            Projectile.Y = Y + 1;
                            Pos[Projectile.X, Projectile.Y] = Projectile;
                            Projectile.orientation = orientation;
                            Timer.Enabled = true;
                        }
                        if (Pos[X, Y + 1] is Player)
                        {
                            Pos[X, Y + 1].Body.Visible = false;
                            Pos[X, Y + 1] = air;
                        }
                        break;
                    case 4:
                        if (Pos[X - 1, Y] is Projectile)
                        {
                            Pos[X - 1, Y].Body.Visible = false;
                            Pos[X - 1, Y] = air;
                        }
                        if (Pos[X - 1, Y] is Air && X - 1 > 0)
                        {
                            Projectile.Body.Visible = true;
                            Projectile.Body.Left = Body.Left - (int)Math.Floor(Body.Width / 1.5);//(int)Math.Round(0.026 * Screen.PrimaryScreen.Bounds.Width + 8) + (int)Math.Round(0.009 * Screen.PrimaryScreen.Bounds.Width + 8)
                            Projectile.Body.Top = Body.Top + Body.Height / 3;//(int)Math.Round(0.050 * Screen.PrimaryScreen.Bounds.Height - 30)
                            Projectile.Body.Width = 15;
                            Projectile.Body.Height = 15;
                            Projectile.X = X - 1;
                            Projectile.Y = Y;
                            Pos[Projectile.X, Projectile.Y] = Projectile;
                            Projectile.orientation = orientation;
                            Timer.Enabled = true;
                        }
                        if (Pos[X - 1, Y] is Player)
                        {
                            Pos[X - 1, Y].Body.Visible = false;
                            Pos[X - 1, Y] = air;
                        }
                        break;
                }
            }
        }
    }
}
