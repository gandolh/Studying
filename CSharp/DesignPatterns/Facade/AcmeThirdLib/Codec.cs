using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.AcmeThirdLib
{
    internal class Codec
    {
        private VideoFile file;
        public Codec()
        {
            
        }

        public Codec(VideoFile file)
        {
            this.file = file;
        }
    }
}
