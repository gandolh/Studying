namespace DesignPatterns.Decorator.Datasource
{
    internal class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource dataSource) : base(dataSource)
        {
        }


        public override string ReadData()
        {
            string data = base.ReadData();
            Console.WriteLine("before decrypting: {0}", data);
            return data.Replace("encrypted ", "");
        }

        public override void WriteData(string data)
        {
            data = "encrypted " + data;
            base.WriteData(data);
        }

    }
}
