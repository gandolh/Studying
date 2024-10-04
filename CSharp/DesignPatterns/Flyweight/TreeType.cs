using Microsoft.VisualBasic;

namespace DesignPatterns.Flyweight
{
    internal class TreeType : IEquatable<TreeType?>
    {
        private string _name = string.Empty;
        private string _color = string.Empty;
        private string _texture = string.Empty;
        private static readonly string _buffer = string.Concat(Enumerable.Repeat("*", 100_000));

        public TreeType(string name, string color, string texture)
        {
            _name = name + _buffer;
            _color = color;
            _texture = texture;
        }

        public void Draw(int x, int y)
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Tree Type:\n" +
                   $"Name: {_name}\n" +
                   $"Color: {_color}\n" +
                   $"Texture: {_texture}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as TreeType);
        }

        public bool Equals(TreeType? other)
        {
            return other is not null &&
                   _name == other._name &&
                   _color == other._color &&
                   _texture == other._texture;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_name, _color, _texture);
        }

        public static bool operator ==(TreeType? left, TreeType? right)
        {
            return EqualityComparer<TreeType>.Default.Equals(left, right);
        }

        public static bool operator !=(TreeType? left, TreeType? right)
        {
            return !(left == right);
        }
    }
}
