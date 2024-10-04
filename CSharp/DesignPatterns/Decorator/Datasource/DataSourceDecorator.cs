namespace DesignPatterns.Decorator.Datasource
{
    internal class DataSourceDecorator : IDataSource
    {
        //wrapee
        private IDataSource _dataSource;

        public DataSourceDecorator(IDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public virtual string ReadData()
        {
            return _dataSource.ReadData();
        }

        public virtual void WriteData(string data)
        {
            _dataSource.WriteData(data);
        }
    }
}
