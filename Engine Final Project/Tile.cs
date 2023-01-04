using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Final_Project
{
    public abstract class Tile
    {
        public Vector2 position { get; protected set; }
        public Vector2 scale { get; protected set; }
    }
}
