using System;
using SFML.Graphics;

namespace AweZom
{
    public class Game : AbsGame
    {
        GameState gameState;
        EnumState currentState;
        EnumState prevState;

        private static uint windowSizeX = 1280;
        private static uint windowSizeY = 720;
        private Sprite spBckGround;


        public Game() : base(windowSizeX, windowSizeY, "AweZome")
        {
            spBckGround = new Sprite(new Texture("/bild.jpg"));
        }

        public override void update(GameTime gTime)
        {
            if (currentState != prevState) handleStates();
            currentState = gameState.update(gTime);
        }

        private void handleStates()
        {
            switch (currentState)
            {
                case EnumState.none: win.Close();
                    break;
                case EnumState.main: gameState = new MainMenue();
                    break;
                case EnumState.ingame: gameState = new InGame();
                    break;
                case EnumState.won: gameState = new GameOver();
                    break;
                case EnumState.controls: gameState = new Controls();
                    break;
                case EnumState.credits: gameState = new Credits();
                    break;
            }
            gameState.initialize();
            gameState.load();
            prevState = currentState;
        }

        public override void draw(RenderWindow win)
        {
            gameState.draw(win);
        }

    }
}