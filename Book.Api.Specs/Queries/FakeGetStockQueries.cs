using System.Threading.Tasks;
using Book.Api.Queries;

namespace Book.Api.Specs.Queries
{
    public class OutOfStockQuery : IGetStockQuery
    {
        public Task<int> Execute(string isbn)
        {
            return Task.FromResult(0);
        }
    }
    
    public class FakeGetStockQuery : IGetStockQuery
    {
        public Task<int> Execute(string isbn)
        {
            return Task.FromResult<int>(100);
        }
    }
}