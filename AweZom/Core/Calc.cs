using SFML.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AweZom.Core
{
    class Calc
    {
        public static float getDistance(Vector2f v1, Vector2f v2)
        {
            return ((float)Math.Sqrt(Math.Pow(Math.Abs(v1.X - v2.X), 2) + Math.Pow(Math.Abs(v1.Y - v2.Y), 2)));
        }

        public float getAngle(Vector2f pos)
        {
            ///<summary>
            ///returns Winkel zw. X-Achse und Vektor(x,y)
            ///Hinweis(Drehungswinkel in ° zum Zielvektor)
            ///</summary>
            ///<param name="pos">Position des Punktes (Vektors)</param>
            return ((float)(Math.Atan2(pos.Y, pos.X) * 180 / Math.PI));
        }

        public static Vector2f addX(Vector2f vector, float x)
        {
            return new Vector2f(vector.X + x, vector.Y);
        }

        public static Vector2f addY(Vector2f vector, float y)
        {
            return new Vector2f(vector.X, vector.Y + y);
        }

        public static float getLength(Vector2f vector)
        {
            return (float)(Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y));
        }

        
    }
}
