
namespace DesignPatterns.Builder
{
    internal class Car
    {
        private string _engine = string.Empty;
        private bool hasGps;
        private int _numberOfSeats;
        private bool _hasTripComputer;

        internal void AddGps()
        {
            hasGps = true;
        }

        internal void SetEngine(string engine)
        {
            _engine = engine;
        }

        internal void setSeats(int number)
        {
            _numberOfSeats = number;
        }

        internal void SetTripComputer()
        {
            _hasTripComputer = true;
        }

        public override string? ToString()
        {
            return $"Car Details:\n" +
                $"Engine: {_engine}\n" +
                $"GPS: {hasGps}\n" +
                $"Number of Seats: {_numberOfSeats}\n" +
                $"Trip Computer: {_hasTripComputer}";
        }
    }
}
