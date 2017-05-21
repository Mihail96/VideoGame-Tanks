using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame_Tanks
{
    class Projectile: Entity
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int orientation { get; set; }
        public bool fired { get; set; }

        public Projectile() { }
        public Projectile(System.Windows.Forms.Panel Body, int orientation, bool fired, int X, int Y):base(Body)
        {
            this.orientation = orientation;
            this.fired = fired;
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return "A Projectile";
        }
    }
}
