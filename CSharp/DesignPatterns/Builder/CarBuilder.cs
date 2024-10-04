namespace DesignPatterns.Builder
{
    internal class CarBuilder : IBuilder
    {
        Car? car;

        public void Reset()
        {
            car = new Car();
        }

        public void SetEngine(string engine)
        {
            car!.SetEngine(engine);
        }

        public void SetGps()
        {
            car!.AddGps();
        }

        public void SetSeats(int number)
        {
            car!.setSeats(number);
        }

        public void SetTripComputer()
        {
            car!.SetTripComputer();
        }

        public Car GetResult()
        {
            return car!;
        }

    }
}
