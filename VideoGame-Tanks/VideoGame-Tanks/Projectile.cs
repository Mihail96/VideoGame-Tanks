using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGame_Tanks
{
    class Projectile: Entity
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int orientation { get; set; }

        public Projectile() { }
        public Projectile(System.Windows.Forms.Panel Body, int orientation, int X, int Y):base(Body)
        {
            this.orientation = orientation;
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return "A Projectile";
        }

        public void Move(Entity[ , ] Pos, Air air)
        {
            switch (orientation)
            {
                case 1:
                    if (Pos[X, Y - 1] is Air && Y - 1 > 0)
                    {
                        Pos[X, Y - 1] = this;
                        Body.Top = Body.Top - (int)Math.Round(0.095 * Screen.PrimaryScreen.Bounds.Height - 30);
                        Y = Y - 1;
                        Pos[X, Y + 1] = air;
                    }
                    else
                    {
                        Body.Visible = false;
                    }
                    if (Pos[X, Y - 1] is Wall)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                    }
                    if (Pos[X, Y - 1] is Projectile)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                        Pos[X, Y - 1].Body.Visible = false;
                        Pos[X, Y - 1] = air;
                    }
                    if (Pos[X, Y - 1] is Player)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                        Pos[X, Y - 1].Body.Visible = false;
                        Pos[X, Y - 1] = air;
                    }
                    break;
                case 2:
                    if (Pos[X + 1, Y] is Air && X + 1 <= 32)
                    {
                        Pos[X + 1, Y] = this;
                        Body.Left = Body.Left + (int)Math.Round(0.021 * Screen.PrimaryScreen.Bounds.Width + 8);
                        X = X + 1;
                        Pos[X - 1, Y] = air;
                    }
                    else
                    {
                        Body.Visible = false;
                    }
                    if (Pos[X + 1, Y] is Wall)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                    }
                    if (Pos[X + 1, Y] is Projectile)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                        Pos[X + 1, Y].Body.Visible = false;
                        Pos[X + 1, Y] = air;
                    }
                    if (Pos[X + 1, Y] is Player)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                        Pos[X + 1, Y].Body.Visible = false;
                        Pos[X + 1, Y] = air;
                    }
                    break;
                case 3:
                    if (Pos[X, Y + 1] is Air && Y + 1 <= 16)
                    {
                        Pos[X, Y + 1] = this;
                        Body.Top = Body.Top + (int)Math.Round(0.082 * Screen.PrimaryScreen.Bounds.Height - 30);
                        Y = Y + 1;
                        Pos[X, Y - 1] = air;
                    }
                    else
                    {
                        Body.Visible = false;
                    }
                    if (Pos[X, Y + 1] is Wall)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                    }
                    if (Pos[X, Y + 1] is Projectile)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                        Pos[X, Y + 1].Body.Visible = false;
                        Pos[X, Y + 1] = air;
                    }
                    if (Pos[X, Y + 1] is Player)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                        Pos[X, Y + 1].Body.Visible = false;
                        Pos[X, Y + 1] = air;
                    }
                    break;
                case 4:
                    if (Pos[X - 1, Y] is Air && X - 1 > 0)
                    {
                        Pos[X - 1, Y] = this;
                        Body.Left = Body.Left - (int)Math.Round(0.02 * Screen.PrimaryScreen.Bounds.Width + 8);
                        X = X - 1;
                        Pos[X + 1, Y] = air;
                    }
                    else
                    {
                        Body.Visible = false;
                    }
                    if (Pos[X - 1, Y] is Wall)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                    }
                    if (Pos[X - 1, Y] is Projectile)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                        Pos[X - 1, Y].Body.Visible = false;
                        Pos[X - 1, Y] = air;
                    }
                    if (Pos[X - 1, Y] is Player)
                    {
                        Pos[X, Y] = air;
                        Body.Visible = false;
                        Pos[X - 1, Y].Body.Visible = false;
                        Pos[X - 1, Y] = air;
                    }
                    break;
            }
        }
    }
}
