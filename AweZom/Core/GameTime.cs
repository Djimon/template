using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AweZom
{
    public class GameTime
    {
        public Stopwatch watch;
        public TimeSpan total;
        public TimeSpan elapsed;
        public List<Stopwatch> watchList;

        public GameTime()
        {
            watch = new Stopwatch();
            List<Stopwatch> watchlist = new List<Stopwatch> { };
            total = TimeSpan.FromSeconds(0);
            elapsed = TimeSpan.FromSeconds(0);
        }

        internal void start()
        {
            watch.Start();
        }

        internal void update()
        {
            total = watch.Elapsed;
            elapsed = watch.Elapsed - total;
        }

        internal void stop()
        {
            watch.Stop();
            total = TimeSpan.FromSeconds(0);
            elapsed = TimeSpan.FromSeconds(0);
        }
    }
}