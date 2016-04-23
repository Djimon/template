using SFML.Graphics;

namespace AweZom
{
    public enum EnumState
    {
        none = -1,
        main,
        play,
        ingame,
        nextLVL,
        won,
        lost,
        controls,
        credits,
        count
    }

    interface GameState
    {
        void initialize();
        void load();
        EnumState update(GameTime time);
        void draw(RenderWindow win);
    }
}