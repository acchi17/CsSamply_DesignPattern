using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedStyle.Objects
{
    public sealed class Mario : CharacterBase
    {
        public Mario() : base(10, 10, Color.Red)
        {
            ;
        }

        public override void Right()
        {
            base.X += 10;
        }

        public override bool Call(out string message)
        {
            message = "";
            _count++;
            if (_count >= 3)
            {
                _count = 0;
                message = "Hi, I'm Mario.";
                return true;
            }
            return false;      
        }
    }
}
