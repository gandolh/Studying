namespace DesignPatterns.Builder
{
    internal class BuilderMain
    {
        public BuilderMain()
        {
           
        }

        public void Main()
        {
            Director director = new Director();
            CarBuilder builder = new CarBuilder();
            director.makeSportsCar(builder);
            Car car = builder.GetResult();
            Console.WriteLine(car);
        }
    }
}
