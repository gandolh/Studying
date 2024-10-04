using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template.DataMiner
{
    internal class DocDataMiner : DataMiner
    {
        protected override void OpenFile()
        {
            Console.WriteLine("Opened DOC file");
        }

        protected override string ExtractData()
        {
            Console.WriteLine("extracted data from DOC file");
            return "this is a text string";

        }

        protected override string ParseData(string rawData)
        {
            Console.WriteLine("parse data from DOC");
            return rawData;
        }

        protected override void CloseFile()
        {
            Console.WriteLine("Closed DOC file");
        }
    }
}
