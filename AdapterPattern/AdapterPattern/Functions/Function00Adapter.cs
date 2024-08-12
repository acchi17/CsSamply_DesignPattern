using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Functions
{
    public class Function00Adapter : IFunctions
    {
        private ExternalFunction.Function00 _func00 = new ExternalFunction.Function00();

        public int GetResult()
        {
            return _func00.GetValue();
        }
    }
}
