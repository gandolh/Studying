using Microsoft.Win32;

namespace DesignPatterns.Prototype
{
    internal class PrototypeMain
    {
        public PrototypeMain() { }

        public void Main() {

            // with prototype registry
            IPrototype button = new Button(10, 40, "red");
            PrototypeRegistry registry = new PrototypeRegistry();
            registry.AddItem("LandingButton", button);
            button = registry.GetByColor("red");
            DecoratedPrint(button);

            // without registry
            Shape circle = new Circle(10, 2, 2, "RED");
            Shape rectangle = new Rectangle(5, 20, 2, 2, "GREEN");
            var newCircle = circle.Clone();
            var newRectangle = rectangle.Clone();
            DecoratedPrint(newCircle);
            DecoratedPrint(newRectangle);
        }

        public void DecoratedPrint(Object obj)
        {
            Console.WriteLine("================");
            Console.WriteLine(obj);
            Console.WriteLine("================");
        }

    }
}
