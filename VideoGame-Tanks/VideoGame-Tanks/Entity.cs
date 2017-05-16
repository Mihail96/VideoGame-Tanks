using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame_Tanks
{
    abstract class Entity
    {
        public System.Windows.Forms.Panel Body { get; set; }

        public Entity() { }
        public Entity(System.Windows.Forms.Panel Body)
        {
            this.Body = Body;
        }

        public abstract override string ToString()
    }
}
