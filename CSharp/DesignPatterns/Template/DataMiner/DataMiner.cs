namespace DesignPatterns.Template.DataMiner
{
    internal abstract class DataMiner
    {
        public DataMiner()
        {
            
        }

        // template method
        public void Mine(string path)
        {
            OpenFile();
            string rawData = ExtractData();
            string data = ParseData(rawData);
            string analysis = AnalyzeData(data);
            SendReport(analysis);
            CloseFile();
        }

        protected abstract void OpenFile();
        protected abstract string ExtractData();
        protected abstract string ParseData(string rawData);

        protected string AnalyzeData(string data)
        {
            Console.WriteLine("Analized data");
            return "anlysis for: " + data;
        }

        protected void SendReport(string analysis)
        {
            Console.WriteLine("Sent report: {0}", analysis);
        }

        protected abstract void CloseFile();

    }
}
