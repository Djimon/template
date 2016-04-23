using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AweZom.GUI
{
    class GUI
    {
        Queue<Sprite> cachedSprites = new Queue<Sprite>();
        RenderWindow win;
        View view { get { return win.GetView(); } }

        public GUI(RenderWindow win, View view)
        {
            this.win = win;
        }

        public void draw<T>(T entity) where T : Transformable, Drawable
        {
            Vector2f originalScale = entity.Scale;
            Vector2f originalPos = entity.Position;

            float viewScale = (float)view.Size.X / win.Size.X;
            entity.Scale *= viewScale;
            entity.Position = view.Center - view.Size / 2F + entity.Position * viewScale;

            win.Draw(entity);

            entity.Scale = originalScale;
            entity.Position = originalPos; 
        }

        public void draw(Sprite sprite)
        {
            Sprite spCopy = new Sprite(sprite);
            float viewScale = (float)view.Size.X / win.Size.X;
            spCopy.Scale *= viewScale;
            spCopy.Position = view.Center - view.Size / 2F + spCopy.Position * viewScale;

            win.Draw(spCopy);
        }

    }
}
