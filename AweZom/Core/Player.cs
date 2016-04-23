using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AweZom.Core
{
    class Player
    {
        public Sprite spPlayer { get; private set; }
        int i_health {get; set;}
        int i_maxHP { get; set; }
        int i_dmg { get; set; }
        int i_def { get; set; }
        float f_movingSpeed { get; set; }

        bool isPressed { get; set; } = false;
        bool isJumping { get; set; } = false;

        Vector2f up = new Vector2f(0,-1);
        Vector2f down = new Vector2f(0, 1);
        Vector2f left = new Vector2f(-1, 0);
        Vector2f right = new Vector2f(1, 0);

        public Player(Vector2f pos, View view)
        {
            spPlayer.Position = pos;
        }

        public void move()
        {

        }

        public void update()
        {

        }

        public void draw(RenderWindow win)
        {
            win.Draw(spPlayer);
        }


    }
}
