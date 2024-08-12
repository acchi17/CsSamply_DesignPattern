using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Functions
{
    public sealed class Function02 : IFunctions
    {
        public int GetResult()
        {
            return 100;
        }
    }
}
