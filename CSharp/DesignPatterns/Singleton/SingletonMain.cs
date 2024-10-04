using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    internal class SingletonMain
    {
        public SingletonMain(){}

        public void Main()
        {
            Singleton instance;
            instance = Singleton.GetInstance();
            instance = Singleton.GetInstance();
            instance = Singleton.GetInstance();
            Console.WriteLine(instance);
            instance = Singleton.GetInstance();
            Console.WriteLine(instance);
        }
    }
}
