using DesignPatterns.Bridge.ShapeColor;
using DesignPatterns.Bridge.TvRemote;

namespace DesignPatterns.Bridge
{
    internal class BridgeMain
    {
        public BridgeMain()
        {
            
        }

        public void Main()
        {
            // Bridge between Shape and Color
            Color blue = new Blue();
            Color red = new Red();

            Shape blueSquare = new Square(blue);
            Shape redCircle = new Circle(red);

            Console.WriteLine(blueSquare);
            Console.WriteLine(redCircle);


            // bridge with device and Remote
            IDevice device = new TV();
            AdvancedRemote remote = new AdvancedRemote(device);
            DecoratedPrint(remote);
            remote.TogglePower();
            remote.VolumeUp();
            remote.VolumeUp();
            remote.ChannelUp();
            DecoratedPrint(remote);
            remote.Mute();
            DecoratedPrint(remote);
        }

        public void DecoratedPrint(Object obj)
        {
            Console.WriteLine("================");
            Console.WriteLine(obj);
            Console.WriteLine("================");
        }
    }
}
