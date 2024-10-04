namespace DesignPatterns.Adapter
{
    internal class SquarePegAdapter : RoundPeg
    {
        private SquarePeg peg;

        public SquarePegAdapter(SquarePeg peg) : base()
        {
            this.peg = peg;
        }

        public override int GetRadius()
        {
            return (int)(peg.GetWidth() * Math.Sqrt(2) / 2);
        }
    }
}
