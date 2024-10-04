using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.MathStrategy
{
    internal class SubstractStrategy : IOperation
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
