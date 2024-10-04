namespace DesignPatterns.Builder
{
    internal interface IBuilder
    {
        public void Reset();
        public void SetSeats(int number);
        public void SetEngine(string engine); 
        public void SetTripComputer();
        public void SetGps();
    }
}
