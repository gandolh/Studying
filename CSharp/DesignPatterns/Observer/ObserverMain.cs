﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    internal class ObserverMain
    {

        public void Main()
        {
            Editor editor = new Editor();
            editor.OpenFile();
            editor.SaveFile();
        }
    }
}
