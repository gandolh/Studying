namespace DesignPatterns.Adapter
{
    internal class RoundHole
    {
        private int _radius;

        public RoundHole(int radius)
        {
            _radius = radius;
        }

        public int GetRadius()
        {
            return _radius;
        }

        public bool Fits(RoundPeg peg)
        {
            return GetRadius() >= peg.GetRadius();
        }
    }
}
