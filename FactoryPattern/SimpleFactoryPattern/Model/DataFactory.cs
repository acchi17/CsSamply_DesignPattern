using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleFactoryPattern.Model
{
    public static class DataFactory
    {
        public static IData CreateData(int kind)
        {
            if (kind == 0)
            {
                return new DataFromSql();
            }
            else
            {
                return new DataFake();
            }
        }
    }
}
