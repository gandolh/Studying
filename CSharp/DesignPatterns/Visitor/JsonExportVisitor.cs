namespace DesignPatterns.Visitor
{
    internal class JsonExportVisitor : IVisitor<string>
    {
        private int _circleCount = 0;
        private int _dotCount = 0;
        private int _rectangleCount = 0;
        private int _compoundShapeCount = 0;

        public string VisitCircle(Circle c)
        {
            _circleCount++;
            string json = @$"
                ""circle_{_circleCount}"": {{ 
                    ""x"": {c.X}, ""y"": {c.Y}, ""radius"": {c.Radius}
                }}
                ";
            return json;
        }

        public string VisitCompoundGraphic(CompoundShape cg)
        {
            _compoundShapeCount++;
            string childrenJson = "[";
            IShape lastShape = cg.Shapes.Last();
            foreach (var shape in cg.Shapes)
            {
                childrenJson += "{" + shape.Accept(this) + "}";
                if (shape != lastShape) childrenJson += ",";
            }
            childrenJson += "]";

            string json = @$"
                ""compoundShape_{_compoundShapeCount}"": {{ 
                    ""x"": {cg.X},
                    ""y"": {cg.Y}, 
                    ""shapes"": {childrenJson}
                }}
                ";

            return json;
        }

        public string VisitDot(Dot d)
        {
            _dotCount++;
            string json = @$"
                ""dot_{_dotCount}"": {{ 
                    ""x"": {d.X}, ""y"": {d.Y}
                }}
                ";
            return json;
        }

        public string VisitRectangle(Rectangle r)
        {

            _rectangleCount++;
            string json = @$"
                ""rectangle_{_rectangleCount}"": {{ 
                    ""x"": {r.X}, ""y"": {r.Y}, ""width"": {r.Width}, ""height"": {r.Height}
                }}
                ";
            return json;
        }

        public string GetJson(IShape shape)
        {
           string json=  shape.Accept(this);
            return "{" + json + "}";
        }

    }
}
