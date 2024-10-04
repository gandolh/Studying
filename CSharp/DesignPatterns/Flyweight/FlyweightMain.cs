using System.Net;

namespace DesignPatterns.Flyweight
{
    internal class FlyweightMain
    {
        public FlyweightMain()
        {
            
        }

        public void Main()
        {
            Forest forest = new Forest();
            for(int i=0;i <100_000;i++)
            {
            forest.PlantTree(10, 20, "Oak", "Green", "Leafy");
            forest.PlantTree(30, 40, "Maple", "Red", "Smooth");
            forest.PlantTree(50, 60, "Pine", "Brown", "Rough");
            }
            forest.Draw();
        }
    }
}
