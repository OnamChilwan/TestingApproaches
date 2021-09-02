using Book.Api.Queries;
using Book.Api.Specs.Queries;

namespace Book.Api.Specs
{
    public class DataContainer
    {
        public DataContainer()
        {
            GetStockQuery = new FakeGetStockQuery();
        }
        
        public IGetStockQuery GetStockQuery { get; set; }
    }
}