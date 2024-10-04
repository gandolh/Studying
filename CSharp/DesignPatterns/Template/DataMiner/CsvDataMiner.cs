namespace DesignPatterns.Template.DataMiner
{
    internal class CsvDataMiner : DataMiner
    {
        protected override void OpenFile()
        {
            Console.WriteLine("Opened CSV file");
        }

        protected override string ExtractData()
        {
            Console.WriteLine("extracted data from CSV file");
            return "this is a text string";

        }

        protected override string ParseData(string rawData)
        {
            Console.WriteLine("parse data from CSV");
            return rawData;
        }

        protected override void CloseFile()
        {
            Console.WriteLine("Closed CSV file");
        }
    }
}
