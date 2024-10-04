namespace DesignPatterns.Decorator.Datasource
{
    internal class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }

        public override string ReadData()
        {
            string data = base.ReadData();
            Console.WriteLine("before decompression: {0}", data);
            return data.Replace("compressed ", "");
        }

        public override void WriteData(string data)
        {
            data = "compressed " + data;
            base.WriteData(data);
        }
    }
}
