namespace DesignPatterns.Adapter
{
    internal class RoundPeg
    {
        private int _radius;
        public RoundPeg(){}

        public RoundPeg(int radius)
        {
            _radius = radius;
        }

        public virtual int GetRadius()
        {
            return _radius;
        }
    }
}
