using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedStyle.Objects
{
    public sealed class Luigi : CharacterBase
    {
        public Luigi() : base(10, 80, Color.Lime)
        {
            ;
        }

        public override void Right()
        {
            base.X += 20;
        }

        public override bool Call(out string message)
        {
            message = "";
            _count++;
            if (_count >= 5)
            {
                _count = 0;
                message = "Hello, It's Luigi.";
                return true;
            }
            return false;
        }
    }
}
