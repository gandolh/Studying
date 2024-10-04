namespace DesignPatterns.Builder
{
    internal class Director
    {
        public void MakeSuv(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(4);
            builder.SetEngine("suv engine");
            builder.SetTripComputer();
            builder.SetGps();
        }

        public void makeSportsCar(IBuilder builder) {
        
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine("sport engine");
            builder.SetTripComputer();
            builder.SetGps();
        }

    }
}
