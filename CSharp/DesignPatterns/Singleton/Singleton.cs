using System.Dynamic;

namespace DesignPatterns.Singleton
{
    internal class Singleton
    {
        public int property1;
        public string property2;
        private static int EntityCount = 0;
        private static Singleton? instance;

        private Singleton(int property1, string property2)
        {
            this.property1 = property1;
            this.property2 = property2;
        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton(0,"static property");
                EntityCount++;
            }
            return instance;
        }

        public override string ToString()
        {
            return $"Singleton Instance:\n" +
                   $"Property1: {property1}\n" +
                   $"Property2: {property2}\n" +
                   $"Entity Count: {EntityCount}";
        }

    }
}
