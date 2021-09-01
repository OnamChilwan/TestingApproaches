using Book.Api.Queries;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Book.Api
{
    public class DataContainer
    {
        public DataContainer()
        {
            GetStockQuery = new FooBarQuery();
        }
        
        public IGetStockQuery GetStockQuery { get; set; }
    }
    
    public class FakeStartup : Startup
    {
        private readonly DataContainer _dataContainer;

        public FakeStartup(IConfiguration configuration, DataContainer dataContainer) 
            : base(configuration)
        {
            _dataContainer = dataContainer;
        }

        protected override void ConfigureIoC(IServiceCollection services)
        {
            services.AddSingleton<IGetStockQuery>(_dataContainer.GetStockQuery);
        }
    }
}