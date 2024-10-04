namespace DesignPatterns.Decorator.Datasource
{
    /// <summary>
    /// Mockuping file storage data reading/writing
    /// </summary>
    internal class FileDataSource : IDataSource
    {
        private string _file = string.Empty;
        public string ReadData()
        {
            return _file;
        }

        public void WriteData(string data)
        {
            _file = data;
        }
    }
}
