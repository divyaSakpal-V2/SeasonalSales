using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales
{
    public class SalesService : ISalesService
    {
        private readonly IRepository _repository;
        public SalesService(IRepository repository)
        {
            _repository = repository;

        }
        public async Task<List<SeasonalData>> GetDataAsync(int topN)
        {
           return await _repository.GetDataAsync(topN);
        }
    }
}
