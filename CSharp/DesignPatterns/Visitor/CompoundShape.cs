using System.Text;

namespace DesignPatterns.Visitor
{
    internal class CompoundShape : IShape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public List<IShape> Shapes { get; private set; } = new List<IShape>();

        public T Accept<T>(IVisitor<T> v)
        {
          return v.VisitCompoundGraphic(this);
        }

        public void Draw()
        {
            Console.WriteLine(this);
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"CompoundShape Details:");
            stringBuilder.AppendLine($"Position (X, Y): ({X}, {Y})");
            stringBuilder.AppendLine("Contained Shapes:");

            foreach (var shape in Shapes)
            {
                stringBuilder.AppendLine(shape.ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
