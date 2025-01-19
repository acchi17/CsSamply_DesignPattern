using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject.Objects
{
    public sealed class Stage
    {
        public double GetAddress()
        {
            Random random = new Random();
            return (random.NextDouble() * 200000);
        }
    }
}
