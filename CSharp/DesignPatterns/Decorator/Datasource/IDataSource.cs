﻿using Microsoft.VisualBasic;

namespace DesignPatterns.Decorator.Datasource
{
    internal interface IDataSource
    {
        public void WriteData(string data);
        public string ReadData();
    }
}
