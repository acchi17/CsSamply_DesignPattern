using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AbstractFactoryPattern.Model
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

        public static INumber CreateNumber(int kind)
        {
            if (kind == 0)
            {
                return new NumberFromSql();
            }
            else
            {
                return new NumberFake();
            }
        }
    }
}
