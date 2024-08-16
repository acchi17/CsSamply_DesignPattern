using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedStyle.Objects
{
    public abstract class CharacterBase
    {
        protected int _count = 0;

        public int Height { get; }
        public int Width { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; }

        public CharacterBase(int x, int y, Color color)
        {
            Height = 50;
            Width = 50;
            X = x;
            Y = y;
            Color = color;
        }

        public abstract void Right();

        public abstract bool Call(out string message);
    }
}
