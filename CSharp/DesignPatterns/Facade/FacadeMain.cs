using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    internal class FacadeMain
    {
        public FacadeMain(){}

        public void Main()
        {
            VideoConverter facade = new VideoConverter();
            facade.Convert("test.txt", "mp4");
        }
    }
}
