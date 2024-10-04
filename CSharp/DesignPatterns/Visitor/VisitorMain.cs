namespace DesignPatterns.Visitor
{
    internal class VisitorMain
    {
        public void Main()
        {
            IVisitor<string> visitor = new JsonExportVisitor();
            Dot dot1 = new Dot(2,5);
            Circle circle = new Circle(1,10,5);
            Rectangle rectangle = new Rectangle(1,10,6,7);  
            Dot dot2 = new Dot(5,10);
            CompoundShape cs = new CompoundShape();
            cs.Shapes.Add(dot1);
            cs.Shapes.Add(circle);
            cs.Shapes.Add(rectangle);
            cs.Shapes.Add(dot2);

            string json = ((JsonExportVisitor)visitor).GetJson(cs);
            Console.WriteLine(json);
        }

    }
}
