using System;
using System.Threading.Tasks;

namespace Book.Api.Queries
{
    public interface IGetStockQuery
    {
        Task<int> Execute(string isbn);
    }
    
    public class GetStockQuery : IGetStockQuery
    {
        public Task<int> Execute(string isbn)
        {
            throw new NotImplementedException();
        }
    }
}