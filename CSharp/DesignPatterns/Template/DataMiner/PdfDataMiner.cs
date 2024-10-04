using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template.DataMiner
{
    internal class PdfDataMiner : DataMiner
    {
        protected override void OpenFile()
        {
            Console.WriteLine("Opened PDF file");
        }

        protected override string ExtractData()
        {
            Console.WriteLine("extracted data from PDF file");
            return "this is a text string";

        }

        protected override string ParseData(string rawData)
        {
            Console.WriteLine("parse data from PDF");
            return rawData;
        }

        protected override void CloseFile()
        {
            Console.WriteLine("Closed PDF file");
        }
    }
}
