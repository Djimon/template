using System;
using SFML.Graphics;
using SFML.Window;

namespace AweZom
{
    public abstract class AbsGame
    {
        public RenderWindow win;
        public static GameTime gTime;

        public AbsGame(uint width, uint height, string title)
        {
            win = new RenderWindow(new VideoMode(width,height),title);
            win.Closed += WindowClosed;
            gTime = new GameTime();
        }

        public void run()
        {
            gTime.start();
            while (win.IsOpen)
            {
                win.Clear();
                win.DispatchEvents();
                gTime.update();
                update(gTime);
                draw(win);
                win.Display();
            }
            gTime.stop();
        }

        public abstract void draw(RenderWindow win);

        public abstract void update(GameTime gTime); 

        public void WindowClosed(Object sender, EventArgs e)
        {
            ((RenderWindow)sender).Close();
        }
    }
}