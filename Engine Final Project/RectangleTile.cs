using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Final_Project
{
    public class RectangleTile : Tile
    {
        public RectangleTile(Vector2 position, Vector2 scale)
        {
            this.position = position;
            this.scale = scale;
            Log.InfoMessage($"A new rectangle tile was created at {this.position.x} , {this.position.y} position, with the scale of {this.scale.x},{this.scale.y}");
        }
    }
}
