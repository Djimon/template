using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AweZom
{
    class Program
    {
        public static Game game;

        static void Main(string[] args)
        {
            game = new Game();
            game.run();
        }
    }

 
}
