using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame_Tanks
{
    class Wall: Entity
    {

        public Wall() { }
        public Wall(System.Windows.Forms.Panel Body):base(Body) { }

        public override string ToString()
        {
            return "A Wall";
        }
    }
}
