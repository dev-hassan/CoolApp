using CoolApp.Core.Interfaces.Data;

namespace CoolApp.Infrastructure.Data
{
    public partial class DatabaseFactory : IDatabaseFactory
    {
        private IDataContext _datacontext;

        public IDataContext Get()
        {
            return _datacontext ?? (_datacontext = new DataContext());
        }

        public void Dispose()
        {
            // TODO: Check what ninject does, because if we dispose this it will crash!
        }
    }
}