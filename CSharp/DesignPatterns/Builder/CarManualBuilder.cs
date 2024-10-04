using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class CarManualBuilder : IBuilder
    {
        Manual? manual;



        public void Reset()
        {
            manual = new();
        }

        public void SetEngine(string engine)
        {
            manual!.SetEngine(engine);
        }

        public void SetGps()
        {
            manual!.AddGps();
        }

        public void SetSeats(int number)
        {
            manual!.setSeats(number);
        }

        public void SetTripComputer()
        {
            manual!.SetTripComputer();
        }

        public Manual GetResult()
        {
            return manual!;
        }
    }
}
